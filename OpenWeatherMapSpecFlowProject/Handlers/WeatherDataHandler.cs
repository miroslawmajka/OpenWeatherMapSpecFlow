using OpenWeatherMapSpecFlowProject.Model;

namespace OpenWeatherMapSpecFlowProject.Handlers
{
    class WeatherDataHandler
    {
        internal DayTempData GetHottestDayFor(ForecastResponse responseData)
        {
            var temperature = "<TODO:hottest-temp-value>";
            var dayDate = "<TODO:hottest-day>";

            // TODO: calculate both values

            return new DayTempData
            {
                CityName = responseData.city.name,
                Description = "hottest day and time",
                Temperature = temperature,
                DayTime = dayDate
            };
        }

        internal MinMaxTempData GetMinTempFor(ForecastResponse responseData)
        {
            var temperature = "<TODO:min-temp-value>";
            var dayDate = "<TODO:min-temp-day>";

            // TODO: calculate both values

            return new MinMaxTempData
            {
                CityName = responseData.city.name,
                Temperature = temperature,
                IsMax = false,
                DayTime = dayDate
            };
        }

        internal MinMaxTempData GetMaxTempFor(ForecastResponse responseData)
        {
            var temperature = "<TODO:max-temp-value>";
            var dayDate = "<TODO:max-temp-day>";

            // TODO: calculate both values

            return new MinMaxTempData
            {
                CityName = responseData.city.name,
                Temperature = temperature,
                IsMax = true,
                DayTime = dayDate
            };
        }
    }
}
