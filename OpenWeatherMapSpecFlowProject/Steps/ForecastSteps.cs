using System;
using TechTalk.SpecFlow;

namespace OpenWeatherMapSpecFlowProject.Steps
{
    [Binding]
    public class ForecastSteps
    {
        [Given(@"The API connection is ready")]
        public void GivenTheAPIConnectionIsReady()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I query the ""(.*)"" API service for ""(.*)""")]
        public void WhenIQueryTheAPIServiceFor(string service, string city)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The results are returned")]
        public void ThenTheResultsAreReturned()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The results are saved")]
        public void ThenTheResultsAreSaved()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The the hottest day for ""(.*)"" is determined")]
        public void ThenTheTheHottestDayForIsDetermined(string city)
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"The ""(.*)"" temperature is determined from the results")]
        public void ThenTheTemperatureIsDeterminedFromTheResults(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
