namespace CreativeGurus.Weather.Wunderground.Models
{
    public class RecordTemp
    {
        public Temp Normal { get; set; }
        public Temp Record { get; set; }
        public string RecordYear { get; set; }
    }
}