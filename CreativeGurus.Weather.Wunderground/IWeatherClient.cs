using System.Threading.Tasks;
using CreativeGurus.Weather.Wunderground.Models;

namespace CreativeGurus.Weather.Wunderground
{
	public interface IWeatherClient
	{
		AlertResponse GetAlerts(QueryType queryType, QueryOptions options = null);

		Task<AlertResponse> GetAlertsAsync(QueryType queryType, QueryOptions options = null);

		AlmanacResponse GetAlmanac(QueryType queryType, QueryOptions options = null);

		Task<AlmanacResponse> GetAlmanacAsync(QueryType queryType, QueryOptions options = null);

		AstronomyResponse GetAstronomy(QueryType queryType, QueryOptions options = null);

		Task<AstronomyResponse> GetAstronomyAsync(QueryType queryType, QueryOptions options = null);

		ConditionsResponse GetConditions(QueryType queryType, QueryOptions options = null);

		Task<ConditionsResponse> GetConditionsAsync(QueryType queryType, QueryOptions options = null);

		ForecastResponse GetForecast(QueryType queryType, QueryOptions options = null);
		
		ForecastResponse GetForecast10Day(QueryType queryType, QueryOptions options = null);

		Task<ForecastResponse> GetForecast10DayAsync(QueryType queryType, QueryOptions options = null);

		Task<ForecastResponse> GetForecastAsync(QueryType queryType, QueryOptions options = null);

		GeoLookupResponse GetGeoLookup(QueryType queryType, QueryOptions options = null);

		Task<GeoLookupResponse> GetGeoLookupAsync(QueryType queryType, QueryOptions options = null);

		HistoryResponse GetHistory(QueryType queryType, QueryOptions options = null);

		Task<HistoryResponse> GetHistoryAsync(QueryType queryType, QueryOptions options = null);

		HourlyResponse GetHourly(QueryType queryType, QueryOptions options = null);

		HourlyResponse GetHourly10Day(QueryType queryType, QueryOptions options = null);

		Task<HourlyResponse> GetHourly10DayAsync(QueryType queryType, QueryOptions options = null);

		Task<HourlyResponse> GetHourlyAsync(QueryType queryType, QueryOptions options = null);

	}
}