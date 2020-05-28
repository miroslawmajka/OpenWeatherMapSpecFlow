Feature: FiveCityForecast
	As an automation engineer 
	I want to ensure that the forecast API service
	Provides data for 5 days along with the maximum temperature value

@FiveCityForecast
Scenario: Get the forecast for 5 cities and get the hottest day for eaceh city
	Given The API connection is ready

	When I query the "forecast" API service for "Dundee"
	Then The results are returned
	And The results are saved

	When I query the "forecast" API service for "London"
	Then The results are returned
	And The the hottest day for "London" is determined

	When I query the "forecast" API service for "Warsaw"
	Then The results are returned
	And The the hottest day for "Warsaw" is determined

	When I query the "forecast" API service for "Tokyo"
	Then The results are returned
	And The the hottest day for "Tokyo" is determined

	When I query the "forecast" API service for "New York"
	Then The results are returned
	And The the hottest day for "New York" is determined
