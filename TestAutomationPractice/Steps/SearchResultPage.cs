using OpenQA.Selenium;

namespace TestAutomationPractice.Steps
{
    internal class SearchResultPage
    {
        private IWebDriver driver;

        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public object SearchResult { get; internal set; }
    }
}