Feature: Trelo API tests
	Test to validate the end points for Trello dashboard

@APITest
Scenario: Fetch the member of Trello using GetMember API request
Given the "id" of the user
When the get method is posted for this "id"
Then the response of the API should fetch the details of the member

Scenario: Fetch the member boards for the specific user
Given I have the valid credentials 
When calling the get method with key "API_KEY" and token "API_TOKEN"
Then the repsonse contains all the boards