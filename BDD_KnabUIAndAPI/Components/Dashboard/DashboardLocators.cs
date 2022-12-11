using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using BDD_KnabUIAndAPI.Shared;

namespace BDD_KnabUIAndAPI.Components
{
    public class DashboardLocators
    {
        public IWebDriver WebDriver { get; }

        public DashboardLocators(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebDriver? Driver { get; set; }

        public IWebElement QA_Autmation_Workspace => WebDriver.FindElement(By.CssSelector("[class='boards-page-board-section-header-name']"));
        public IWebElement DashboardTitle => WebDriver.FindElement(By.CssSelector("[class='board-tile-details-name']"));

        public IWebElement DashboardTile => WebDriver.FindElement(By.ClassName("boards-page-board-section-list-item"));
        public IWebElement CreateBoard => WebDriver.FindElement(By.CssSelector("[class='board-tile mod-add']"));
        public IWebElement BoardTitleInput => WebDriver.FindElement(By.CssSelector("[data-testid='create-board-title-input']"));
        public IWebElement CreateBoardButton => WebDriver.FindElement(By.CssSelector("[data-testid='create-board-submit-button']"));

        public IWebElement AddNewCard => WebDriver.FindElement(By.ClassName("js-add-a-card"));

        public IWebElement NewCardName => WebDriver.FindElement(By.CssSelector("[class='list-card-composer-textarea js-card-title']"));

        
        public IWebElement AddCard => WebDriver.FindElement(By.CssSelector("[type='submit'][value='Add card']"));

    public void SelectAndOpenBoard()
        {
            DashboardTile.Click();
        }

    public void AddDashboardCard()
        {
            AddNewCard.Click();
            NewCardName.SendKeys("Task-Testing");
            AddCard.Click();
        }
    }
}