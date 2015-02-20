﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGurus.Weather.WundergroundAPI.Models;
using CGurus.Weather.WundergroundAPI.Utilities;

namespace CGurus.Weather.WundergroundAPI
{
    public class WApi
    {
        private string _apiKey { get; set; }
        private const string _baseUrl = "http://api.wunderground.com/api";

        public WApi(string ApiKey)
        {
            _apiKey = ApiKey;
        }

        public AlertData GetAlertsUS(string State, string City)
        {
            ValidateState(State);

            //Example: http://api.wunderground.com/api/{API_Key}/alerts/q/IA/Des_Moines.json
            string uri = string.Format("{0}/{1}/alerts/q/{2}/{3}.json", _baseUrl, _apiKey, State, City.Replace(" ", "_"));

            return RestRequest.Execute<AlertData>(uri);
        }

        public ForecastData GetForecastUS(string State, string City)
        {
            ValidateState(State);

            //Example: http://api.wunderground.com/api/{API_Key}/forecast/q/CA/San_Francisco.json
            string uri = string.Format("{0}/{1}/forecast/q/{2}/{3}.json", _baseUrl, _apiKey, State, City.Replace(" ", "_"));

            return RestRequest.Execute<ForecastData>(uri);
        }

        public ForecastData GetForecast10DayUS(string State, string City)
        {
            ValidateState(State);

            //Example: http://api.wunderground.com/api/{API_Key}/forecast10day/q/CA/San_Francisco.json
            string uri = string.Format("{0}/{1}/forecast10day/q/{2}/{3}.json", _baseUrl, _apiKey, State, City.Replace(" ", "_"));

            return RestRequest.Execute<ForecastData>(uri);
        }

        public ForecastHourlyData GetForecastHourlyUS(string State, string City)
        {
            ValidateState(State);

            //Example: http://api.wunderground.com/api/{API_Key}/hourly/q/CA/San_Francisco.json
            string uri = string.Format("{0}/{1}/hourly/q/{2}/{3}.json", _baseUrl, _apiKey, State, City.Replace(" ", "_"));

            return RestRequest.Execute<ForecastHourlyData>(uri);
        }

        public WeatherHistory GetHistoryUS(string State, string City, DateTime date) {
            ValidateState(State);

            //Example: http://api.wunderground.com/api/{API_Key}/history_{Date}/q/CA/San_Francisco.json
            string uri = string.Format("{0}/{1}/history_{2}/q/{3}/{4}.json", _baseUrl, _apiKey, date.ToString("yyyyMMdd"), State, City.Replace(" ", "_"));

            return RestRequest.Execute<WeatherHistory>(uri);
        }

        private void ValidateState(string State)
        {
            if (State.Length > 2) { throw new ArgumentException("State must be a two character abbreviation."); }
        }

    }
}
