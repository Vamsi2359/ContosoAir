using OpenQA.Selenium;
using ContosoAirOperation;

namespace ContosoAirWebPage
{
    /// <summary>
    /// Page class implementation for ContosoAir home page.
    /// </summary>
    public class HomePage : IHomePage
    {
        private readonly IWebDriver _driver;
        private readonly string _url = "http://localhost:3000"; // change if different

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToHomePage()
        {
            _driver.Navigate().GoToUrl(_url);
        }

        public string GetPageTitle()
        {
            return _driver.Title;
        }
    }
}
