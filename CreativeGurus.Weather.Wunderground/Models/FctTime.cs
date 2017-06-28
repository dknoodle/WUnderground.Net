using System;
using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
	public class FctTime
	{
		[JsonProperty("hour")]
		public int? Hour { get; set; }

		[JsonProperty("hour_padded")]
		public string HourPadded { get; set; }

		[JsonProperty("min")]
		public int? Min { get; set; }

		[JsonProperty("sec")]
		public int? Sec { get; set; }

		[JsonProperty("year")]
		public int? Year { get; set; }

		[JsonProperty("mon")]
		public int? Mon { get; set; }

		[JsonProperty("mon_padded")]
		public string MonPadded { get; set; }

		[JsonProperty("mon_abbrev")]
		public string MonAbbrev { get; set; }

		[JsonProperty("mday")]
		public int? Mday { get; set; }

		[JsonProperty("mday_padded")]
		public string MdayPadded { get; set; }

		[JsonProperty("yday")]
		public int? Yday { get; set; }

		[JsonProperty("isdst")]
		public string Isdst { get; set; }

		[JsonProperty("epoch")]
		public long? Epoch { get; set; }

		public DateTime EpochDate { get { return Epoch.HasValue ? Utilities.EpochConverter.FromUnixTime(this.Epoch.Value) : DateTime.MinValue; } }

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

		[JsonProperty("tz")]
		public string Tz { get; set; }

		[JsonProperty("age")]
		public string Age { get; set; }

		[JsonProperty("UTCDATE")]
		public string UTCDate { get; set; }
	}
}