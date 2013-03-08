using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGurus.Weather.WundergroundAPI.Models
{
    public class Wind
    {
        public double? Degrees { get; set; }
        public string Dir { get; set; }
        public double? Kph { get; set; }
        public double? Mph { get; set; }
    }
}
