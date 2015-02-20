using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGurus.Weather.WundergroundAPI.Models {
    public class WeatherHistory {
        public History History { get; set; }
        public Response Response { get; set; }
    }

    public class History {
        public ShortDate Date { get; set; }
        public ShortDate Utcdate { get; set; }
        public Observation[] Observations { get; set; }
        public Dailysummary[] Dailysummary { get; set; }
    }

    public class ShortDate {
        public string Pretty { get; set; }
        public string Year { get; set; }
        public string Mon { get; set; }
        public string Mday { get; set; }
        public string Hour { get; set; }
        public string Min { get; set; }
        public string Tzname { get; set; }
    }

    public class Observation {
        public ShortDate Date { get; set; }
        public ShortDate Utcdate { get; set; }
        public string Tempm { get; set; }
        public string Tempi { get; set; }
        public string Dewptm { get; set; }
        public string Dewpti { get; set; }
        public string Hum { get; set; }
        public string Wspdm { get; set; }
        public string Wspdi { get; set; }
        public string Wgustm { get; set; }
        public string Wgusti { get; set; }
        public string Wdird { get; set; }
        public string Wdire { get; set; }
        public string Vism { get; set; }
        public string Visi { get; set; }
        public string Pressurem { get; set; }
        public string Pressurei { get; set; }
        public string Windchillm { get; set; }
        public string Windchilli { get; set; }
        public string Heatindexm { get; set; }
        public string Heatindexi { get; set; }
        public string Precipm { get; set; }
        public string Precipi { get; set; }
        public string Conds { get; set; }
        public string Icon { get; set; }
        public string Fog { get; set; }
        public string Rain { get; set; }
        public string Snow { get; set; }
        public string Hail { get; set; }
        public string Thunder { get; set; }
        public string Tornado { get; set; }
        public string Metar { get; set; }
    }

    public class Dailysummary {
        public ShortDate Date { get; set; }
        public string Fog { get; set; }
        public string Rain { get; set; }
        public string Snow { get; set; }
        public string Snowfallm { get; set; }
        public string Snowfalli { get; set; }
        public string Monthtodatesnowfallm { get; set; }
        public string Monthtodatesnowfalli { get; set; }
        public string Since1julsnowfallm { get; set; }
        public string Since1julsnowfalli { get; set; }
        public string Snowdepthm { get; set; }
        public string Snowdepthi { get; set; }
        public string Hail { get; set; }
        public string Thunder { get; set; }
        public string Tornado { get; set; }
        public string Meantempm { get; set; }
        public string Meantempi { get; set; }
        public string Meandewptm { get; set; }
        public string Meandewpti { get; set; }
        public string Meanpressurem { get; set; }
        public string Meanpressurei { get; set; }
        public string Meanwindspdm { get; set; }
        public string Meanwindspdi { get; set; }
        public string Meanwdire { get; set; }
        public string Meanwdird { get; set; }
        public string Meanvism { get; set; }
        public string Meanvisi { get; set; }
        public string Humidity { get; set; }
        public string Maxtempm { get; set; }
        public string Maxtempi { get; set; }
        public string Mintempm { get; set; }
        public string Mintempi { get; set; }
        public string Maxhumidity { get; set; }
        public string Minhumidity { get; set; }
        public string Maxdewptm { get; set; }
        public string Maxdewpti { get; set; }
        public string Mindewptm { get; set; }
        public string Mindewpti { get; set; }
        public string Maxpressurem { get; set; }
        public string Maxpressurei { get; set; }
        public string Minpressurem { get; set; }
        public string Minpressurei { get; set; }
        public string Maxwspdm { get; set; }
        public string Maxwspdi { get; set; }
        public string Minwspdm { get; set; }
        public string Minwspdi { get; set; }
        public string Maxvism { get; set; }
        public string Maxvisi { get; set; }
        public string Minvism { get; set; }
        public string Minvisi { get; set; }
        public string Gdegreedays { get; set; }
        public string Heatingdegreedays { get; set; }
        public string Coolingdegreedays { get; set; }
        public string Precipm { get; set; }
        public string Precipi { get; set; }
        public string Precipsource { get; set; }
        public string Heatingdegreedaysnormal { get; set; }
        public string Monthtodateheatingdegreedays { get; set; }
        public string Monthtodateheatingdegreedaysnormal { get; set; }
        public string Since1sepheatingdegreedays { get; set; }
        public string Since1sepheatingdegreedaysnormal { get; set; }
        public string Since1julheatingdegreedays { get; set; }
        public string Since1julheatingdegreedaysnormal { get; set; }
        public string Coolingdegreedaysnormal { get; set; }
        public string Monthtodatecoolingdegreedays { get; set; }
        public string Monthtodatecoolingdegreedaysnormal { get; set; }
        public string Since1sepcoolingdegreedays { get; set; }
        public string Since1sepcoolingdegreedaysnormal { get; set; }
        public string Since1jancoolingdegreedays { get; set; }
        public string Since1jancoolingdegreedaysnormal { get; set; }
    }
}
