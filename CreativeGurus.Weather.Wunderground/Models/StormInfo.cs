using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class StormInfo
    {
        [JsonProperty("stormName")]
        public string StormName { get; set; }

        [JsonProperty("stormName_Nice")]
        public string StormNameNice { get; set; }

        [JsonProperty("stormNumber")]
        public string StormNumber { get; set; }

        [JsonProperty("time_epoch")]
        public long TimeEpoch { get; set; }

        public DateTime TimeEpochDate { get { return Utilities.EpochConverter.FromUnixTime(this.TimeEpoch); } }

        [JsonProperty("Motion_deg")]
        public int MotionDeg { get; set; }

        [JsonProperty("Motion_spd")]
        public int MotionSpd { get; set; }

        [JsonProperty("position_lat")]
        public string PositionLat { get; set; }

        [JsonProperty("position_lon")]
        public string PositionLon { get; set; }
    }
}
