namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Forecast
    {
        public SimpleForecast SimpleForecast { get; set; }
        public TxtForecast Txt_Forecast { get; set; }
    }
}