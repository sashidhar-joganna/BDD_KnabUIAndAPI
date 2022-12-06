Feature: TrelloLogin
	Land on the Trello home page and click on sign in button

@mytag
Scenario: User logs in using his username and password
Given the user has a valid login credentials
When the user clicks on the "Login" button
And the user enters "Username" and "Password"
| Username            | Password |
| l0gint3st@gmail.com | Testen01 |
And the user clicks on the "LoginSubmit" button 
Then the user is successfully logged in to dashboard "QA Automation"
