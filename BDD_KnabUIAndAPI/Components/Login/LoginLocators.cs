using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BDD_KnabUIAndAPI.Components
{
     class LoginLocators
    {
        public IWebDriver WebDriver { get; }
        
        public LoginLocators(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebDriver? Driver { get; set; }

        public IWebElement SignInButton => WebDriver.FindElement(By.CssSelector("[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']"));
        public IWebElement UserNameInput => WebDriver.FindElement(By.CssSelector("[name='user'][class='form-field']"));
        public IWebElement ContinueButton => WebDriver.FindElement(By.CssSelector("[value='Continue']"));
        public IWebElement LoggingUser => WebDriver.FindElement(By.CssSelector("[class='username-readonly']"));
        public IWebElement PasswordInput => WebDriver.FindElement(By.Id("password"));
        public IWebElement LoginSubmitButton => WebDriver.FindElement(By.Id("login-submit"));
        public IWebElement BtnLoginAtlassian => WebDriver.FindElement(By.XPath("//input[@value='Log in with Atlassian']"));
             
                      
        public void WrongLogin(string username, string password)
        {
            UserNameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginSubmitButton.Click();
        }

       public void Login(string username, string password)
        {
            UserNameInput.SendKeys(username);
            ContinueButton.Click();
            PasswordInput.SendKeys(password);
            LoginSubmitButton.Click();
        }

        public void SigninClick()
        {
            if (SignInButton != null)
            {
                SignInButton.Click();
            }
        }
     

    }
}
