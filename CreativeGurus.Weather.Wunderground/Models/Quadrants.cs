using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Quadrants
    {

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("quad_1")]
        public string Quad1 { get; set; }

        [JsonProperty("quad_2")]
        public string Quad2 { get; set; }

        [JsonProperty("quad_3")]
        public string Quad3 { get; set; }

        [JsonProperty("quad_4")]
        public string Quad4 { get; set; }
    }
}
