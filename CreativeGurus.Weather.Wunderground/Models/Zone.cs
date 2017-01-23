using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
