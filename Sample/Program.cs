using CreativeGurus.Weather.Wunderground;
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
                string key = "{Your_API_Key_Here}";

                WeatherClient client = new WeatherClient(key);

                var alerts1 = client.Alerts.GetAlertsUS("Dallas", "TX");
                var alerts2 = await client.Alerts.GetAlertsUSAsync("Dallas", "TX");
                var alerts3 = client.Alerts.GetAlertsEurope("zmw:00000.1.16172");
                var alerts4 = await client.Alerts.GetAlertsEuropeAsync("zmw:00000.1.16172");

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
