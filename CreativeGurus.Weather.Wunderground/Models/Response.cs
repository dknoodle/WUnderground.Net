using Newtonsoft.Json;
using System.Collections.Generic;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Response
    {
        [JsonProperty("error")]
        public Dictionary<string, string> Error { get; set; }

        [JsonProperty("features")]
        public Dictionary<string, string> Features { get; set; }

        [JsonProperty("results")]
        public ResultLocation[] Results { get; set; }

        [JsonProperty("termsofService")]
        public string TermsofService { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}