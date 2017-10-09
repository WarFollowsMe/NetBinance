using NetBinance.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.MarketDataEndpoints.Responses
{
    /* 24hr ticker price change Binance API JSON Response example
    {
      "priceChange": "-94.99999800",
      "priceChangePercent": "-95.960",
      "weightedAvgPrice": "0.29628482",
      "prevClosePrice": "0.10002000",
      "lastPrice": "4.00000200",
      "bidPrice": "4.00000000",
      "askPrice": "4.00000200",
      "openPrice": "99.00000000",
      "highPrice": "100.00000000",
      "lowPrice": "0.10000000",
      "volume": "8913.30000000",
      "openTime": 1499783499040,
      "closeTime": 1499869899040,
      "fristId": 28385,   // First tradeId
      "lastId": 28460,    // Last tradeId
      "count": 76         // Trade count
    }
    */
    public class Ticker24Response
    {
        public double PriceChange { get; set; }
        public double PriceChangePercent { get; set; }
        public double WeightedAvgPrice { get; set; }
        public double PrevClosePrice { get; set; }
        public double LastPrice { get; set; }
        public double BidPrice { get; set; }
        public double AskPrice { get; set; }
        public double OpenPrice { get; set; }
        public double HighPrice { get; set; }
        public double Volume { get; set; }
        [JsonConverter(typeof(UnixTimestampJsonConverter))]
        public DateTime OpenTime { get; set; }
        [JsonConverter(typeof(UnixTimestampJsonConverter))]
        public DateTime CloseTime { get; set; }
        public int FristId { get; set; }
        public int LastId { get; set; }
        public int Count { get; set; }
    }
}
