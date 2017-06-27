using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class DailySummary
    {
        [JsonProperty("date")]
        public Date Date { get; set; }
        [JsonProperty("fog")]
        public bool Fog { get; set; }
        [JsonProperty("rain")]
        public bool Rain { get; set; }
        [JsonProperty("snow")]
        public bool Snow { get; set; }
        [JsonProperty("snowfallm")]
        public float? SnowFallMetric { get; set; }
        [JsonProperty("snowfalli")]
        public float? SnowFallImperial { get; set; }
        [JsonProperty("monthtodatesnowfallm")]
        public float? MonthToDateSnowFallMetric { get; set; }
        [JsonProperty("monthtodatesnowfalli")]
        public float? MonthToDateSnowFallImperial { get; set; }
        [JsonProperty("since1julsnowfallm")]
        public float? Since1JulSnowFallMetric { get; set; }
        [JsonProperty("since1julsnowfalli")]
        public float? Since1JulSnowFallImperial { get; set; }
        [JsonProperty("snowdepthm")]
        public float? SnowDepthMetric { get; set; }
        [JsonProperty("snowdepthi")]
        public float? SnowDepthImperial { get; set; }
        [JsonProperty("hail")]
        public bool Hail { get; set; }
        [JsonProperty("thunder")]
        public bool Thunder { get; set; }
        [JsonProperty("tornado")]
        public bool Tornado { get; set; }
        [JsonProperty("meantempm")]
        public float? MeanTempMetric { get; set; }
        [JsonProperty("meantempi")]
        public float? MeanTempImperial { get; set; }
        [JsonProperty("meandewptm")]
        public float? MeanDewPointMetric { get; set; }
        [JsonProperty("meandewpti")]
        public float? MeanDewPopintImperial { get; set; }
        [JsonProperty("meanpressurem")]
        public float? MeanPressureMetric { get; set; }
        [JsonProperty("meanpressurei")]
        public float? MeanPressureImperial { get; set; }
        [JsonProperty("meanwindspdm")]
        public float? MeanWindSpeedMetric { get; set; }
        [JsonProperty("meanwindspdi")]
        public float? MeanWindSpeedImperial { get; set; }
        [JsonProperty("meanwdire")]
        public string MeanWindDirection { get; set; }
        [JsonProperty("meanwdird")]
        public int? MeanWindDirectionDegree { get; set; }
        [JsonProperty("meanvism")]
        public float? MeanVisibilityMetric { get; set; }
        [JsonProperty("meanvisi")]
        public float? MeanVisibilityImperial { get; set; }
        [JsonProperty("humidity")]
        public int? Humidity { get; set; }
        [JsonProperty("maxtempm")]
        public float? MaxTempMetric { get; set; }
        [JsonProperty("maxtempi")]
        public float? MaxTempImperial { get; set; }
        [JsonProperty("mintempm")]
        public float? MinTempMetric { get; set; }
        [JsonProperty("mintempi")]
        public float? MinTempImperial { get; set; }
        [JsonProperty("maxhumidity")]
        public int? MaxHumidity { get; set; }
        [JsonProperty("minhumidity")]
        public int? MinHumidity { get; set; }
        [JsonProperty("maxdewptm")]
        public float? MaxDewPointMetric { get; set; }
        [JsonProperty("maxdewpti")]
        public float? MaxDewPointImperial { get; set; }
        [JsonProperty("mindewptm")]
        public float? MinDewPointMetric { get; set; }
        [JsonProperty("mindewpti")]
        public float? MinDewPointImperial { get; set; }
        [JsonProperty("maxpressurem")]
        public float? MaxPressureMetric { get; set; }
        [JsonProperty("maxpressurei")]
        public float? MaxPressureImperial { get; set; }
        [JsonProperty("minpressurem")]
        public float? MinPressureMetric { get; set; }
        [JsonProperty("minpressurei")]
        public float? MinPressureImperial { get; set; }
        [JsonProperty("maxwspdm")]
        public float? MaxWindSpeedMetric { get; set; }
        [JsonProperty("maxwspdi")]
        public float? MaxWindSpeedImperial { get; set; }
        [JsonProperty("minwspdm")]
        public float? MinWindSpeedMetric { get; set; }
        [JsonProperty("minwspdi")]
        public float? MinWindSpeedImperial { get; set; }
        [JsonProperty("maxvism")]
        public float? MaxVisibilityMetric { get; set; }
        [JsonProperty("maxvisi")]
        public float? MaxVisibilityImperial { get; set; }
        [JsonProperty("minvism")]
        public float? MinVisibilityMetric { get; set; }
        [JsonProperty("minvisi")]
        public float? MinVisibilityImperial { get; set; }
        [JsonProperty("gdegreedays")]
        public int? GrowingDegreeDays { get; set; }
        [JsonProperty("heatingdegreedays")]
        public int? HeatingDegreeDays { get; set; }
        [JsonProperty("coolingdegreedays")]
        public int? CoolingDegreeDays { get; set; }
        [JsonProperty("precipm")]
        public float? PrecipitationMetric { get; set; }
        [JsonProperty("precipi")]
        public float? PrecipitationImperial { get; set; }
        [JsonProperty("precipsource")]
        public string PrecipitationSource { get; set; }
        [JsonProperty("heatingdegreedaysnormal")]
        public int? HeatingDegreeDaysNormal { get; set; }
        [JsonProperty("monthtodateheatingdegreedays")]
        public int? MonthToDateHeatingDegreeDays { get; set; }
        [JsonProperty("monthtodateheatingdegreedaysnormal")]
        public int? MonthToDateHeatingDegreeDaysNormal { get; set; }
        [JsonProperty("since1sepheatingdegreedays")]
        public int? Since1SepHeatingDegreeDays { get; set; }
        [JsonProperty("since1sepheatingdegreedaysnormal")]
        public int? Since1SepHeatingDegreeDaysNormal { get; set; }
        [JsonProperty("since1julheatingdegreedays")]
        public int? Since1JulHeatingDegreeDays { get; set; }
        [JsonProperty("since1julheatingdegreedaysnormal")]
        public int? Since1JulHeatingDegreeDaysNormal { get; set; }
        [JsonProperty("coolingdegreedaysnormal")]
        public int? CoolingDegreeDaysNormal { get; set; }
        [JsonProperty("monthtodatecoolingdegreedays")]
        public int? MonthToDateCoolingDegreeDays { get; set; }
        [JsonProperty("monthtodatecoolingdegreedaysnormal")]
        public int? MonthToDateCoolingDegreeDaysNormal { get; set; }
        [JsonProperty("since1sepcoolingdegreedays")]
        public int? Since1SepCoolingDegreeDays { get; set; }
        [JsonProperty("since1sepcoolingdegreedaysnormal")]
        public int? Since1SepCoolingDegreeDaysNormal { get; set; }
        [JsonProperty("since1jancoolingdegreedays")]
        public int? Since1JanCoolingDegreeDays { get; set; }
        [JsonProperty("since1jancoolingdegreedaysnormal")]
        public int? Since1JanCoolingDegreeDaysNormal { get; set; }

    }
}
