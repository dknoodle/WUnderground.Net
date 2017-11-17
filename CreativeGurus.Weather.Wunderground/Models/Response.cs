using System.Collections.Generic;
using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
	public class Response
	{
        public Response()
        {
            this.Results = new List<ResultResponse>();
        }

        [JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("termsofService")]
		public string TermsofService { get; set; }

		[JsonProperty("features")]
		public Dictionary<string, string> Features { get; set; }

		[JsonProperty("error")]
		public Dictionary<string, string> Error { get; set; }

        [JsonProperty("results")]
        public IEnumerable<ResultResponse> Results { get; set; }
	}
}