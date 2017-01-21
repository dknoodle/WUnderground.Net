using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Station
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Icao { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
    }
}
