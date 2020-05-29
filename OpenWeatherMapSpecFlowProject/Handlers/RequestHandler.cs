using Newtonsoft.Json;
using OpenWeatherMapSpecFlowProject.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenWeatherMapSpecFlowProject.Handlers
{
    public class RequestHandler : IRequestHandler
    {
        public async Task<ForecastResponse> Handle(ForecastRequest request, HttpClient httpClient = null)
        {
            using (httpClient != null ? httpClient : httpClient = new HttpClient())
            {
                return await CallApiEndpoint(httpClient, request);
            }
        }

        private async Task<ForecastResponse> CallApiEndpoint(HttpClient httpClient, ForecastRequest request)
        {
            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(request.URI)
            };

            var callResponse = await httpClient.SendAsync(requestMessage);

            var callResponseAsString = await callResponse.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ForecastResponse>(callResponseAsString);
        }
    }
}
