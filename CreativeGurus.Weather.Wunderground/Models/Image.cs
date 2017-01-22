using System;
using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground
{
	public class Image
	{
		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
