using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Utilities
{
    internal class DoubleConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            writer.WriteValue(string.IsNullOrWhiteSpace(value.ToString()) ? (double?)null : (double)value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return string.IsNullOrWhiteSpace(existingValue.ToString()) ? (double?)null : (double)existingValue;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(double);
        }
    }
}
