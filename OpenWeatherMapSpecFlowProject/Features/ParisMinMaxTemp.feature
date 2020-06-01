Feature: ParisMinMaxTemp
	As an automation engineer 
	I want to ensure that the forecast API service
	Provides data for the 5 in city of Paris along with the lowest and highest temperatures

Background: Setup the HTTP client with the API ID
	Given The API connection is ready

@ParisMinMaxTemp
Scenario: Get the forecast for Paris and determine the maximum and minimum temperature over that time
	When I query the "forecast" API service for "Paris"
	Then The results are returned for "Paris"
	And The "minimum" temperature is determined for "Paris"
	And The "maximum" temperature is determined for "Paris"
