using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
