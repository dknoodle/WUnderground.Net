using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class DateSimple
    {
        [JsonProperty("pretty")]
        public string Pretty { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("mon")]
        public string Mon { get; set; }

        [JsonProperty("mday")]
        public string MDay { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("min")]
        public string Min { get; set; }

        [JsonProperty("tzname")]
        public string TZName { get; set; }
    }
}