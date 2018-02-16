using System;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class ForecastDay
    {
        public string FctText { get; set; }
        public string FctText_Metric { get; set; }
        public string Icon { get; set; }
        public string Icon_Url { get; set; }
        public Int16? Period { get; set; }
        public Int16? Pop { get; set; }
        public string Title { get; set; }
    }
}