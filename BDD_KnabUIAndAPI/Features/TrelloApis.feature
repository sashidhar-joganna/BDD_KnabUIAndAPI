Feature: Trelo API tests
	Test to validate the end points for Trello dashboard

@APITest
Scenario: Fetch the board of Trello using GetBoard API request
Given the board ID of a specific board
When the get board method is posted for this "id"
Then the response of the API should fetch the details of the board

Scenario: Fetch the member boards for the specific user
Given I have the valid credentials 
When calling the get member boards 
Then the repsonse contains all the boards belonging to the user

Scenario: To create a new Trello board
Given I have the board name
When I call the Create board API with "Board_name" 
Then the response should be successful
