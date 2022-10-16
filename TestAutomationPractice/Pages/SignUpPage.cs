﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class SignUpPage
    {
        readonly IWebDriver driver;
        public By signUpaPage = By.Id("account-creation_form");
        public By firstname = By.Id("customer_firstname");
        public By lastname = By.Id("customer_lastname");
        public By password = By.Id("passwd");
        public By address = By.Id("address1");
        public By city = By.Id("city");
        public By state = By.Id("id_state");
        public By zipCode = By.Id("postcode");
        public By phone = By.Id("phone_mobile");
        public By registerbtn = By.Id("submitAccount");

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(signUpaPage));


        }
    }
}
