namespace CreativeGurus.Weather.Wunderground.Models
{
    public class MoonPhase
    {
        public string AgeOfMoon { get; set; }
        public Time Current_Time { get; set; }
        public string PercentIlluminated { get; set; }
        public Time Sunrise { get; set; }
        public Time Sunset { get; set; }
    }
}