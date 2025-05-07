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

namespace WOI_Testsuite.BB_Admin_Dashboard
{
    [TestFixture]

    public class BB_Admin_Dashboard_Testcases : TestBase
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
        public void BB()
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

            IWebElement targetElement = _driver.FindElement(By.CssSelector("#root > div.public-container > header > div.header-top > nav.desktop > ul > li:nth-child(4) > a"));
            try
            {
                
                targetElement.Click();

                
                System.Threading.Thread.Sleep(3000);
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", targetElement);
            }
            Thread.Sleep(2000); 


            IWebElement targetElement1 = _driver.FindElement(By.CssSelector("#root > div.auth-container > div > div.auth-center > div.footer > div:nth-child(1)"));
            try
            {
               
                targetElement1.Click();

                
                System.Threading.Thread.Sleep(3000);
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", targetElement1);
            }
            Thread.Sleep(2000); 

            try
            {


                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
                usernameField.SendKeys("siyasanga.Nkungwana@ecotp.gov.za");

                
                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
                passwordField.SendKeys("Password@123456789");

                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
                loginButton.Click();

                Console.WriteLine("Login Successful!");

            }
            catch (ElementClickInterceptedException)
            {
                Console.WriteLine($"Login Failed");
            }


          
            IWebElement specificElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));
            try
            {
                specificElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick);
            }
            Thread.Sleep(2000); 


          
            IWebElement specificElementToClick1 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > header > div.header-top > nav.desktop > ul > li:nth-child(2) > div > button > svg:nth-child(3)")));
            try
            {
                specificElementToClick1.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick1);
            }
            Thread.Sleep(2000); 

            
            IWebElement specificElementToClick11 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.building-block-content > div:nth-child(8) > div.buildinb-block-desktop > table > tbody > tr > td:nth-child(2) > div > div.resource-item-name > span.resource-label.undefined")));
            try
            {
                specificElementToClick11.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick11);
            }
            Thread.Sleep(2000); 
            IWebElement specificElementToClick12 = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder-selection > div.manage-select-building-block > div > button")));
            try
            {
                specificElementToClick12.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick12);
            }
            Thread.Sleep(2000); 

            IWebElement katKopOption = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder-selection > div.manage-select-building-block > div > ul > li:nth-child(2)")));
            try
            {
                katKopOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", katKopOption);
            }
            Thread.Sleep(2000); 

            IWebElement EditButton = _wait.Until(d => d.FindElement(By.CssSelector("#edit-building-block")));
            try
            {
                EditButton.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", EditButton);
            }
            Thread.Sleep(2000); 



            try
            {


                
                void FillFieldIfEmpty(By selector, string value)
                {
                    IWebElement field = _wait.Until(d => d.FindElement(selector));
                    if (string.IsNullOrWhiteSpace(field.GetAttribute("value"))) 
                    {
                        field.SendKeys(value);
                    }
                }

                
                FillFieldIfEmpty(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder-selection > div.contact-details > div:nth-child(1) > div > input"), "10073 Elias Park");
                FillFieldIfEmpty(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder-selection > div.contact-details > div:nth-child(2) > div > input"), "10073 Elias Park, Eastern Cape");
                FillFieldIfEmpty(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder-selection > div.contact-details > div:nth-child(3) > div > input"), "0535639086");
                FillFieldIfEmpty(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder-selection > div.contact-details > div:nth-child(4) > div > input"), "0813894727");
                FillFieldIfEmpty(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder-selection > div.contact-details > div:nth-child(5) > div > input"), "info@saps.gov.za");

                // Optional delay to observe results
                Thread.Sleep(3000);
            }

            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", EditButton);
            }
            Thread.Sleep(2000); // Delay for 2 seconds



            IWebElement GBVFServicesCheck = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder > div:nth-child(2) > div")));
            try
            {
                GBVFServicesCheck.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", GBVFServicesCheck);
            }
            Thread.Sleep(2000); // Delay for 2 seconds



            try
            {


                // Function to check if an input field is already filled
                bool IsFieldEmpty(By selector)
                {
                    IWebElement field = _wait.Until(d => d.FindElement(selector));
                    return string.IsNullOrWhiteSpace(field.GetAttribute("value"));
                }

                // Function to fill an input field only if empty
                void FillFieldIfEmpty(By selector, string value)
                {
                    if (IsFieldEmpty(selector))
                    {
                        IWebElement field = _wait.Until(d => d.FindElement(selector));
                        field.SendKeys(value);
                    }
                }

                // Selectors for the input fields
                var nameField = By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder > div:nth-child(2) > div.block-card-body > div > div.contact-row > div.contact-details > div:nth-child(1) > div > input");
                var emailField = By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder > div:nth-child(2) > div.block-card-body > div > div.contact-row > div.contact-details > div:nth-child(2) > div > input");
                var telephoneField = By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder > div:nth-child(2) > div.block-card-body > div > div.contact-row > div.contact-details > div:nth-child(3) > div > input");
                var alternateField = By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder > div:nth-child(2) > div.block-card-body > div > div.contact-row > div.contact-details > div:nth-child(4) > div > input");
                var mobileField = By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder > div:nth-child(2) > div.block-card-body > div > div.contact-row > div.contact-details > div:nth-child(5) > div > input");

                // Fill fields only if they are empty
                FillFieldIfEmpty(nameField, "Lelethu Mlinjani");
                FillFieldIfEmpty(emailField, "lelethu@saps.gov.za");
                FillFieldIfEmpty(telephoneField, "0537830283");
                FillFieldIfEmpty(alternateField, "0827520736");
                FillFieldIfEmpty(mobileField, "0672976392");

                // Click the Job Role dropdown if empty
                var jobRoleField = By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder > div:nth-child(2) > div.block-card-body > div > div.contact-row > div.contact-details > div:nth-child(6) > div > div > button > div");

                if (IsFieldEmpty(jobRoleField))
                {
                    IWebElement JobRoleElement = _wait.Until(d => d.FindElement(jobRoleField));

                    try
                    {
                        JobRoleElement.Click();
                    }
                    catch (ElementClickInterceptedException)
                    {
                        ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", JobRoleElement);
                    }
                    Thread.Sleep(2000); // Delay for 2 seconds

                    // Select "Admin Clerk" option
                    var adminClerkOption = By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-building-block-content > div.manage-block-card-holder > div:nth-child(2) > div.block-card-body > div > div.contact-row > div.contact-details > div:nth-child(6) > div > div > div > div.filter-container > ul > li:nth-child(4)");

                    IWebElement AdminClerkElement = _wait.Until(d => d.FindElement(adminClerkOption));

                    try
                    {
                        AdminClerkElement.Click();
                    }
                    catch (ElementClickInterceptedException)
                    {
                        ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", AdminClerkElement);
                    }
                    Thread.Sleep(2000); // Delay for 2 seconds
                }

                // If all fields are filled, click "Add Additional Contact Person" button
                if (!IsFieldEmpty(nameField) &&
                    !IsFieldEmpty(emailField) &&
                    !IsFieldEmpty(telephoneField) &&
                    !IsFieldEmpty(alternateField) &&
                    !IsFieldEmpty(mobileField))
                {
                    try
                    {
                        IWebElement addContactButton = _wait.Until(d => d.FindElement(By.CssSelector("#add-contact")));
                        addContactButton.Click();
                        Console.WriteLine("Contact added successfully!");
                    }
                    catch (ElementClickInterceptedException)
                    {
                        Console.WriteLine("Failed to click 'Add Contact' button.");
                    }
                }
                else
                {
                    Console.WriteLine("Some fields are still empty. Cannot add contact.");
                }

            }
            catch (ElementClickInterceptedException)
            {
                Console.WriteLine("Error: ");
            }

            //Select Add additional Contact Person


            try
            {

                // Click the Add Additional Contact person button
                IWebElement addContactButton = _wait.Until(d => d.FindElement(By.CssSelector("#add-contact")));
                addContactButton.Click();


                Console.WriteLine("Login Successful!");

            }
            catch (ElementClickInterceptedException)
            {
                Console.WriteLine($"Login Failed");
            }

            //Click the Submit button

            try
            {

                // Click the Submit button
                IWebElement submitButton = _wait.Until(d => d.FindElement(By.CssSelector("#action-building-block")));
                submitButton.Click();


                Console.WriteLine("Login Successful!");

            }
            catch (ElementClickInterceptedException)
            {
                Console.WriteLine($"Login Failed");
            }


            // Navigate to the desired element (Dropdown Button)
            IWebElement specificElementToClick14 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[2]/header/div[2]/nav[1]/ul/li[2]/div/button/h3/span")));
            try
            {
                specificElementToClick14.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick14);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            // Wait for the dropdown to be visible

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
