using CreativeGurus.Weather.Wunderground.Models;
using CreativeGurus.Weather.Wunderground.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground
{
    public class Service<T> where T : new()
    {
        private string _baseUrl;
        private string _apiKey;

        internal Service(string apiKey, string baseUrl)
        {
            this._apiKey = apiKey;
            this._baseUrl = baseUrl;
        }

		internal T GetData(Feature feature, QueryType queryType, QueryOptions options)
		{
			string url = UrlBuilder.BuildUrl(_baseUrl, _apiKey, feature, queryType, options);
			return RestRequest.Execute<T>(new Uri(url));
        }

		internal async Task<T> GetDataAsync(Feature feature, QueryType queryType, QueryOptions options)
		{
			string url = UrlBuilder.BuildUrl(_baseUrl, _apiKey, feature, queryType, options);
			return await RestRequest.ExecuteAsync<T>(new Uri(url)).ConfigureAwait(false);
        }
    }
}
