namespace CreativeGurus.Weather.Wunderground.Models
{
    public class ForecastHourlyData
    {
        public ForecastHourly[] Hourly_Forecast { get; set; }
        public Response Response { get; set; }
    }
}