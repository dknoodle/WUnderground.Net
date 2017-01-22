using System;
using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground
{
	public class ObservationLocation
	{
		[JsonProperty("full")]
		public string Full { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("country_iso3166")]
		public string CountryIso3166 { get; set; }

		[JsonProperty("latitude")]
		public string Latitude { get; set; }

		[JsonProperty("longitude")]
		public string Longitude { get; set; }

		[JsonProperty("elevation")]
		public string Elevation { get; set; }
	}
}
