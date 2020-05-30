using System.Web;

namespace OpenWeatherMapSpecFlowProject.Model
{
    public class ForecastRequest : ApiRequest
    {
        private const string API_SERVICE = "forecast";

        public ForecastRequest(string city)
        {
            this.ServiceName = API_SERVICE;

            var queryParams = HttpUtility.ParseQueryString(string.Empty);

            queryParams.Add("q", city);

            this.QueryParams = queryParams;
        }
    }
}
