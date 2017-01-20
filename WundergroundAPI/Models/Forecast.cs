using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Forecast
    {
        public SimpleForecast SimpleForecast { get; set; }
        public TxtForecast Txt_Forecast { get; set; }
    }
}
