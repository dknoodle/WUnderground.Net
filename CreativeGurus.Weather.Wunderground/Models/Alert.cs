using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class Alert
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("date_epoch")]
        public long? DateEpoch { get; set; }

        public DateTime DateEpochDate { get { return DateEpoch.HasValue ? Utilities.EpochConverter.FromUnixTime(this.DateEpoch.Value) : new DateTime(); } }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("expires_epoch")]
        public long? ExpiresEpoch { get; set; }

        public DateTime ExpiresEpochDate { get { return ExpiresEpoch.HasValue?  Utilities.EpochConverter.FromUnixTime(this.ExpiresEpoch.Value) : new DateTime(); } }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("phenomena")]
        public string Phenomena { get; set; }

        [JsonProperty("significance")]
        public string Significance { get; set; }

        [JsonProperty("wtype_meteoalarm")]
        public string WtypeMeteoalarm { get; set; }

        [JsonProperty("wtype_meteoalarm_name")]
        public string WtypeMeteoalarmName { get; set; }

        [JsonProperty("level_meteoalarm")]
        public string LevelMeteoalarm { get; set; }

        [JsonProperty("level_meteoalarm_name")]
        public string LevelMeteoalarmName { get; set; }

        [JsonProperty("level_meteoalarm_description")]
        public string LevelMeteoalarmDescription { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }

        [JsonProperty("ZONES")]
        public IList<Zone> Zones { get; set; }

        [JsonProperty("StormBased")]
        public StormBased StormBased { get; set; }
    }
}