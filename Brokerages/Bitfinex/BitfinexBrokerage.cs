<<<<<<< HEAD
﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using QuantConnect.Brokerages.Bitfinex.Rest;
using QuantConnect.Data.Market;
using QuantConnect.Interfaces;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.Securities;
using QuantConnect.Util;
using RestSharp;
using static QuantConnect.Brokerages.Bitfinex.Rest.Constants;

namespace QuantConnect.Brokerages.Bitfinex
{
    /// <summary>
    /// Bitfinex exchange REST integration.
    /// </summary>
    public partial class BitfinexBrokerage : BaseWebsocketsBrokerage, IDataQueueHandler, IGetTick
    {

        #region Declarations
        private readonly object _fillLock = new object();
        private const string Buy = "buy";
        private const string Sell = "sell";
        private const string ExchangeMarket = "exchange market";
        private const string ExchangeLimit = "exchange limit";
        private const string ExchangeStop = "exchange stop";
        private const string Market = "market";
        private const string Limit = "limit";
        private const string Stop = "stop";
        private const string Usd = "usd";
        private readonly object _lockerConnectionMonitor = new object();
        private DateTime _lastHeartbeatUtcTime = DateTime.UtcNow;
        private readonly IAlgorithm _algorithm;

        private readonly JsonSerializerSettings settings = new JsonSerializerSettings
        {
            FloatParseHandling = FloatParseHandling.Decimal
        };

        /// <summary>
        /// List of unknown orders
        /// </summary>
        protected readonly FixedSizeHashQueue<string> UnknownOrderIDs = new FixedSizeHashQueue<string>(1000);

        /// <summary>
        /// Stores fill messages
        /// </summary>
        public ConcurrentDictionary<int, BitfinexFill> FillSplit { get; set; }
 
        private enum ChannelCode
        {
            pubticker = 0,
            stats = 1,
            trades = 2
        }

        #endregion

        /// <summary>
        /// Create brokerage instance
        /// </summary>
        /// <param name="url">w</param>
        /// <param name="websocket"></param>
        /// <param name="restClient"></param>
        /// <param name="apiKey"></param>
        /// <param name="apiSecret"></param>
        /// <param name="algorithm"></param>
        public BitfinexBrokerage(string url, IWebSocket websocket, IRestClient restClient, string apiKey, string apiSecret, IAlgorithm algorithm)
            : base(url, websocket, restClient, apiKey, apiSecret, QuantConnect.Market.Bitfinex, "bitfinex")
        {
            WebSocket = websocket;

            _algorithm = algorithm;
            FillSplit = new ConcurrentDictionary<int, BitfinexFill>();

            WebSocket.Open += (s, e) => { Authenticate(); };
        }


        #region IBrokerage

        /// <summary>
        /// Add bitfinex order and prepare for fill message
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public override bool PlaceOrder(Order order)
        {

            LockStream();

            var quantity = order.Quantity;
            FillSplit.TryAdd(order.Id, new BitfinexFill(order));

            var holdingsQuantity = _algorithm.Securities.ContainsKey(order.Symbol) ? _algorithm.Securities[order.Symbol].Holdings.Quantity : 0;
            order.PriceCurrency = order.Symbol.Value.Substring(3, 3);
            Order crossOrder = null;

            if (OrderCrossesZero(order, holdingsQuantity))
            {
                crossOrder = order.Clone();
                //first liquidate holdings
                var firstOrderQuantity = -holdingsQuantity;
                //then keep going with the difference
                var secondOrderQuantity = order.Quantity - firstOrderQuantity;
                crossOrder.Quantity = secondOrderQuantity;
                order.Quantity = firstOrderQuantity;
            }

            var result = PlaceOrder(order, crossOrder);
            order.Quantity = quantity;

            UnlockStream();

            return result;
        }

