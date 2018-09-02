Feature: apiapplication

@mytag
Scenario: Get API response using given endpoint
	Given I have a enpoint /endpoint/
	When I call a GET method of API
	Then I get API response in JSON format
