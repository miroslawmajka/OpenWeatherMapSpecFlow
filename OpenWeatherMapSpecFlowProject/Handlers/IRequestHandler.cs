using OpenWeatherMapSpecFlowProject.Model;
using System.Threading.Tasks;

namespace OpenWeatherMapSpecFlowProject.Handlers
{
    public interface IRequestHandler
    {
        Task<ForecastResponse> Handle(ApiRequest request);
    }
}
