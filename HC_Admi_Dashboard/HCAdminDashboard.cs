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
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }



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

                //// Wait for the dashboard/homepage to load
                //_wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard")));

                Console.WriteLine("Login Successful!");

            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }

            //Copy the survey link
            IWebElement targetElement19 = _wait.Until(d => d.FindElement(By.CssSelector("#copy-survey")));

            try
            {
                // Click the element
                targetElement19.Click();

                // Add delay to observe (optional)
                System.Threading.Thread.Sleep(3000);
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }

            //Send the survey link via email


            //IWebElement targetElement18 = _wait.Until(d => d.FindElement(By.CssSelector("#send-survey")));

            //try
            //{
            //    // Click the element
            //    targetElement18.Click();

            //    // Add delay to observe (optional)
            //    System.Threading.Thread.Sleep(3000);
            //}
            //catch (WebDriverTimeoutException)
            //{
            //    Console.WriteLine("Overlay did not disappear within the wait time.");
            //}


            //Click the preview survey questions

            //IWebElement targetElement17 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.container > div.dashboard-contained-graphs > div.participation-items > div.partic-heading > a > h2")));

            //try
            //{
            //    // Click the element
            //    targetElement17.Click();

            //    // Add delay to observe (optional)
            //    System.Threading.Thread.Sleep(3000);
            //}
            //catch (WebDriverTimeoutException)
            //{
            //    Console.WriteLine("Overlay did not disappear within the wait time.");
            //}

            ////Click next button

            ////IWebElement targetElement16 = _wait.Until(d => d.FindElement(By.CssSelector("#nextButton")));
            //IWebElement targetElement16 = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/div[2]/form/div[5]/div/button[2]")));
            //try
            //{
            //    // Click the element
            //    targetElement16.Click();

            //    // Add delay to observe (optional)
            //    System.Threading.Thread.Sleep(3000);
            //}
            //catch (WebDriverTimeoutException)
            //{
            //    Console.WriteLine("Overlay did not disappear within the wait time.");
            //}

            ////Click next button


            //IWebElement targetElement15 = _wait.Until(d => d.FindElement(By.CssSelector("#nextButton")));

            //try
            //{
            //    // Click the element
            //    targetElement15.Click();

            //    // Add delay to observe (optional)
            //    System.Threading.Thread.Sleep(3000);
            //}
            //catch (WebDriverTimeoutException)
            //{
            //    Console.WriteLine("Overlay did not disappear within the wait time.");
            //}


            ////Click next button


            //IWebElement targetElement14 = _wait.Until(d => d.FindElement(By.CssSelector("#nextButton")));

            //try
            //{
            //    // Click the element
            //    targetElement14.Click();

            //    // Add delay to observe (optional)
            //    System.Threading.Thread.Sleep(3000);
            //}
            //catch (WebDriverTimeoutException)
            //{
            //    Console.WriteLine("Overlay did not disappear within the wait time.");
            //}

            ////Click back button
            //IWebElement targetElement13 = _wait.Until(d => d.FindElement(By.CssSelector("#prevButton")));

            //try
            //{
            //    // Click the element
            //    targetElement13.Click();

            //    // Add delay to observe (optional)
            //    System.Threading.Thread.Sleep(3000);
            //}
            //catch (WebDriverTimeoutException)
            //{
            //    Console.WriteLine("Overlay did not disappear within the wait time.");
            //}

            //select the Preview back button
            //IWebElement anchorElement = _wait.Until(d => d.FindElement(By.XPath("/html/body/main/div[1]/div[1]/div/a")));

            //// Click the anchor element
            //try
            //{
            //    anchorElement.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    // Use JavaScript executor as a fallback click
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", anchorElement);
            //}

            //Go back to the Admin landing page

            IWebElement targetElement27 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > header > div.header-top > div > a")));

            try
            {
                // Click the element
                targetElement27.Click();

                // Add delay to observe (optional)
                System.Threading.Thread.Sleep(3000);
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
            IWebElement specificElementToClick1 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("#root > div.authenticated-layout > div > div > div.header > div.view-button > div > div > button")));
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

            IWebElement firstListItem = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.header > div.view-button > div > div > ul > li:nth-child(1)")));

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



            //// Navigate to the desired profile (Dropdown Button)
            //IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));
            //try
            //{
            //    specificElementToClick.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            //}
            //Thread.Sleep(2000); // Delay for 2 seconds



            //// Select the "logout" option from the dropdown
            //IWebElement logoutOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Logout']")));
            //try
            //{
            //    logoutOption.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", logoutOption);
            //}



        }
    }

}
