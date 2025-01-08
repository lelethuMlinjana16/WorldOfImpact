using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace WOI_Testsuite.BB_Public_Dashboard
{
    [TestFixture]
    public class HC_Dashboard_Testcase : TestBase
    {
        private IWebDriver _driver;
        [SetUp]
        public void StartBrowser()
        {
            if (_driver == null)  // Ensure the driver is initialized
            {
                _driver = SiteConnection();
            }
        }

        [Test, Order(1)]
        public void NavigateToOrganisationalHealthCheck()
        {
            Delay(2); 

            try
            {
               
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));

                var orgHealthCheckLink = _driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div[2]"));

                try
                {
                    orgHealthCheckLink.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    // If click is intercepted, use JavaScript as a fallback
                    IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
                    js.ExecuteScript("arguments[0].click();", orgHealthCheckLink);
                }

                Delay(2); // Wait for the page to load

                // Additional assertions or actions to validate reaching the correct page
                // Assert.IsTrue(_driver.PageSource.Contains("Organisational Health Check"));
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Organisational Health Check link not found on the home page.");
            }
            catch (Exception ex)
            {
                Assert.Fail($"An error occurred: {ex.Message}");
            }
        }

        [Test, Order(2)]
        public void SelectSubcategoryCheckboxes()
        {
            // Ensure that the page has navigated to the Organisational Health Check screen
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"root\"]/div[2]/div[1]/div[2]/ul"))); // Adjust if there’s a different identifier for the section header

            // Locate all checkbox elements for subcategories
            var checkboxes = _driver.FindElements(By.CssSelector("#root > div.app-container > div.component-nav > div.component-nav-item.organisational-health-check.active > ul")); // Adjust selector if needed

            // Iterate over each checkbox and select it if not already selected
            foreach (var checkbox in checkboxes)
            {
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
            }

            // Optional: Verify that all checkboxes are selected
            foreach (var checkbox in checkboxes)
            {
                //Assert.IsTrue(checkbox.Selected, "Checkbox was not selected.");
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}
