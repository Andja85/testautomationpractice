using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Steps
{
    [Binding]
    public class FooterSteps : Base
    {
        FooterPage fp = new FooterPage(Driver);
             
        [When(@"user clicks on 'Specials"" option")]
        public void WhenUserClicksOnSpecialsOption(string link)
        {
            fp.ClickOnInformtionLink(link);
        }
        
        [Then(@"correct 'Price drop"" is displayed")]
        public void ThenCorrectPriceDropIsDisplayed(string page)
        {
            Assert.True(fp.InformationPageIsDisplayed(page),"Expected page is NOT displayed");
        }
    }
}
