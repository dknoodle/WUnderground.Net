namespace CreativeGurus.Weather.Wunderground.Models
{
    public enum AMPM
    {
        AM = 0,
        PM = 1
    }

    public enum LookupType
    {
        AirportCode = 0,
        AutoIp = 1,
        GlobalCity = 2,
        LatLon = 3,
        LinkId = 4,
        PersonalWeatherStationId = 5,
        USCity = 6,
        ZipCode = 7
    }

    public enum Service
    {
        Alerts = 0,
        Almanac = 1,
        Astronomy = 2,
        Conditions = 3,
        CurrentHurricane = 4,
        Forecast = 5,
        Forecast10Day = 6,
        GeoLookup = 7,
        History = 8,
        Hourly = 9,
        Hourly10Day = 10,
        Planner = 11,
        RawTide = 12,
        Satellite = 13,
        Tide = 14,
        WebCams = 15,
        Yesterday = 16
    }
}