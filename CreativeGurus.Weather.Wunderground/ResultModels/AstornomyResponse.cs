using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class AstronomyResponse
    {
        [JsonProperty("moon_phase")]
        public MoonPhase MoonPhase { get; set; }

        public Response Response { get; set; }

        [JsonProperty("sun_phase")]
        public SunPhase sun_phase { get; set; }
    }
}