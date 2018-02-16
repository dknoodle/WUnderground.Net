using Newtonsoft.Json;
using System.Collections.Generic;

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