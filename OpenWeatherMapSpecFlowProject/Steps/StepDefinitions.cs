using FluentAssertions;
using OpenWeatherMapSpecFlowProject.Context;
using OpenWeatherMapSpecFlowProject.Factories;
using OpenWeatherMapSpecFlowProject.Handlers;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenWeatherMapSpecFlowProject.Steps
{
    [Binding]
    public class StepDefinitions
    {
        // TODO: figure out how to acccess scenario context between different step definition files/classes
        private readonly ApiScenarioContext context;
        private readonly ApiRequestFactory apiRequestFactory;
        private readonly WeatherDataHandler weatherDataHandler;

        public StepDefinitions()
        {
            context = new ApiScenarioContext();
            apiRequestFactory = new ApiRequestFactory();
            weatherDataHandler = new WeatherDataHandler();
        }

        [Given(@"The API connection is ready")]
        public void GivenTheAPIConnectionIsReady()
        {
            context.ApiRequestHandler = new RequestHandler(EnvHandler.OWA_API_ID);
        }
        
        [When(@"I query the ""(.*)"" API service for ""(.*)""")]
        public async Task WhenIQueryTheAPIServiceFor(string service, string cityName)
        {
            var request = apiRequestFactory.GetRequest(new RequestBlueprint
            {
                ServiceName = service,
                CityName = cityName
            });

            var response = await context.ApiRequestHandler.Handle(request);

            context.AddOrReplaceApiResponse(cityName, response);
        }
        
        [Then(@"The results are returned for ""(.*)""")]
        public void ThenTheResultsAreReturned(string cityName)
        {
            context.ApiResponses.Should().ContainKey(cityName);

            context.ApiResponses[cityName].Should().NotBeNull();
            context.ApiResponses[cityName].city.Should().NotBeNull();
            context.ApiResponses[cityName].city.name.Should().NotBeNull();
            context.ApiResponses[cityName].city.name.Should().BeEquivalentTo(cityName);
        }
        
        [Then(@"The hottest day is determined for ""(.*)""")]
        public void ThenTheHottestDayForIsDetermined(string cityName)
        {
            var responseData = context.ApiResponses[cityName];

            var hottestDayData = weatherDataHandler.GetHottestDayFor(responseData);

            Console.WriteLine(hottestDayData.ToString());
        }

        [Then(@"The ""(.*)"" temperature is determined for ""(.*)""")]
        public void ThenTheTemperatureIsDeterminedFromTheResults(string minMaxTemp, string cityName)
        {
            var responseData = context.ApiResponses[cityName];

            object temperatureData;

            if (minMaxTemp == "minimum")
            {
                temperatureData = weatherDataHandler.GetMinTempFor(responseData);
            } else
            {
                temperatureData = weatherDataHandler.GetMaxTempFor(responseData);
            }

            Console.WriteLine(temperatureData.ToString());
        }
    }
}
