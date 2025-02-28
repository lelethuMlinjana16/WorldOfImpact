using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;

namespace WOI_Testsuite.Crime_Public_Dashboard
{
    [TestFixture]
     
    public class Crime_Dashboard_Testcases : TestBase
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
        public void Test_SelectCrimeChartViewDashboard()
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

            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.gbvf-indicators.default")));

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
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.gbvf-indicators.active > ul > li:nth-child(4) > label > input[type=checkbox]")));
            try
            {
                inputElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            }

            Thread.Sleep(2000); // Delay for 2 seconds

         

            // Locate and click the specific element
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.gbvf-indicators.active > ul > li:nth-child(5) > label > input[type=checkbox]")));
            try
            {
                specificLabel.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificLabel);
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
                                // Wait for the dropdown to be visible
           

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
        public void Test_SelectCrimeGridViewDashboard()
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
"#root > div.public-container > div > div > div > div.component-nav-item.gbvf-indicators.default"
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

            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > main > div > div.grid-container > div:nth-child(1) > div.header-row > div.header-icons > div > div:nth-child(1) > svg")));
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
           
            IWebElement specificElementToClick2 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > main > div > div.grid-container > div:nth-child(7) > div.header-row > div.header-icons > div > div:nth-child(2)")));
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
        public void Test_SelectCrimeMapViewDashboard()
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

            
                IWebElement targetElement = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.gbvf-indicators.default")));

            try
            {
                targetElement.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", targetElement);
            }

            Thread.Sleep(2000); // Delay for 2 seconds


            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(1) > a")));
            try
            {
                firstElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick);
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
            IWebElement northernCapeOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Northern Cape')]")));
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
            // Wait for the dropdown to be visible
           

            // Select the desired option from the second dropdown (adjust the XPath for the specific option)
            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Frances Baard')]"))); // Replace 'Desired Option Text' with the actual option text
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
            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Sol Plaatje Local Municipality')]"))); // Replace 'Desired Option Text' with the actual option text
            try
            {
                thirdDropdownOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownOption);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            IWebElement mapElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > main > div > div.map-container > div.map-view > div.leaflet-container.leaflet-touch.leaflet-fade-anim > div.leaflet-pane.leaflet-map-pane > div.leaflet-pane.leaflet-marker-pane > img:nth-child(2)")));
            try
            {
                mapElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", mapElementToClick);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            // close the contact tab

            //Close the Contact modal

            IWebElement svgRect1 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
"#root > div.public-container > div > main > div > div.map-container > div.map-view > div.geo-modal-overlay > div > div.geo-modal-header > div > div > svg"
          )));

            try

            {
                // Click the SVG rect element
                svgRect1.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // Use JavaScript to click if intercepted
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", svgRect1);
            }

            Task.Delay(2000).Wait();

            //Returning back to home page

            // Wait for the element to be visible and clickable
            IWebElement headerElement = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
                "#root > div.public-container > header > div.header-top > div > a > div"
            )));

            try
            {
                // Click the element (possibly a logo or navigation link)
                headerElement.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // Use JavaScript click if intercepted
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", headerElement);
            }

            // Optional: Wait for 2 seconds to observe the click action
            Task.Delay(2000).Wait();

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

