using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class FctTime
    {
        public string Age { get; set; }
        public AMPM AmPm { get; set; }
        public string Civil { get; set; }
        public long Epoch { get; set; }
        public DateTime EpochDate { get { return Utilities.EpochConverter.FromUnixTime(this.Epoch); } }
        public Int16? Hour { get; set; }
        public string Hour_Padded { get; set; }
        public bool IsDst { get; set; }
        public Int16? MDay { get; set; }
        public string MDay_Padded { get; set; }
        public Int16? Min { get; set; }
        public Int16? Mon { get; set; }
        public string Mon_Abbrev { get; set; }
        public string Mon_Padded { get; set; }
        public string Month_Name { get; set; }
        public string Month_Name_Abbrev { get; set; }
        public string Pretty { get; set; }
        public Int16? Sec { get; set; }
        public string Tz { get; set; }
        public DayOfWeek WeekDay_Name { get; set; }
        public string Weekday_Name_Abbrev { get; set; }
        public string Weekday_Name_Night { get; set; }
        public string Weekday_Name_Night_UnLang { get; set; }
        public string Weekday_Name_UnLang { get; set; }
        public Int16? YDay { get; set; }
        public Int16? Year { get; set; }
        public DateTime UTCDate { get; set; }
    }
}