        private bool PlaceOrder(Order order, Order crossOrder = null)
        {
            var totalQuantity = order.Quantity + (crossOrder != null ? crossOrder.Quantity : 0);

            var newOrder = new PlaceOrderPost
            {
                Amount = Math.Abs(order.Quantity).ToString(),
                Price = GetPrice(order).ToString(),
                Symbol = order.Symbol.Value,
                Type = MapOrderType(order.Type),
                Exchange = BrokerageMarket,
                Side = order.Quantity > 0 ? Buy : Sell
            };

            var response = ExecutePost(NewOrderRequestUrl, newOrder);

            var placing = JsonConvert.DeserializeObject<PlaceOrderResponse>(response.Content);

            if (placing != null && placing.OrderId != 0)
            {
                if (CachedOrderIDs.ContainsKey(order.Id))
                {
                    CachedOrderIDs[order.Id].BrokerId.Add(placing.OrderId.ToString());
                }
                else
                {
                    if (order.Type == OrderType.Market || order.Type == OrderType.Limit || order.Type == OrderType.StopMarket)
                    {
                    }
                    else
                    {
                        throw new Exception("BitfinexBrokerage.PlaceOrder(): Unsupported order type was encountered: " + order.Type);
                    }

                    order.BrokerId = new List<string> { placing.OrderId.ToString() };
                    CachedOrderIDs.TryAdd(order.Id, order);
                }
                if (crossOrder != null && crossOrder.Status != OrderStatus.Submitted)
                {
                    order.Status = OrderStatus.Submitted;
                    //Calling place order recursively, but switching the active order
                    return PlaceOrder(crossOrder, order);
                }

                OnOrderEvent(new OrderEvent(order, DateTime.UtcNow, 0, "Bitfinex Order Event") { Status = OrderStatus.Submitted });
                Log.Trace("BitfinexBrokerage.PlaceOrder(): Order completed successfully orderId:" + order.Id);
            }
            else
            {
                //todo: maybe only secondary of cross order failed and order will partially fill. This will leave us inconsistent
                OnOrderEvent(new OrderEvent(order, DateTime.UtcNow, 0, "Bitfinex Order Event") { Status = OrderStatus.Invalid });
                Log.Trace("BitfinexBrokerage.PlaceOrder(): Order failed Order Id: " + order.Id + " timestamp:" + order.Time + " quantity: " + order.Quantity);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Update an existing order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public override bool UpdateOrder(Order order)
        {
            bool cancelled;
            foreach (var id in order.BrokerId)
            {
                cancelled = CancelOrder(order);
                if (!cancelled)
                {
                    return false;
                }
            }
            return PlaceOrder(order);
        }

        /// <summary>
        /// Cancel an existing order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public override bool CancelOrder(Order order)
        {
            try
            {
                Log.Trace("BitfinexBrokerage.CancelOrder(): Symbol: " + order.Symbol.Value + " Quantity: " + order.Quantity);

                foreach (var id in order.BrokerId)
                {
                    var cancelPost = new OrderIdPost
                    {
                        OrderId = Convert.ToInt64(id)
                    };

                    var response = ExecutePost(OrderCancelRequestUrl, cancelPost);
                    var cancelling = JsonConvert.DeserializeObject<OrderStatusResponse>(response.Content);

                    if (cancelling.Id > 0)
                    {
                        Order cached;
                        CachedOrderIDs.TryRemove(order.Id, out cached);

                        OnOrderEvent(new OrderEvent(order, DateTime.UtcNow, 0, "Bitfinex Cancel Order Event") { Status = OrderStatus.Canceled });
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception err)
            {
                new BrokerageMessageEvent(BrokerageMessageType.Error, 0, "BitfinexBrokerage.CancelOrder(): OrderID: " + order.Id + " - " + err);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Retreive orders from exchange
        /// </summary>
        /// <returns></returns>
        public override List<Order> GetOpenOrders()
        {
            var list = new List<Order>();

            var response = ExecutePost(ActiveOrdersRequestUrl, new PostBase());

            if (response == null || response.Content == "[]" || !response.Content.StartsWith("["))
            {
                return list;
            }

            var getting = JsonConvert.DeserializeObject<OrderStatusResponse[]>(response.Content);

            foreach (var item in getting.Where(g => !g.IsCancelled))
            {
                //do not return open orders for inactive wallet
                if (_algorithm.BrokerageModel.AccountType == AccountType.Cash && !item.Type.StartsWith("exchange"))
                {
                    continue;
                }
                else if (_algorithm.BrokerageModel.AccountType == AccountType.Margin && item.Type.StartsWith("exchange"))
                {
                    continue;
                }

                Order order = null;
                if (item.Type == ExchangeMarket || item.Type == Market)
                {
                    order = new MarketOrder();
                }
                else if (item.Type == ExchangeLimit || item.Type == Limit)
                {
                    order = new LimitOrder
                    {
                        LimitPrice = decimal.Parse(item.Price)
                    };
                }
                else if (item.Type == ExchangeStop || item.Type == Stop)
                {
                    order = new StopMarketOrder
                    {
                        StopPrice = decimal.Parse(item.Price)
                    };
                }
                else
                {
                    new BrokerageMessageEvent(BrokerageMessageType.Error, 0, "BitfinexBrokerage.GetOpenOrders(): Unsupported order type returned from brokerage" + item.Type);
                    continue;
                }

                order.Quantity = decimal.Parse(item.RemainingAmount);
                order.BrokerId = new List<string> { item.Id.ToString() };
                order.Symbol = Symbol.Create(item.Symbol.ToUpper(), SecurityType.Crypto, BrokerageMarket);
                order.Time = Time.UnixTimeStampToDateTime(double.Parse(item.Timestamp));
                order.Price = decimal.Parse(item.Price);
                order.Status = MapOrderStatus(item);
                list.Add(order);
            }


            foreach (var item in list)
            {
                if (item.Status.IsOpen())
                {
                    var cached = CachedOrderIDs.Where(c => c.Value.BrokerId.Contains(item.BrokerId.First()));
                    if (cached.Count() > 0 && cached.First().Value != null)
                    {
                        CachedOrderIDs[cached.First().Key] = item;
                        item.Id = cached.First().Key;
                    }
                    //todo: if there was no cached order and order gets filled. Will tie into an order id
                }
            }
            return list;
        }

        /// <summary>
        /// Retreive holdings from exchange
        /// </summary>
        /// <returns></returns>
        public override List<Holding> GetAccountHoldings()
        {
            return new List<Holding>();
        }

        /// <summary>
        /// Get Cash Balances from exchange
        /// </summary>
        /// <returns></returns>
        public override List<Cash> GetCashBalance()
        {
            try
            {
                var list = new List<Cash>();
                var response = ExecutePost(BalanceRequestUrl, new PostBase());

                var getting = JsonConvert.DeserializeObject<IList<BalanceResponse>>(response.Content);

                foreach (var item in getting)
                {
                    if (item.Type == GetWallet() && item.Amount > 0)
                    {
                        if (item.Currency.Equals(Usd, StringComparison.InvariantCultureIgnoreCase))
                        {
                            list.Add(new Cash(item.Currency.ToUpper(), item.Amount, 1));
                        }
                        else
                        {
                            var baseSymbol = (item.Currency + Usd).ToLower();
                            var ticker = GetTick(baseSymbol);
                            list.Add(new Cash(item.Currency.ToUpper(), item.Amount, ticker.Price));
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                new BrokerageMessageEvent(BrokerageMessageType.Error, 0, "BitfinexBrokerage.GetCashBalance(): " + ex.ToString());
                return null;
            }
        }

        #endregion

        /// <summary>
        /// Logs out and closes connection
        /// </summary>
        public override void Disconnect()
        {
            UnAuthenticate();
            WebSocket.Close();
        }

        /// <summary>
        /// A hard reset can occur which requires us to re-auth and re-subscribe
        /// </summary>
        protected override void Reconnect()
        {
            var subscribed = GetSubscribed();

            try
            {
                if (WebSocket.IsOpen)
                {
                    // connection is still good
                    LastHeartbeatUtcTime = DateTime.UtcNow;
                    return;
                }
                Log.Trace($"BitfinexBrokerage(): Reconnecting... IsConnected: {IsConnected}");

                //try to clean up state
                try
                {
                    WebSocket.Error -= OnError;
                    UnAuthenticate();
                    Unsubscribe(null, subscribed);
                    if (IsConnected)
                    {
                        WebSocket.Close();
                        Wait(ConnectionTimeout, () => !WebSocket.IsOpen);
                    }
                }
                catch (Exception ex)
                {
                    Log.Trace("BitfinexBrokerage(): Exception encountered cleaning up state.", ex);
                }
                if (!IsConnected)
                {
                    WebSocket.Connect();
                    Wait(ConnectionTimeout, () => WebSocket.IsOpen);
                }
                Log.Trace("BitfinexBrokerage(): Attempting Subscribe");
            }
            catch (Exception ex)
            {
                Log.Trace("Exception encountered reconnecting.", ex);
            }
            finally
            {
                Authenticate();
                WebSocket.Error += OnError;

                Subscribe(null, subscribed);
            }
        }

        private Tick GetTick(string symbol)
        {
            return GetTick(Symbol.Create(symbol, SecurityType.Crypto, BrokerageMarket));
        }

        /// <summary>
        /// Get the latest tick for symbol
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public Tick GetTick(Symbol symbol)
        {
            var url = PubTickerRequestUrl + "/" + symbol.Value.ToLower();
            var response = ExecuteGet(url);

            var data = JsonConvert.DeserializeObject<TickerGet>(response.Content);

            return new Tick
            {
                DataType = MarketDataType.Tick,
                TickType = TickType.Quote,
                Exchange = BrokerageMarket,
                Quantity = data.Volume,
                Time = Time.UnixTimeStampToDateTime(data.Timestamp),
                Value = data.Mid,
                BidPrice = data.Bid,
                AskPrice = data.Ask
            };
        }

        private IRestResponse ExecutePost(string resource, object data)
        {
            if (data.GetType().BaseType == typeof(PostBase) || data.GetType() == typeof(PostBase))
            {
                ((PostBase)data).Nonce = Time.DateTimeToUnixTimeStamp(DateTime.UtcNow).ToString();
                ((PostBase)data).Request = resource;
            }

            var json = JsonConvert.SerializeObject(data);
            var payload = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));
            var request = new RestRequest(resource, Method.POST);
            //add auth headers
            request.AddHeader(ApiBfxKey, ApiKey);
            request.AddHeader(ApiBfxPayload, payload);
            request.AddHeader(ApiBfxSig, GetHexHashSignature(payload, ApiSecret));

            var response = RestClient.Execute(request);
            CheckForError(response);

            return response;
        }

        private IRestResponse ExecuteGet(string url)
        {
            try
            {
                var response = RestClient.Execute(new RestRequest(url));
                CheckForError(response);
                return response;
            }
            catch (Exception ex)
            {
                new BrokerageMessageEvent(BrokerageMessageType.Error, 0, "BitfinexBrokerage.ExecuteGet(): " + ex.ToString());
                return null;
            }
        }

        private string GetWallet()
        {
            return _algorithm.BrokerageModel.AccountType == AccountType.Margin ? "trading" : "exchange";
        }

    }
}
||||||| merged common ancestors
=======
﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using Newtonsoft.Json;
using QuantConnect.Data;
using QuantConnect.Data.Market;
using QuantConnect.Interfaces;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.Packets;
using QuantConnect.Securities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using QuantConnect.Orders.Fees;

namespace QuantConnect.Brokerages.Bitfinex
{
    public partial class BitfinexBrokerage : BaseWebsocketsBrokerage, IDataQueueHandler
    {
        private readonly BitfinexSymbolMapper _symbolMapper = new BitfinexSymbolMapper();

        #region IBrokerage
        /// <summary>
        /// Checks if the websocket connection is connected or in the process of connecting
        /// </summary>
        public override bool IsConnected => WebSocket.IsOpen;

        /// <summary>
        /// Places a new order and assigns a new broker ID to the order
        /// </summary>
        /// <param name="order">The order to be placed</param>
        /// <returns>True if the request for a new order has been placed, false otherwise</returns>
        public override bool PlaceOrder(Order order)
        {
            return SubmitOrder(GetEndpoint("order/new"), order);
        }

        /// <summary>
        /// Updates the order with the same id
        /// </summary>
        /// <param name="order">The new order information</param>
        /// <returns>True if the request was made for the order to be updated, false otherwise</returns>
        public override bool UpdateOrder(Order order)
        {
            if (order.BrokerId.Count == 0)
            {
                throw new ArgumentNullException("BitfinexBrokerage.UpdateOrder: There is no brokerage id to be updated for this order.");
            }
            if (order.BrokerId.Count > 1)
            {
                throw new NotSupportedException("BitfinexBrokerage.UpdateOrder: Multiple orders update not supported. Please cancel and re-create.");
            }

            return SubmitOrder(GetEndpoint("order/cancel/replace"), order);
        }

        /// <summary>
        /// Cancels the order with the specified ID
        /// </summary>
        /// <param name="order">The order to cancel</param>
        /// <returns>True if the request was submitted for cancellation, false otherwise</returns>
        public override bool CancelOrder(Order order)
        {
            Log.Trace("BitfinexBrokerage.CancelOrder(): {0}", order);

            if (!order.BrokerId.Any())
            {
                // we need the brokerage order id in order to perform a cancellation
                Log.Trace("BitfinexBrokerage.CancelOrder(): Unable to cancel order without BrokerId.");
                return false;
            }

            LockStream();
            var endpoint = GetEndpoint("order/cancel/multi");
            var payload = new JsonObject();
            payload.Add("request", endpoint);
            payload.Add("nonce", GetNonce().ToString());
            payload.Add("order_ids", order.BrokerId.Select(i => long.Parse(i)));

            var request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(payload.ToString());
            SignRequest(request, payload.ToString());

            var response = ExecuteRestRequest(request);
            var cancellationSubmitted = false;
            if (response.StatusCode == HttpStatusCode.OK && !(response.Content?.IndexOf("None to cancel", StringComparison.OrdinalIgnoreCase) >= 0))
            {
                OnOrderEvent(new OrderEvent(order,
                    DateTime.UtcNow,
                    OrderFee.Zero,
                    "Bitfinex Order Event") { Status = OrderStatus.CancelPending });

                cancellationSubmitted = true;
            }

            UnlockStream();
            return cancellationSubmitted;
        }

        /// <summary>
        /// Closes the websockets connection
        /// </summary>
        public override void Disconnect()
        {
            base.Disconnect();

            WebSocket.Close();
        }

        /// <summary>
        /// Gets all orders not yet closed
        /// </summary>
        /// <returns></returns>
        public override List<Order> GetOpenOrders()
        {
            var list = new List<Order>();
            var endpoint = GetEndpoint("orders");
            var request = new RestRequest(endpoint, Method.POST);

            JsonObject payload = new JsonObject();
            payload.Add("request", endpoint);
            payload.Add("nonce", GetNonce().ToString());

            request.AddJsonBody(payload.ToString());
            SignRequest(request, payload.ToString());

            var response = ExecuteRestRequest(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"BitfinexBrokerage.GetOpenOrders: request failed: [{(int)response.StatusCode}] {response.StatusDescription}, Content: {response.Content}, ErrorMessage: {response.ErrorMessage}");
            }

            var orders = JsonConvert.DeserializeObject<Messages.Order[]>(response.Content)
                .Where(OrderFilter(_algorithm.BrokerageModel.AccountType));
            foreach (var item in orders)
            {
                Order order;
                if (item.Type.Replace("exchange", "").Trim() == "market")
                {
                    order = new MarketOrder { Price = item.Price };
                }
                else if (item.Type.Replace("exchange", "").Trim() == "limit")
                {
                    order = new LimitOrder { LimitPrice = item.Price };
                }
                else if (item.Type.Replace("exchange", "").Trim() == "stop")
                {
                    order = new StopMarketOrder { StopPrice = item.Price };
                }
                else
                {
                    OnMessage(new BrokerageMessageEvent(BrokerageMessageType.Error, (int)response.StatusCode,
                        "BitfinexBrokerage.GetOpenOrders: Unsupported order type returned from brokerage: " + item.Type));
                    continue;
                }

                order.Quantity = item.Side == "sell" ? -item.OriginalAmount : item.OriginalAmount;
                order.BrokerId = new List<string> { item.Id };
                order.Symbol = _symbolMapper.GetLeanSymbol(item.Symbol);
                order.Time = Time.UnixTimeStampToDateTime(item.Timestamp);
                order.Status = ConvertOrderStatus(item);
                order.Price = item.Price;
                list.Add(order);
            }

            foreach (var item in list)
            {
                if (item.Status.IsOpen())
                {
                    var cached = CachedOrderIDs.Where(c => c.Value.BrokerId.Contains(item.BrokerId.First()));
                    if (cached.Any())
                    {
                        CachedOrderIDs[cached.First().Key] = item;
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Gets all open positions
        /// </summary>
        /// <returns></returns>
        public override List<Holding> GetAccountHoldings()
        {
            var endpoint = GetEndpoint("positions");
            var request = new RestRequest(endpoint, Method.POST);

            JsonObject payload = new JsonObject();
            payload.Add("request", endpoint);
            payload.Add("nonce", GetNonce().ToString());

            request.AddJsonBody(payload.ToString());
            SignRequest(request, payload.ToString());

            var response = ExecuteRestRequest(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"BitfinexBrokerage.GetAccountHoldings: request failed: [{(int)response.StatusCode}] {response.StatusDescription}, Content: {response.Content}, ErrorMessage: {response.ErrorMessage}");
            }

            var positions = JsonConvert.DeserializeObject<Messages.Position[]>(response.Content);
            return positions.Where(p => p.Amount != 0)
                .Select(ConvertHolding)
                .ToList();
        }

        /// <summary>
        /// Gets the total account cash balance for specified account type
        /// </summary>
        /// <returns></returns>
        public override List<CashAmount> GetCashBalance()
        {
            var list = new List<CashAmount>();
            var endpoint = GetEndpoint("balances"); ;
            var request = new RestRequest(endpoint, Method.POST);

            JsonObject payload = new JsonObject();
            payload.Add("request", endpoint);
            payload.Add("nonce", GetNonce().ToString());

            request.AddJsonBody(payload.ToString());
            SignRequest(request, payload.ToString());

            var response = ExecuteRestRequest(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception($"BitfinexBrokerage.GetCashBalance: request failed: [{(int)response.StatusCode}] {response.StatusDescription}, Content: {response.Content}, ErrorMessage: {response.ErrorMessage}");
            }

            var availableWallets = JsonConvert.DeserializeObject<Messages.Wallet[]>(response.Content)
                .Where(WalletFilter(_algorithm.BrokerageModel.AccountType));
            foreach (var item in availableWallets)
            {
                if (item.Amount > 0)
                {
                    list.Add(new CashAmount(item.Amount, item.Currency.ToUpper()));
                }
            }

            return list;
        }

        /// <summary>
        /// Gets the history for the requested security
        /// </summary>
        /// <param name="request">The historical data request</param>
        /// <returns>An enumerable of bars covering the span specified in the request</returns>
        public override IEnumerable<BaseData> GetHistory(Data.HistoryRequest request)
        {
            string resolution = ConvertResolution(request.Resolution);
            long resolutionInMS = (long)request.Resolution.ToTimeSpan().TotalMilliseconds;
            string symbol = _symbolMapper.GetBrokerageSymbol(request.Symbol);
            long startMTS = (long)Time.DateTimeToUnixTimeStamp(request.StartTimeUtc) * 1000;
            long endMTS = (long)Time.DateTimeToUnixTimeStamp(request.EndTimeUtc) * 1000;
            string endpoint = $"v2/candles/trade:{resolution}:t{symbol}/hist?limit=1000&sort=1";

            while ((endMTS - startMTS) > resolutionInMS)
            {
                var timeframe = $"&start={startMTS}&end={endMTS}";

                var restRequest = new RestRequest(endpoint + timeframe, Method.GET);
                var response = ExecuteRestRequest(restRequest);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"BitfinexBrokerage.GetHistory: request failed: [{(int)response.StatusCode}] {response.StatusDescription}, Content: {response.Content}, ErrorMessage: {response.ErrorMessage}");
                }

                var candles = JsonConvert.DeserializeObject<object[][]>(response.Content)
                    .Select(entries => new Messages.Candle(entries))
                    .ToList();

                startMTS = candles.Last().Timestamp + resolutionInMS;
                var period = request.Resolution.ToTimeSpan();

                foreach (var candle in candles)
                {
                    yield return new TradeBar()
                    {
                        Time = Time.UnixMillisecondTimeStampToDateTime(candle.Timestamp),
                        Symbol = request.Symbol,
                        Low = candle.Low,
                        High = candle.High,
                        Open = candle.Open,
                        Close = candle.Close,
                        Volume = candle.Volume,
                        Value = candle.Close,
                        DataType = MarketDataType.TradeBar,
                        Period = period,
                        EndTime = Time.UnixMillisecondTimeStampToDateTime(candle.Timestamp + (long)period.TotalMilliseconds)
                    };
                }
            }
        }

        #endregion

        #region IDataQueueHandler
        /// <summary>
        /// Get the next ticks from the live trading data queue
        /// </summary>
        /// <returns>IEnumerable list of ticks since the last update.</returns>
        public IEnumerable<BaseData> GetNextTicks()
        {
            lock (TickLocker)
            {
                var copy = Ticks.ToArray();
                Ticks.Clear();
                return copy;
            }
        }

        /// <summary>
        /// Adds the specified symbols to the subscription
        /// </summary>
        /// <param name="job">Job we're subscribing for:</param>
        /// <param name="symbols">The symbols to be added keyed by SecurityType</param>
        public void Subscribe(LiveNodePacket job, IEnumerable<Symbol> symbols)
        {
            Subscribe(symbols);
        }


        /// <summary>
        /// Removes the specified symbols to the subscription
        /// </summary>
        /// <param name="job">Job we're processing.</param>
        /// <param name="symbols">The symbols to be removed keyed by SecurityType</param>
        public void Unsubscribe(LiveNodePacket job, IEnumerable<Symbol> symbols)
        {
            Unsubscribe(symbols);
        }
        #endregion

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public override void Dispose()
        {
            _restRateLimiter.Dispose();
        }
    }
}
>>>>>>> d2923b3ca1497258036d88109a0aa6363d642c6f
