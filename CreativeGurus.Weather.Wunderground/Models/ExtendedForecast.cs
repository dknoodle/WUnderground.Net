using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class ExtendedForecast
    {

        [JsonProperty("ForecastHour")]
        public string ForecastHour { get; set; }
    }
}
