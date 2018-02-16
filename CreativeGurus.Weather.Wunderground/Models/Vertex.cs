using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Vertex
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }
    }
}