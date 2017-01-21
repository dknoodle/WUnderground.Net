using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using System;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Services
{
    public class Hourly
    {
        private string _baseUrl;
        private string _apiKey;

        internal Hourly(string apiKey, string baseUrl)
        {
            this._apiKey = apiKey;
            this._baseUrl = baseUrl;
        }

        /// <summary>
        /// Hourly forecast data for the next 24 hours
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/hourly/q/CA/San_Francisco.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns>Returns hourly forecast data for the next 24 hours</returns>
        public ForecastHourlyData GetForecastHourlyUS(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/hourly/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return RestRequest.Execute<ForecastHourlyData>(new Uri(uri));
        }

        /// <summary>
        /// Hourly forecast data for the next 24 hours
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/hourly/q/CA/San_Francisco.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns>Asynchronously returns hourly forecast data for the next 24 hours</returns>
        public async Task<ForecastHourlyData> GetForecastHourlyUSAsync(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/hourly/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return await RestRequest.ExecuteAsync<ForecastHourlyData>(new Uri(uri)).ConfigureAwait(false);
        }

        /// <summary>
        /// Hourly forecast data for the next 10 days
        /// </summary>
        /// <example>http://api.wunderground.com/api/Your_Key/hourly10day/q/CA/San_Francisco.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns>Returns a summary of the hourly weather for the next 10 days. This includes high and low temperatures, a string text forecast and the conditions.</returns>
        public ForecastHourlyData GetForecastHourly10DayUS(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/hourly10day/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return RestRequest.Execute<ForecastHourlyData>(new Uri(uri));
        }

        /// <summary>
        /// Hourly forecast data for the next 10 days
        /// </summary>
        /// <example>http://api.wunderground.com/api/Your_Key/hourly10day/q/CA/San_Francisco.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns>Asynchronously returns a summary of the hourly weather for the next 10 days. This includes high and low temperatures, a string text forecast and the conditions.</returns>
        public async Task<ForecastHourlyData> GetForecastHourly10DayUSAsync(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/hourly10day/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return await RestRequest.ExecuteAsync<ForecastHourlyData>(new Uri(uri)).ConfigureAwait(false);
        }
    }
}