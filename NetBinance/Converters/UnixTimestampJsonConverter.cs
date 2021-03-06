﻿using Newtonsoft.Json;
using System;
using System.Reflection;

namespace NetBinance.Converters
{
    public class UnixTimestampJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            long timestamp = serializer.Deserialize<long>(reader);

            return timestamp.ToDateTime();
        }

        public override bool CanConvert(Type type)
        {
            return typeof(DateTime).IsAssignableFrom(type);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanRead
        {
            get { return true; }
        }
    }
}
