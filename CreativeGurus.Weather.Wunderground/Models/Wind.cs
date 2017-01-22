using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Wind
    {
		[JsonProperty("dir")]
		public string Dir { get; set; }

		[JsonProperty("degrees")]
		public double? Degrees { get; set; }

		[JsonProperty("kph")]
        public double? Kph { get; set; }

		[JsonProperty("mph")]
        public double? Mph { get; set; }
    }
}