using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Alert
    {
        public string Attribution { get; set; }
        public string Date { get; set; }
        public long Date_Epoch { get; set; }
        public DateTime Date_EpochDate { get { return Utilities.EpochConverter.FromUnixTime(this.Date_Epoch); } }
        public string Description { get; set; }
        public string Expires { get; set; }
        public long Expires_Epoch { get; set; }
        public DateTime Expires_EpochDate { get { return Utilities.EpochConverter.FromUnixTime(this.Expires_Epoch); } }
        public string Level_MeteoAlarm { get; set; }
        public string Level_MeteoAlarm_Description { get; set; }
        public string Level_MeteoAlarm_Name { get; set; }
        public string Message { get; set; }
        public string Phenomena { get; set; }
        public string Significance { get; set; }
        public string Type { get; set; }
        public string WType_MeteoAlarm { get; set; }
        public string WType_MeteoAlarm_Name { get; set; }
    }
}
