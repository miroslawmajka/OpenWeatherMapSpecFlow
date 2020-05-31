using OpenWeatherMapSpecFlowProject.Handlers;
using OpenWeatherMapSpecFlowProject.Model;
using System.Collections.Generic;

namespace OpenWeatherMapSpecFlowProject.Context
{
    public class ApiScenarioContext
    {
        public Dictionary<string,ForecastResponse> ApiResponses { get; }
        public IRequestHandler ApiRequestHandler { get; set; }

        public ApiScenarioContext()
        {
            ApiResponses = new Dictionary<string, ForecastResponse>();
        }

        public void AddOrReplaceApiResponse(string city, ForecastResponse response)
        {
            if (ApiResponses.ContainsKey(city))
            {
                ApiResponses.Remove(city);
            }

            ApiResponses.Add(city, response);
        }
    }
}
