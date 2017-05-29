using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class SunPhase
    {
        [JsonProperty("sunrise")]
        public Time Sunrise { get; set; }

        [JsonProperty("sunset")]
        public Time Sunset { get; set; }
    }
}