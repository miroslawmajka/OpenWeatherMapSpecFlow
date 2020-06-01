using System.Collections.Specialized;

namespace OpenWeatherMapSpecFlowProject.Model
{
    public abstract class ApiRequest
    {
        // This could be in a static class elsewhere as a common source of truth
        private const string OWA_URL = "http://api.openweathermap.org/data/2.5/";

        public string ApiUrl { get { return OWA_URL;  } }
        public string ServiceName { get; protected set; }
        public NameValueCollection QueryParams { get; protected set; }
    }
}
