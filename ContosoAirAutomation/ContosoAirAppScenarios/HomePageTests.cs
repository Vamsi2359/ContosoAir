using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ContosoAirOperation;
using ContosoAirWebPage;

namespace ContosoAirAppScenarios
{
    /// <summary>
    /// Test cases for ContosoAir Home Page.
    /// </summary>
    [TestFixture]
    public class HomePageTests
    {
        private IWebDriver _driver;
        private IHomePage _homePage;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _homePage = new HomePage(_driver);
        }

        [Test]
        public void HomePage_Title_ShouldBeCorrect()
        {
            // Arrange & Act
            _homePage.NavigateToHomePage();
            string title = _homePage.GetPageTitle();

            // Assert
            Assert.AreEqual("Contoso Air", title, "Page title does not match");
        }

        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();      // Close the browser
                _driver.Dispose();   // Release all resources
            }
        }

    }
}
