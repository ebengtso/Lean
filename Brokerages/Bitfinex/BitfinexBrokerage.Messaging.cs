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
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuantConnect.Data.Market;
using QuantConnect.Interfaces;
using QuantConnect.Logging;
using QuantConnect.Orders;

namespace QuantConnect.Brokerages.Bitfinex
{
    public partial class BitfinexBrokerage : BaseWebsocketsBrokerage, IDataQueueHandler
    {
        /// <summary>
        /// Wss message handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnMessageImpl(object sender, WebSocketMessage e)
        {
            try
            {
                var raw = JsonConvert.DeserializeObject<dynamic>(e.Message, settings);

                if (raw.Type == JTokenType.Array)
                {
                    string id = raw[0];
                    string term = raw[1].Type == JTokenType.String ? raw[1] : "";

                    if (term == "hb")
                    {
                        //heartbeat
                        _lastHeartbeatUtcTime = DateTime.UtcNow;
                        return;
                    }
                    else if (ChannelList.ContainsKey(id) && ChannelList[id].Name == "ticker")
                    {
                        //ticker
                        PopulateTicker(e.Message, ChannelList[id].Symbol);
                        return;
                    }
                    else if (ChannelList.ContainsKey(id) && ChannelList[id].Name == "trades" && (term == "te" || term == "tu"))
                    {
                        if (term == "tu")
                        {
                            return;
                        }
                        //todo: optional trade ticker
                        PopulateTradeTicker(e.Message, ChannelList[id].Symbol);
                        return;
                    }
                    else if (id == "0" && term == "tu")
                    {
                        //expect a "te" and "tu" for each fill. The "tu" will include fees, so we won't act upon a "te"
                        var data = raw[2].ToObject(typeof(string[]));
                        PopulateTrade(term, data);
                        return;
                    }
                    else if (term == "ws")
                    {
                        //wallet
                        var data = raw[2].ToObject(typeof(string[][]));
                        PopulateWallet(data);
                        return;
                    }
                    else if (!ChannelList.ContainsKey(id))
                    {
                        return;
                    }
                }
                else if ((raw.channel == "ticker" || raw.channel == "trades") && raw.@event == "subscribed")
                {
                    var channel = (string)raw.channel;
                    var currentChannelId = (string)raw.chanId;
                    var pair = (string)raw.pair;

                    var removing = ChannelList.Where(c => c.Value.Name == channel && c.Value.Symbol == pair).Select(c => c.Key).ToArray();

                    foreach (var item in removing)
                    {
                        if (item != currentChannelId)
                        {
                            ChannelList.Remove(item);
                        }
                    }
                    ChannelList[currentChannelId] = new Channel { Name = channel, Symbol = raw.pair };
                    return;
                }
                else if (raw.chanId == 0)
                {
                    if (raw.status == "FAIL")
                    {
                        throw new Exception("Failed to authenticate with ws gateway");
                    }
                    Log.Trace("BitfinexBrokerage.OnMessage(): Successful wss auth");
                    return;
                }
                else if (raw.code == "20051" || raw.code == "20061")
                {
                    //hard reset - only close and allow reconnect timeout to handle
                    Log.Trace("BitfinexBrokerage.OnMessage(): Broker restart sequence is starting.");
                    WebSocket.Close();
                    return;
                }

                Log.Trace("BitfinexBrokerage.OnMessage(): " + e.Message);
            }
            catch (Exception ex)
            {
                Log.Error(ex, string.Format("Parsing wss message failed. Data: {0}", e.Message));
                throw;
            }
        }

        private void PopulateTicker(string response, string symbol)
        {
            var data = JsonConvert.DeserializeObject<string[]>(response, settings);
            var msg = new Messages.Ticker(data);
            lock (Ticks)
            {
                Ticks.Add(new Tick
                {
                    AskPrice = msg.Ask,
                    BidPrice = msg.Bid,
                    AskSize = msg.AskSize,
                    BidSize = msg.BidSize,
                    Time = DateTime.UtcNow,
                    Value = (msg.Ask + msg.Bid) / 2m,
                    TickType = TickType.Quote,
                    Symbol = Symbol.Create(symbol.ToUpper(), SecurityType.Crypto, BrokerageMarket),
                    DataType = MarketDataType.Tick
                });
            }
        }

