using Newtonsoft.Json;

namespace NetBinance.MarketDataEndpoints
{    
    /*
    [
      {
        "symbol": "LTCBTC",
        "bidPrice": "4.00000000",
        "bidQty": "431.00000000",
        "askPrice": "4.00000200",
        "askQty": "9.00000000"
      },
      {
        "symbol": "ETHBTC",
        "bidPrice": "0.07946700",
        "bidQty": "9.00000000",
        "askPrice": "100000.00000000",
        "askQty": "1000.00000000"
      }
    ]
    */
    public class BookTicker
    {
        public string Symbol { get; set; }
        public double BidPrice { get; set; }
        [JsonProperty(PropertyName = "bidQty")]
        public double BidQuantity { get; set; }
        public double AskPrice { get; set; }
        [JsonProperty(PropertyName = "askQty")]
        public double AskQuantity { get; set; }
    }
}
