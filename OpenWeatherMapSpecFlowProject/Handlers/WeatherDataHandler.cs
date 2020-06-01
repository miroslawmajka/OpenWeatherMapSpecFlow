using OpenWeatherMapSpecFlowProject.Model;
using System;

namespace OpenWeatherMapSpecFlowProject.Handlers
{
    class WeatherDataHandler
    {
        private const double KELVIN_TO_CELSIUS = 273.15;

        internal DayTempData GetHottestDayFor(ForecastResponse responseData)
        {
            double highestTemp = double.MinValue;
            long highestTimestamp = long.MinValue;

            foreach (var forecastPeriod in responseData.list)
            {
                if (forecastPeriod.main.temp > highestTemp)
                {
                    highestTemp = forecastPeriod.main.temp;
                    highestTimestamp = forecastPeriod.dt;
                }
            }

            return new DayTempData
            {
                CityName = responseData.city.name,
                Description = "hottest day and time",
                Temperature = GetTempInCelsiusFromKelvin(highestTemp),
                DayTime = GetDayTimeDescription(highestTimestamp)
            };
        }

        internal MinMaxTempData GetMinTempFor(ForecastResponse responseData)
        {
            double minTemp = double.MaxValue;
            long minTimestamp = long.MinValue;

            foreach (var forecastPeriod in responseData.list)
            {
                if (forecastPeriod.main.temp < minTemp)
                {
                    minTemp = forecastPeriod.main.temp;
                    minTimestamp = forecastPeriod.dt;
                }
            }

            return new MinMaxTempData
            {
                CityName = responseData.city.name,
                IsMax = false,
                Temperature = GetTempInCelsiusFromKelvin(minTemp),
                DayTime = GetDayTimeDescription(minTimestamp)
            };
        }

        internal MinMaxTempData GetMaxTempFor(ForecastResponse responseData)
        {
            double maxTemp = double.MinValue;
            long maxTimestamp = long.MinValue;

            foreach (var forecastPeriod in responseData.list)
            {
                if (forecastPeriod.main.temp > maxTemp)
                {
                    maxTemp = forecastPeriod.main.temp;
                    maxTimestamp = forecastPeriod.dt;
                }
            }

            return new MinMaxTempData
            {
                CityName = responseData.city.name,
                IsMax = true,
                Temperature = GetTempInCelsiusFromKelvin(maxTemp),
                DayTime = GetDayTimeDescription(maxTimestamp)
            };
        }

        private string GetTempInCelsiusFromKelvin(double kelvinTemp)
        {
            var celsiusTemp = kelvinTemp - KELVIN_TO_CELSIUS;

            return string.Format("{0:N1} celsius", celsiusTemp);
        }

        private string GetDayTimeDescription(long unixDate)
        {
            var unixStartTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            var calculatedTime = unixStartTime.AddSeconds(unixDate);

            var dayName = calculatedTime.DayOfWeek.ToString();
            var dayDate = calculatedTime.ToString("dd/MM/yyyy HH:mm UTC");

            return $"{dayName} ({dayDate})";
        }
    }
}
