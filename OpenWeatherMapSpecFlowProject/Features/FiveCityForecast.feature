Feature: FiveCityForecast
	As an automation engineer 
	I want to ensure that the forecast API service
	Provides data for 5 days along with the maximum temperature value

Background: Setup the HTTP client with the API ID
	Given The API connection is ready

@FiveCityForecast
Scenario Outline: Get the forecast for 5 cities and get the hottest day for each city
	When I query the "forecast" API service for "<city>"
	Then The results are returned for "<city>"
	And The hottest day for "<city>" is determined

	Examples:
		| city     |
		| Dundee   |
		| London   |
		| Warsaw   |
		| Tokyo    |
		| New York |