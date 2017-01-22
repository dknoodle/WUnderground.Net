using System;
using CreativeGurus.Weather.Wunderground.Models;
using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground
{
	public class ConditionsResponse
	{
		[JsonProperty("response")]
		public Response Response { get; set; }

		[JsonProperty("current_observation")]
		public CurrentObservation CurrentObservation { get; set; }
	}
}
