using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Time
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }
}