using System.Web;

namespace OpenWeatherMapSpecFlowProject.Model
{
    public class ForecastRequest : ApiRequest
    {
        public const string API_SERVICE_NAME = "forecast";

        public ForecastRequest(string city)
        {
            this.ServiceName = API_SERVICE_NAME;

            var queryParams = HttpUtility.ParseQueryString(string.Empty);

            queryParams.Add("q", city);

            this.QueryParams = queryParams;
        }
    }
}
