using System.Collections.Generic;

namespace OpenWeatherMapSpecFlowProject.Model
{
    // Top-level of the response JSON
    public class ForecastResponse
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List<ForecastForTime> list { get; set; }
        public ForecastCity city { get; set; }
    }
        
    public class ForecastForTime
    {
        public long dt { get; set; }
        public ForecastDetails main { get; set; }
        public List<ForecastDescription> weather { get; set; }
        public ForecastClouds clouds { get; set; }
        public ForecastWind wind { get; set; }
        public ForecastSys sys { get; set; }
        public string dt_txt { get; set; }
    }

    public class ForecastDetails
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public int pressure { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
        public int humidity { get; set; }
        public float temp_kf { get; set; }
    }

    public class ForecastDescription
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class ForecastClouds
    {
        public int all { get; set; }
    }

    public class ForecastWind
    {
        public float speed { get; set; }
        public int deg { get; set; }
    }

    public class ForecastSys
    {
        public string pod { get; set; }
    }

    public class ForecastCity
    {
        public int id { get; set; }
        public string name { get; set; }
        public ForecastCoordinates coords { get; set; }
        public string country { get; set; }
        public long population { get; set; }
        public int timezone { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }

    }

    public class ForecastCoordinates
    {   
        public double lat { get; set; }
        public double lon { get; set; }
    }
}
