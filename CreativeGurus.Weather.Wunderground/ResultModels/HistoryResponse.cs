using CreativeGurus.Weather.Wunderground.Models;
using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.ResultModels
{
    public class HistoryResponse
    {
        [JsonProperty("response")]
        public Response Response { get; set; }

        [JsonProperty("history")]
        public History History { get; set; }
    }
}