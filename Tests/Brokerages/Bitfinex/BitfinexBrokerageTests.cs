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
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using Moq;
using NUnit.Framework;
using QuantConnect.Brokerages;
using QuantConnect.Brokerages.Bitfinex;
using QuantConnect.Brokerages.Bitfinex.Rest;
using QuantConnect.Interfaces;
using RestSharp;

namespace QuantConnect.Tests.Brokerages.Bitfinex
{
    [TestFixture]
    public class BitfinexBrokerageTests
    {
        private BitfinexBrokerage _unit;
        private Mock<IRestClient> _rest;
        private readonly Mock<IWebSocket> _wss = new Mock<IWebSocket>();
        private Symbol _symbol;
        private readonly Mock<IAlgorithm> _algo = new Mock<IAlgorithm>();
        private readonly AccountType _accountType = AccountType.Margin;

        [SetUp]
        public void Setup()
        {
            _rest = new Mock<IRestClient>();
            _algo.Setup(a => a.BrokerageModel.AccountType).Returns(_accountType);

            _unit = new BitfinexBrokerage("http://localhost", _wss.Object, _rest.Object, "abc", "123", _algo.Object);
            _symbol = Symbol.Create("BTCUSD", SecurityType.Crypto, Market.Bitfinex);

            //todo: test data
            var setupData = new Dictionary<string, string>
            {
                { Constants.NewOrderRequestUrl, "bitfinex_order.json" },
                { Constants.OrderCancelRequestUrl, "bitfinex_cancel.json" },
                { Constants.PubTickerRequestUrl + "/btcusd", "bitfinex_ticker.json" },
                { Constants.PubTickerRequestUrl + "/ethbtc", "bitfinex_ticker_ethbtc.json" },
                { Constants.PubTickerRequestUrl + "/ethusd", "bitfinex_ticker_ethusd.json" },
                { Constants.ActiveOrdersRequestUrl, "bitfinex_open.json" },
                { Constants.ActivePositionsRequestUrl, "bitfinex_position.json" },
                { Constants.BalanceRequestUrl, "bitfinex_wallet.json" }
            };

            _rest.Setup(m => m.Execute(It.IsAny<IRestRequest>())).Returns<RestRequest>(r => new RestResponse
            {
                Content = File.ReadAllText("TestData//" + setupData[r.Resource]),
                StatusCode = HttpStatusCode.OK
            });
        }

        [Test]
        public void UpdateOrderTest()
        {
            var brokerId = 123;
            var response = new OrderStatusResponse
            {
                Id = brokerId,
                Symbol = "BTCUSD"
            };

            var placed = new PlaceOrderResponse
            {
                OrderId = 1,
                Symbol = "BTCUSD"
            };

            var isCancel = true;
            var cancel = new ManualResetEvent(false);
            var open = new ManualResetEvent(false);

            _unit.OrderStatusChanged += (s, e) =>
            {
                if (isCancel)
                {
                    Assert.AreEqual(0, e.OrderFee);
                    Assert.AreEqual(Orders.OrderStatus.Canceled, e.Status);
                    isCancel = false;
                    cancel.Set();
                    return;
                }
                Assert.AreEqual("BTCUSD", e.Symbol.Value);
                Assert.AreEqual(0, e.OrderFee);
                Assert.AreEqual(Orders.OrderStatus.Submitted, e.Status);
                open.Set();
            };

            var actual = _unit.UpdateOrder(new Orders.MarketOrder { BrokerId = new List<string> { brokerId.ToString() }, Symbol = _symbol });
            Assert.IsTrue(actual);
            Assert.IsTrue(cancel.WaitOne(1000));
            Assert.IsTrue(open.WaitOne(1000));
        }

