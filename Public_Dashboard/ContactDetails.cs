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


            IWebElement specificElementToClick5 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(1) > div > button > div")));
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


            IWebElement specificElementToClick8 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.public-container > div > main > div > div.contact-directory-search > div > div.filter-component > div > button > div")));
            try
            {
                specificElementToClick8.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick8);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


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


            //IWebElement specificElementToClick81 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.public-container > div > main > div > div.contact-directory-content > div:nth-child(1) > div > div.card-content > div:nth-child(3) > div > ul > li > span")));
            //try
            //{
            //    specificElementToClick81.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick81);
            //}
            //Thread.Sleep(2000); // Delay for 2 seconds


            //IWebElement specificElementToClick83 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > div > a")));
            //try
            //{
            //    specificElementToClick83.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick83);
            //}
            //Thread.Sleep(2000); // Delay for 2 seconds


        }
    }

}

