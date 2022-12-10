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
        public IWebElement LoggingUser => WebDriver.FindElement(By.ClassName("css-18sagaz"));
        public IWebElement PasswordInput => WebDriver.FindElement(By.CssSelector("[class='css-wxvfrp'][name='password']"));
        public IWebElement LoginSubmitButton => WebDriver.FindElement(By.Id("login-submit"));
        public IWebElement LoginError => WebDriver.FindElement(By.Id("login-error"));
             
                      
        public void KeyinUser(string username)
        {
            UserNameInput.SendKeys(username);
            ContinueButton.Click();
            CommonSteps.AddDelay();
            
        }

        public void KeyinPassword(string password)
        {
            PasswordInput.SendKeys(password);
            LoginSubmitButton.Click();
            CommonSteps.AddDelay();
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
