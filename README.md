# BDD_KnabUIAndAPI

This repository is a demonstration of the UI and API tests using the BDD approach. The scenarios considered for automation are the functionalities of Trello application login and Dashboard.

# Project structure:

The UI and API Test automation is carried out in a structured way. 
    # components folder holds the locators for every element that is referenced in the automation scenarios
    # Features folder contains the Specflow Feature files in BDD format each for UI and API tests
    # Shared folder contains the generic functions and the test data used in all the tests
    # Steps folder contains the Step definitions for each specfic feature file

This folder structure when adding more scenarios to automate it is easy to scale and extend within this project structure. The scenarios automated is more of a demonstration to this structure with which it can be extended easily to increase the coverage in every scenario and also add more automated scenarios. 

    In addition, when the business cases are well understood shared folder can be effectively utilized to share generic components for re-use across the project.

# How to install and run the tests 
   
   - Nuget Packages installed:
      Microsoft.Extensions.Configuration.Json
      Microsoft.NET.Test.Sdk
      Selenium.Support
      Selenium.WebDriver
      Selenium.WebDriver.ChromeDriver
      Specflow
      Specflow.Tools.MsBuild.Generation
      SpecFlow.xUnit
      Xunit
      Xunit.core
      Xunit.runner.visualstudio
      Restsharp

   - The tests are using the BDD structure in Given When Then format (for both UI and API tests)

   - The test data can be easily replaced with any specific test data to run the tests

   - Using Visual Studio Test Explorer: When the solution is built successfully all the tests appear in the Test explorer. Here we can run or debug all the tests 

   - The UI tests are configured to run on Firefox browser and can be extended to run on multiple browsers by initiatilizing the driver in the CommonSteps.cs file
  
# Test scenarios 

This project consists of the following automated test scenarios

UI Automation: 

Scenario 1: User logs in using his username and password
Given the user has a valid login credentials
When the user clicks on the Signin button
And the user enters "sashizen@gmail.com" and "Testen01"
And the user clicks on the Submit button 
Then the user is successfully logged in to dashboard "Test Management"

Scenario 2: User logs in with invalid credentials
Given the user enters "sashizen@gmail.com" and "IncorrectPassword"
Then user is denied access

Scenario 3: User adds a task to the board
Given the user is logged in to the dashboard
When user adds a task to the board "Task No:1"
Then the task is added to the board

API Automation:

Scenario 1: Fetch the board of Trello using GetBoard API request
Given the board ID of a specific board
When the get board method is posted for this "id"
Then the response of the API should fetch the details of the board

Scenario 2: Fetch the member boards for the specific user
Given I have the valid credentials 
When calling the get member boards 
Then the repsonse contains all the boards belonging to the user

Scenario 3: To create a new Trello board
Given I have the board name
When I call the Create board API with "Board_name" 
Then the response should be successful

The dliverables for test plan and test cases related to login and dashboard features are available in separate files
