using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground
{
    internal class Service<T> where T : new()
    {
        private string _baseUrl;
        private string _apiKey;

        internal Service(string apiKey, string baseUrl)
        {
            this._apiKey = apiKey;
            this._baseUrl = baseUrl;
        }

        internal T GetData(Service service, LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            string url = GetUrl(service: service, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress);
            return RestRequest.Execute<T>(new Uri(url));
        }

        private string GetUrl(Service service, LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}/{1}/{2}", _baseUrl, _apiKey, service.ToString().ToLower());

            if (!string.IsNullOrWhiteSpace(language)) { sb.AppendFormat("/lang:{0}", language); }  //Language
            if (usePWS != null) { sb.AppendFormat("/pws:{0}", usePWS.Value); } // Use Personal weather station
            if (useBestFct != null) { sb.AppendFormat("/bestfct:{0}", useBestFct.Value); } // Use weather underground best forecast for forecast

            sb.Append("/q/");

            switch (lookupType)
            {
                case LookupType.AirportCode:
                    sb.Append(id);
                    break;

                case LookupType.AutoIp:
                    sb.Append("autoip");
                    break;

                case LookupType.LinkId:
                    sb.AppendFormat("zmw:{0}", id);
                    break;

                case LookupType.GlobalCity:
                    sb.AppendFormat("{0}/{1}", country, city.Replace(" ", "_"));
                    break;

                case LookupType.LatLon:
                    sb.AppendFormat("{0},{1}", latitude, longitude);
                    break;

                case LookupType.USCity:
                    Validation.ValidateState(state);
                    sb.AppendFormat("{0}/{1}", state, city.Replace(" ", "_"));
                    break;

                case LookupType.PersonalWeatherStationId:
                    sb.AppendFormat("pws:{0}", id);
                    break;

                case LookupType.ZipCode:
                    sb.Append(id);
                    break;
            }

            sb.Append(".json");

            if (!string.IsNullOrWhiteSpace(ipAddress)) { sb.AppendFormat("?geo_ip={0}", ipAddress); }

            return sb.ToString();
        }
    }
}
