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
            WApi wApi = new WApi("API_Key_Goes_Here");

            var alerts = wApi.GetAlertsUS("CA", "San Francisco");
            var alertsPws = wApi.GetAlertsUS("KUTCLEAR3");
            var forecast = wApi.GetForecastUS("CA", "San Francisco");
            var forecastPws = wApi.GetAlertsUS("KUTCLEAR3");
            var forecast10Day = wApi.GetForecast10DayUS("CA", "San Francisco");
            var forecast10DayPws = wApi.GetForecast10DayUS("KUTCLEAR3");
            var forecastHourlyUS = wApi.GetForecastHourlyUS("CA", "San Francisco");
            var forecastHourlyPws = wApi.GetForecastHourlyUS("KUTCLEAR3");
            
            Console.ReadLine();

        }
    }
}
