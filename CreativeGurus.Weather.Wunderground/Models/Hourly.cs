using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Hourly
    {
        [JsonProperty("FCTTIME")]
        public FctTime FctTime { get; set; }

        [JsonProperty("temp")]
        public TemperatureEM Temp { get; set; }

        [JsonProperty("dewpoint")]
        public TemperatureEM Dewpoint { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("fctcode")]
        public int? FctCode { get; set; }

        [JsonProperty("sky")]
        public double? Sky { get; set; }

        [JsonProperty("wspd")]
        public TemperatureEM WSpd { get; set; }

        [JsonProperty("wdir")]
        public Wind WDir { get; set; }

        [JsonProperty("wx")]
        public string Wx { get; set; }

        [JsonProperty("uvi")]
        public int? Uvi { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("windchill")]
        public TemperatureEM Windchill { get; set; }

        [JsonProperty("heatindex")]
        public TemperatureEM Heatindex { get; set; }

        [JsonProperty("feelslike")]
        public TemperatureEM Feelslike { get; set; }

        [JsonProperty("qpf")]
        public TemperatureEM Qpf { get; set; }

        [JsonProperty("snow")]
        public TemperatureEM Snow { get; set; }

        [JsonProperty("pop")]
        public int? Pop { get; set; }

        [JsonProperty("mslp")]
        public TemperatureEM Mslp { get; set; }
    }
}