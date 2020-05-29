namespace OpenWeatherMapSpecFlowProject.Model
{
    public class ForecastRequest
    {
        private const string API_BASE_URL = "http://api.openweathermap.org/data/2.5/";
        private const string API_SERVICE = "forecast";

        public string URI { get; }

        public ForecastRequest(string city)
        {
            this.URI = $"{API_BASE_URL}/${API_SERVICE}?q=${city}";
        }
    }
}
