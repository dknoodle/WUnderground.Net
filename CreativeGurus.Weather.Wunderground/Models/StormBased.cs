using Newtonsoft.Json;
using System.Collections.Generic;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class StormBased
    {
        [JsonProperty("vertices")]
        public IList<Vertex> Vertices { get; set; }

        [JsonProperty("Vertex_count")]
        public int VertexCount { get; set; }

        [JsonProperty("stormInfo")]
        public StormInfo StormInfo { get; set; }
    }
}