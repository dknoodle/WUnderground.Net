using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Pressure
    {
        [JsonProperty("mb")]
        public int Mb { get; set; }

        [JsonProperty("inches")]
        public double Inches { get; set; }
    }
}