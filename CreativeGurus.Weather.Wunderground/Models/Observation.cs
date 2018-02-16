using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Observation
    {
        [JsonProperty("date")]
        public DateSimple Date { get; set; }

        [JsonProperty("utcdate")]
        public DateSimple UTCDate { get; set; }

        [JsonProperty("tempm")]
        public string Tempm { get; set; }

        [JsonProperty("tempi")]
        public string Tempi { get; set; }

        [JsonProperty("dewptm")]
        public string Dewptm { get; set; }

        [JsonProperty("dewpti")]
        public string Dewpti { get; set; }

        [JsonProperty("hum")]
        public string Hum { get; set; }

        [JsonProperty("wspdm")]
        public string Wspdm { get; set; }

        [JsonProperty("wspdi")]
        public string Wspdi { get; set; }

        [JsonProperty("wgustm")]
        public string Wgustm { get; set; }

        [JsonProperty("wgusti")]
        public string Wgusti { get; set; }

        [JsonProperty("wdird")]
        public string Wdird { get; set; }

        [JsonProperty("wdire")]
        public string Wdire { get; set; }

        [JsonProperty("vism")]
        public string Vism { get; set; }

        [JsonProperty("visi")]
        public string Visi { get; set; }

        [JsonProperty("pressurem")]
        public string Pressurem { get; set; }

        [JsonProperty("pressurei")]
        public string Pressurei { get; set; }

        [JsonProperty("windchillm")]
        public string Windchillm { get; set; }

        [JsonProperty("windchilli")]
        public string Windchilli { get; set; }

        [JsonProperty("heatindexm")]
        public string Heatindexm { get; set; }

        [JsonProperty("heatindexi")]
        public string Heatindexi { get; set; }

        [JsonProperty("precipm")]
        public string Precipm { get; set; }

        [JsonProperty("precipi")]
        public string Precipi { get; set; }

        [JsonProperty("conds")]
        public string Conds { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("fog")]
        public string Fog { get; set; }

        [JsonProperty("rain")]
        public string Rain { get; set; }

        [JsonProperty("snow")]
        public string Snow { get; set; }

        [JsonProperty("hail")]
        public string Hail { get; set; }

        [JsonProperty("thunder")]
        public string Thunder { get; set; }

        [JsonProperty("tornado")]
        public string Tornado { get; set; }

        [JsonProperty("metar")]
        public string Metar { get; set; }
    }
}