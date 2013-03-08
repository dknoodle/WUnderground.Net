using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGurus.Weather.WundergroundAPI.Models
{
    public class AlertData
    {
        public Alert[] Alerts { get; set; }
        public Response Response { get; set; }
    }
}
