using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGurus.Weather.WundergroundAPI;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WApi wApi = new WApi("");

            var alerts = wApi.GetAlertsUS("CA", "San Francisco");
            var forecast = wApi.GetForecastUS("CA", "San Francisco");
            var forecast10day = wApi.GetForecast10DayUS("CA", "San Francisco");
            var forecasthourlyus = wApi.GetForecastHourlyUS("CA", "San Francisco");
            
            Console.ReadLine();

        }
    }
}
