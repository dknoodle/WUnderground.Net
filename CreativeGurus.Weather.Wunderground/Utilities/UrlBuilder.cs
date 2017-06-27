﻿using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using System;
using System.Text;

namespace CreativeGurus.Weather.Wunderground
{
    internal static class UrlBuilder
    {
        internal static string BuildUrl(string baseUrl, string apiKey, Feature feature, QueryType queryType, QueryOptions options)
        {
            StringBuilder sb = new StringBuilder();
            if (feature != Feature.History)
                sb.AppendFormat("{0}/{1}/{2}", baseUrl, apiKey, feature.ToString().ToLower());
            else
                sb.AppendFormat("{0}/{1}/{2}", baseUrl, apiKey, feature.ToString().ToLower() + "_" + options.HistoryDate.Year.ToString() + options.HistoryDate.Month.ToString() + options.HistoryDate.Day.ToString());

            if (!string.IsNullOrWhiteSpace(options?.Language)) { sb.AppendFormat("/lang:{0}", options?.Language); }  //Language
            if (options?.UsePWS == true) { sb.AppendFormat("/pws:{0}", options?.UsePWS); } // Use Personal weather station
            if (options?.UseBestFct == true) { sb.AppendFormat("/bestfct:{0}", options?.UseBestFct); } // Use weather underground best forecast for forecast

            sb.Append("/q/");

            switch (queryType)
            {
                case QueryType.AirportCode:
                    if (string.IsNullOrWhiteSpace(options?.AirportCode)) { throw new ArgumentException("AirportCode must be supplied when using a QueryType of AirportCode"); }
                    sb.Append(options?.AirportCode);
                    break;

                case QueryType.AutoIp:
                    sb.Append("autoip");
                    break;

                case QueryType.LinkId:
                    if (string.IsNullOrWhiteSpace(options?.LinkId)) { throw new ArgumentException("LinkId must be supplied when using a QueryType of LinkId"); }
                    sb.AppendFormat("zmw:{0}", options?.LinkId);
                    break;

                case QueryType.GlobalCity:
                    if (string.IsNullOrWhiteSpace(options?.Country)) { throw new ArgumentException("Country must be supplied when using a QueryType of GlobalCity"); }
                    if (string.IsNullOrWhiteSpace(options?.City)) { throw new ArgumentException("City must be supplied when using a QueryType of GlobalCity"); }
                    sb.AppendFormat("{0}/{1}", options?.Country, options?.City.Replace(" ", "_"));
                    break;

                case QueryType.GPS:
                    if (string.IsNullOrWhiteSpace(options?.Latitude)) { throw new ArgumentException("Latitude must be supplied when using a QueryType of GPS"); }
                    if (string.IsNullOrWhiteSpace(options?.Longitude)) { throw new ArgumentException("Longitude must be supplied when using a QueryType of GPS"); }
                    sb.AppendFormat("{0},{1}", options?.Latitude, options?.Longitude);
                    break;

                case QueryType.USCity:
                    if (string.IsNullOrWhiteSpace(options?.City)) { throw new ArgumentException("City must be supplied when using a QueryType of USCity"); }
                    if (string.IsNullOrWhiteSpace(options?.State)) { throw new ArgumentException("State must be supplied when using a QueryType of USCity"); }
                    Validation.ValidateState(options?.State);
                    sb.AppendFormat("{0}/{1}", options?.State, options?.City.Replace(" ", "_"));
                    break;

                case QueryType.PWSId:
                    if (string.IsNullOrWhiteSpace(options?.PWSId)) { throw new ArgumentException("PWSId must be supplied when using a QueryType of PWSId"); }
                    sb.AppendFormat("pws:{0}", options?.PWSId);
                    break;

                case QueryType.ZipCode:
                    if (string.IsNullOrWhiteSpace(options?.ZipCode)) { throw new ArgumentException("ZipCode must be supplied when using a QueryType of ZipCode"); }
                    sb.Append(options?.ZipCode);
                    break;
            }

            sb.Append(".json");

            if (!string.IsNullOrWhiteSpace(options?.IpAddress)) { sb.AppendFormat("?geo_ip={0}", options?.IpAddress); }

            return sb.ToString();
        }
    }
}