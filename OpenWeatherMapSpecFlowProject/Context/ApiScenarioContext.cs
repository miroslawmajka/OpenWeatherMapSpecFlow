using OpenWeatherMapSpecFlowProject.Handlers;
using OpenWeatherMapSpecFlowProject.Model;
using TechTalk.SpecFlow;

namespace OpenWeatherMapSpecFlowProject.Context
{
    public class ApiScenarioContext
    {
        public ForecastResponse ApiResponse { get; set; }
        public IRequestHandler Handler { get; set; }
    }
}
