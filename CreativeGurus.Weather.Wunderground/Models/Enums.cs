namespace CreativeGurus.Weather.Wunderground.Models
{
    public enum AMPM
    {
        AM = 0,
        PM = 1
    }

    /// <summary>
    /// QueryTypes to use qhen querying the Weather Underground API
    /// </summary>
    public enum QueryType
    {
        /// <summary>
        /// Sets the query type to use an Airport Code.  Must provide AirportCode of the location to query.
        /// </summary>
        AirportCode = 0,

        /// <summary>
        /// Sets the query type to use the IP address of the calling client for location data.
        /// </summary>
        AutoIp = 1,

        /// <summary>
        /// Sets the query type to be a global (non US) city.  Must provide Country and City of the location to query.
        /// </summary>
        GlobalCity = 2,

        /// <summary>
        /// Sets the query type to use GPS Latitude and Longitude.  Must provide Latitude and Longitude of the location to query.
        /// </summary>
        GPS = 3,

        /// <summary>
        /// Sets the query type to use a Link ID.  Must provide LinkId of the location to query.
        /// </summary>
        LinkId = 4,

        /// <summary>
        /// Sets the query type to use a PWSId (Personal Weather Station).  Must provide the PWSId of the station to query.
        /// </summary>
        PWSId = 5,

        /// <summary>
        /// Sets the query type to use a US City and State.  Must provide the US City and State of the location to query.
        /// </summary>
        USCity = 6,

        /// <summary>
        /// Sets the query type to use a US Zip Code.  Must provide the US Zip Code of the location to query.
        /// </summary>
        ZipCode = 7
    }

    /// <summary>
    /// Feature to use when querying the Weather Underground API
    /// </summary>
    public enum Feature
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