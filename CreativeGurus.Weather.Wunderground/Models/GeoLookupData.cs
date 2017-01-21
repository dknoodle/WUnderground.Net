using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class GeoLookupData
    {
        public Response Response { get; set; }
        public Location Location { get; set; }
    }
}
