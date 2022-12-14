using BDD_KnabUIAndAPI.Components;
using BDD_KnabUIAndAPI.Shared;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BDD_KnabUIAndAPI.Steps
{
    [Binding]
    public sealed class TrelloLoginStepDefinitions
    {
      [BeforeScenario]

        public void BeforeScenario()
        {
            
            CommonSteps.InitializeTest();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
            CommonSteps.EndTest();
        }
//Scenario 1:
        [Given(@"the user has a valid login credentials")]
        public void GivenTheUserHasAValidLoginCredentials()
        {
           
        }


        [When(@"the user clicks on the Signin button")]
        public void WhenTheUserClicksOnTheSigninButton()
        {      
            LoginLocators login = new LoginLocators(CommonSteps.Driver);
            login.SigninClick();
        }


        [When(@"the user enters ""(.*)"" and ""(.*)""")]
        public void WhenTheUserEntersAnd(string username, string password)
        {
            LoginLocators login = new LoginLocators(CommonSteps.Driver);
            login.KeyinUser(username);
            CommonSteps.AddDelay();
            String actual = login.LoggingUser.Text;
            Assert.Equal(username, actual);
            login.KeyinPassword(password);
            
            
        }

        [When(@"the user clicks on the Submit button")]
        public void WhenTheUserClicksOnTheSubmitButton()
        {
            LoginLocators login = new LoginLocators(CommonSteps.Driver);
            login.LoginSubmitButton.Click();
        }

        [Then(@"the user is successfully logged in to dashboard ""(.*)""")]
        public void ThenTheUserIsSuccessfullyLoggedInToDashboard(string dashboardTitle)
        {
            DashboardLocators dashboard = new DashboardLocators(CommonSteps.Driver);
            var actualTitle = dashboard.DashboardTitle.Text;
            Assert.Equal(dashboardTitle, actualTitle);
          
        }

//Scenario 2:

        [Given(@"the user enters ""(.*)"" and ""(.*)""")]
        public void GivenTheUserEntersAnd(string username, string password)
        {
            LoginLocators login = new LoginLocators(CommonSteps.Driver);
            login.SigninClick();
            login.KeyinUser(username);
            login.KeyinPassword(password);
            CommonSteps.AddDelay();
        }

        [Then(@"user is denied access")]
        public void ThenUserIsDeniedAccess()
        {
            LoginLocators login = new LoginLocators(CommonSteps.Driver);
            Assert.NotNull(login.LoginError);
        }


//Scenario 3: 

        [Given(@"the user is logged in to the dashboard")]
        public void GivenTheUserIsLoggedInToTheDashboard()
        {

           // this.GivenTheUserEntersAnd(); - Can also reuse the complete steps in other scenarios, with minor modifications. 
            LoginLocators login = new LoginLocators(CommonSteps.Driver);
            login.SigninClick();
            login.KeyinUser(TestData.Username);
            login.KeyinPassword(TestData.Password);
            
        }

        [When(@"user adds a task to the board ""(.*)""")]
        public void WhenUserAddsATaskToTheBoard(string task)
        {
           DashboardLocators dashboard = new DashboardLocators(CommonSteps.Driver);
            dashboard.SelectAndOpenBoard();
            dashboard.AddDashboardCard();
           

        }

        [Then(@"the task is added to the board")]
        public void ThenTheTaskIsAddedToTheBoard()
        {
            
        }
    }
}
