using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class History
    {
        [JsonProperty("date")]
        public Date Date { get; set; }
        [JsonProperty("utcdate")]
        public Date UTCDATE { get; set; }
        [JsonProperty("observations")]
        public Observation[] Observations { get; set; }
        [JsonProperty("dailysummary")]
        public DailySummary[] DailySummaries { get; set; }
    }
}
