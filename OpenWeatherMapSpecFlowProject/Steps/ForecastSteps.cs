using dotenv.net;
using OpenWeatherMapSpecFlowProject.Context;
using OpenWeatherMapSpecFlowProject.Handlers;
using OpenWeatherMapSpecFlowProject.Model;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenWeatherMapSpecFlowProject.Steps
{
    [Binding]
    public class ForecastSteps
    {
        private readonly ApiScenarioContext context;

        public ForecastSteps(ApiScenarioContext scenarioContext)
        {
            DotEnv.Config(false);

            context = scenarioContext;
        }

        [Given(@"The API connection is ready")]
        public void GivenTheAPIConnectionIsReady()
        {
            context.Handler = RequestHandler.GetInstance();
        }
        
        [When(@"I query the ""(.*)"" API service for ""(.*)""")]
        public async Task WhenIQueryTheAPIServiceFor(string service, string city)
        {
            var request = new ForecastRequest(city);

            context.ApiResponse = await context.Handler.Handle(request);
        }
        
        [Then(@"The results are returned")]
        public void ThenTheResultsAreReturned()
        {
            // TODO: assert on context.ApiResponse being there as valid JSON
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
