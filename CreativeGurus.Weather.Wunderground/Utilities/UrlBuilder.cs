using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using System;
using System.Text;

namespace CreativeGurus.Weather.Wunderground
{
	internal static class UrlBuilder
	{
		internal static string BuildUrl(string baseUrl, string apiKey, Feature feature, QueryType queryType, QueryOptions options)
		{
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("{0}/{1}/{2}", baseUrl, apiKey, feature.ToString().ToLower());

                if (!string.IsNullOrWhiteSpace(options?.Language)) { sb.AppendFormat("/lang:{0}", options?.Language); }  //Language
                if (options?.UsePWS == true) { sb.AppendFormat("/pws:{0}", options?.UsePWS); } // Use Personal weather station
                if (options?.UseBestFct == true) { sb.AppendFormat("/bestfct:{0}", options?.UseBestFct); } // Use weather underground best forecast for forecast

                sb.Append("/q/");

                switch (queryType)
                {
                    case QueryType.AirportCode:
                        sb.Append(options?.AirportCode);
                        break;

                    case QueryType.AutoIp:
                        sb.Append("autoip");
                        break;

                    case QueryType.LinkId:
                        sb.AppendFormat("zmw:{0}", options?.LinkId);
                        break;

                    case QueryType.GlobalCity:
                        sb.AppendFormat("{0}/{1}", options?.Country, options?.City.Replace(" ", "_"));
                        break;

                    case QueryType.GPS:
                        sb.AppendFormat("{0},{1}", options?.Latitude, options?.Longitude);
                        break;

                    case QueryType.USCity:
                        Validation.ValidateState(options?.State);
                        sb.AppendFormat("{0}/{1}", options?.State, options?.City.Replace(" ", "_"));
                        break;

                    case QueryType.PWSId:
                        sb.AppendFormat("pws:{0}", options?.PWSId);
                        break;

                    case QueryType.ZipCode:
                        sb.Append(options?.ZipCode);
                        break;
                }

                sb.Append(".json");

                if (!string.IsNullOrWhiteSpace(options?.IpAddress)) { sb.AppendFormat("?geo_ip={0}", options?.IpAddress); }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
		}
	}
}