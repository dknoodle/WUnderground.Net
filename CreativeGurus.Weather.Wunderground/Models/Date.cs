using System;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Date
    {
        public AMPM AmPm { get; set; }
        public Int16? Day { get; set; }
        public DateTime EpochDate { get { return Utilities.EpochConverter.FromUnixTime(this.Epoch); } }
        public long Epoch { get; set; }
        public Int16? Hour { get; set; }
        public bool IsDst { get; set; }
        public Int16? Min { get; set; }
        public Int16? Month { get; set; }
        public string MonthName { get; set; }
        public string Pretty { get; set; }
        public Int16? Sec { get; set; }
        public string Tz_Long { get; set; }
        public string Tz_Short { get; set; }
        public string Weekday { get; set; }
        public string Weekday_Short { get; set; }
        public Int16? YDay { get; set; }
        public Int16? Year { get; set; }
    }
}