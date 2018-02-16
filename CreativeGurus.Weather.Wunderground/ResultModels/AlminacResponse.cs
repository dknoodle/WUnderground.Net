using CreativeGurus.Weather.Wunderground.Models;

namespace CreativeGurus.Weather.Wunderground.ResultModels
{
    public class AlmanacResponse
    {
        public Almanac Almanac { get; set; }
        public Response Response { get; set; }
    }
}