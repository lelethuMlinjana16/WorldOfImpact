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
using System.Reflection.Emit;
using DocumentFormat.OpenXml.Wordprocessing;
using static OpenQA.Selenium.BiDi.Modules.Script.EvaluateResult;
using DocumentFormat.OpenXml.Bibliography;

namespace WOI_Testsuite.HC_Admi_Dashboard
{

    [TestFixture]

    public class HCAdminDashboard : TestBase
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

        [Test, Order(1)]
        public void LoginHC()
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

            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
            try
            {
                // Click the element
                targetElement.Click();

                // Add delay to observe (optional)
                System.Threading.Thread.Sleep(3000);
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", targetElement);
            }
            Thread.Sleep(2000); // Delay for 2 seconds




            IWebElement targetElement1 = _driver.FindElement(By.CssSelector("#root > div.auth-container > div > div.auth-center > div.footer > div:nth-child(1)"));
            try
            {
                // Click the element
                targetElement1.Click();

                // Add delay to observe (optional)
                System.Threading.Thread.Sleep(3000);
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", targetElement1);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            try
            {


                // Find and fill the username field
                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
                usernameField.SendKeys("dora1@gmail.com");

                // Find and fill the password field
                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
                passwordField.SendKeys("Password@123456789");

                // Click the login button
                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
                loginButton.Click();

                Console.WriteLine("Login Successful!");

            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }

            try
            {
                //Copy the survey link
                IWebElement copyButton = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("copy-survey")));

                // Click the button
                copyButton.Click();
            }
              catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }
         

            //View survey results

            IWebElement targetElement22 = _wait.Until(d => d.FindElement(By.CssSelector("#view-survey-results > h2")));

            try
            {
                // Click the element
                targetElement22.Click();

                // Add delay to observe (optional)
                System.Threading.Thread.Sleep(3000);
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }

            // Go back to the Admin landing page
            IWebElement targetElement29 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > header > div.header-top > div > a")));

            try
            {
                // Click the element
                targetElement29.Click();

                // Add delay to observe (optional)
                System.Threading.Thread.Sleep(3000);
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }


            // Navigate to the selection of student (Dropdown Button)
            IWebElement specificElementToClick1 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div[2]/div[1]/div/div/button")));
            try
            {
                specificElementToClick1.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick1);
            }
            Thread.Sleep(2000); // Delay for 2 seconds



            // Select the "students" option from the dropdown

            IWebElement firstListItem = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.container > div.survey-graphs > div.view-button > div > div > ul > li:nth-child(1)")));

            // Click the list item
            try
            {
                firstListItem.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // Use JavaScript executor as a fallback click
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstListItem);
            }



            // Navigate to the desired profile (Dropdown Button)
            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));
            try
            {
                specificElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            }
            Thread.Sleep(2000); // Delay for 2 seconds



            // Select the "logout" option from the dropdown
            IWebElement logoutOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Logout']")));
            try
            {
                logoutOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", logoutOption);
            }



        }
    }

}