        private void PopulateTradeTicker(string response, string symbol)
        {
            var data = JsonConvert.DeserializeObject<string[]>(response, settings);

            var msg = new Messages.Trade(data);
            lock (Ticks)
            {
                Ticks.Add(new Tick
                {
                    Time = DateTime.UtcNow,
                    Value = msg.Price,
                    TickType = TickType.Trade,
                    Symbol = Symbol.Create(symbol.ToUpper(), SecurityType.Crypto, BrokerageMarket),
                    DataType = MarketDataType.Tick,
                    Quantity = msg.Amount
                });
            }
        }

        private void PopulateWallet(string[][] data)
        {
            foreach (var item in data)
            {
                var msg = new Messages.Wallet(item);
                if (msg.Name == GetWallet())
                {
                    OnAccountChanged(new Securities.AccountEvent(msg.Currency.ToUpper(), msg.Balance));
                }
            }
        }

        private void PopulateTrade(string term, string[] data)
        {
            var msg = new Messages.Fill(term, data);

            var cached = CachedOrderIDs.Where(o => o.Value.BrokerId.Contains(msg.OrdId.ToString()));

            if (cached.Any())
            {
                if (msg.FeeCurrency != "USD")
                {
                    msg.Fee = msg.Fee * msg.PriceExecuted;
                    msg.FeeCurrency = "USD";
                }
                var split = FillSplit[cached.First().Key];
                var added = split.Add(msg);
                if (!added)
                {
                    //ignore fill message duplicate
                    Log.Trace("BitfinexBrokerage.PopulateTrade:" + "Fill message duplicate:" + string.Join(",", data));
                    return;
                }

                var fill = new OrderEvent
                (
                    cached.First().Key, cached.First().Value.Symbol, msg.Timestamp, OrderStatus.PartiallyFilled,
                    cached.First().Value.Direction, msg.PriceExecuted, msg.AmountExecuted,
                    0, "Bitfinex Fill Event"
                );
                fill.FillPriceCurrency = cached.First().Value.Symbol.Value;
                fill.OrderFee = Math.Abs(msg.Fee);

                if (split.IsCompleted())
                {
                    fill.Status = OrderStatus.Filled;
                    fill.FillQuantity = msg.AmountExecuted;

                    var outOrder = cached.First().Value;
                    CachedOrderIDs.TryRemove(cached.First().Key, out outOrder);
                }

                OnOrderEvent(fill);
            }
            else
            {
                UnknownOrderIDs.Add(msg.OrdId.ToString());
            }
        }

        /// <summary>
        /// Authenticate with wss
        /// </summary>
        public void Authenticate()
        {
            var key = ApiKey;
            var authNonce = DateTime.UtcNow.Ticks;
            var payload = "AUTH" + authNonce;
            WebSocket.Send(JsonConvert.SerializeObject(new
            {
                @event = "auth",
                apiKey = key,
                authSig = GetHexHashSignature(payload, ApiSecret),
                authNonce = authNonce,
                authPayload = payload
            }));
        }

        private void UnAuthenticate()
        {
            WebSocket.Send(JsonConvert.SerializeObject(new
            {
                @event = "unauth"
            }));
        }

        /// <summary>
        /// Get queued tick data
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Data.BaseData> GetNextTicks()
        {
            lock (Ticks)
            {
                var copy = Ticks.ToArray();
                Ticks.Clear();
                return copy;
            }
        }

