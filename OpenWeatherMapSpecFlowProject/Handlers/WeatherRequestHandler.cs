using Newtonsoft.Json;
using OpenWeatherMapSpecFlowProject.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenWeatherMapSpecFlowProject.Handlers
{
    /// <summary>
    /// Using IRequestHandler interface in case we want to mock this one out for unit testing
    /// or use a different handler in the future
    /// </summary>
    public class WeatherRequestHandler : IRequestHandler
    {
        private readonly string appId;

        public WeatherRequestHandler(string appId)
        {
            this.appId = appId;
        }

        public async Task<ForecastResponse> Handle(ApiRequest request)
        {
            var queryParams = request.QueryParams;

            queryParams.Add("appid", this.appId);

            var queryString = queryParams.ToString();

            var requestUrl = $"{request.ApiUrl}/{request.ServiceName}?{queryString}";

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(requestUrl)
            };

            string responseString = string.Empty;

            using (var httpClient = new HttpClient())
            { 
                var callResponse = await httpClient.SendAsync(requestMessage);

                responseString = await callResponse.Content.ReadAsStringAsync();
            }

            if (string.IsNullOrWhiteSpace(responseString))
            {
                throw new Exception("Received empty string from the API");
            }

            return JsonConvert.DeserializeObject<ForecastResponse>(responseString);
        }
    }
}
