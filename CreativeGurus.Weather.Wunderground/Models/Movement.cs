using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
