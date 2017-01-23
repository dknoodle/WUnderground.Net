using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
