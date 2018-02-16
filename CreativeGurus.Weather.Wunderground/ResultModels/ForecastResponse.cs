using CreativeGurus.Weather.Wunderground.Models;

namespace CreativeGurus.Weather.Wunderground.ResultModels
{
    public class ForecastResponse
    {
        public Forecast Forecast { get; set; }
        public Response Response { get; set; }
    }
}