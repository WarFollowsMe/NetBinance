using Newtonsoft.Json;

namespace NetBinance.MarketDataEndpoints
{    
    /*Aggregate trades list Binance API JSON Response example
    [
      {
        "a": 26129,         // Aggregate tradeId
        "p": "0.01633102",  // Price
        "q": "4.70443515",  // Quantity
        "f": 27781,         // First tradeId
        "l": 27781,         // Last tradeId
        "T": 1498793709153, // Timestamp
        "m": true,          // Was the buyer the maker?
        "M": true           // Was the trade the best price match?
      }
    ]
    */
    public class AggregateTrade {

        [JsonProperty("a")]
        public long TradeId { get; set; }
        [JsonProperty("p")]
        public decimal Price { get; set; }
        [JsonProperty("q")]
        public decimal Quantity { get; set; }
        [JsonProperty("f")]
        public long FirstTradeId { get; set; }
        [JsonProperty("l")]
        public long LastTradeId { get; set; }
        [JsonProperty("T")]
        public long Timestamp { get; set; }
        [JsonProperty("m")]
        public bool IsMaker { get; set; }
        [JsonProperty("M")]
        public bool IsBestPrice { get; set; }
    }
}