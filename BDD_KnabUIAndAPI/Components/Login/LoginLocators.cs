using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_KnabUIAndAPI.Components
{
    class LoginLocators
    {
       
        public static IWebElement SignInButton = CommonSteps.Driver.FindElement(By.Id("[data-uuid='MJFtCCgVhXrVl7v9HA7EH_login']"));
        public static IWebElement UserNameInput = CommonSteps.Driver.FindElement(By.CssSelector("[name='user'][class='form-field']"));
        public static IWebElement ContinueButton = CommonSteps.Driver.FindElement(By.CssSelector("[type='submit'][class='button account-button button-green btn btn-success']"));
        public static IWebElement LoggingUser = CommonSteps.Driver.FindElement(By.CssSelector("[title='l0g1nt3st@gmail.com'][class='css-18sagaz']"));
        public static IWebElement PasswordInput = CommonSteps.Driver.FindElement(By.CssSelector("[name='password']['class='css-wxvfrp']"));
        public static IWebElement LoginSubmitButton = CommonSteps.Driver.FindElement(By.CssSelector("[id='login-submit'][class='css-19see2r']"));

   

      
    }
}
