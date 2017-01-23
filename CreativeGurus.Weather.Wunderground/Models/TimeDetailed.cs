using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class TimeDetailed
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("hour_padded")]
        public string HourPadded { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("mon")]
        public int Mon { get; set; }

        [JsonProperty("mon_padded")]
        public string MonPadded { get; set; }

        [JsonProperty("mon_abbrev")]
        public string MonAbbrev { get; set; }

        [JsonProperty("mday")]
        public int Mday { get; set; }

        [JsonProperty("mday_padded")]
        public string MdayPadded { get; set; }

        [JsonProperty("yday")]
        public int Yday { get; set; }

        [JsonProperty("isdst")]
        public bool? Isdst { get; set; }

        [JsonProperty("epoch")]
        public long Epoch { get; set; }

        [JsonProperty("pretty")]
        public string Pretty { get; set; }

        [JsonProperty("civil")]
        public string Civil { get; set; }

        [JsonProperty("month_name")]
        public string MonthName { get; set; }

        [JsonProperty("month_name_abbrev")]
        public string MonthNameAbbrev { get; set; }

        [JsonProperty("weekday_name")]
        public string WeekdayName { get; set; }

        [JsonProperty("weekday_name_night")]
        public string WeekdayNameNight { get; set; }

        [JsonProperty("weekday_name_abbrev")]
        public string WeekdayNameAbbrev { get; set; }

        [JsonProperty("weekday_name_unlang")]
        public string WeekdayNameUnlang { get; set; }

        [JsonProperty("weekday_name_night_unlang")]
        public string WeekdayNameNightUnlang { get; set; }

        [JsonProperty("ampm")]
        public AMPM AmPm { get; set; }
    }
}
