using OpenWeatherMapSpecFlowProject.Model;
using System;

namespace OpenWeatherMapSpecFlowProject.Factories
{
    class ApiRequestFactory
    {
        public ApiRequest GetRequest(RequestBlueprint blueprint)
        {
            switch(blueprint.ServiceName)
            {
                case ForecastRequest.API_SERVICE_NAME:
                    return new ForecastRequest(blueprint.CityName);
                default:
                    throw new ArgumentOutOfRangeException("Service name provided does not exist");
            }
        }
    }
}
