using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGurus.Weather.WundergroundAPI.Models
{
    public class SimpleForecast
    {
        public SimpleForecastDay[] ForecastDay { get; set; }
    }
}
