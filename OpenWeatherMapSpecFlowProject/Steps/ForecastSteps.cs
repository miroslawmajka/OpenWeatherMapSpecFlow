using Newtonsoft.Json;
using OpenWeatherMapSpecFlowProject.Context;
using OpenWeatherMapSpecFlowProject.Handlers;
using OpenWeatherMapSpecFlowProject.Model;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenWeatherMapSpecFlowProject.Steps
{
    [Binding]
    public class ForecastSteps
    {
        private readonly ApiScenarioContext context;

        public ForecastSteps()
        {
            context = new ApiScenarioContext();
        }

        [Given(@"The API connection is ready")]
        public void GivenTheAPIConnectionIsReady()
        {
            context.ApiRequestHandler = new RequestHandler(EnvHandler.OWA_API_ID);
        }
        
        [When(@"I query the ""(.*)"" API service for ""(.*)""")]
        public async Task WhenIQueryTheAPIServiceFor(string service, string city)
        {
            var request = new ForecastRequest(city);

            context.ApiResponse = await context.ApiRequestHandler.Handle(request);
        }
        
        [Then(@"The results are returned")]
        public void ThenTheResultsAreReturned()
        {
            // TODO: assert on context.ApiResponse being there as valid JSON

            Console.WriteLine(JsonConvert.SerializeObject(context.ApiResponse));
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
