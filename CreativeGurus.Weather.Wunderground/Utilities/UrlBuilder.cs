using System;
using System.Text;
using CreativeGurus.Weather.Wunderground.Models;

namespace CreativeGurus.Weather.Wunderground.Utilities
{
    internal static class UrlBuilder
    {
        internal static string BuildUrl(string baseUrl, string apiKey, Feature feature, QueryType queryType, QueryOptions options)
        {
            StringBuilder sb = new StringBuilder();

            if (feature == Feature.History)
            {
                if (options.Date == null) { throw new ArgumentException("Date must be supplied when querying for History"); }

                string year = options.Date.Value.Year.ToString();
                string month = options.Date.Value.Month.ToString();
                string day = options.Date.Value.Day.ToString();

                if (month.Length == 1) { month = $"0{month}"; }
                if (day.Length == 1) { day = $"0{day}"; }

                sb.AppendFormat("{0}/{1}/{2}", baseUrl, apiKey, $"{feature.ToString().ToLower()}_{year}{month}{day}");
            }
            else
            {
                sb.AppendFormat("{0}/{1}/{2}", baseUrl, apiKey, feature.ToString().ToLower());
            }

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