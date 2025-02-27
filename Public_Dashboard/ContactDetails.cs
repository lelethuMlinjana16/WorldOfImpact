using ClosedXML.Excel;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOI_Testsuite.Public_Dashboard
{
    [TestFixture]
    public class ContactDetails : TestBase
    {


        private WebDriverWait _wait;

        [SetUp]
        public void StartBrowser()
        {
            _driver = SiteConnection();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            _driver.Url = "https://woi-sit.azurewebsites.net/";
            _driver.Manage().Window.Maximize();
        }

        [Test, Order(1)]
        public void CheckContact()
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

            Thread.Sleep(2000); // Delay for 2 seconds


            // Click on the first element in the dashboard using JavaScript click as a fallback

            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[1]/a")));
            try
            {
                firstElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick);
            }

            Thread.Sleep(2000); // Delay for 2 seconds


            IWebElement specificElementToClick5 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[3]/nav/ul/li[1]/div/button/div")));
            try
            {
                specificElementToClick5.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick5);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            // Wait for the dropdown to be visible


            IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[1]/div/button/div")));

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
            Thread.Sleep(2000); // Delay for 2 seconds

            // Verify the selection
            IWebElement selectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Northern Cape']"))); // Adjust the XPath to match the visible selected option.
            Assert.That(selectedOption.Displayed, Is.True, "Free State was not successfully selected from the dropdown.");

            Thread.Sleep(2000); // Delay for 2 seconds



            IWebElement specificElementToClick8 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"root\"]/div[2]/div/div/div[1]/div/div[1]/div/button/div")));
            try
            {
                specificElementToClick8.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick8);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            IWebElement dropdownMenus = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div/div/div[1]/div/div[1]/div/button/div")));

            // Select the "Northern Cape" option from the dropdown
            IWebElement sheltersOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Shelters']")));
            try
            {
                sheltersOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", sheltersOption);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            // Verify the selection
            IWebElement selectedOptions = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Shelters']"))); // Adjust the XPath to match the visible selected option.
            Assert.That(selectedOptions.Displayed, Is.True, "Shelters was not successfully selected from the dropdown.");


            //IWebElement specificElementToClick9 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"root\"]/div[2]/div/div/div[1]/div/div[1]/div/button/div")));
            //try
            //{
            //    specificElementToClick8.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick9);
            //}
            //Thread.Sleep(2000); // Delay for 2 seconds


            //IWebElement dropdownMenuss = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div/div/div[1]/div/div[1]/div/button/div")));

            //// Select the "Northern Cape" option from the dropdown
            //IWebElement sheltersOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Shelters']")));
            //try
            //{
            //    sheltersOption.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", sheltersOption);
            //}
            //Thread.Sleep(2000); // Delay for 2 seconds

            //// Verify the selection
            //IWebElement selectedOptions = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Shelters']"))); // Adjust the XPath to match the visible selected option.
            //Assert.That(selectedOptions.Displayed, Is.True, "Shelters was not successfully selected from the dropdown.");

        }
    }

}

