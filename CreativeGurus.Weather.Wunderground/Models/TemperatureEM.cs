using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class TemperatureEM
    {
        [JsonProperty("english")]
        public double English { get; set; }

        [JsonProperty("metric")]
        public double Metric { get; set; }
    }
}