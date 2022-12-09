Feature: TrelloLogin
	Land on the Trello home page and click on sign in button

@mytag
Scenario: User logs in using his username and password
Given the user has a valid login credentials
When the user clicks on the Signin button
And the user enters "sashizen@gmail.com" and "Testen01"
And the user clicks on the Submit button 
Then the user is successfully logged in to dashboard "Test Management"

Scenario: User logs in with invalid credentials
Given the user enters "sashizen@gmail.com" and "IncorrectPassword"
Then user is denied access

Scenario: User adds a task to the board
Given the user is logged in to the dashboard
When user adds a task to the board "Task No:1"
Then the task is added to the board

