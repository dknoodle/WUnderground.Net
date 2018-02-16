using CreativeGurus.Weather.Wunderground.Models;

namespace CreativeGurus.Weather.Wunderground.ResultModels
{
    public class HourlyResponse
    {
        public Hourly[] Hourly_Forecast { get; set; }
        public Response Response { get; set; }
    }
}