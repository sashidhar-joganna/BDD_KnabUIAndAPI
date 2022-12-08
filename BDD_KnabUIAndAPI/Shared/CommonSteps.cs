using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_KnabUIAndAPI
{
    public static class CommonSteps
    {
        public static int Timeout = 40;

        public static IWebDriver Driver { get; set; }

        public static void InitializeTest()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("http://trello.com");
            Driver.Manage().Window.Maximize();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Timeout);
        }



        public static void EndTest()
        {
            
            Driver.Close();
        }

        public static void AddDelay()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Timeout);
        }
    }
}
