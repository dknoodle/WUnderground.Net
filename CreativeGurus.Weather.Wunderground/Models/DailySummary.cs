using Newtonsoft.Json;

namespace CreativeGurus.Weather.Wunderground.Models
{
    public class DailySummary
    {
        [JsonProperty("date")]
        public DateSimple Date { get; set; }

        [JsonProperty("fog")]
        public string Fog { get; set; }

        [JsonProperty("rain")]
        public string Rain { get; set; }

        [JsonProperty("snow")]
        public string Snow { get; set; }

        [JsonProperty("snowfallm")]
        public string Snowfallm { get; set; }

        [JsonProperty("snowfalli")]
        public string Snowfalli { get; set; }

        [JsonProperty("monthtodatesnowfallm")]
        public string Monthtodatesnowfallm { get; set; }

        [JsonProperty("monthtodatesnowfalli")]
        public string Monthtodatesnowfalli { get; set; }

        [JsonProperty("since1julsnowfallm")]
        public string Since1julsnowfallm { get; set; }

        [JsonProperty("since1julsnowfalli")]
        public string Since1julsnowfalli { get; set; }

        [JsonProperty("snowdepthm")]
        public string Snowdepthm { get; set; }

        [JsonProperty("snowdepthi")]
        public string Snowdepthi { get; set; }

        [JsonProperty("hail")]
        public string Hail { get; set; }

        [JsonProperty("thunder")]
        public string Thunder { get; set; }

        [JsonProperty("tornado")]
        public string Tornado { get; set; }

        [JsonProperty("meantempm")]
        public string Meantempm { get; set; }

        [JsonProperty("meantempi")]
        public string Meantempi { get; set; }

        [JsonProperty("meandewptm")]
        public string Meandewptm { get; set; }

        [JsonProperty("meandewpti")]
        public string Meandewpti { get; set; }

        [JsonProperty("meanpressurem")]
        public string Meanpressurem { get; set; }

        [JsonProperty("meanpressurei")]
        public string Meanpressurei { get; set; }

        [JsonProperty("meanwindspdm")]
        public string Meanwindspdm { get; set; }

        [JsonProperty("meanwindspdi")]
        public string Meanwindspdi { get; set; }

        [JsonProperty("meanwdire")]
        public string Meanwdire { get; set; }

        [JsonProperty("meanwdird")]
        public string Meanwdird { get; set; }

        [JsonProperty("meanvism")]
        public string Meanvism { get; set; }

        [JsonProperty("meanvisi")]
        public string Meanvisi { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("maxtempm")]
        public string Maxtempm { get; set; }

        [JsonProperty("maxtempi")]
        public string Maxtempi { get; set; }

        [JsonProperty("mintempm")]
        public string Mintempm { get; set; }

        [JsonProperty("mintempi")]
        public string Mintempi { get; set; }

        [JsonProperty("maxhumidity")]
        public string Maxhumidity { get; set; }

        [JsonProperty("minhumidity")]
        public string Minhumidity { get; set; }

        [JsonProperty("maxdewptm")]
        public string Maxdewptm { get; set; }

        [JsonProperty("maxdewpti")]
        public string Maxdewpti { get; set; }

        [JsonProperty("mindewptm")]
        public string Mindewptm { get; set; }

        [JsonProperty("mindewpti")]
        public string Mindewpti { get; set; }

        [JsonProperty("maxpressurem")]
        public string Maxpressurem { get; set; }

        [JsonProperty("maxpressurei")]
        public string Maxpressurei { get; set; }

        [JsonProperty("minpressurem")]
        public string Minpressurem { get; set; }

        [JsonProperty("minpressurei")]
        public string Minpressurei { get; set; }

        [JsonProperty("maxwspdm")]
        public string Maxwspdm { get; set; }

        [JsonProperty("maxwspdi")]
        public string Maxwspdi { get; set; }

        [JsonProperty("minwspdm")]
        public string Minwspdm { get; set; }

        [JsonProperty("minwspdi")]
        public string Minwspdi { get; set; }

        [JsonProperty("maxvism")]
        public string Maxvism { get; set; }

        [JsonProperty("maxvisi")]
        public string Maxvisi { get; set; }

        [JsonProperty("minvism")]
        public string Minvism { get; set; }

        [JsonProperty("minvisi")]
        public string Minvisi { get; set; }

        [JsonProperty("gdegreedays")]
        public string Gdegreedays { get; set; }

        [JsonProperty("heatingdegreedays")]
        public string Heatingdegreedays { get; set; }

        [JsonProperty("coolingdegreedays")]
        public string Coolingdegreedays { get; set; }

        [JsonProperty("precipm")]
        public string Precipm { get; set; }

        [JsonProperty("precipi")]
        public string Precipi { get; set; }

        [JsonProperty("precipsource")]
        public string Precipsource { get; set; }

        [JsonProperty("heatingdegreedaysnormal")]
        public string Heatingdegreedaysnormal { get; set; }

        [JsonProperty("monthtodateheatingdegreedays")]
        public string Monthtodateheatingdegreedays { get; set; }

        [JsonProperty("monthtodateheatingdegreedaysnormal")]
        public string Monthtodateheatingdegreedaysnormal { get; set; }

        [JsonProperty("since1sepheatingdegreedays")]
        public string Since1sepheatingdegreedays { get; set; }

        [JsonProperty("since1sepheatingdegreedaysnormal")]
        public string Since1sepheatingdegreedaysnormal { get; set; }

        [JsonProperty("since1julheatingdegreedays")]
        public string Since1julheatingdegreedays { get; set; }

        [JsonProperty("since1julheatingdegreedaysnormal")]
        public string Since1julheatingdegreedaysnormal { get; set; }

        [JsonProperty("coolingdegreedaysnormal")]
        public string Coolingdegreedaysnormal { get; set; }

        [JsonProperty("monthtodatecoolingdegreedays")]
        public string Monthtodatecoolingdegreedays { get; set; }

        [JsonProperty("monthtodatecoolingdegreedaysnormal")]
        public string Monthtodatecoolingdegreedaysnormal { get; set; }

        [JsonProperty("since1sepcoolingdegreedays")]
        public string Since1sepcoolingdegreedays { get; set; }

        [JsonProperty("since1sepcoolingdegreedaysnormal")]
        public string Since1sepcoolingdegreedaysnormal { get; set; }

        [JsonProperty("since1jancoolingdegreedays")]
        public string Since1jancoolingdegreedays { get; set; }

        [JsonProperty("since1jancoolingdegreedaysnormal")]
        public string Since1jancoolingdegreedaysnormal { get; set; }
    }
}