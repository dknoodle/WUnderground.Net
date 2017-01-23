using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Pressure
    {

        [JsonProperty("mb")]
        public int Mb { get; set; }

        [JsonProperty("inches")]
        public double Inches { get; set; }
    }
}
