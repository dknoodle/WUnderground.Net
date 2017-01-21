using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    [JsonObject(Title = "Station")]
    public class PersonalStation
    {
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Id { get; set; }
        public int Distance_Km { get; set; }
        public int Distance_Mi { get; set; }
    }
}