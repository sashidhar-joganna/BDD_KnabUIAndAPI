using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using BDD_KnabUIAndAPI.Shared;

namespace BDD_KnabUIAndAPI.Components
{
    class DashboardLocators
    {
        public IWebDriver WebDriver { get; }

        public DashboardLocators(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public  IWebElement QA_Autmation_Workspace => WebDriver.FindElement(By.CssSelector("[class='boards-page-board-section-header-name']"));
        public  IWebElement CreateBoard => WebDriver.FindElement(By.CssSelector("[class='board-tile mod-add']"));
        public  IWebElement BoardTitleInput => WebDriver.FindElement(By.CssSelector("[data-testid='create-board-title-input']"));
        public  IWebElement CreateBoardButton => WebDriver.FindElement(By.CssSelector("[data-testid='create-board-submit-button']"));
       }
}
