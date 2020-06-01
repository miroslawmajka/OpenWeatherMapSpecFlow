using OpenWeatherMapSpecFlowProject.Handlers;
using TechTalk.SpecFlow;

namespace OpenWeatherMapSpecFlowProject.Hooks
{
    [Binding]
    class BeforeHooks
    {
        [BeforeScenario(Order = 0)]
        public void SetupEnvironmentVariables()
        {
            EnvHandler.SetupEnvVars();
        }
    }
}
