using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class ForecastHourlyData
    {
        public ForecastHourly[] Hourly_Forecast { get; set; }
        public Response Response { get; set; }
    }
}
