using BDD_KnabUIAndAPI.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace BDD_KnabUIAndAPI
{
    [Binding]
    public sealed class TrelloLoginStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        public static IWebDriver Driver {get; set;}
        public static int Timeout = 30;

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
            LoginLocators.SignInButton.Click();
        }

        [When(@"the user enters ""(.*)"" and ""(.*)""")]
        public void WhenTheUserEntersAnd(string userName, string password)
        {
            //LoginLocators.UserNameInput.SendKeys(userName);
            //LoginLocators.ContinueButton.Click();
            //Assert.Equal(userName, LoginLocators.LoggingUser.Text);
            //LoginLocators.PasswordInput.SendKeys(password);
        }

        [When(@"the user clicks on the Submit button")]
        public void WhenTheUserClicksOnTheSubmitButton()
        {
            //LoginLocators.LoginSubmitButton.Click();
        }

        [Then(@"the user is successfully logged in to dashboard ""(.*)""")]
        public void ThenTheUserIsSuccessfullyLoggedInToDashboard(string p0)
        {
            //Console.WriteLine("User logged in");        
        }









       




    }
}
