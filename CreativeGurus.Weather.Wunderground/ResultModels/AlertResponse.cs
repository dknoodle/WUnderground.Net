using CreativeGurus.Weather.Wunderground.Models;

namespace CreativeGurus.Weather.Wunderground.ResultModels
{
    public class AlertResponse
    {
        public Alert[] Alerts { get; set; }
        public Response Response { get; set; }
    }
}