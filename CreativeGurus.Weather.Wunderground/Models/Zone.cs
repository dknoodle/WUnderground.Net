using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Zone
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("ZONE")]
        public string ZONE { get; set; }
    }
}