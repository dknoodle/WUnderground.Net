using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using System;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Services
{
    public class Alerts
    {
        private string _baseUrl;
        private string _apiKey;

        internal Alerts(string apiKey, string baseUrl)
        {
            this._apiKey = apiKey;
            this._baseUrl = baseUrl;
        }

        /// <summary>
        /// Returns the short name description, expiration time and a long text description of a severe alert, if one has been issued for the searched upon location.
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/alerts/q/IA/Des_Moines.json</example>
        /// <param name="city">US city name</param>
        /// <param name="state">Two character US state abbreviation</param>
        /// <returns>Weather Underground Alert data for the requested city and state</returns>
        public AlertData GetAlertsUS(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/alerts/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return RestRequest.Execute<AlertData>(new Uri(uri));
        }

        /// <summary>
        /// Asynchronously returns the short name description, expiration time and a long text description of a severe alert, if one has been issued for the searched upon location.
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/alerts/q/IA/Des_Moines.json</example>
        /// <param name="state">Two character US state abbreviation</param>
        /// <param name="city">US city name</param>
        /// <returns>Weather Underground Alert data for the requested city and state</returns>
        public async Task<AlertData> GetAlertsUSAsync(string city, string state)
        {
            Validation.ValidateState(state);

            string uri = string.Format("{0}/{1}/alerts/q/{2}/{3}.json", _baseUrl, _apiKey, state, city.Replace(" ", "_"));

            return await RestRequest.ExecuteAsync<AlertData>(new Uri(uri)).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the short name description, expiration time and a long text description of a severe alert, if one has been issued for the searched upon location in Europe.
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/alerts/q/zmw:00000.1.16172.json</example>
        /// <param name="location">Europe location identifier</param>
        /// <returns>Weather Underground Alert data for the requested European location</returns>
        public AlertData GetAlertsEurope(string location)
        {
            //Example: http://api.wunderground.com/api/{API_Key}/alerts/q/zmw:00000.1.16172.json
            string uri = string.Format("{0}/{1}/alerts/q/{2}.json", _baseUrl, _apiKey, location);

            return RestRequest.Execute<AlertData>(new Uri(uri));
        }

        /// <summary>
        /// Asynchronously returns the short name description, expiration time and a long text description of a severe alert, if one has been issued for the searched upon location in Europe.
        /// </summary>
        /// <example>http://api.wunderground.com/api/{API_Key}/alerts/q/zmw:00000.1.16172.json</example>
        /// <param name="location">Europe location identifier</param>
        /// <returns>Weather Underground Alert data for the requested European location</returns>
        public async Task<AlertData> GetAlertsEuropeAsync(string location)
        {
            //Example: http://api.wunderground.com/api/{API_Key}/alerts/q/zmw:00000.1.16172.json
            string uri = string.Format("{0}/{1}/alerts/q/{2}.json", _baseUrl, _apiKey, location);

            return await RestRequest.ExecuteAsync<AlertData>(new Uri(uri)).ConfigureAwait(false);
        }
    }
}