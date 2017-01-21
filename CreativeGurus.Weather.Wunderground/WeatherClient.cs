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

        private Services.Alerts _alerts;
        private Services.Forecast _forecast;
        private Services.Hourly _hourly;
        private Services.GeoLookup _geoLookup;

        public WeatherClient(string apiKey)
        {
            _apiKey = apiKey;

            _alerts = new Services.Alerts(_apiKey, _baseUrl);
            _forecast = new Services.Forecast(_apiKey, _baseUrl);
            _hourly = new Services.Hourly(_apiKey, _baseUrl);
            _geoLookup = new GeoLookup(_apiKey, _baseUrl);
        }

        public Services.Alerts Alerts { get { return _alerts; } }

        public Services.Forecast Forecast { get { return _forecast; } }

        public Services.Hourly Hourly { get { return _hourly; } }

        public Services.GeoLookup GeoLookup { get { return _geoLookup; } }
    }
}
