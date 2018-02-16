using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class History
    {
        [JsonProperty("date")]
        public DateSimple Date { get; set; }

        [JsonProperty("utcdate")]
        public DateSimple UTCDate { get; set; }

        [JsonProperty("observations")]
        public Observation[] Observations { get; set; }

        [JsonProperty("dailysummary")]
        public DailySummary[] Dailysummary { get; set; }
    }
}