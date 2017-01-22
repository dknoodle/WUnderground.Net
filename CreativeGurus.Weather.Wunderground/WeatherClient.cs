using CreativeGurus.Weather.Wunderground.Models;
using System.Threading.Tasks;

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

        public AlertData GetAlerts(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<AlertData> forecast = new Service<AlertData>(_apiKey, _baseUrl);
            return forecast.GetData(service: Service.Alerts, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress);
        }

        public async Task<AlertData> GetAlertsAsync(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<AlertData> forecast = new Service<AlertData>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(service: Service.Alerts, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress).ConfigureAwait(false);
        }

        public AlmanacData GetAlmanac(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<AlmanacData> forecast = new Service<AlmanacData>(_apiKey, _baseUrl);
            return forecast.GetData(service: Service.Almanac, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress);
        }

        public async Task<AlmanacData> GetAlmanacAsync(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<AlmanacData> forecast = new Service<AlmanacData>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(service: Service.Almanac, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress).ConfigureAwait(false);
        }

        public AstronomyData GetAstronomy(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<AstronomyData> forecast = new Service<AstronomyData>(_apiKey, _baseUrl);
            return forecast.GetData(service: Service.Astronomy, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress);
        }

        public async Task<AstronomyData> GetAstronomyAsync(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<AstronomyData> forecast = new Service<AstronomyData>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(service: Service.Astronomy, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress).ConfigureAwait(false);
        }

        public ForecastData GetForecast(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<ForecastData> forecast = new Service<ForecastData>(_apiKey, _baseUrl);
            return forecast.GetData(service: Service.Forecast, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress);
        }

        public async Task<ForecastData> GetForecastAsync(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<ForecastData> forecast = new Service<ForecastData>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(service: Service.Forecast, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress).ConfigureAwait(false);
        }

        public GeoLookupData GetGeoLookup(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<GeoLookupData> forecast = new Service<GeoLookupData>(_apiKey, _baseUrl);
            return forecast.GetData(service: Service.GeoLookup, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress);
        }

        public async Task<GeoLookupData> GetGeoLookupAsync(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<GeoLookupData> forecast = new Service<GeoLookupData>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(service: Service.GeoLookup, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress).ConfigureAwait(false);
        }

        public HourlyData GetHourly(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<HourlyData> forecast = new Service<HourlyData>(_apiKey, _baseUrl);
            return forecast.GetData(service: Service.Hourly, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress);
        }

        public async Task<HourlyData> GetHourlyAsync(LookupType lookupType, string city = "", string state = "", string country = "", string id = "", string latitude = "", string longitude = "", string language = "", bool? usePWS = null, bool? useBestFct = null, string ipAddress = "")
        {
            Service<HourlyData> forecast = new Service<HourlyData>(_apiKey, _baseUrl);
            return await forecast.GetDataAsync(service: Service.Hourly, lookupType: lookupType, city: city, state: state, country: country, id: id, latitude: latitude, longitude: longitude, language: language, usePWS: usePWS, useBestFct: useBestFct, ipAddress: ipAddress).ConfigureAwait(false);
        }
    }
}