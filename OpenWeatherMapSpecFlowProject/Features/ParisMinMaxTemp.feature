Feature: ParisMinMaxTemp
	As an automation engineer 
	I want to ensure that the forecast API service
	Provides data for the 5 in city of Paris along with the lowest and highest temperatures

@ParisMinMaxTemp
Scenario: Get the forecast for Paris and determine the maximum and minimum temperature over that time
	Given The API connection is ready

	When I query the "forecast" API service for "Paris"
	Then The results are returned
	And The "minimum" temperature is determined from the results
	And The "maximum" temperature is determined from the results
