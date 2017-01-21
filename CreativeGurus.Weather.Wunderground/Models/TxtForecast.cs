namespace CreativeGurus.Weather.Wunderground.Models
{
    public class TxtForecast
    {
        public string Date { get; set; }
        public ForecastDay[] ForecastDay { get; set; }
    }
}