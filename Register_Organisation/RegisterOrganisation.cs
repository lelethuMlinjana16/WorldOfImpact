using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Bibliography;

namespace WOI_Testsuite.Register_Organisation
{
    [TestFixture]
    public class RegisterOrganisation : TestBase
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
        public void Register()
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

                // Wait for the element to be visible (using WebDriverWait)
                IWebElement elementToClick = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div/div[4]/div[2]/span")));

                // Click the element
                elementToClick.Click();


                Console.WriteLine("Element clicked successfully!");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element not found!");
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Element not visible within timeout period!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Navigate to the desired element (Dropdown Button)
            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[1]/button/div")));
            try
            {
                specificElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            try
            {


                IWebElement dropdownMenu = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div.custom-dropdown > button > div")));

                // Select the "Northern Cape" option from the dropdown
                IWebElement missOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Miss']")));

                missOption.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the firstname field
                IWebElement firstNameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(4) > div > input")));
                firstNameField.SendKeys("Mary");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the lastname field
                IWebElement lastNameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(5) > div > input")));
                lastNameField.SendKeys("Jansen");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement telephoneField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(8) > div > input")));
                telephoneField.SendKeys("0118763297");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement emailAddressField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(9) > div > input")));
                emailAddressField.SendKeys("marydibete@gmail.com");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement passwordsField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(12) > div > input")));
                passwordsField.SendKeys("Password@123456789");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement confirmPasswordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(13) > div > input")));
                confirmPasswordField.SendKeys("Password@123456789");

                Thread.Sleep(2000); // Delay for 2 seconds


                // Click the next button
                IWebElement nextButton = _wait.Until(d => d.FindElement(By.CssSelector("#login")));
                nextButton.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the OrganisationName field)
                IWebElement organisationNameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(2) > div > input")));
                organisationNameField.SendKeys("Mukwevho Holdings");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Organisation Type field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick1 = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(3) > button > div")));
                try
                {
                    specificElementToClick1.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick1);
                }
                Thread.Sleep(2000);

              

                IWebElement organisationTypeField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='NGO']")));

                organisationTypeField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Your role in the organisation field
                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick2 = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(5) > button > div")));
                try
                {
                    specificElementToClick2.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick2);
                }
                Thread.Sleep(2000);


         
                IWebElement organisationRoleField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Admin Clerk']")));

                organisationRoleField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Organisation branch field
                IWebElement organisationBranchField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(7) > div > input")));
                organisationBranchField.SendKeys("Mukwevho Holdings");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Street number field
                IWebElement streetNumberField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(9) > div > input")));
                streetNumberField.SendKeys("10073");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Street name field
                IWebElement streetNameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(10) > div > input")));
                streetNameField.SendKeys("Sunny-side");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Suburb field
                IWebElement suburbField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(11) > div > input")));
                suburbField.SendKeys("Phalaborwa");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the city field
                IWebElement cityField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(12) > div > input")));
                cityField.SendKeys("Tzaneen");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Postal code field
                IWebElement postalCodeField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(13) > div > input")));
                postalCodeField.SendKeys("0744");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Province field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick4 = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(15) > button > div")));
                try
                {
                    specificElementToClick4.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick4);
                }
                Thread.Sleep(2000);

               

                IWebElement provinceField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Limpopo']")));

                provinceField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the District field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick5 = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(17) > button > div")));
                try
                {
                    specificElementToClick5.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick5);
                }
                Thread.Sleep(2000);

               

                IWebElement districtField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Mopani']")));

                districtField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Local Municipality field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick6 = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div:nth-child(19) > button > div")));
                try
                {
                    specificElementToClick6.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick6);
                }
                Thread.Sleep(2000);

             

                IWebElement localMunicipalityField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Ba-Phalaborwa Local Municipality']")));

                localMunicipalityField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds


                // Click the next button
                IWebElement nextButton1 = _wait.Until(d => d.FindElement(By.CssSelector("#login")));
                nextButton1.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                Console.WriteLine("Next Successful!");

                // Find and fill the Number of members in organisation field
                IWebElement numberOfMembersInOrganisationField = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div.input-holder > div > input")));
                numberOfMembersInOrganisationField.SendKeys("50");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Number of members in organisation field
                IWebElement element = _wait.Until(d => d.FindElement(By.CssSelector("#root > form > div > div > div.body-info > div > div.terms-and-conditions")));

                // Click the element
                element.Click();

                Thread.Sleep(2000); // Delay for 2 seconds


                // Get all open window handles
                List<string> windowHandles = new List<string>(_driver.WindowHandles);

                _driver.SwitchTo().Window(windowHandles[0]);
                Console.WriteLine("Switched back to previous tab: " + _driver.Title);


                Thread.Sleep(2000); // Delay for 2 seconds

                // Click the next button
                IWebElement nextButton2 = _wait.Until(d => d.FindElement(By.CssSelector("/html/body/div/form/div/div/div[3]/div[1]/button")));
                nextButton1.Click();

                Thread.Sleep(2000); // Delay for 2 seconds 


                // Locate the input field using XPath
                IWebElement inputField = _wait.Until(d => d.FindElement(By.CssSelector("#login")));

                //Enter the number
                inputField.SendKeys("891117");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Login Failed: {ex.Message}");
            }

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

        
    
