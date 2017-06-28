using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class HistoryResponse
    {
		[JsonProperty("response")]
		public Response Response { get; set; }

		[JsonProperty("history")]
		public History History { get; set; }
    }
}