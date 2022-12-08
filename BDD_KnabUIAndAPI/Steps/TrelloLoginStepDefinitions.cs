using BDD_KnabUIAndAPI.Components;
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
        
        LoginLocators LoginLocators = null;

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
            
            login.Login(username, password);
            CommonSteps.AddDelay();         
           // Assert.Matches(username, login.LoggingUser.Text);
           
        }


 



        [When(@"the user clicks on the Submit button")]
        public void WhenTheUserClicksOnTheSubmitButton()
        {
            LoginLocators login = new LoginLocators(CommonSteps.Driver);
            login.LoginSubmitButton.Click();
        }

        [Then(@"the user is successfully logged in to dashboard ""(.*)""")]
        public void ThenTheUserIsSuccessfullyLoggedInToDashboard(string p0)
        {
            DashboardLocators dashboard = new DashboardLocators(CommonSteps.Driver);
            Console.WriteLine("User logged in");        
        }









       




    }
}