        /// <summary>
        /// Add subscription to Websockets service
        /// </summary>
        /// <param name="job"></param>
        /// <param name="symbols"></param>
        public void Subscribe(Packets.LiveNodePacket job, IEnumerable<Symbol> symbols)
        {
            if (!IsConnected)
            {
                Connect();
            }

            //todo: attempt unsubscribe to cleanup existing. Otherwise, dupe sub messages to be taken as sub confirmation

            foreach (var item in symbols)
            {
                if (item.Value.Contains("UNIVERSE"))
                {
                    continue;
                }

                WebSocket.Send(JsonConvert.SerializeObject(new
                {
                    @event = "subscribe",
                    channel = "ticker",
                    pair = item.Value
                }));

                WebSocket.Send(JsonConvert.SerializeObject(new
                {
                    @event = "subscribe",
                    channel = "trades",
                    pair = item.Value
                }));

                Log.Trace("BitfinexBrokerage.Subscribe(): Sent subcribe for " + item.Value);
            }
        }

        /// <summary>
        /// Remove subscription from Websockets service
        /// </summary>
        /// <param name="job"></param>
        /// <param name="symbols"></param>
        public void Unsubscribe(Packets.LiveNodePacket job, IEnumerable<Symbol> symbols)
        {
            foreach (var item in symbols)
            {
                lock (ChannelList)
                {
                    foreach (var channel in ChannelList.Where(c => c.Value.Symbol == item.ToString()))
                    {
                        Unsubscribe(channel.Key);
                    }
                }
            }
        }

        private void Unsubscribe(string id)
        {
            try
            {
                WebSocket.Send(JsonConvert.SerializeObject(new
                {
                    @event = "unsubscribe",
                    channelId = id
                }));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error encountered whilst attempting unsubscribe.");
            }
        }

