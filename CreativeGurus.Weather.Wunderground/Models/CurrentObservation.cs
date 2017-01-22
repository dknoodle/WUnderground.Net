using System;
using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground
{
	public class CurrentObservation
	{

		[JsonProperty("image")]
		public Image Image { get; set; }

		[JsonProperty("display_location")]
		public DisplayLocation DisplayLocation { get; set; }

		[JsonProperty("observation_location")]
		public ObservationLocation ObservationLocation { get; set; }

		[JsonProperty("estimated")]
		public Estimated Estimated { get; set; }

		[JsonProperty("station_id")]
		public string StationId { get; set; }

		[JsonProperty("observation_time")]
		public string ObservationTime { get; set; }

		[JsonProperty("observation_time_rfc822")]
		public string ObservationTimeRfc822 { get; set; }

		[JsonProperty("observation_epoch")]
		public string ObservationEpoch { get; set; }

		[JsonProperty("local_time_rfc822")]
		public string LocalTimeRfc822 { get; set; }

		[JsonProperty("local_epoch")]
		public string LocalEpoch { get; set; }

		[JsonProperty("local_tz_short")]
		public string LocalTzShort { get; set; }

		[JsonProperty("local_tz_long")]
		public string LocalTzLong { get; set; }

		[JsonProperty("local_tz_offset")]
		public string LocalTzOffset { get; set; }

		[JsonProperty("weather")]
		public string Weather { get; set; }

		[JsonProperty("temperature_string")]
		public string TemperatureString { get; set; }

		[JsonProperty("temp_f")]
		public double TempF { get; set; }

		[JsonProperty("temp_c")]
		public double TempC { get; set; }

		[JsonProperty("relative_humidity")]
		public string RelativeHumidity { get; set; }

		[JsonProperty("wind_string")]
		public string WindString { get; set; }

		[JsonProperty("wind_dir")]
		public string WindDir { get; set; }

		[JsonProperty("wind_degrees")]
		public int WindDegrees { get; set; }

		[JsonProperty("wind_mph")]
		public double WindMph { get; set; }

		[JsonProperty("wind_gust_mph")]
		public string WindGustMph { get; set; }

		[JsonProperty("wind_kph")]
		public double WindKph { get; set; }

		[JsonProperty("wind_gust_kph")]
		public string WindGustKph { get; set; }

		[JsonProperty("pressure_mb")]
		public string PressureMb { get; set; }

		[JsonProperty("pressure_in")]
		public string PressureIn { get; set; }

		[JsonProperty("pressure_trend")]
		public string PressureTrend { get; set; }

		[JsonProperty("dewpoint_string")]
		public string DewpointString { get; set; }

		[JsonProperty("dewpoint_f")]
		public int DewpointF { get; set; }

		[JsonProperty("dewpoint_c")]
		public int DewpointC { get; set; }

		[JsonProperty("heat_index_string")]
		public string HeatIndexString { get; set; }

		[JsonProperty("heat_index_f")]
		public string HeatIndexF { get; set; }

		[JsonProperty("heat_index_c")]
		public string HeatIndexC { get; set; }

		[JsonProperty("windchill_string")]
		public string WindchillString { get; set; }

		[JsonProperty("windchill_f")]
		public string WindchillF { get; set; }

		[JsonProperty("windchill_c")]
		public string WindchillC { get; set; }

		[JsonProperty("feelslike_string")]
		public string FeelslikeString { get; set; }

		[JsonProperty("feelslike_f")]
		public string FeelslikeF { get; set; }

		[JsonProperty("feelslike_c")]
		public string FeelslikeC { get; set; }

		[JsonProperty("visibility_mi")]
		public string VisibilityMi { get; set; }

		[JsonProperty("visibility_km")]
		public string VisibilityKm { get; set; }

		[JsonProperty("solarradiation")]
		public string Solarradiation { get; set; }

		[JsonProperty("UV")]
		public string UV { get; set; }

		[JsonProperty("precip_1hr_string")]
		public string Precip1hrString { get; set; }

		[JsonProperty("precip_1hr_in")]
		public string Precip1hrIn { get; set; }

		[JsonProperty("precip_1hr_metric")]
		public string Precip1hrMetric { get; set; }

		[JsonProperty("precip_today_string")]
		public string PrecipTodayString { get; set; }

		[JsonProperty("precip_today_in")]
		public string PrecipTodayIn { get; set; }

		[JsonProperty("precip_today_metric")]
		public string PrecipTodayMetric { get; set; }

		[JsonProperty("icon")]
		public string Icon { get; set; }

		[JsonProperty("icon_url")]
		public string IconUrl { get; set; }

		[JsonProperty("forecast_url")]
		public string ForecastUrl { get; set; }

		[JsonProperty("history_url")]
		public string HistoryUrl { get; set; }

		[JsonProperty("ob_url")]
		public string ObUrl { get; set; }
	}

}
