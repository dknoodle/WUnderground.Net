using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class ResultLocation
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_iso3166")]
        public string CountryISO { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("l")]
        public string L { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zmw")]
        public string ZMW { get; set; }
    }
}