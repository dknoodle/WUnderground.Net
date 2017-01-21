using CreativeGurus.Weather.Wunderground;
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
                string key = "611649331a9c9e34";

                WeatherClient client = new WeatherClient(key);

                //Sample Alerts
                //var alerts1 = client.Alerts.GetAlertsUS("Dallas", "TX");
                //var alerts2 = await client.Alerts.GetAlertsUSAsync("Dallas", "TX");

                //var alerts3 = client.Alerts.GetAlertsEurope("zmw:00000.1.16172");
                //var alerts4 = await client.Alerts.GetAlertsEuropeAsync("zmw:00000.1.16172");

                //Sample GeoLookups
                var geo1 = client.GeoLookup.GeoLookupAirportCode("SFO");
                var geo2 = client.GeoLookup.GeoLookupAutoIPAddress();
                var geo3 = client.GeoLookup.GeoLookupGlobal("France", "Paris");
                var geo4 = client.GeoLookup.GeoLookupLatLon("37.776289", "-122.395234");
                var geo5 = client.GeoLookup.GeoLookupPersonalWeatherStation("KMNCHASK10");
                var geo6 = client.GeoLookup.GeoLookupUS("Dallas", "TX");
                var geo7 = client.GeoLookup.GeoLookupUSZipCode("75056");

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