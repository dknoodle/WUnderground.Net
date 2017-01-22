namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Almanac
    {
        public string Airport_Code { get; set; }
        public RecordTemp Temp_High { get; set; }
        public RecordTemp Temp_Low { get; set; }
    }
}