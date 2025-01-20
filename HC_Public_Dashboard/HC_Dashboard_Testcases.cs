using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOI_Testsuite.HC_Public_Dashboard
{
    [TestFixture]

    public class HC_Dashboard_Testcases : TestBase
    {

        private WebDriverWait _wait;

        [SetUp]
        public void StartBrowser()
        {
            _driver = base.SiteConnection();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            _driver.Url = "https://woi-sit.azurewebsites.net/";
            _driver.Manage().Window.Maximize();
        }


        public static bool Test_SelectCrimeDashboard_Completed = false;

        [Test, Order(1)]
        public void Test_SelectHCDashboardView()
        {
            // Wait for the overlay to disappear if present
            try
            {
                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }

            // The Map View

            // Click on the first element in the dashboard using JavaScript click as a fallback
            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[1]/a/")));
            try
            {
                firstElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick);
            }


            // Click on the desired input element
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[2]/ul/li[5]/label/input")));
            try
            {
                inputElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            }

            // Optionally, add verification if needed
            Assert.That(inputElementToClick.Selected, Is.True, "The input element was not successfully selected.");

            // Locate and click the specific element
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[1]/ul/li[2]/ul/li[4]/label")));
            try
            {
                specificLabel.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificLabel);
            }



            // Navigate to the desired element (Dropdown Button)
            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[3]/nav/ul/li[4]/div/button/div/span")));
            try
            {
                specificElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            }

            // Wait for the dropdown to be visible
            IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[4]/div/button/div")));

            // Select the "Northern Cape" option from the dropdown
            IWebElement northernCapeOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Northern Cape']")));
            try
            {
                northernCapeOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", northernCapeOption);
            }

            // Verify the selection
            IWebElement selectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Northern Cape']"))); // Adjust the XPath to match the visible selected option.
            Assert.That(selectedOption.Displayed, Is.True, "Northern Cape was not successfully selected from the dropdown.");


            // Navigate to the desired element (Dropdown Button for the second dropdown)
            IWebElement secondDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[5]/div/button/div/span")));
            try
            {
                secondDropdownToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownToClick);
            }

            // Wait for the dropdown to be visible
            IWebElement secondDropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[5]/div/button/div")));

            // Select the desired option from the second dropdown (adjust the XPath for the specific option)
            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Frances Baard']"))); // Replace 'Desired Option Text' with the actual option text
            try
            {
                secondDropdownOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownOption);
            }

            // Verify the selection
            IWebElement secondSelectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Frances Baard']"))); // Replace 'Desired Option Text' with the actual option text
            Assert.That(secondSelectedOption.Displayed, Is.True, "The desired option was not successfully selected from the second dropdown.");

            // Navigate to the desired element (Dropdown Button for the third dropdown)
            IWebElement thirdDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[6]/div/button/div/span")));
            try
            {
                thirdDropdownToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownToClick);
            }

            // Wait for the dropdown to be visible
            IWebElement thirdDropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[6]/div/button/div")));

            // Select the desired option from the third dropdown (adjust the XPath for the specific option)
            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Sol Plaatje Local Municipality']"))); // Replace 'Desired Option Text' with the actual option text
            try
            {
                thirdDropdownOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownOption);
            }

            // Verify the selection
            IWebElement thirdSelectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Sol Plaatje Local Municipality']"))); // Replace 'Desired Option Text' with the actual option text
            Assert.That(thirdSelectedOption.Displayed, Is.True, "The desired option was not successfully selected from the third dropdown.");

            

        }

    }
}
