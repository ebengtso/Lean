using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Newtonsoft.Json.Linq;
using QuantConnect;
using QuantConnect.Util;
using RestSharp;

namespace QuantConnect.Lean.Engine.DataFeeds
{
    public class Downloader
    {
        private string _url = "https://api-fxtrade.oanda.com/v3/instruments/{0}/candles?price={1}&from={2}&to={3}&granularity={4}";
        private string _token;
        private string _dataPath;
        private string _price = "BA";
       public Downloader()
        {
        }

        public void Initialize(string token, string dataPath)
        {
            _token = token;
            _dataPath = dataPath;
        }
        public bool DownloadData(Symbol symbol, Resolution resolution, DateTime date, DateTime todate)
        {
            string r = "S5";
            string filename = "";
            switch(resolution)
            {
                case Resolution.Minute:
                    r = "M1";
                    filename = string.Format("{0}{1:D2}{2:D2}_{3}_minute_quote.csv", new object[] { date.Year, date.Month, date.Day, symbol.ID.Symbol });
                    break;
                case Resolution.Second:
                    r = "S5";
                    filename = string.Format("{0}{1:D2}{2:D2}_{3}_second_quote.csv", new object[] { date.Year, date.Month, date.Day, symbol.ID.Symbol });
                    break;
                case Resolution.Tick:
                    r = "S5";
                    filename = string.Format("{0}{1:D2}{2:D2}_{3}_tick_quote.csv", new object[] { date.Year, date.Month, date.Day, symbol.ID.Symbol });
                    break;
                case Resolution.Hour:
                    r = "H1";
                    filename = string.Format("{0}.csv", symbol.ID.Symbol);
                    break;
                case Resolution.Daily:
                    r = "D";
                    filename = string.Format("{0}.csv", symbol.ID.Symbol);
                    break;
            }
            RestClient client = new RestClient();
            var auth = "Bearer " + _token;
            client.Timeout = 120000;
            string s = string.Format("{0}_{1}",symbol.ID.Symbol.Substring(0,symbol.ID.Symbol.Length-3),symbol.ID.Symbol.Substring(symbol.ID.Symbol.Length - 3));
            string url = string.Format(_url, s, _price, ToUnixTimestamp(date), ToUnixTimestamp(todate), r);
            client.BaseUrl = new Uri(url);

            var request = new RestRequest();
            request.AddHeader("content-type", "application/json");
            request.AddHeader("Authorization", auth);
            IRestResponse response = client.Execute(request);
            string json = response.Content;

            // Save csv in same folder heirarchy as Lean
            var path = Path.Combine(_dataPath, LeanData.GenerateRelativeZipFilePath(symbol.Value, symbol.ID.SecurityType, symbol.ID.Market, date, resolution));

            // Make sure the directory exist before writing
            (new FileInfo(path)).Directory.Create();
            CreateZip(path, filename, JSonToCSV(date,json), json);
            return true;
        }

        private void CreateZip(string path, string name, string content, string originaljson)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    var quotesFile = archive.CreateEntry(name);

                    using (var entryStream = quotesFile.Open())
                    using (var streamWriter = new StreamWriter(entryStream))
                    {
                        streamWriter.Write(content);
                    }

                    var downloadedFile = archive.CreateEntry("originaldownload.json");

                    using (var entryStream = downloadedFile.Open())
                    using (var streamWriter = new StreamWriter(entryStream))
                    {
                        streamWriter.Write(originaljson);
                    }
                }

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    memoryStream.CopyTo(fileStream);
                }
            }
        }
        private string JSonToCSV(DateTime date, string json)
        {
            
            string content = "";
            string row = "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}";

            Instrument ins = Instrument.FromJson(json);
            foreach (Candle candle in ins.Candles)
            {
                content = content + string.Format(row, new object[] { (candle.Time-date).TotalMilliseconds, candle.Bid.O, candle.Bid.H, candle.Bid.L, candle.Bid.C, candle.Volume, candle.Ask.O, candle.Ask.H, candle.Ask.L, candle.Ask.C, candle.Volume }) + Environment.NewLine;
            }
            return content;
        }

        private int ToUnixTimestamp(DateTime dateTime)
        {
            return (int)(TimeZoneInfo.ConvertTimeToUtc(dateTime) -
                     new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }

        public static void Main(string[] args)
        {
            var d = new Downloader();
            d.Initialize("token here", "../");
            var symbol = QuantConnect.Symbol.Create("JP225USD", SecurityType.Cfd, Market.Oanda);
            d.DownloadData(symbol, Resolution.Minute, new DateTime(2018, 1, 17, 0, 0, 0, 0, System.DateTimeKind.Utc),new DateTime(2018, 1, 18, 0, 0, 0, 0, System.DateTimeKind.Utc));
        }
    }


}
