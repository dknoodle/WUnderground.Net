using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CGurus.Weather.WundergroundAPI.Utilities
{
    internal class RestRequest
    {
        internal static T Execute<T>(string Uri) where T : new()
        {
            RestSharp.IRestRequest request = new RestSharp.RestRequest();

            var client = new RestClient();
            client.BaseUrl = Uri;
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            if (response.Content.Length > 0)
            {
                return JsonConvert.DeserializeObject<T>(response.Content, new Utilities.BoolConverter(), new Utilities.DoubleConverter());
            }

            return response.Data;
        }
    }
}
