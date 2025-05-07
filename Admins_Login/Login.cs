//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DocumentFormat.OpenXml.Wordprocessing;
//using DocumentFormat.OpenXml.Bibliography;

//namespace WOI_Testsuite.Admins_Login
//{
//    [TestFixture]
//    public class Login : TestBase
//    {
//        private WebDriverWait _wait;

//        [SetUp]
//        public void StartBrowser()
//        {
//            _driver = SiteConnection();
//            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
//            _driver.Url = "https://woi-sit.azurewebsites.net/";
//            _driver.Manage().Window.Maximize();


//        }
//        [Test, Order(1)]
//        public void Logins()
//        {
//            //try
//            //{

//            //    IWebElement targetElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[4]/a")));

//            //    // Click the element
//            //    targetElement.Click();

//            //    Console.WriteLine("Element clicked successfully!");
//            //}
//            //catch (NoSuchElementException)
//            //{
//            //    Console.WriteLine("Element not found!");
//            //}
//            //catch (WebDriverTimeoutException)
//            //{
//            //    Console.WriteLine("Element not visible within timeout period!");
//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine($"Error: {ex.Message}");
//            //}


//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            // Locate the element using CSS Selector
//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try { 
//            // Click the element
//            targetElement.Click();

//            // Add delay to observe (optional)
//            System.Threading.Thread.Sleep(3000);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }



//            //try
//            //{
               

//            //    // Wait for the element to be visible
//            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            //    IWebElement inputField = wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));

//            //    // Input text into the field
//            //    inputField.SendKeys("YourTextHere"); // Replace with actual input

//            //    // Add delay to observe (optional)
//            //    Thread.Sleep(3000);
//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine("Error: " + ex.Message);
//            //}


//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("mankgasha@digitalsolutionfoundry.co.za");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("Password@123456789");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();


//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }


//            // Navigate to the desired element (Dropdown Button)
//            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));
//            try
//            {
//                specificElementToClick.Click();
//            }
//            catch (ElementClickInterceptedException)
//            {
//                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
//            }
//            Thread.Sleep(2000); // Delay for 2 seconds

//            // Wait for the dropdown to be visible


//            IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));

//            // Select the "Northern Cape" option from the dropdown
//            IWebElement logoutOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Logout']")));
//            try
//            {
//                logoutOption.Click();
//            }
//            catch (ElementClickInterceptedException)
//            {
//                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", logoutOption);
//            }



//        }
//        [Test, Order(2)]
//        public void LoginHC()
//        {

//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try
//            {
//                // Click the element
//                targetElement.Click();

//                // Add delay to observe (optional)
//                System.Threading.Thread.Sleep(3000);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }



//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("dora1@gmail.com");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("Password@123456789");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();

//                //// Wait for the dashboard/homepage to load
//                //_wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard")));

//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }


//            // Navigate to the desired element (Dropdown Button)
//            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));
//            try
//            {
//                specificElementToClick.Click();
//            }
//            catch (ElementClickInterceptedException)
//            {
//                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
//            }
//            Thread.Sleep(2000); // Delay for 2 seconds

//            // Wait for the dropdown to be visible


//            IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));

//            // Select the "Northern Cape" option from the dropdown
//            IWebElement logoutOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Logout']")));
//            try
//            {
//                logoutOption.Click();
//            }
//            catch (ElementClickInterceptedException)
//            {
//                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", logoutOption);
//            }



//        }
//        [Test, Order(3)]
//        public void LoginBB()
//        {

//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try
//            {
//                // Click the element
//                targetElement.Click();

//                // Add delay to observe (optional)
//                System.Threading.Thread.Sleep(3000);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }



//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("siyasanga.Nkungwana@ecotp.gov.za");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("Password@123456789");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();


//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }


//            // Navigate to the desired element (Dropdown Button)
//            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));
//            try
//            {
//                specificElementToClick.Click();
//            }
//            catch (ElementClickInterceptedException)
//            {
//                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
//            }
//            Thread.Sleep(2000); // Delay for 2 seconds

//            // Wait for the dropdown to be visible


//            IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));

//            // Select the "Northern Cape" option from the dropdown
//            IWebElement logoutOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Logout']")));
//            try
//            {
//                logoutOption.Click();
//            }
//            catch (ElementClickInterceptedException)
//            {
//                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", logoutOption);
//            }
//        }

//        [Test, Order(4)]
//        public void LoginWithEmptyFields()
//        {

//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try
//            {
//                // Click the element
//                targetElement.Click();

//                // Add delay to observe (optional)
//                System.Threading.Thread.Sleep(3000);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }



//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();

//                //// Wait for the dashboard/homepage to load
//                //_wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard")));

//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }

//        }

//        [Test, Order(5)]
//        public void LoginWithEmptyEmailField()
//        {

//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try
//            {
//                // Click the element
//                targetElement.Click();

//                // Add delay to observe (optional)
//                System.Threading.Thread.Sleep(3000);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }



//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("Password@123456789");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();

//                //// Wait for the dashboard/homepage to load
//                //_wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard")));

//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }

//        }
//        [Test, Order(6)]
//        public void LoginWithWrongDetails()
//        {

//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try
//            {
//                // Click the element
//                targetElement.Click();

//                // Add delay to observe (optional)
//                System.Threading.Thread.Sleep(3000);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }



//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("siyasanga.Nkungana@ecotp.gov.za");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("Password@12345789");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();

                
//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }

//        }

//        [Test, Order(7)]
//        public void LoginWithInvalidEmail()
//        {

//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try
//            {
//                // Click the element
//                targetElement.Click();

//                // Add delay to observe (optional)
//                System.Threading.Thread.Sleep(3000);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }



//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("siyasanga.Nkungwanaecotp.gov.za");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("Password@123456789");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();

            

//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }

//        }


//        [Test, Order(8)]
//        public void LoginWithEmptyPasswordField()
//        {

//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try
//            {
//                // Click the element
//                targetElement.Click();

//                // Add delay to observe (optional)
//                System.Threading.Thread.Sleep(3000);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }



//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("siyasanga.Nkungwana@ecotp.gov.za");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();


//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }


//        }

//        [Test, Order(9)]
//        public void LoginWithNotExistingEmail()
//        {

//            // Wait for the overlay to disappear if present
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000); // Delay for 2 seconds

//            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
//            try
//            {
//                // Click the element
//                targetElement.Click();

//                // Add delay to observe (optional)
//                System.Threading.Thread.Sleep(3000);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }



//            try
//            {


//                // Find and fill the username field
//                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
//                usernameField.SendKeys("mosima@gmail.co.za");

//                // Find and fill the password field
//                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
//                passwordField.SendKeys("Password@123456789");

//                // Click the login button
//                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
//                loginButton.Click();

                

//                Console.WriteLine("Login Successful!");

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Login Failed: {ex.Message}");
//            }


            
//        }
                                
//    }
//}
                        
