using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Observation
    {
        [JsonProperty("date")]
        public Date Date { get; set; }
        [JsonProperty("utcdate")]
        public Date UTCDATE { get; set; }
        [JsonProperty("tempm")]
        public float? TempCelcius { get; set; }
        [JsonProperty("tempi")]
        public float? TempFahrenheit { get; set; }
        [JsonProperty("dewptm")]
        public float? DewPointMetric { get; set; }
        [JsonProperty("dewpti")]
        public float? DewPointImparial { get; set; }
        [JsonProperty("hum")]
        public int? Humidity { get; set; }
        [JsonProperty("wspdm")]
        public float? WindSpeedMetric { get; set; }
        [JsonProperty("wspdi")]
        public float? WindSpeedImperial { get; set; }
        [JsonProperty("wgustm")]
        public float? WindGustMetric { get; set; }
        [JsonProperty("wgusti")]
        public float? WindGurstImperial { get; set; }
        [JsonProperty("wdird")]
        public int? WindDirectionDegree { get; set; }
        [JsonProperty("wdire")]
        public string WindDirection { get; set; }
        [JsonProperty("vism")]
        public float? VisibilityMetric { get; set; }
        [JsonProperty("visi")]
        public float? VisibilityImperial { get; set; }
        [JsonProperty("pressurem")]
        public float? PressureMetric { get; set; }
        [JsonProperty("pressurei")]
        public float? PressureImperial { get; set; }
        [JsonProperty("windchillm")]
        public float? WindChillMetric { get; set; }
        [JsonProperty("windchilli")]
        public float? WindChillImperial { get; set; }
        [JsonProperty("heatindexm")]
        public float? HeatIndexMetric { get; set; }
        [JsonProperty("heatindexi")]
        public float? HeatIndexImperial { get; set; }
        [JsonProperty("precipm")]
        public float? PrecipitationMetric { get; set; }
        [JsonProperty("precipi")]
        public float? PrecipitationImperial { get; set; }
        [JsonProperty("conds")]
        public string Conditions { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("fog")]
        public bool Fog { get; set; }
        [JsonProperty("rain")]
        public bool Rain { get; set; }
        [JsonProperty("snow")]
        public bool Snow { get; set; }
        [JsonProperty("hail")]
        public bool Hail { get; set; }
        [JsonProperty("thunder")]
        public bool Thunder { get; set; }
        [JsonProperty("tornado")]
        public bool Tornado { get; set; }
        [JsonProperty("metar")]
        public string Metar { get; set; }

    }
}
