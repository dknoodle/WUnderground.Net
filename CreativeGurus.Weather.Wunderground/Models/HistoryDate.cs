using System;
using System.Collections.Generic;
using System.Text;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class HistoryDate
    {
        public HistoryDate(int Year, int Month, int Day)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }
        public int Day { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
    }
}
