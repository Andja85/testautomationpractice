using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);
       

        [Given(@"User opens contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            ut.ClickOnElement(hp.contacUS);
        }
        
        [When(@"User fill in required fields field with ""(.*)"" reading ""(.*)"" massage")]
        public void GivenUserFillInRequiredFieldsFieldWithReadingMassage(string heading, string message)
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.DropdownSelect(cup.subjectHeading, heading);
            ut.EnterTextInElement(cup.contactEmail, ut.GenerateRandomEmail());
            ut.EnterTextInElement(cup.message, message);
        }

        
        [When(@"user submits the form")]
        public void WhenUserSubmitsTheform()
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.ClickOnElement(cup.sendBtn);
        }
        
        [Then(@"massage ""(.*)"" is presented to the user")]
        public void ThenMassageIsePresentedToTheUser(string successMessage)
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            Assert.That(ut.ReturnTextFromElement(cup.successMessage), Is.EqualTo(successMessage), "Message was not sent to customer service");
        }
    }
}
