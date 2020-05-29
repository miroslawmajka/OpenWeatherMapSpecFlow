using OpenWeatherMapSpecFlowProject.Model;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenWeatherMapSpecFlowProject.Handlers
{
    public interface IRequestHandler
    {
        Task<ForecastResponse> Handle(ForecastRequest request, HttpClient httpClient = null);
    }
}
