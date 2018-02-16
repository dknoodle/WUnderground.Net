using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class ExtendedForecast
    {
        [JsonProperty("ForecastHour")]
        public string ForecastHour { get; set; }
    }
}