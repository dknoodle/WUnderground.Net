using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class SimpleForecastDay
    {
        public Int16? AveHumidity { get; set; }
        public Wind AveWind { get; set; }
        public string Conditions { get; set; }
        public Date Date { get; set; }
        public TemperatureCF High { get; set; }
        public string Icon { get; set; }
        public string Icon_Url { get; set; }
        public TemperatureCF Low { get; set; }
        public Int16? MaxHumidity { get; set; }
        public Wind MaxWind { get; set; }
        public Int16? MinHumidity { get; set; }
        public Int16? Period { get; set; }
        public Int16? Pop { get; set; }
        public Accumulation Qpf_AllDay { get; set; }
        public Accumulation Qpf_Day { get; set; }
        public Accumulation Qpf_Night { get; set; }
        public string SkyIcon { get; set; }
        public Accumulation Snow_AllDay { get; set; }
        public Accumulation Snow_Day { get; set; }
        public Accumulation Snow_Night { get; set; }
    }
}
