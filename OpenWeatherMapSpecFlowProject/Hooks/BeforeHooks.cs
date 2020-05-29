using dotenv.net;
using TechTalk.SpecFlow;

namespace OpenWeatherMapSpecFlowProject.Hooks
{
    [Binding]
    class BeforeHooks
    {
        [BeforeScenario(Order = 0)]
        public void CleanDatabase()
        {
            // Read the OWA_API_ID from the .env file in the running folder (TestResults)
            DotEnv.Config();
        }
    }
}
