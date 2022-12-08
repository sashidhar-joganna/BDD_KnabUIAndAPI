using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BDD_KnabUIAndAPI.Components.Tasks
{
    class TaskBoardLocators
    {
        public IWebDriver WebDriver { get; }

        public TaskBoardLocators(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public  IWebElement AddTaskTitle => WebDriver.FindElement(By.CssSelector("[class='list-card-composer-textarea js-card-title']"));
        public  IWebElement AddTaskButton => WebDriver.FindElement(By.CssSelector("[type='submit']['value='Add card']"));
        
    }
}
