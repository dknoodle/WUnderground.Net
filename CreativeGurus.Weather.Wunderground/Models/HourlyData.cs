namespace CreativeGurus.Weather.Wunderground.Models
{
    public class HourlyData
    {
        public Hourly[] Hourly_Forecast { get; set; }
        public Response Response { get; set; }
    }
}