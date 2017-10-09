using NetBinance.Converters;
using Newtonsoft.Json;

namespace NetBinance.MarketDataEndpoints
{ 
    [JsonConverter(typeof(BidAskJsonConverter))]
    public class BidAsk
    {
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
