using NetBinance.MarketDataEndpoints;
using NetBinance.MarketDataEndpoints.Responses;
using Newtonsoft.Json;
using System;

namespace NetBinance.Converters
{
    public class BidAskJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var obj = new BidAsk()
            {
                Price = (double)(reader.ReadAsDecimal() ?? 0),
                Quantity = (double)(reader.ReadAsDecimal() ?? 0)
            };
            reader.Read();
            return obj;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
