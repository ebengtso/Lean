# QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
# Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

from AlgorithmImports import *
from System.Collections.Generic import List

### <summary>
### In this algorithm we show how you can easily use the universe selection feature to fetch symbols
### to be traded using the BaseData custom data system in combination with the AddUniverse{T} method.
### AddUniverse{T} requires a function that will return the symbols to be traded.
### </summary>
### <meta name="tag" content="using data" />
### <meta name="tag" content="universes" />
### <meta name="tag" content="custom universes" />
class DropboxBaseDataUniverseSelectionAlgorithm(QCAlgorithm):

    def Initialize(self):

        self.UniverseSettings.Resolution = Resolution.Daily

        # Order margin value has to have a minimum of 0.5% of Portfolio value, allows filtering out small trades and reduce fees.
        # Commented so regression algorithm is more sensitive
        #self.Settings.MinimumOrderMarginPortfolioPercentage = 0.005

        self.SetStartDate(2017, 7, 6)
        self.SetEndDate(2018, 7, 4)

        universe = self.AddUniverse(StockDataSource, self.stockDataSource)

        historicalSelectionData = self.History(universe, 3)
        if len(historicalSelectionData) != 3:
            raise ValueError(f"Unexpected universe data count {len(historicalSelectionData)}")

        for universeData in historicalSelectionData["symbols"]:
            if len(universeData) != 5:
                raise ValueError(f"Unexpected universe data receieved")

    def stockDataSource(self, data):
        list = []
        for item in data:
            for symbol in item["Symbols"]:
                list.append(symbol)
        return list

    def OnData(self, slice):

        if slice.Bars.Count == 0: return
        if self._changes is None: return

        # start fresh
        self.Liquidate()

        percentage = 1 / slice.Bars.Count
        for tradeBar in slice.Bars.Values:
            self.SetHoldings(tradeBar.Symbol, percentage)

        # reset changes
        self._changes = None

    def OnSecuritiesChanged(self, changes):
        self._changes = changes

class StockDataSource(PythonData):

    def GetSource(self, config, date, isLiveMode):
        url = "https://www.dropbox.com/s/2l73mu97gcehmh7/daily-stock-picker-live.csv?dl=1" if isLiveMode else \
            "https://www.dropbox.com/s/ae1couew5ir3z9y/daily-stock-picker-backtest.csv?dl=1"

        return SubscriptionDataSource(url, SubscriptionTransportMedium.RemoteFile)

    def Reader(self, config, line, date, isLiveMode):
        if not (line.strip() and line[0].isdigit()): return None

        stocks = StockDataSource()
        stocks.Symbol = config.Symbol

        csv = line.split(',')
        if isLiveMode:
            stocks.Time = date
            stocks["Symbols"] = csv
        else:
            stocks.Time = datetime.strptime(csv[0], "%Y%m%d")
            stocks["Symbols"] = csv[1:]
        return stocks
