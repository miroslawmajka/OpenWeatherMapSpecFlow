using OpenWeatherMapSpecFlowProject.Handlers;
using OpenWeatherMapSpecFlowProject.Model;

namespace OpenWeatherMapSpecFlowProject.Context
{
    public class ApiScenarioContext
    {
        public ForecastResponse ApiResponse { get; set; }
        public IRequestHandler ApiRequestHandler { get; set; }
    }
}
