using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using CreativeGurus.Weather.Wunderground.Services;

namespace CreativeGurus.Weather.Wunderground
{
    public class WeatherClient
    {
        private string _apiKey;
        private const string _baseUrl = "http://api.wunderground.com/api";

        public WeatherClient(string apiKey)
        {
            _apiKey = apiKey;

            Alerts = new Services.Alerts(_apiKey, _baseUrl);
            Forecast = new Services.Forecast(_apiKey, _baseUrl);
            Hourly = new Services.Hourly(_apiKey, _baseUrl);
        }

        public Services.Alerts Alerts { get; set; }

        public Services.Forecast Forecast { get; set; }

        public Services.Hourly Hourly { get; set; }
    }
}
