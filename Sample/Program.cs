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
                //List of supported languages
                //https://www.wunderground.com/weather/api/d/docs?d=language-support&MR=1

                string key = "611649331a9c9e34";
                //string key = "{Your API Key Here}";

				WeatherClient client = new WeatherClient(key);

				//Sample Alerts
				//var a1 = client.GetAlerts(QueryType.AirportCode, new QueryOptions() { AirportCode = "DFW" });  //Gets data by Airport Code
				//var a2 = client.GetAlerts(QueryType.AutoIp);  //Gets data by the detected IP address of the calling client
				//var a3 = client.GetAlerts(QueryType.GlobalCity, new QueryOptions() { Country = "France", City = "Paris"}); //Gets data by country and city
				//var a4 = client.GetAlerts(QueryType.GPS, new QueryOptions() { Latitude = "37.776289", Longitude = "-122.395234" }); //Gets data by GPS coordinates
				//var a5 = client.GetAlerts(QueryType.LinkId, new QueryOptions() { LinkId = "00000.1.16172" }); //Gets data by Weather Underground Link ID
				//var a6 = client.GetAlerts(QueryType.PWSId, new QueryOptions() { PWSId = "KMNCHASK10" }); //Gets data from a personal weather station by ID
				//var a7 = client.GetAlerts(QueryType.USCity, new QueryOptions() { City = "Dallas", State = "TX" }); //Gets data for a US City
				//var a8 = client.GetAlerts(QueryType.ZipCode, new QueryOptions() { ZipCode = "94107" }); //Gets data by US Zip Code

				//Sample Alminac
				//var al1 = client.GetAlmanac(QueryType.USCity, new QueryOptions() { City = "Dallas", State = "TX" });

				//Sample Astronomy
				//var as1 = client.GetAstronomy(QueryType.USCity, new QueryOptions() { City = "Dallas", State = "TX" });

                //Sample Forecasts
                //var f1 = client.GetForecast(QueryType.AirportCode, new QueryOptions() { AirportCode = "DFW" });  //Gets data by Airport Code
                //var f2 = client.GetForecast(QueryType.AutoIp);  //Gets data by the detected IP address of the calling client
                //var f3 = client.GetForecast(QueryType.GlobalCity, new QueryOptions() { Country = "France", City = "Paris" }); //Gets data by country and city
                //var f4 = client.GetForecast(QueryType.GPS, new QueryOptions() { Latitude = "37.776289", Longitude = "-122.395234" }); //Gets data by GPS coordinates
                //var f5 = client.GetForecast(QueryType.LinkId, new QueryOptions() { LinkId = "00000.1.16172" }); //Gets data by Weather Underground Link ID
                //var f6 = client.GetForecast(QueryType.PWSId, new QueryOptions() { PWSId = "KMNCHASK10" }); //Gets data from a personal weather station by ID
                //var f7 = client.GetForecast(QueryType.USCity, new QueryOptions() { City = "Dallas", State = "TX" }); //Gets data for a US City
                //var f8 = client.GetForecast(QueryType.ZipCode, new QueryOptions() { ZipCode = "94107" }); //Gets data by US Zip Code

                //Sample GeoLookups
                //var g1 = client.GetGeoLookup(QueryType.AirportCode, new QueryOptions() { AirportCode = "DFW" });  //Gets data by Airport Code
                //var g2 = client.GetGeoLookup(QueryType.AutoIp);  //Gets data by the detected IP address of the calling client
                //var g3 = client.GetGeoLookup(QueryType.GlobalCity, new QueryOptions() { Country = "France", City = "Paris" }); //Gets data by country and city
                //var g4 = client.GetGeoLookup(QueryType.GPS, new QueryOptions() { Latitude = "37.776289", Longitude = "-122.395234" }); //Gets data by GPS coordinates
                //var g5 = client.GetGeoLookup(QueryType.LinkId, new QueryOptions() { LinkId = "00000.1.16172" }); //Gets data by Weather Underground Link ID
                //var g6 = client.GetGeoLookup(QueryType.PWSId, new QueryOptions() { PWSId = "KMNCHASK10" }); //Gets data from a personal weather station by ID
                //var g7 = client.GetGeoLookup(QueryType.USCity, new QueryOptions() { City = "Dallas", State = "TX" }); //Gets data for a US City
                //var g8 = client.GetGeoLookup(QueryType.ZipCode, new QueryOptions() { ZipCode = "94107" }); //Gets data by US Zip Code

				//Sample Hourly
				//var h1 = client.GetHourly(QueryType.USCity, new QueryOptions() { City = "Dallas", State = "TX" });

				//Sample Conditions
				//var c1 = await client.GetConditionsAsync(QueryType.USCity, new QueryOptions() { City = "Dallas", State = "TX" });

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