namespace OpenWeatherMapSpecFlowProject.Model
{
    class DayTempData
    {
        public string CityName { get; set; }
        public string Description { get; set; }
        public string Temperature { get; set; }
        public string DayTime { get; set; }

        public override string ToString()
        {
            return $"The {Description} for {CityName} is {DayTime} with temperature of {Temperature}.";
        }
    }
}
