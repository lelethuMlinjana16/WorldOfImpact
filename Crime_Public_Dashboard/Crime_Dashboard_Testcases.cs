using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

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

            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[3]")));

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
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[3]/ul/li[4]/label/input")));
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
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[3]/ul/li[5]/label/input")));
            try
            {
                specificLabel.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificLabel);
            }

            Thread.Sleep(2000); // Delay for 2 seconds

            // Verify the selection
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
            Thread.Sleep(2000); // Delay for 2 seconds
            // Wait for the dropdown to be visible
            IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[4]/div/button/div")));

            // Select the "Free State" option from the dropdown
            IWebElement freeStateOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Free State']")));
            try
            {
                freeStateOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", freeStateOption);
            }
            Thread.Sleep(2000); // Delay for 2 seconds
            // Verify the selection
            IWebElement selectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Free State']"))); // Adjust the XPath to match the visible selected option.
            Assert.That(selectedOption.Displayed, Is.True, "Free State was not successfully selected from the dropdown.");


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
            Thread.Sleep(2000); // Delay for 2 seconds
            // Wait for the dropdown to be visible
            IWebElement secondDropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[5]/div/button/div")));

            // Select the desired option from the second dropdown (adjust the XPath for the specific option)
            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Mangaung']"))); // Replace 'Desired Option Text' with the actual option text
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
            IWebElement secondSelectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Mangaung']"))); // Replace 'Desired Option Text' with the actual option text
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
            Thread.Sleep(2000); // Delay for 2 seconds
            // Wait for the dropdown to be visible
            IWebElement thirdDropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[6]/div/button/div")));

            // Select the desired option from the third dropdown (adjust the XPath for the specific option)
            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Mangaung Metropolitan Municipality']"))); // Replace 'Desired Option Text' with the actual option text
            try
            {
                thirdDropdownOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownOption);
            }
            Thread.Sleep(2000); // Delay for 2 seconds
            // Verify the selection
            IWebElement thirdSelectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Mangaung Metropolitan Municipality']"))); // Replace 'Desired Option Text' with the actual option text
            Assert.That(thirdSelectedOption.Displayed, Is.True, "The desired option was not successfully selected from the third dropdown.");


            // Verify the element displayed after clicking
            IWebElement firstClickVerificationElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div[1]/div[3]")));
            Assert.That(firstClickVerificationElement.Displayed, Is.True, "The expected element did not appear after the first click.");


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

            try
            {
                IWebElement targetElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div[1]/div[3]")));

                // Perform actions with the element (click, get text, etc.)
                Console.WriteLine("Element text: " + targetElement.Text); // Get the text of the element
                targetElement.Click(); // Click the element (if clickable)

                // Optionally wait to observe the result
                System.Threading.Thread.Sleep(2000);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("Element did not appear in time: " + ex.Message);
            }

            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[2]/a")));
            try
            {
                firstElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick);
            }


            Thread.Sleep(2000); // Delay for 2 seconds

            
            //Switch from bottom to above

            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\'root\']/div[2]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div/div[2]")));
            try
            {
                specificElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            }

            Thread.Sleep(2000); // Delay for 2 seconds

            

            //Switch from above to bottom
           
            IWebElement specificElementToClick2 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/div[2]/div/div[2]/div[3]/div[1]/div[2]/div/div[1]")));
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

            IWebElement specificElementToClick3 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"root\"]/div[2]/div[2]/div/button/span")));
            try
            {
                specificElementToClick3.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick3);
            }
            Thread.Sleep(2000); // Delay for 2 seconds
            // Verify the element displayed after clicking
            IWebElement firstClickVerificationElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div[1]/div[3]")));
            Assert.That(firstClickVerificationElement.Displayed, Is.True, "The expected element did not appear after the first click.");


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

            try
            {
                IWebElement targetElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div[1]/div[3]")));

                // Perform actions with the element (click, get text, etc.)
                Console.WriteLine("Element text: " + targetElement.Text); // Get the text of the element
                targetElement.Click(); // Click the element (if clickable)

                // Optionally wait to observe the result
                System.Threading.Thread.Sleep(2000);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("Element did not appear in time: " + ex.Message);
            }

            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[1]/a")));
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
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[3]/ul/li[2]/label/input")));
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
            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[3]/nav/ul/li[4]/div/button/div/span")));
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

            Thread.Sleep(2000); // Delay for 2 seconds

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

            Thread.Sleep(2000); // Delay for 2 seconds

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

            Thread.Sleep(2000); // Delay for 2 seconds

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

            Thread.Sleep(2000); // Delay for 2 seconds

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
            Thread.Sleep(2000); // Delay for 2 seconds

            // Verify the selection
            IWebElement thirdSelectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Sol Plaatje Local Municipality']"))); // Replace 'Desired Option Text' with the actual option text
            Assert.That(thirdSelectedOption.Displayed, Is.True, "The desired option was not successfully selected from the third dropdown.");


            IWebElement mapElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[2]/div/div[1]/div[1]/div[1]/div[4]/img[2]")));
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

            try
            {
                // Wait for the modal to appear
                IWebElement modal = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#root > div.app-container > div.content > div > div.map-container > div.geo-modal-overlay > div")));

                // Locate and click the close button
                IWebElement closeButton = modal.FindElement(By.CssSelector("#root > div.app-container > div.content > div > div.map-container > div.geo-modal-overlay > div > div.geo-modal-header > div > div > svg")); // Adjust the selector
                closeButton.Click();

                // Switch back to the main content if switched to an iframe
                _driver.SwitchTo().DefaultContent();

                // Wait for the modal to disappear
                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("#root > div.app-container > div.content > div > div.map-container > div.geo-modal-overlay > div")));

                Console.WriteLine("Modal closed successfully.");
            }
            catch (WebDriverTimeoutException e)
            {
                Console.WriteLine("Modal did not appear or close in time: " + e.Message);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Modal or close button not found: " + e.Message);
            }


            // Verify the element displayed after clicking
            IWebElement firstClickVerificationElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div[1]/div[3]")));
            Assert.That(firstClickVerificationElement.Displayed, Is.True, "The expected element did not appear after the first click.");


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

