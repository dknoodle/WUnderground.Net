using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class CurrentHurricane
    {

        [JsonProperty("stormInfo")]
        public StormInfo StormInfo { get; set; }

        [JsonProperty("Current")]
        public Current Current { get; set; }

        [JsonProperty("forecast")]
        public IList<Forecast> Forecast { get; set; }

        [JsonProperty("ExtendedForecast")]
        public IList<ExtendedForecast> ExtendedForecast { get; set; }
    }
}
