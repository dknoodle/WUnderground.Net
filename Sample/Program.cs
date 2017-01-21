using CreativeGurus.Weather.Wunderground;
using CreativeGurus.Weather.Wunderground.Services;
using CreativeGurus.Weather.Wunderground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples().Wait();
        }

        static async Task<bool> Examples()
        {
            try
            {
                string key = "";

                WeatherClient client = new WeatherClient(key);

                //var alerts1 = client.Alerts.GetAlertsUS("Dallas", "TX");
                //var alerts2 = await client.Alerts.GetAlertsUSAsync("Dallas", "TX");
                //var alerts3 = client.Alerts.GetAlertsEurope("zmw:00000.1.16172");
                //var alerts4 = await client.Alerts.GetAlertsEuropeAsync("zmw:00000.1.16172");

                //var geo1 = client.GeoLookup.GeoLookupAirportCode("SFO");
                //var geo2 = client.GeoLookup.GeoLookupAutoIPAddress();
                var geo3 = client.GeoLookup.GeoLookupGlobal("France", "Paris");
                //var geo4 = client.GeoLookup.GeoLookupLatLon("37.776289", "-122.395234");
                //var geo5 = client.GeoLookup.GeoLookupPersonalWeatherStation("KMNCHASK10");
                var geo6 = client.GeoLookup.GeoLookupUS("Dallas", "TX");
                //var geo7 = client.GeoLookup.GeoLookupUSZipCode("75056");


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
