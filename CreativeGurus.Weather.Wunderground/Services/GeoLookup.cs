using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Services
{
    public class GeoLookup
    {
        private string _baseUrl;
        private string _apiKey;

        internal GeoLookup(string apiKey, string baseUrl)
        {
            this._apiKey = apiKey;
            this._baseUrl = baseUrl;
        }

        public GeoLookupData GeoLookupUS(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/geolookup/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return RestRequest.Execute<GeoLookupData>(new Uri(uri));
        }

        public GeoLookupData GeoLookupGlobal(string country, string city)
        {
            string uri = string.Format("{0}/{1}/geolookup/q/{2}/{3}.json", _baseUrl, _apiKey, country, city.Replace(" ", "_"));

            return RestRequest.Execute<GeoLookupData>(new Uri(uri));
        }

        public GeoLookupData GeoLookupAutoIPAddress()
        {
            string uri = string.Format("{0}/{1}/geolookup/q/autoip.json", _baseUrl, _apiKey);

            return RestRequest.Execute<GeoLookupData>(new Uri(uri));
        }

        public GeoLookupData GeoLookupUSZipCode(string zipCode)
        {
            string uri = string.Format("{0}/{1}/geolookup/q/{2}.json", _baseUrl, _apiKey, zipCode);

            return RestRequest.Execute<GeoLookupData>(new Uri(uri));
        }

        public GeoLookupData GeoLookupAirportCode(string airportCode)
        {
            string uri = string.Format("{0}/{1}/geolookup/q/{2}.json", _baseUrl, _apiKey, airportCode);

            return RestRequest.Execute<GeoLookupData>(new Uri(uri));
        }

        public GeoLookupData GeoLookupLatLon(string latitude, string longitude)
        {
            string uri = string.Format("{0}/{1}/geolookup/q/{2},{3}.json", _baseUrl, _apiKey, latitude, longitude);

            return RestRequest.Execute<GeoLookupData>(new Uri(uri));
        }

        public GeoLookupData GeoLookupPersonalWeatherStation(string weatherStationId)
        {
            string uri = string.Format("{0}/{1}/geolookup/q/pws:{2}.json", _baseUrl, _apiKey, weatherStationId);

            return RestRequest.Execute<GeoLookupData>(new Uri(uri));
        }
    }
}