        [Test]
        public void CancelOrderTest()
        {
            string brokerId = "123";

            var raised = new ManualResetEvent(false);
            _unit.OrderStatusChanged += (s, e) =>
            {
                Assert.AreEqual("BTCUSD", e.Symbol.Value);
                Assert.AreEqual(0, e.OrderFee);
                Assert.AreEqual(Orders.OrderStatus.Canceled, e.Status);
                Assert.IsNotNull(_unit.CachedOrderIDs.Single(o => o.Value.BrokerId.Contains(brokerId)));
                raised.Set();
            };

            var actual = _unit.CancelOrder(new Orders.MarketOrder(_symbol, 100, DateTime.UtcNow) { BrokerId = new List<string> { brokerId } });

            Assert.IsTrue(actual);
        }

        [Test]
        public void GetOpenOrdersTest()
        {
            _unit.CachedOrderIDs.TryAdd(1, new Orders.MarketOrder { BrokerId = new List<string> { "448411366" }, Price = 123 });

            var actual = _unit.GetOpenOrders();

            Assert.AreEqual(0.02m, actual.First().Quantity);
            Assert.AreEqual(10000m, actual.First().Price);
            Assert.AreEqual("BTCUSD", actual.First().Symbol.Value);
            Assert.AreEqual(Orders.OrderDirection.Buy, actual.First().Direction);
            Assert.AreEqual(Orders.OrderType.Limit, actual.First().Type);
            Assert.AreEqual(Orders.OrderStatus.Submitted, actual.First().Status);

            Assert.AreEqual(Orders.OrderStatus.PartiallyFilled, actual.Last().Status);
            Assert.AreEqual(0.01m, actual.Last().Quantity);
            Assert.AreEqual(1, actual.Last().Id);

            Assert.AreEqual(2, actual.Count());
            Assert.That(_unit.CachedOrderIDs.Count(b => b.Value.BrokerId.Contains("448411366")) == 1);
            Assert.AreEqual(1, _unit.CachedOrderIDs.Count());
        }

        [Test]
        public void GetAccountHoldingsTest()
        {
            var actual = _unit.GetAccountHoldings();

            Assert.AreEqual(0, actual.Count());
        }

        [Test]
        public void GetCashBalanceTest()
        {
            var actual = _unit.GetCashBalance();

            Assert.AreEqual(1, actual.Single(e => e.Symbol == "USD").Amount);
            Assert.AreEqual(1, actual.Single(e => e.Symbol == "USD").ConversionRate);

            Assert.AreEqual(2, actual.Single(e => e.Symbol == "BTC").Amount);
            Assert.AreEqual(244.755m, actual.Single(e => e.Symbol == "BTC").ConversionRate);
        }

