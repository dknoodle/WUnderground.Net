using System;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class ForecastHourly
    {
        public string Condition { get; set; }
        public TemperatureEM Dewpoint { get; set; }
        public Int16? FctCode { get; set; }
        public FctTime FctTime { get; set; }
        public TemperatureEM FeelsLike { get; set; }
        public TemperatureEM HeatIndex { get; set; }
        public double? Humidity { get; set; }
        public string Icon { get; set; }
        public string Icon_Url { get; set; }
        public TemperatureEM Mslp { get; set; }
        public Int16? Pop { get; set; }
        public TemperatureEM Qpf { get; set; }
        public double? Sky { get; set; }
        public TemperatureEM Snow { get; set; }
        public TemperatureEM Temp { get; set; }
        public Int16? Uvi { get; set; }
        public Wind WDir { get; set; }
        public TemperatureEM WindChill { get; set; }
        public TemperatureEM WSpd { get; set; }
        public string Wx { get; set; }
    }
}