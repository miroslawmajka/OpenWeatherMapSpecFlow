using System.Collections.Generic;

namespace OpenWeatherMapSpecFlowProject.Model
{
    public class ForecastResponse
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }

        // TODO: drill down to the bottom of that JSON
        public List<object> list { get; set; }

        // TODO: map all the fields here
        public object city { get; set; }
    }
}