        /// <summary>
        /// Sybscribes to the given symbols
        /// </summary>
        /// <param name="symbols"></param>
        public override void Subscribe(IEnumerable<Symbol> symbols)
        {
            Subscribe(null, symbols);
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
using Newtonsoft.Json.Linq;
using QuantConnect.Data.Market;
using QuantConnect.Interfaces;
using QuantConnect.Logging;
using QuantConnect.Orders;
using QuantConnect.Orders.Fees;
using QuantConnect.Securities;
using QuantConnect.Util;
using RestSharp;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace QuantConnect.Brokerages.Bitfinex
{
    public partial class BitfinexBrokerage
    {
        private const string ApiVersion = "v1";
        private readonly IAlgorithm _algorithm;
        private readonly ISecurityProvider _securityProvider;
        private readonly ConcurrentQueue<WebSocketMessage> _messageBuffer = new ConcurrentQueue<WebSocketMessage>();
        private readonly object channelLocker = new object();
        private volatile bool _streamLocked;
        private readonly RateGate _restRateLimiter = new RateGate(8, TimeSpan.FromMinutes(1));
        private readonly ConcurrentDictionary<Symbol, OrderBook> _orderBooks = new ConcurrentDictionary<Symbol, OrderBook>();
        private readonly object closeLocker = new object();
        private readonly List<string> _pendingClose = new List<string>();
        private readonly IPriceProvider _priceProvider;

        /// <summary>
        /// Locking object for the Ticks list in the data queue handler
        /// </summary>
        protected readonly object TickLocker = new object();

        /// <summary>
        /// Constructor for brokerage
        /// </summary>
        /// <param name="wssUrl">websockets url</param>
        /// <param name="restUrl">rest api url</param>
        /// <param name="apiKey">api key</param>
        /// <param name="apiSecret">api secret</param>
        /// <param name="algorithm">the algorithm instance is required to retrieve account type</param>
        /// <param name="priceProvider">The price provider for missing FX conversion rates</param>
        public BitfinexBrokerage(string wssUrl, string restUrl, string apiKey, string apiSecret, IAlgorithm algorithm, IPriceProvider priceProvider)
            : base(wssUrl, new WebSocketWrapper(), new RestClient(restUrl), apiKey, apiSecret, Market.Bitfinex, "Bitfinex")
        {
            _algorithm = algorithm;
            _securityProvider = algorithm?.Portfolio;
            _priceProvider = priceProvider;

            WebSocket.Open += (sender, args) =>
            {
                SubscribeAuth();
            };
        }

        /// <summary>
        /// Wss message handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void OnMessage(object sender, WebSocketMessage e)
        {
            LastHeartbeatUtcTime = DateTime.UtcNow;

            // Verify if we're allowed to handle the streaming packet yet; while we're placing an order we delay the
            // stream processing a touch.
            try
            {
                if (_streamLocked)
                {
                    _messageBuffer.Enqueue(e);
                    return;
                }
            }
            catch (Exception err)
            {
                Log.Error(err);
            }

            OnMessageImpl(sender, e);
        }

        /// <summary>
        /// Subscribes to the authenticated channels (using an single streaming channel)
        /// </summary>
        public void SubscribeAuth()
        {
            if (string.IsNullOrEmpty(ApiKey) || string.IsNullOrEmpty(ApiSecret))
                return;

            var authNonce = GetNonce();
            var authPayload = "AUTH" + authNonce;
            var authSig = AuthenticationToken(authPayload);
            WebSocket.Send(JsonConvert.SerializeObject(new
            {
                @event = "auth",
                apiKey = ApiKey,
                authNonce,
                authPayload,
                authSig
            }));

            Log.Trace("BitfinexBrokerage.Subscribe: Sent subscribe.");
        }

        /// <summary>
        /// Subscribes to the requested symbols (using an individual streaming channel)
        /// </summary>
        /// <param name="symbols">The list of symbols to subscribe</param>
        public override void Subscribe(IEnumerable<Symbol> symbols)
        {
            foreach (var symbol in symbols)
            {
                if (symbol.Value.Contains("UNIVERSE") ||
                    !_symbolMapper.IsKnownBrokerageSymbol(symbol.Value) ||
                    symbol.SecurityType != _symbolMapper.GetLeanSecurityType(symbol.Value))
                {
                    continue;
                }

                WebSocket.Send(JsonConvert.SerializeObject(new
                {
                    @event = "subscribe",
                    channel = "book",
                    pair = _symbolMapper.GetBrokerageSymbol(symbol)
                }));

                WebSocket.Send(JsonConvert.SerializeObject(new
                {
                    @event = "subscribe",
                    channel = "trades",
                    pair = _symbolMapper.GetBrokerageSymbol(symbol)
                }));
            }

            Log.Trace("BitfinexBrokerage.Subscribe: Sent subscribe.");
        }

        /// <summary>
        /// Ends current subscriptions
        /// </summary>
        public void Unsubscribe(IEnumerable<Symbol> symbols)
        {
            if (WebSocket.IsOpen)
            {
                var map = ChannelList.ToDictionary(k => k.Value.Symbol, k => k.Key, StringComparer.InvariantCultureIgnoreCase);
                foreach (var symbol in symbols)
                {
                    if (map.ContainsKey(symbol.Value))
                    {
                        WebSocket.Send(JsonConvert.SerializeObject(new
                        {
                            @event = "unsubscribe",
                            channelId = map[symbol.Value]
                        }));
                    }
                }
            }
        }

        /// <summary>
        /// Implementation of the OnMessage event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMessageImpl(object sender, WebSocketMessage e)
        {
            try
            {
                var token = JToken.Parse(e.Message);

                if (token is JArray)
                {
                    int channel = token[0].ToObject<int>();
                    //heartbeat
                    if (token[1].Type == JTokenType.String && token[1].Value<string>() == "hb")
                    {
                        return;
                    }
                    //public channels
                    if (channel != 0)
                    {
                        if (token.Count() == 2)
                        {
                            OnSnapshot(
                                token[0].ToObject<string>(),
                                token[1].ToObject<string[][]>()
                            );
                        }
                        else
                        {
                            // pass channel id as separate arg
                            OnUpdate(
                                token[0].ToObject<string>(),
                                token.ToObject<string[]>().Skip(1).ToArray()
                            );
                        }
                    }
                    else if (channel == 0)
                    {
                        string term = token[1].ToObject<string>();
                        switch (term.ToLower())
                        {
                            case "oc":
                                OnOrderClose(token[2].ToObject<string[]>());
                                return;
                            case "tu":
                                EmitFillOrder(token[2].ToObject<string[]>());
                                return;
                            default:
                                return;
                        }
                    }
                }
                else if (token is JObject)
                {
                    Messages.BaseMessage raw = token.ToObject<Messages.BaseMessage>();
                    switch (raw.Event.ToLower())
                    {
                        case "subscribed":
                            OnSubscribe(token.ToObject<Messages.ChannelSubscription>());
                            return;
                        case "unsubscribed":
                            OnUnsubscribe(token.ToObject<Messages.ChannelUnsubscribing>());
                            return;
                        case "auth":
                            var auth = token.ToObject<Messages.AuthResponseMessage>();
                            var result = string.Equals(auth.Status, "OK", StringComparison.OrdinalIgnoreCase) ? "succeed" : "failed";
                            Log.Trace($"BitfinexWebsocketsBrokerage.OnMessage: Subscribing to authenticated channels {result}");
                            return;
                        case "info":
                        case "ping":
                            return;
                        case "error":
                            var error = token.ToObject<Messages.ErrorMessage>();
                            Log.Trace($"BitfinexWebsocketsBrokerage.OnMessage: {error.Level}: {error.Message}");
                            return;
                        default:
                            Log.Trace($"BitfinexWebsocketsBrokerage.OnMessage: Unexpected message format: {e.Message}");
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                OnMessage(new BrokerageMessageEvent(BrokerageMessageType.Error, -1, $"Parsing wss message failed. Data: {e.Message} Exception: {exception}"));
                throw;
            }
        }

        private void OnSubscribe(Messages.ChannelSubscription data)
        {
            try
            {
                Channel existing = null;
                lock (channelLocker)
                {
                    if (!ChannelList.TryGetValue(data.ChannelId, out existing))
                    {
                        ChannelList[data.ChannelId] = new BitfinexChannel() { ChannelId = data.ChannelId, Name = data.Channel, Symbol = data.Symbol }; ;
                    }
                    else
                    {
                        BitfinexChannel typedChannel = existing as BitfinexChannel;
                        typedChannel.Name = data.Channel;
                        typedChannel.ChannelId = data.ChannelId;
                        typedChannel.Symbol = data.Symbol;
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void OnUnsubscribe(Messages.ChannelUnsubscribing data)
        {
            try
            {
                lock (channelLocker)
                {
                    ChannelList.Remove(data.ChannelId);
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void OnSnapshot(string channelId, string[][] entries)
        {
            try
            {
                BitfinexChannel channel = ChannelList[channelId] as BitfinexChannel;

                if (channel == null)
                {
                    OnMessage(new BrokerageMessageEvent(BrokerageMessageType.Warning, -1, $"Message recieved from unknown channel Id {channelId}"));
                    return;
                }

                switch (channel.Name.ToLower())
                {
                    case "book":
                        ProcessOrderBookSnapshot(channel, entries);
                        return;
                    case "trades":
                        ProcessTradesSnapshot(channel, entries);
                        return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void ProcessOrderBookSnapshot(BitfinexChannel channel, string[][] entries)
        {
            try
            {
                var symbol = _symbolMapper.GetLeanSymbol(channel.Symbol);

                OrderBook orderBook;
                if (!_orderBooks.TryGetValue(symbol, out orderBook))
                {
                    orderBook = new OrderBook(symbol);
                    _orderBooks[symbol] = orderBook;
                }
                else
                {
                    orderBook.BestBidAskUpdated -= OnBestBidAskUpdated;
                    orderBook.Clear();
                }

                foreach (var entry in entries)
                {
                    var price = decimal.Parse(entry[0], NumberStyles.Float, CultureInfo.InvariantCulture);
                    var amount = decimal.Parse(entry[2], NumberStyles.Float, CultureInfo.InvariantCulture);

                    if (amount > 0)
                        orderBook.UpdateBidRow(price, amount);
                    else
                        orderBook.UpdateAskRow(price, Math.Abs(amount));
                }

                orderBook.BestBidAskUpdated += OnBestBidAskUpdated;

                EmitQuoteTick(symbol, orderBook.BestBidPrice, orderBook.BestBidSize, orderBook.BestAskPrice, orderBook.BestAskSize);
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void ProcessTradesSnapshot(BitfinexChannel channel, string[][] entries)
        {
            try
            {
                var symbol = _symbolMapper.GetLeanSymbol(channel.Symbol);
                foreach (var entry in entries)
                {
                    // pass time, price, amount
                    EmitTradeTick(symbol, entry.Skip(1).ToArray());
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void OnUpdate(string channelId, string[] entries)
        {
            try
            {
                BitfinexChannel channel = ChannelList[channelId] as BitfinexChannel;

                if (channel == null)
                {
                    OnMessage(new BrokerageMessageEvent(BrokerageMessageType.Warning, -1, $"Message recieved from unknown channel Id {channelId}"));
                    return;
                }

                switch (channel.Name.ToLower())
                {
                    case "book":
                        ProcessOrderBookUpdate(channel, entries);
                        return;
                    case "trades":
                        ProcessTradeUpdate(channel, entries);
                        return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void ProcessOrderBookUpdate(BitfinexChannel channel, string[] entries)
        {
            try
            {
                var symbol = _symbolMapper.GetLeanSymbol(channel.Symbol);
                var orderBook = _orderBooks[symbol];

                var price = decimal.Parse(entries[0], NumberStyles.Float, CultureInfo.InvariantCulture);
                var count = int.Parse(entries[1]);
                var amount = decimal.Parse(entries[2], NumberStyles.Float, CultureInfo.InvariantCulture);

                if (count == 0)
                {
                    orderBook.RemovePriceLevel(price);
                }
                else
                {
                    if (amount > 0)
                    {
                        orderBook.UpdateBidRow(price, amount);
                    }
                    else if (amount < 0)
                    {
                        orderBook.UpdateAskRow(price, Math.Abs(amount));
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void ProcessTradeUpdate(BitfinexChannel channel, string[] entries)
        {
            try
            {
                string eventType = entries[0];
                if (eventType == "tu")
                {
                    var symbol = _symbolMapper.GetLeanSymbol(channel.Symbol);
                    // pass time, price, amount
                    EmitTradeTick(symbol, new[] { entries[3], entries[4], entries[5] });
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void OnOrderClose(string[] entries)
        {
            string brokerId = entries[0];
            if (entries[5].IndexOf("canceled", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                var order = CachedOrderIDs
                    .FirstOrDefault(o => o.Value.BrokerId.Contains(brokerId))
                    .Value;
                if (order == null)
                {
                    order = _algorithm.Transactions.GetOrderByBrokerageId(brokerId);
                    if (order == null)
                    {
                        // not our order, nothing else to do here
                        return;
                    }
                }
                Order outOrder;
                if (CachedOrderIDs.TryRemove(order.Id, out outOrder))
                {
                    OnOrderEvent(new OrderEvent(order,
                        DateTime.UtcNow,
                        OrderFee.Zero,
                        "Bitfinex Order Event") { Status = OrderStatus.Canceled });
                }
            }
            else
            {
                lock (closeLocker)
                {
                    _pendingClose.Add(brokerId);
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="entries"></param>
        private void EmitTradeTick(Symbol symbol, string[] entries)
        {
            try
            {
                var time = Time.UnixTimeStampToDateTime(double.Parse(entries[0], NumberStyles.Float, CultureInfo.InvariantCulture));
                var price = decimal.Parse(entries[1], NumberStyles.Float, CultureInfo.InvariantCulture);
                var amout = decimal.Parse(entries[2], NumberStyles.Float, CultureInfo.InvariantCulture);

                lock (TickLocker)
                {
                    Ticks.Add(new Tick
                    {
                        Value = price,
                        Time = time,
                        Symbol = symbol,
                        TickType = TickType.Trade,
                        Quantity = Math.Abs(amout)
                    });
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void EmitFillOrder(string[] entries)
        {
            try
            {
                var brokerId = entries[4];
                var order = CachedOrderIDs
                    .FirstOrDefault(o => o.Value.BrokerId.Contains(brokerId))
                    .Value;
                if (order == null)
                {
                    order = _algorithm.Transactions.GetOrderByBrokerageId(brokerId);
                    if (order == null)
                    {
                        // not our order, nothing else to do here
                        return;
                    }
                }

                var symbol = _symbolMapper.GetLeanSymbol(entries[2]);
                var fillPrice = decimal.Parse(entries[6], NumberStyles.Float, CultureInfo.InvariantCulture);
                var fillQuantity = decimal.Parse(entries[5], NumberStyles.Float, CultureInfo.InvariantCulture);
                var direction = fillQuantity < 0 ? OrderDirection.Sell : OrderDirection.Buy;
                var updTime = Time.UnixTimeStampToDateTime(double.Parse(entries[3], NumberStyles.Float, CultureInfo.InvariantCulture));
                var orderFee = OrderFee.Zero;
                if (fillQuantity != 0)
                {
                    var security = _securityProvider.GetSecurity(order.Symbol);
                    orderFee = security.FeeModel.GetOrderFee(
                        new OrderFeeParameters(security, order));
                }

                OrderStatus status = fillQuantity == order.Quantity ? OrderStatus.Filled : OrderStatus.PartiallyFilled;

                var orderEvent = new OrderEvent
                (
                    order.Id, symbol, updTime, status,
                    direction, fillPrice, fillQuantity,
                    orderFee, $"Bitfinex Order Event {direction}"
                );

                // if the order is closed, we no longer need it in the active order list
                lock (closeLocker)
                {
                    if (_pendingClose.Contains(brokerId))
                    {
                        _pendingClose.Remove(brokerId);
                        Order outOrder;
                        CachedOrderIDs.TryRemove(order.Id, out outOrder);
                    }
                }
                OnOrderEvent(orderEvent);
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

        private void EmitQuoteTick(Symbol symbol, decimal bidPrice, decimal bidSize, decimal askPrice, decimal askSize)
        {
            lock (TickLocker)
            {
                Ticks.Add(new Tick
                {
                    AskPrice = askPrice,
                    BidPrice = bidPrice,
                    Value = (askPrice + bidPrice) / 2m,
                    Time = DateTime.UtcNow,
                    Symbol = symbol,
                    TickType = TickType.Quote,
                    AskSize = Math.Abs(askSize),
                    BidSize = Math.Abs(bidSize)
                });
            }
        }

        private void OnBestBidAskUpdated(object sender, BestBidAskUpdatedEventArgs e)
        {
            EmitQuoteTick(e.Symbol, e.BestBidPrice, e.BestBidSize, e.BestAskPrice, e.BestAskSize);
        }

        /// <summary>
        /// Lock the streaming processing while we're sending orders as sometimes they fill before the REST call returns.
        /// </summary>
        public void LockStream()
        {
            Log.Trace("BItfinexBrokerage.Messaging.LockStream(): Locking Stream");
            _streamLocked = true;
        }

        /// <summary>
        /// Unlock stream and process all backed up messages.
        /// </summary>
        public void UnlockStream()
        {
            Log.Trace("BItfinexBrokerage.Messaging.UnlockStream(): Processing Backlog...");
            while (_messageBuffer.Any())
            {
                WebSocketMessage e;
                _messageBuffer.TryDequeue(out e);
                OnMessageImpl(this, e);
            }
            Log.Trace("BItfinexBrokerage.Messaging.UnlockStream(): Stream Unlocked.");
            // Once dequeued in order; unlock stream.
            _streamLocked = false;
        }

        /// <summary>
        /// Gets a list of current subscriptions
        /// </summary>
        /// <returns></returns>
        protected override IList<Symbol> GetSubscribed()
        {
            IList<Symbol> list = new List<Symbol>();
            lock (ChannelList)
            {
                foreach (var ticker in ChannelList.Select(x => x.Value.Symbol).Distinct())
                {
                    list.Add(_symbolMapper.GetLeanSymbol(ticker));
                }
            }
            return list;
        }

        /// <summary>
        /// Represents Bitfinex channel information
        /// </summary>
        protected class BitfinexChannel : Channel
        {
            /// <summary>
            /// Represents channel identifier for specific subscription
            /// </summary>
            public string ChannelId { get; set; }
        }
    }
}
>>>>>>> d2923b3ca1497258036d88109a0aa6363d642c6f
