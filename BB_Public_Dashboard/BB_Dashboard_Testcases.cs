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


        [Test, Order(1)]
        public void Test_SelectBBDashboardView()
        {

            try
            {
                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }

            Thread.Sleep(2000); 



            IWebElement element = _driver.FindElement(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.default"));

          
            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
               
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
            }

            Thread.Sleep(2000); 



            IWebElement element1 = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(1) > a"));

        
            try
            {
                element1.Click();
            }
            catch (ElementClickInterceptedException)
            {
                
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element1);
            }

            Thread.Sleep(2000); 


            IWebElement checkbox = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
                "#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.active > ul > li:nth-child(2) > label > div > input[type=checkbox]"
            )));

            try
            {
              
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
            }
            catch (ElementClickInterceptedException)
            {
                
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", checkbox);
            }

            _wait.Until(driver => checkbox.Selected);

            Assert.That(checkbox.Selected, Is.True, "The checkbox was not successfully selected.");


            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.active > ul > li:nth-child(2) > ul > li:nth-child(4) > label")));
            try
            {
                
                if (!specificLabel.Selected)
                {
                    specificLabel.Click();
                }
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificLabel);
            }
            Thread.Sleep(2000); 

            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(2) > div > button > div")));

            try
            {
                
                specificElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            } 


            IWebElement dropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Northern Cape')]"))); 

            try
            {
                dropdownOption.Click();
            }

            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", dropdownOption);

            }

            Thread.Sleep(2000); 

           
            IWebElement secondDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(3) > div > button > div")));
            try
            {
                secondDropdownToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownToClick);
            }


            Thread.Sleep(2000); 


            IWebElement secondSelectedOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Frances Baard')]")));


            try
            {
                secondSelectedOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondSelectedOption);
            }
            Thread.Sleep(2000); 


            IWebElement thirdDropdownToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > li:nth-child(4) > div > button > div")));
            try
            {
                thirdDropdownToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownToClick);
            }
            Thread.Sleep(2000); 


            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Sol Plaatje Local Municipality')]"))); 
            try
            {
                thirdDropdownOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", thirdDropdownOption);
            }
            Thread.Sleep(2000); 


            IWebElement mapElementToClick = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#root > div.public-container > div > main > div > div.map-container > div.map-view > div.leaflet-container.leaflet-touch.leaflet-fade-anim > div.leaflet-pane.leaflet-map-pane > div.leaflet-pane.leaflet-marker-pane > img:nth-child(2)")));
            try
            {
                mapElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", mapElementToClick);
            }
            Thread.Sleep(2000); 


            IWebElement svgRect = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
              "#root > div.public-container > div > main > div > div.map-container > div.map-view > div.geo-modal-overlay > div > div.geo-modal-header > div > div > svg > rect:nth-child(2)"
          )));

            try
            {
                
                svgRect.Click();
            }
            catch (ElementClickInterceptedException)
            {
                
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", svgRect);
            }

            Task.Delay(2000).Wait();

          
            IWebElement headerElement = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(
                "#root > div.public-container > header > div.header-top > div > a > div"
            )));

            try
            {
               
                headerElement.Click();
            }
            catch (ElementClickInterceptedException)
            {
                
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", headerElement);
            }

            
            Task.Delay(2000).Wait();


        }

        [Test, Order(2)]
        public void Test_SelectBBGridViewDashboard()
        {
         
           
            try
            {
                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }

            Thread.Sleep(2000); 

       

            IWebElement element = _driver.FindElement(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.default"));

        
            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
              
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
            }

            Thread.Sleep(2000); 

           
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#root > div.public-container > header > div.desktop-filter > div > nav > ul > div > li:nth-child(2) > a")));
            try
            {
                inputElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            }

            Thread.Sleep(2000); 


        }

        [Test, Order (3)]
        public void Test_SelectBBChartViewDashboard()
         {
            

            try
            {
                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }
            Thread.Sleep(2000); 

            IWebElement element = _driver.FindElement(By.CssSelector("#root > div.public-container > div > div > div > div.component-nav-item.building-blocks.default"));

            
            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
            
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
            }

            Thread.Sleep(2000); 

           
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
            Thread.Sleep(2000); 

            IWebElement easternCapeOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Eastern Cape')]"))); 
            try
            {
                easternCapeOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", easternCapeOption);
            }
            Thread.Sleep(2000); 
                               
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
            Thread.Sleep(2000); 
            
            IWebElement secondDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Amathole')]")));
            try
            {
                secondDropdownOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", secondDropdownOption);
            }
            Thread.Sleep(2000); 
          
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
            Thread.Sleep(2000); 

            IWebElement thirdDropdownOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[contains(text(),'Mbhashe Local Municipality')]"))); 
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
           
            if (_driver != null)
            {
                _driver.Quit();
            }
        }
    }
}