        [TestCase(-200, 200, 1)]
        [TestCase(-201, 200, 2)]
        [TestCase(-200, 0, 1)]
        [TestCase(200, -200, 1)]
        [TestCase(201, -200, 2)]
        [TestCase(200, 200, 1)]
        [TestCase(200, 0, 1)]
        public void PlaceOrderTest(decimal quantity, decimal holdings, int expectedCount)
        {
            const int id = 123;
            _algo.Setup(a => a.Securities).Returns(BitfinexTestsHelpers.CreateHoldings(holdings));

            var raised = new ManualResetEvent(false);

            _unit.OrderStatusChanged += (s, e) =>
            {
                Assert.AreEqual("BTCUSD", e.Symbol.Value);
                Assert.AreEqual(0, e.OrderFee);
                Assert.AreEqual(Orders.OrderStatus.Submitted, e.Status);
                Assert.AreEqual(0, e.FillQuantity);
                raised.Set();
            };
            var actual = _unit.PlaceOrder(new Orders.MarketOrder(_symbol, quantity, DateTime.UtcNow) { Id = id });

            Assert.IsTrue(actual);
            Assert.IsTrue(raised.WaitOne(100));
            Assert.AreEqual(expectedCount, _unit.CachedOrderIDs[id].BrokerId.Count());
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

using System;
using QuantConnect.Interfaces;
using QuantConnect.Securities;
using NUnit.Framework;
using QuantConnect.Brokerages.Bitfinex;
using QuantConnect.Configuration;
using Moq;
using QuantConnect.Brokerages;
using QuantConnect.Tests.Common.Securities;

namespace QuantConnect.Tests.Brokerages.Bitfinex
{
    [TestFixture, Ignore("This test requires a configured and testable Oanda practice account")]
    public partial class BitfinexBrokerageTests : BrokerageTests
    {
        /// <summary>
        /// Creates the brokerage under test and connects it
        /// </summary>
        /// <param name="orderProvider"></param>
        /// <param name="securityProvider"></param>
        /// <returns></returns>
        protected override IBrokerage CreateBrokerage(IOrderProvider orderProvider, ISecurityProvider securityProvider)
        {
            var securities = new SecurityManager(new TimeKeeper(DateTime.UtcNow, new[] { TimeZones.NewYork }));
            securities.Add(Symbol, CreateSecurity(Symbol));
            var transactions = new SecurityTransactionManager(null, securities);
            transactions.SetOrderProcessor(new FakeOrderProcessor());

            var algorithm = new Mock<IAlgorithm>();
            algorithm.Setup(a => a.Transactions).Returns(transactions);
            algorithm.Setup(a => a.BrokerageModel).Returns(new BitfinexBrokerageModel(AccountType.Margin));
            algorithm.Setup(a => a.Portfolio).Returns(new SecurityPortfolioManager(securities, transactions));

            var priceProvider = new Mock<IPriceProvider>();
            priceProvider.Setup(a => a.GetLastPrice(It.IsAny<Symbol>())).Returns(1.234m);

            return new BitfinexBrokerage(
                    Config.Get("bitfinex-url", "wss://api.bitfinex.com/ws"),
                    Config.Get("bitfinex-rest", "https://api.bitfinex.com"),
                    Config.Get("bitfinex-api-key"),
                    Config.Get("bitfinex-api-secret"),
                    algorithm.Object,
                    priceProvider.Object
                );
        }

        /// <summary>
        /// Gets the symbol to be traded, must be shortable
        /// </summary>
        protected override Symbol Symbol => Symbol.Create("ETHUSD", SecurityType.Crypto, Market.Bitfinex);

        /// <summary>
        /// Gets the security type associated with the <see cref="BrokerageTests.Symbol" />
        /// </summary>
        protected override SecurityType SecurityType => SecurityType.Crypto;

        //no stop limit support in v1
        public override TestCaseData[] OrderParameters => new[]
        {
            new TestCaseData(new MarketOrderTestParameters(Symbol)).SetName("MarketOrder"),
            new TestCaseData(new LimitOrderTestParameters(Symbol, HighPrice, LowPrice)).SetName("LimitOrder"),
            new TestCaseData(new StopMarketOrderTestParameters(Symbol, HighPrice, LowPrice)).SetName("StopMarketOrder"),
        };

        /// <summary>
        /// Gets a high price for the specified symbol so a limit sell won't fill
        /// </summary>
        protected override decimal HighPrice => 1000m;

        /// <summary>
        /// Gets a low price for the specified symbol so a limit buy won't fill
        /// </summary>
        protected override decimal LowPrice => 100m;

        /// <summary>
        /// Gets the current market price of the specified security
        /// </summary>
        protected override decimal GetAskPrice(Symbol symbol)
        {
            var tick = ((BitfinexBrokerage)this.Brokerage).GetTick(symbol);
            return tick.AskPrice;
        }

        /// <summary>
        /// Returns wether or not the brokers order methods implementation are async
        /// </summary>
        protected override bool IsAsync() => false;

        /// <summary>
        /// Gets the default order quantity
        /// </summary>
        protected override decimal GetDefaultQuantity() => 0.04m;
    }
}
>>>>>>> d2923b3ca1497258036d88109a0aa6363d642c6f
