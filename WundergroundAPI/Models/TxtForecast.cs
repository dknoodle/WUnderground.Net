using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class TxtForecast
    {
        public string Date { get; set; }
        public ForecastDay[] ForecastDay { get; set; }
    }
}
