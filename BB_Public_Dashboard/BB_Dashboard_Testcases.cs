using System.Data.OleDb;
using System.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Reflection.Emit;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;


namespace WOI_Testsuite
{
    [TestFixture]
    public class BB_Dashboard_Testcases : TestBase
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


        //public static bool Test_SelectCrimeDashboard_Completed = false;

        [Test, Order(1)]
        public void Test_SelectBBDashboardView()
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



            IWebElement element = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(1) > a"));

            // Attempt clicking
            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // Fallback to JavaScript click
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
            }

            Thread.Sleep(2000); // Delay to allow navigation



            // Wait for the checkbox to be present and clickable
            IWebElement checkbox = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
                "#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.active > ul > li:nth-child(2) > label > input[type=checkbox]"
            )));

            try
            {
                // Ensure the checkbox is visible before clicking
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
            }
            catch (ElementClickInterceptedException)
            {
                // Use JavaScript click if normal click fails
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", checkbox);
            }

            // Wait until the checkbox is actually selected
            _wait.Until(driver => checkbox.Selected);

            // Assertion to confirm checkbox selection
            Assert.That(checkbox.Selected, Is.True, "The checkbox was not successfully selected.");

            // Locate and click the specific element

            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.active > ul > li:nth-child(2) > ul > li:nth-child(4) > label")));
            try
            {
                // Ensure the checkbox is visible before clicking
                if (!specificLabel.Selected)
                {
                    specificLabel.Click();
                }
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificLabel);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            // Navigate to the desired element (Dropdown Button)
            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(2) > div > button > div")));

            try
            {
                // Try clicking the dropdown
                specificElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // Fallback: Use JavaScript click if the normal click fails
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            } // Delay for 2 seconds


            IWebElement dropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Northern Cape')]"))); // Updated XPath for list items

            try
            {
                dropdownOption.Click();
            }

            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", dropdownOption);

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
            IWebElement secondSelectedOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Frances Baard')]")));


            try
            {
                secondSelectedOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondSelectedOption);
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


            // Navigate to the desired map element 

            IWebElement mapElementToClick = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#root > div.public-container > div > main > div > div.map-container > div.map-view > div.leaflet-container.leaflet-touch.leaflet-fade-anim > div.leaflet-pane.leaflet-map-pane > div.leaflet-pane.leaflet-marker-pane > img:nth-child(2)")));
            try
            {
                mapElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", mapElementToClick);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


           //View the contact details

            try
            {


                // Wait for the dropdown inside the modal to be visible and clickable
                IWebElement dropdown = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
                    "#root > div.public-container > div > main > div > div.map-container > div.map-view > div.geo-modal-overlay > div > div.modal-body > div > div > div.card-content > div:nth-child(3) > div > ul > li > div.dropdown"
                )));

                try
                {
                    // Click to open the dropdown
                    dropdown.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    // Use JavaScript to click if intercepted
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", dropdown);
                }

                // Optional: Wait for dropdown options to be visible
                Task.Delay(2000).Wait();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Task.Delay(2000).Wait();

            //Close the Contact modal

            IWebElement svgRect = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
              "#root > div.public-container > div > main > div > div.map-container > div.map-view > div.geo-modal-overlay > div > div.geo-modal-header > div > div > svg > rect:nth-child(2)"
          )));

            try
            {
                // Click the SVG rect element
                svgRect.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // Use JavaScript to click if intercepted
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", svgRect);
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

        [Test, Order(2)]
        public void Test_SelectBBGridViewDashboard()
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
                "#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(2) > a"
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

            // Click on the desired input element
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.active > ul > li:nth-child(3) > label > input[type=checkbox]")));
            try
            {
                inputElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            }

            Thread.Sleep(2000); // Delay for 2 seconds

            // Optionally, add verification if needed
            Assert.That(inputElementToClick.Selected, Is.True, "The input element was not successfully selected.");

            // Locate and click the specific element
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.active > ul > li:nth-child(3) > ul > li:nth-child(1) > label > input[type=checkbox]")));
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
            // Wait for the dropdown to be visible
            //IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[4]/div/button/div")));

            // Select the "Northern Cape" option from the dropdown
            IWebElement northernCapeOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Free State')]")));
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
            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Fezile Dabi')]"))); // Replace 'Desired Option Text' with the actual option text
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
            // Wait for the dropdown to be visible
           

            // Select the desired option from the third dropdown (adjust the XPath for the specific option)
            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Metsimaholo Local Municipality')]"))); // Replace 'Desired Option Text' with the actual option text
            try
            {
                thirdDropdownOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownOption);
            }
            Thread.Sleep(2000); // Delay for 2 seconds
           


            Thread.Sleep(2000); // Delay for 2 seconds


            
        }

        [Test, Order (3)]
        public void Test_SelectBBChartViewDashboard()
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
            // The Grid View

            // Click on the Chart view element in the dashboard using JavaScript click as a fallback
            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
                "#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(3) > a"
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

            // Click on the Response Network input element


            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.active > ul > li:nth-child(4) > label > input[type=checkbox]")));
            try
            {
                inputElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            }
            Thread.Sleep(2000); // Delay for 2 seconds
            // Optionally, add verification if needed
            Assert.That(inputElementToClick.Selected, Is.True, "The input element was not successfully selected.");


            // Navigate to the desired element (Dropdown Button)
            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
                "#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(2) > div > button > div"
            )));

            try
            {
                specificElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            // Select the desired option from the third dropdown (adjust the XPath for the specific option)
            IWebElement easternCapeOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Eastern Cape')]"))); // Replace 'Desired Option Text' with the actual option text
            try
            {
                easternCapeOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", easternCapeOption);
            }
            Thread.Sleep(2000); // Delay for 2 seconds
                               


            // Navigate to the desired element (Dropdown Button for the second dropdown)
            IWebElement secondDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
"#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(3) > div > button > div"
            )));

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
            
            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Amathole')]"))); // Replace 'Desired Option Text' with the actual option text
            try
            {
                secondDropdownOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownOption);
            }
            Thread.Sleep(2000); // Delay for 2 seconds
            // Verify the selection
           

            // Navigate to the desired element (Dropdown Button for the third dropdown)
            IWebElement thirdDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
"#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(4) > div > button > div"
            )));
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
            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Mbhashe Local Municipality')]"))); // Replace 'Desired Option Text' with the actual option text
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




