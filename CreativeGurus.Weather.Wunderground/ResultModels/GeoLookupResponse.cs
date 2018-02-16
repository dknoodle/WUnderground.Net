using CreativeGurus.Weather.Wunderground.Models;

namespace CreativeGurus.Weather.Wunderground.ResultModels
{
    public class GeoLookupResponse
    {
        public Response Response { get; set; }
        public Location Location { get; set; }
    }
}