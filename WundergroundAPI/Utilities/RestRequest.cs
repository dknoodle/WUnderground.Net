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
            var jsonDeserializer = new JsonDeserializer();
            jsonDeserializer.JsonConverters = new JsonConverter[] { new Utilities.BoolConverter(), new Utilities.DoubleConverter() };
            client.AddHandler("application/json", jsonDeserializer);

            client.BaseUrl = Uri;
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return response.Data;
        }
    }
}
