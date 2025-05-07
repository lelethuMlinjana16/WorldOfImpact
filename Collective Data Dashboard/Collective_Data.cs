using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOI_Testsuite.Collective_Data_Dashboard
{


        [TestFixture]

        public class Collective_Data : TestBase
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
            public void Test_SelectCollectiveDataChartViewDashboard()
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

                // The Chart View

                // Click on the first element in the dashboard using JavaScript click as a fallback

                IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.collective-actions.default")));

                try
                {
                    firstElementToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick);
                }

                Thread.Sleep(2000); // Delay for 2 seconds
                                    // Click on the desired input element 
                IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.collective-actions.active > ul > li:nth-child(4) > label > div > input[type=checkbox]")));
                try
                {
                    inputElementToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            }

            Thread.Sleep(2000); // Delay for 2 seconds

            // Click on the desired input element 
            IWebElement inputElementToClick2 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.collective-actions.active > ul > li:nth-child(4) > ul > li > label > div > input[type=checkbox]")));
            try
            {
                inputElementToClick2.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick2);
            }

            Thread.Sleep(2000); // Delay for 2 seconds



            // Locate and click the specific element
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.collective-actions.active > ul > li:nth-child(5) > label > div > input[type=checkbox]")));
                try
                {
                    specificLabel.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificLabel);
            }

            Thread.Sleep(2000); // Delay for 2 seconds


            // Locate and click the specific element
            IWebElement specificLabel5 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.collective-actions.active > ul > li:nth-child(5) > ul > li > label > div > input[type=checkbox]")));
            try
            {
                specificLabel5.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificLabel5);
            }

            Thread.Sleep(2000); // Delay for 2 seconds


            // Navigate to the desired element (Dropdown Button)
            IWebElement specificElementToClick5 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(2) > div > button > div")));
                try
                {
                    specificElementToClick5.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick5);
                }
                Thread.Sleep(2000); // Delay for 2 seconds


                // Select the "Northern Cape" option from the dropdown

                IWebElement freeStateOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Free State')]")));
                try
                {
                    freeStateOption.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", freeStateOption);
                }
                Thread.Sleep(2000); // Delay for 2 seconds


                // Navigate to the desired element (Dropdown Button for the second dropdown)
                IWebElement secondDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(3) > div > button > div")));
                try
                {
                    secondDropdownToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownToClick);
                }
                Thread.Sleep(2000); // Delay for 2 seconds
                  
                // Select the desired option from the second dropdown (adjust the XPath for the specific option)
                IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Mangaung')]"))); // Replace 'Desired Option Text' with the actual option text
                try
                {
                    secondDropdownOption.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownOption);
                }
                Thread.Sleep(2000); // Delay for 2 seconds

                // Navigate to the desired element (Dropdown Button for the third dropdown)
                IWebElement thirdDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(4) > div > button > div")));
                try
                {
                    thirdDropdownToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownToClick);
                }
                Thread.Sleep(2000); // Delay for 2 seconds

                // Select the desired option from the third dropdown (adjust the XPath for the specific option)
                IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Mangaung Metropolitan Municipality')]"))); // Replace 'Desired Option Text' with the actual option text
                try
                {
                    thirdDropdownOption.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownOption);
                }
                Thread.Sleep(2000); // Delay for 2 seconds

            }


            [Test, Order(2)]
            public void Test_SelectCollectiveDataGridViewDashboard()
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

                // The Chart View

                // Click on the first element in the dashboard using JavaScript click as a fallback


                IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
    "#root > div.public-container > div > div > div > div.component-nav-item.collective-actions.default"
                )));


                try
                {
                    firstElementToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick);
                }

                Thread.Sleep(2000); // Delay for 2 seconds



                IWebElement firstElementToClick1 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(2) > a")));
                try
                {
                    firstElementToClick1.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick1);
                }


                Thread.Sleep(2000); // Delay for 2 seconds


                //Switch from top to bottom

                IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > main > div > div > div:nth-child(9) > div.header-row > div.header-icons > div > div:nth-child(1)")));
                try
                {
                    specificElementToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
                }

                Thread.Sleep(2000); // Delay for 2 seconds



                //Switch from bottom to top

                IWebElement specificElementToClick2 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > main > div > div > div:nth-child(2) > div.header-row > div.header-icons > div > div:nth-child(2)")));
                try
                {
                    specificElementToClick2.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick2);
                }

                Thread.Sleep(2000); // Delay for 2 seconds

                //Switch from Lowest to highest 

                IWebElement specificElementToClick3 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(" #root > div.public-container > div > main > div > button > span")));
                try
                {
                    specificElementToClick3.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick3);
                }
                Thread.Sleep(2000); // Delay for 2 seconds



            }


            [Test, Order(3)]
            public void Test_SelectCollectiveDataMapViewDashboard()
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

            // The Chart View

            // Click on the first element in the dashboard using JavaScript click as a fallback


            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.collective-actions.default")));

            try
            {
                firstElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick);
            }

            Thread.Sleep(2000); // Delay for 2 seconds
                                // Click on the desired input element 
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(1) > a")));
            try
            {
                inputElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            }

            Thread.Sleep(2000); // Delay for 2 seconds



            // Navigate to the desired element (Dropdown Button)
            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(2) > div > button > div")));
                try
                {
                    specificElementToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
                }
                Thread.Sleep(2000); // Delay for 2 seconds


                // Select the "Northern Cape" option from the dropdown
                IWebElement northernCapeOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Western Cape')]")));
                try
                {
                    northernCapeOption.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", northernCapeOption);
                }
                Thread.Sleep(2000); // Delay for 2 seconds



                // Navigate to the desired element (Dropdown Button for the second dropdown)
                IWebElement secondDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(3) > div > button > div")));
                try
                {
                    secondDropdownToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownToClick);
                }
                Thread.Sleep(2000); // Delay for 2 seconds
                  
                // Select the desired option from the second dropdown (adjust the XPath for the specific option)
                IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'West Coast')]"))); // Replace 'Desired Option Text' with the actual option text
                try
                {
                    secondDropdownOption.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownOption);
                }
                Thread.Sleep(2000); // Delay for 2 seconds


                // Navigate to the desired element (Dropdown Button for the third dropdown)
                IWebElement thirdDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(4) > div > button > div")));
                try
                {
                    thirdDropdownToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownToClick);
                }
                Thread.Sleep(2000); // Delay for 2 seconds


                // Select the desired option from the third dropdown (adjust the XPath for the specific option)
                IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Cederberg Local Municipality')]"))); // Replace 'Desired Option Text' with the actual option text
                try
                {
                    thirdDropdownOption.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownOption);
                }
                Thread.Sleep(2000); 
            }

            [OneTimeTearDown]
            public void TearDown()
            {
                // Ensure the WebDriver session is properly closed after each test
                if (_driver != null)
                {
                    _driver.Quit();
                }
            }

        }
    }

