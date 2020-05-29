using System.Web;

namespace OpenWeatherMapSpecFlowProject.Model
{
    public class ForecastRequest : ApiRequest
    {
        private const string API_SERVICE = "forecast";

        public ForecastRequest(string city, string apiId)
        {
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            queryString.Add("q", city);
            queryString.Add("appid", apiId);

            var queryStringPart = queryString.ToString();

            this.URI = $"{API_BASE_URL}/{API_SERVICE}?{queryStringPart}";
        }
    }
}
