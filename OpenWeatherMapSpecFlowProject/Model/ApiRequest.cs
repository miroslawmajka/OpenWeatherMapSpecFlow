namespace OpenWeatherMapSpecFlowProject.Model
{
    public abstract class ApiRequest
    {
        protected const string API_BASE_URL = "http://api.openweathermap.org/data/2.5/";

        public string URI { get; protected set; }
    }
}
