using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class WindSpeed
    {
        [JsonProperty("Kts")]
        public int Kts { get; set; }

        [JsonProperty("Mph")]
        public int Mph { get; set; }

        [JsonProperty("Kph")]
        public int Kph { get; set; }
    }
}