using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using System;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Services
{
    public class Forecast
    {
        private string _baseUrl;
        private string _apiKey;

        internal Forecast(string apiKey, string baseUrl)
        {
            this._apiKey = apiKey;
            this._baseUrl = baseUrl;
        }

        /// <summary>
        /// Returns a summary of the weather for the next 3 days. This includes high and low temperatures, a string text forecast and the conditions.
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/forecast/q/CA/San_Francisco.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns></returns>
        public ForecastData GetForecastUS(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/forecast/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return RestRequest.Execute<ForecastData>(new Uri(uri));
        }

        /// <summary>
        ///  returns a summary of the weather for the next 3 days. This includes high and low temperatures, a string text forecast and the conditions.
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/forecast/q/CA/San_Francisco.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns></returns>
        public async Task<ForecastData> GetForecastUSAsync(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/forecast/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return await RestRequest.ExecuteAsync<ForecastData>(new Uri(uri)).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a summary of the weather for the next 10 days. This includes high and low temperatures, a string text forecast and the conditions.
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/forecast10day/q/CA/San_Francisco.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns></returns>
        public ForecastData GetForecast10DayUS(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/forecast10day/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return RestRequest.Execute<ForecastData>(new Uri(uri));
        }

        /// <summary>
        /// Asynchronously returns a summary of the weather for the next 10 days. This includes high and low temperatures, a string text forecast and the conditions.
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/forecast10day/q/CA/San_Francisco.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns></returns>
        public async Task<ForecastData> GetForecast10DayUSAsync(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/forecast10day/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return await RestRequest.ExecuteAsync<ForecastData>(new Uri(uri)).ConfigureAwait(false);
        }
    }
}