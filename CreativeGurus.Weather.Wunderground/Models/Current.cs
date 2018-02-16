using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Current
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("SaffirSimpsonCategory")]
        public int SaffirSimpsonCategory { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Time")]
        public TimeDetailed Time { get; set; }

        [JsonProperty("TimeGMT")]
        public TimeDetailed TimeGMT { get; set; }

        [JsonProperty("WindSpeed")]
        public WindSpeed WindSpeed { get; set; }

        [JsonProperty("WindGust")]
        public WindSpeed WindGust { get; set; }

        [JsonProperty("Fspeed")]
        public WindSpeed Fspeed { get; set; }

        [JsonProperty("Movement")]
        public Movement Movement { get; set; }

        [JsonProperty("Pressure")]
        public Pressure Pressure { get; set; }

        [JsonProperty("WindQuadrants")]
        public Quadrants WindQuadrants { get; set; }

        //[JsonProperty("WindRadius")]
        //public WindRadius WindRadius { get; set; }

        //[JsonProperty("SeaQuadrants")]
        //public SeaQuadrants SeaQuadrants { get; set; }

        //[JsonProperty("SeaRadius")]
        //public SeaRadius SeaRadius { get; set; }
    }
}