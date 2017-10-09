using NetBinance.MarketDataEndpoints;
using Newtonsoft.Json;
using System;

namespace NetBinance.Converters
{
    public class KlineJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(DateTime).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var obj = new Kline()
            {
                OpenTime = long.Parse((string)reader.Value).ToDateTime(),
                Open = (double)(reader.ReadAsDecimal() ?? 0),
                High = (double)(reader.ReadAsDecimal() ?? 0),
                Low = (double)(reader.ReadAsDecimal() ?? 0),
                Close = (double)(reader.ReadAsDecimal() ?? 0),
                Volume = (double)(reader.ReadAsDecimal() ?? 0),
                CloseTime = long.Parse((string)reader.Value).ToDateTime(),
                NumberOfTrandes = reader.ReadAsInt32() ?? 0,
                BaseAssetVolume = (double)(reader.ReadAsDecimal() ?? 0),
                QuoteAssetVolume = (double)(reader.ReadAsDecimal() ?? 0)
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
