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


       

        [Test, Order(1)]
        public void Test_SelectHCChartViewDashboard()
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
"#organisational-health-check-desc"
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
           
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.organisational-health-check.active > ul > li:nth-child(4) > label > input[type=checkbox]")));
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
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.organisational-health-check.active > ul > li:nth-child(5) > label > input[type=checkbox]")));
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
                                
           


           

            // Select the "Gauteng" option from the dropdown
            IWebElement gautengOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Gauteng')]")));
            try
            {
                gautengOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", gautengOption);
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

            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Sedibeng')]"))); // Replace 'Desired Option Text' with the actual option text
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
            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Midvaal Local Municipality')]"))); // Replace 'Desired Option Text' with the actual option text
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
        public void Test_SelectHCGridViewDashboard()
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

            // Click on the first element in the dashboard using JavaScript click as a fallback /html/body/div/div[2]/div/div/div/div[2]

            try
            {
                IWebElement targetElement = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#organisational-health-check-desc")));

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

           

            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(2) > a")));
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
           
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.organisational-health-check.active > ul > li:nth-child(2) > label > input[type=checkbox]")));
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
            
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.organisational-health-check.active > ul > li:nth-child(6) > label > input[type=checkbox]")));
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
                               
         

            // Select the "Northern Cape" option from the dropdown
            IWebElement limpopoOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Limpopo')]")));
            try
            {
                limpopoOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", limpopoOption);
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

            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Capricorn')]"))); // Replace 'Desired Option Text' with the actual option text
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
            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Polokwane Local Municipality')]"))); // Replace 'Desired Option Text' with the actual option text
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


        [Test, Order(3)]
        public void Test_SelectHCMapViewDashboard()
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
                IWebElement targetElement = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#organisational-health-check-desc")));

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

            //// Click on the desired input element
            //IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("/html/body/div/div[2]/div[1]/div[2]/ul/li[1]/label/input")));
            //try
            //{
            //    inputElementToClick.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            //}

            //Thread.Sleep(2000); // Delay for 2 seconds



            // Locate and click the specific element
           
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.organisational-health-check.active > ul > li:nth-child(4) > label > input[type=checkbox]")));
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
                                
            

            // Select the "Northern Cape" option from the dropdown
            IWebElement mpumalangaOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Mpumalanga')]")));
            try
            {
                mpumalangaOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", mpumalangaOption);
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

            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Ehlanzeni')]"))); // Replace 'Desired Option Text' with the actual option text
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
            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Nkomazi Local Municipality')]"))); // Replace 'Desired Option Text' with the actual option text
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
