using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;
using System.Globalization;

namespace CGurus.Weather.WundergroundAPI.Utilities
{

    public class JsonDeserializer : IDeserializer
    {
        private readonly Newtonsoft.Json.JsonSerializer _serializer;
        public JsonConverter[] JsonConverters;

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }

        public CultureInfo Culture { get; set; }

        public JsonDeserializer()
        {
            this.Culture = CultureInfo.InvariantCulture;
        }

        public T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content, JsonConverters);
        }

    }
}
