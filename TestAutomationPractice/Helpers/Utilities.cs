using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Helpers
{
    public class Utilities
    {

        readonly IWebDriver driver;
        private static readonly Random RandomName = new Random();


        public Utilities(IWebDriver driver)
        {

            this.driver = driver;

        }

        public string GenerateRandomEmail()
        { 
            return string.Format("email{0}@mailnator.com", RandomName.Next(10000, 100000));
        }

        internal void EnterTextInElement(By searchField, object term)
        {
            throw new NotImplementedException();
        }

        internal void ClickOnElement(HomePage hp, object searchBtn)
        {
            throw new NotImplementedException();
        }

        public void ClickOnElement(By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)).Click();

        }

        internal string ReturnTextFromElement(object searchResult)
        {
            throw new NotImplementedException();
        }

        internal void DropdownSelect(object subjectHeading)
        {
            throw new NotImplementedException();
        }

        public void DropdownSelect(By select, string option)
        {
         
            WebDriverWait wait= new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(select));
            var dropdown = driver.FindElement(select);
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(option);

        }
            
        public void EnterTextInElement(By locator, string text)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);

        }

        public string ReturnTextFromElement(By locator)
        {
            return driver.FindElement(locator).GetAttribute("textContent");

        }

         public bool ElementIsDisplayed(By locator) 
         {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).Displayed;
         }
    }




}
