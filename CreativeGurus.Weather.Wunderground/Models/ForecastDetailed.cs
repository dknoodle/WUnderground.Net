using CreativeGurus.Weather.Wunderground.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class ForecastDetailed
    {
        [JsonProperty("ForecastHour")]
        public string ForecastHour { get; set; }

        [JsonProperty("SaffirSimpsonCategory")]
        public int SaffirSimpsonCategory { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

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

        [JsonProperty("WindQuadrants")]
        public Quadrants WindQuadrants { get; set; }

        //[JsonProperty("WindRadius")]
        //public WindRadius { get; set; }
    }
}
