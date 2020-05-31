using Newtonsoft.Json;
using OpenWeatherMapSpecFlowProject.Context;
using OpenWeatherMapSpecFlowProject.Factories;
using OpenWeatherMapSpecFlowProject.Handlers;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenWeatherMapSpecFlowProject.Steps
{
    [Binding]
    public class ForecastSteps
    {
        private readonly ApiScenarioContext context;
        private readonly ApiRequestFactory apiRequestFactory;

        public ForecastSteps()
        {
            context = new ApiScenarioContext();
            apiRequestFactory = new ApiRequestFactory();
        }

        [Given(@"The API connection is ready")]
        public void GivenTheAPIConnectionIsReady()
        {
            context.ApiRequestHandler = new RequestHandler(EnvHandler.OWA_API_ID);
        }
        
        [When(@"I query the ""(.*)"" API service for ""(.*)""")]
        public async Task WhenIQueryTheAPIServiceFor(string service, string city)
        {
            var request = apiRequestFactory.GetRequest(new RequestBlueprint
            {
                ServiceName = service,
                City = city
            });

            var response = await context.ApiRequestHandler.Handle(request);

            if (context.ApiResponses.ContainsKey(city))
            {
                context.ApiResponses.Remove(city);
            }

            context.ApiResponses.Add(city, response);
        }
        
        [Then(@"The results are returned for ""(.*)""")]
        public void ThenTheResultsAreReturned(string city)
        {
            // TODO: assert on context.ApiResponse being there as valid JSON

            Console.WriteLine(JsonConvert.SerializeObject(context.ApiResponses[city]));
        }
        
        [Then(@"The the hottest day for ""(.*)"" is determined")]
        public void ThenTheTheHottestDayForIsDetermined(string city)
        {
            // TODO: anaylse the JSON data and figure the hottest day
        }

        [Then(@"The ""(.*)"" temperature is determined from the results")]
        public void ThenTheTemperatureIsDeterminedFromTheResults(string minMaxTemp)
        {
            //  TODO: anaylse the JSON data and figure the min/max temp
        }
    }
}
