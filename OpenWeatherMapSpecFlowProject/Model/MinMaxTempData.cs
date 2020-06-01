namespace OpenWeatherMapSpecFlowProject.Model
{
    class MinMaxTempData
    {
        public string CityName { get; set; }
        public bool IsMax { get; set; }
        public string Temperature { get; set; }
        public string DayTime { get; set; }

        public override string ToString()
        {
            var minMaxPart = IsMax ? "maximum" : "minimum";

            return $"The {minMaxPart} temperature for {CityName} is {Temperature} at {DayTime}.";
        }
    }
}
