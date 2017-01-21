namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Location
    {
        public string Type { get; set; }
        public string Country { get; set; }
        public string Country_Iso3166 { get; set; }
        public string Country_Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Tz_Short { get; set; }
        public string Tz_Long { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Zip { get; set; }
        public string Magic { get; set; }
        public string Wmo { get; set; }
        public string L { get; set; }
        public string RequestUrl { get; set; }
        public string WuiUrl { get; set; }
        public NearbyWeatherStations Nearby_Weather_Stations { get; set; }
    }
}