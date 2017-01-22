using CreativeGurus.Weather.Wunderground;
using CreativeGurus.Weather.Wunderground.Models;
using System;
using System.Threading.Tasks;

namespace Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Examples().Wait();
        }

        private static async Task<bool> Examples()
        {
            try
            {
                string key = "{Your API Key Here}";

                WeatherClient client = new WeatherClient(key);

                //Sample Alerts
                var a1 = client.GetAlerts(LookupType.AirportCode, id: "DFW");  //Gets data by Airport Code
                var a2 = client.GetAlerts(LookupType.AutoIp);  //Gets data by the detected IP address of the calling client
                var a3 = client.GetAlerts(LookupType.GlobalCity, country: "France", city: "Paris"); //Gets data by country and city
                var a4 = client.GetAlerts(LookupType.LatLon, latitude: "37.776289", longitude: "-122.395234"); //Gets data by GPS coordinates
                var a5 = client.GetAlerts(LookupType.LinkId, id: "00000.1.16172"); //Gets data by Weather Underground Link ID
                var a6 = client.GetAlerts(LookupType.PersonalWeatherStationId, id: "KMNCHASK10"); //Gets data from a personal weather station by ID
                var a7 = client.GetAlerts(LookupType.USCity, city: "San Francisco", state: "CA"); //Gets data for a US City
                var a8 = client.GetAlerts(LookupType.ZipCode, id: "94107"); //Gets data by US Zip Code

                //Sample Forecasts
                var f1 = client.GetForecast(LookupType.AirportCode, id: "DFW");  //Gets data by Airport Code
                var f2 = client.GetForecast(LookupType.AutoIp);  //Gets data by the detected IP address of the calling client
                var f3 = client.GetForecast(LookupType.GlobalCity, country: "France", city: "Paris"); //Gets data by country and city
                var f4 = client.GetForecast(LookupType.LatLon, latitude: "37.776289", longitude: "-122.395234"); //Gets data by GPS coordinates
                var f5 = client.GetForecast(LookupType.LinkId, id: "00000.1.16172"); //Gets data by Weather Underground Link ID
                var f6 = client.GetForecast(LookupType.PersonalWeatherStationId, id: "KMNCHASK10"); //Gets data from a personal weather station by ID
                var f7 = client.GetForecast(LookupType.USCity, city: "San Francisco", state: "CA"); //Gets data for a US City
                var f8 = client.GetForecast(LookupType.ZipCode, id: "94107"); //Gets data by US Zip Code

                //Sample GeoLookups
                var g1 = client.GetGeoLookup(LookupType.AirportCode, id: "DFW");  //Gets data by Airport Code
                var g2 = client.GetGeoLookup(LookupType.AutoIp);  //Gets data by the detected IP address of the calling client
                var g3 = client.GetGeoLookup(LookupType.GlobalCity, country: "France", city: "Paris"); //Gets data by country and city
                var g4 = client.GetGeoLookup(LookupType.LatLon, latitude: "37.776289", longitude: "-122.395234"); //Gets data by GPS coordinates
                var g5 = client.GetGeoLookup(LookupType.LinkId, id: "00000.1.16172"); //Gets data by Weather Underground Link ID
                var g6 = client.GetGeoLookup(LookupType.PersonalWeatherStationId, id: "KMNCHASK10"); //Gets data from a personal weather station by ID
                var g7 = client.GetGeoLookup(LookupType.USCity, city: "San Francisco", state: "CA"); //Gets data for a US City
                var g8 = client.GetGeoLookup(LookupType.ZipCode, id: "94107"); //Gets data by US Zip Code

                //Sample GeoLookups
                //var geo1 = client.GeoLookup.GetGeoLookupAirportCode("SFO");
                //var geo1a = await client.GeoLookup.GetGeoLookupAirportCodeAsync("SFO");

                //var geo2 = client.GeoLookup.GetGeoLookupAutoIPAddress();
                //var geo2a = await client.GeoLookup.GetGeoLookupAutoIPAddressAsync();

                //var geo3 = client.GeoLookup.GetGeoLookupGlobal("France", "Paris");
                //var geo3a = await client.GeoLookup.GetGeoLookupGlobalAsync("France", "Paris");

                //var geo4 = client.GeoLookup.GetGeoLookupLatLon("37.776289", "-122.395234");
                //var geo4a = await client.GeoLookup.GetGeoLookupLatLonAsync("37.776289", "-122.395234");

                //var geo5 = client.GeoLookup.GetGeoLookupPersonalWeatherStation("KMNCHASK10");
                //var geo5a = await client.GeoLookup.GetGeoLookupPersonalWeatherStationAsync("KMNCHASK10");

                //var geo6 = client.GeoLookup.GetGeoLookupUS("Dallas", "TX");
                //var geo6a = await client.GeoLookup.GetGeoLookupUSAsync("Dallas", "TX");

                //var geo7 = client.GeoLookup.GetGeoLookupUSZipCode("75056");
                //var geo7a = await client.GeoLookup.GetGeoLookupUSZipCodeAsync("75056");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}