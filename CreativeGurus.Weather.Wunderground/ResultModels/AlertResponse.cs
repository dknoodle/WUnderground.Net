namespace CreativeGurus.Weather.Wunderground.Models
{
    public class AlertResponse
    {
        public Models.Alert[] Alerts { get; set; }
        public Models.Response Response { get; set; }
    }
}