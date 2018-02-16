using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Movement
    {
        [JsonProperty("Degrees")]
        public string Degrees { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }
}