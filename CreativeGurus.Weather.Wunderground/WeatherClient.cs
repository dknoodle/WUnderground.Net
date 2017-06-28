using CreativeGurus.Weather.Wunderground.Models;

using System.Threading.Tasks;
using System;

namespace CreativeGurus.Weather.Wunderground
{
    public class WeatherClient
    {
        private const string _baseUrl = "http://api.wunderground.com/api";
        private string _apiKey;

        public WeatherClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public AlertResponse GetAlerts(QueryType queryType, QueryOptions options = null)
        {
            Service<AlertResponse> forecast = new Service<AlertResponse>(_apiKey, _baseUrl);
            return forecast.GetData(Feature.Alerts, queryType, options);
        }

        public async Task<AlertResponse> GetAlertsAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<AlertResponse> forecast = new Service<AlertResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.Alerts, queryType, options).ConfigureAwait(false);
        }

        public AlmanacResponse GetAlmanac(QueryType queryType, QueryOptions options = null)
        {
            Service<AlmanacResponse> forecast = new Service<AlmanacResponse>(_apiKey, _baseUrl);
            return forecast.GetData(Feature.Almanac, queryType, options);
        }

        public async Task<AlmanacResponse> GetAlmanacAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<AlmanacResponse> forecast = new Service<AlmanacResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.Almanac, queryType, options).ConfigureAwait(false);
        }

        public AstronomyResponse GetAstronomy(QueryType queryType, QueryOptions options = null)
        {
            Service<AstronomyResponse> forecast = new Service<AstronomyResponse>(_apiKey, _baseUrl);
            return forecast.GetData(Feature.Astronomy, queryType, options);
        }

        public async Task<AstronomyResponse> GetAstronomyAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<AstronomyResponse> forecast = new Service<AstronomyResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.Astronomy, queryType, options).ConfigureAwait(false);
        }

        public ConditionsResponse GetConditions(QueryType queryType, QueryOptions options = null)
        {
            Service<ConditionsResponse> forecast = new Service<ConditionsResponse>(_apiKey, _baseUrl);
            return forecast.GetData(Feature.Conditions, queryType, options);
        }

        public async Task<ConditionsResponse> GetConditionsAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<ConditionsResponse> forecast = new Service<ConditionsResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.Conditions, queryType, options).ConfigureAwait(false);
        }

        public ForecastResponse GetForecast(QueryType queryType, QueryOptions options = null)
        {
            Service<ForecastResponse> forecast = new Service<ForecastResponse>(_apiKey, _baseUrl);
            return forecast.GetData(Feature.Forecast, queryType, options);
        }

        public async Task<ForecastResponse> GetForecastAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<ForecastResponse> forecast = new Service<ForecastResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.Forecast, queryType, options).ConfigureAwait(false);
        }

        public GeoLookupResponse GetGeoLookup(QueryType queryType, QueryOptions options = null)
        {
            Service<GeoLookupResponse> forecast = new Service<GeoLookupResponse>(_apiKey, _baseUrl);
            return forecast.GetData(Feature.GeoLookup, queryType, options);
        }

        public async Task<GeoLookupResponse> GetGeoLookupAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<GeoLookupResponse> forecast = new Service<GeoLookupResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.GeoLookup, queryType, options).ConfigureAwait(false);
        }

        public HourlyResponse GetHourly(QueryType queryType, QueryOptions options = null)
        {
            Service<HourlyResponse> forecast = new Service<HourlyResponse>(_apiKey, _baseUrl);
            return forecast.GetData(Feature.Hourly, queryType, options);
        }

        public HourlyResponse GetHourly10Day(QueryType queryType, QueryOptions options = null)
        {
            Service<HourlyResponse> forecast = new Service<HourlyResponse>(_apiKey, _baseUrl);
            return forecast.GetData(Feature.Hourly10Day, queryType, options);
        }

        public async Task<HourlyResponse> GetHourly10DayAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<HourlyResponse> forecast = new Service<HourlyResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.Hourly10Day, queryType, options).ConfigureAwait(false);
        }

        public async Task<HourlyResponse> GetHourlyAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<HourlyResponse> forecast = new Service<HourlyResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.Hourly, queryType, options).ConfigureAwait(false);
        }

		public ForecastResponse GetForecast10Day(QueryType queryType, QueryOptions options = null)
		{
			Service<ForecastResponse> forecast = new Service<ForecastResponse>(_apiKey, _baseUrl);
			return forecast.GetData(Feature.Forecast10Day, queryType, options);
		}

        public async Task<ForecastResponse> GetForecast10DayAsync(QueryType queryType, QueryOptions options = null)
        {
            Service<ForecastResponse> forecast = new Service<ForecastResponse>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(Feature.Forecast10Day, queryType, options);
        }

		public HistoryResponse GetHistory(QueryType queryType, QueryOptions options = null)
		{
			Service<HistoryResponse> forecast = new Service<HistoryResponse>(_apiKey, _baseUrl);
			return forecast.GetData(Feature.History, queryType, options);
		}

		public async Task<HistoryResponse> GetHistoryAsync(QueryType queryType, QueryOptions options = null)
		{
			Service<HistoryResponse> forecast = new Service<HistoryResponse>(_apiKey, _baseUrl);
			return await forecast.GetDataAsync(Feature.History, queryType, options);
		}
    }
}