namespace CreativeGurus.Weather.Wunderground.Models
{
    public class HourlyResponse
    {
        public Hourly[] Hourly_Forecast { get; set; }
        public Response Response { get; set; }
    }
}