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
            try
            {

                IWebElement targetElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[4]/a")));

                // Click the element
                targetElement.Click();

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


                IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[1]/button/div")));

                // Select the "Northern Cape" option from the dropdown
                IWebElement missOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Miss']")));

                missOption.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the firstname field
                IWebElement firstNameField = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[3]/input")));
                firstNameField.SendKeys("Mary");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the lastname field
                IWebElement lastNameField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[4]/input"));
                lastNameField.SendKeys("Jansen");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement telephoneField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[6]/input"));
                telephoneField.SendKeys("0118763297");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement emailAddressField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[7]/input"));
                emailAddressField.SendKeys("marydibete@gmail.com");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement passwordsField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[9]/input"));
                passwordsField.SendKeys("Password@123456789");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement confirmPasswordField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[10]/input"));
                confirmPasswordField.SendKeys("Password@123456789");

                Thread.Sleep(2000); // Delay for 2 seconds


                // Click the next button
                IWebElement nextButton = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                nextButton.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the OrganisationName field
                IWebElement organisationNameField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[1]/input"));
                organisationNameField.SendKeys("Mukwevho Holdings");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Organisation Type field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick1 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[2]/button/div")));
                try
                {
                    specificElementToClick1.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick1);
                }
                Thread.Sleep(2000);

                IWebElement dropdownMenu1 = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[2]/button/div")));

                IWebElement organisationTypeField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='NGO']")));

                organisationTypeField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Your role in the organisation field
                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick2 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[4]/button/div")));
                try
                {
                    specificElementToClick2.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick2);
                }
                Thread.Sleep(2000);

                IWebElement dropdownMenu2 = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[4]/button/div")));

                IWebElement organisationRoleField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Admin Clerk']")));

                organisationRoleField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Organisation branch field
                IWebElement organisationBranchField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[6]/input"));
                organisationBranchField.SendKeys("Mukwevho Holdings");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Street number field
                IWebElement streetNumberField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[7]/input"));
                streetNumberField.SendKeys("10073");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Street name field
                IWebElement streetNameField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[8]/input"));
                streetNameField.SendKeys("Sunny-side");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Suburb field
                IWebElement suburbField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[9]/input"));
                suburbField.SendKeys("Phalaborwa");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the city field
                IWebElement cityField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[10]/input"));
                cityField.SendKeys("Tzaneen");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Postal code field
                IWebElement postalCodeField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[11]/input"));
                postalCodeField.SendKeys("0744");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Province field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick4 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[12]/button/div")));
                try
                {
                    specificElementToClick4.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick4);
                }
                Thread.Sleep(2000);

                IWebElement dropdownMenu3 = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[12]/button/div")));

                IWebElement provinceField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Limpopo']")));

                provinceField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the District field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick5 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[14]/button/div")));
                try
                {
                    specificElementToClick5.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick5);
                }
                Thread.Sleep(2000);

                IWebElement dropdownMenu4 = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[14]/button/div")));

                IWebElement districtField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Mopani']")));

                districtField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Local Municipality field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick6 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[16]/button/div")));
                try
                {
                    specificElementToClick6.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick6);
                }
                Thread.Sleep(2000);

                IWebElement dropdownMenu5 = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[16]/button/div")));

                IWebElement localMunicipalityField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Ba-Phalaborwa Local Municipality']")));

                localMunicipalityField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds


                // Click the next button
                IWebElement nextButton1 = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                nextButton1.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                Console.WriteLine("Next Successful!");

                // Find and fill the Number of members in organisation field
                IWebElement numberOfMembersInOrganisationField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[1]/input"));
                numberOfMembersInOrganisationField.SendKeys("50");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Number of members in organisation field
                IWebElement element = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/form/div/div/div[2]/div/div[2]/label/span")));

                // Click the element
                element.Click();

                Thread.Sleep(2000); // Delay for 2 seconds


                // Get all open window handles
                List<string> windowHandles = new List<string>(_driver.WindowHandles);

                _driver.SwitchTo().Window(windowHandles[0]);
                Console.WriteLine("Switched back to previous tab: " + _driver.Title);


                Thread.Sleep(2000); // Delay for 2 seconds

                // Click the next button
                IWebElement nextButton2 = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                nextButton1.Click();

                Thread.Sleep(2000); // Delay for 2 seconds 


                // Locate the input field using XPath
                IWebElement inputField = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/input"));

                //Enter the number
                inputField.SendKeys("891117");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Login Failed: {ex.Message}");
            }

        }


        [Test, Order(2)]
        public void RegistrationValidation()
        {
            try
            {

                IWebElement targetElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[4]/a")));

                // Click the element
                targetElement.Click();

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


                IWebElement dropdownMenu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[1]/button/div")));

                // Select the "Northern Cape" option from the dropdown
                IWebElement missOption = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Miss']")));

                missOption.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the firstname field
                IWebElement firstNameField = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[3]/input")));
                firstNameField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the lastname field
                IWebElement lastNameField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[4]/input"));
                lastNameField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement telephoneField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[6]/input"));
                telephoneField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement emailAddressField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[7]/input"));
                emailAddressField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement passwordsField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[9]/input"));
                passwordsField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement confirmPasswordField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[10]/input"));
                confirmPasswordField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds


                // Click the next button
                IWebElement nextButton = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                nextButton.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                //Fill in the everything

                // Find and fill the firstname field
                IWebElement firstName1Field = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[3]/input")));
                firstNameField.SendKeys("Mary");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the lastname field
                IWebElement lastNameFie1ld = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[4]/input"));
                lastNameField.SendKeys("Jansen");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement telephone1Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[6]/input"));
                telephoneField.SendKeys("0118763297");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement emailAddress1Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[7]/input"));
                emailAddressField.SendKeys("marymamabolo@gmail.com");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement passwords1Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[9]/input"));
                passwordsField.SendKeys("Password@123456789");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the telephone field
                IWebElement confirmPassword1Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[10]/input"));
                confirmPasswordField.SendKeys("Password@123456789");

                Thread.Sleep(2000); // Delay for 2 seconds


                // Click the next button
                IWebElement nextButton8 = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                nextButton8.Click();

                Thread.Sleep(2000); // Delay for 2 seconds  

                // Find and fill the OrganisationName field
                IWebElement organisationNameField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[1]/input"));
                organisationNameField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Organisation Type field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick1 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[2]/button/div")));
                try
                {
                    specificElementToClick1.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick1);
                }
                Thread.Sleep(2000);

                IWebElement dropdownMenu1 = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[2]/button/div")));

                IWebElement organisationTypeField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='NGO']")));

                organisationTypeField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Your role in the organisation field
                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElementToClick2 = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[4]/button/div")));
                try
                {
                    specificElementToClick2.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElementToClick2);
                }
                Thread.Sleep(2000);

                IWebElement dropdownMenu2 = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[4]/button/div")));

                IWebElement organisationRoleField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Admin Clerk']")));

                organisationRoleField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Organisation branch field
                IWebElement organisationBranchField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[6]/input"));
                organisationBranchField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Street number field
                IWebElement streetNumberField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[7]/input"));
                streetNumberField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Street name field
                IWebElement streetNameField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[8]/input"));
                streetNameField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Suburb field
                IWebElement suburbField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[9]/input"));
                suburbField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the city field
                IWebElement cityField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[10]/input"));
                cityField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Postal code field
                IWebElement postalCodeField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[11]/input"));
                postalCodeField.SendKeys("");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Province field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElement4ToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[12]/button/div")));
                try
                {
                    specificElement4ToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElement4ToClick);
                }
                Thread.Sleep(2000);

                IWebElement dropdown3Menu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[12]/button/div")));

                IWebElement provinceField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Limpopo']")));

                provinceField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the District field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElement5ToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[14]/button/div")));
                try
                {
                    specificElement5ToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElement5ToClick);
                }
                Thread.Sleep(2000);

                IWebElement dropdown4Menu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[14]/button/div")));

                IWebElement districtField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Mopani']")));

                districtField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Local Municipality field

                // Navigate to the desired element (Dropdown Button)
                IWebElement specificElement6ToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/form/div/div/div[2]/div/div[16]/button/div")));
                try
                {
                    specificElement6ToClick.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificElement6ToClick);
                }
                Thread.Sleep(2000);

                IWebElement dropdown5Menu = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/form/div/div/div[2]/div/div[16]/button/div")));

                IWebElement localMunicipalityField = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[text()='Ba-Phalaborwa Local Municipality']")));

                localMunicipalityField.Click();

                Thread.Sleep(2000); // Delay for 2 seconds


                // Click the next button
                IWebElement nextButton1 = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                nextButton1.Click();

                Thread.Sleep(2000); // Delay for 2 seconds

                //Find and fill the OrganisationName field
                IWebElement organisationName15Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[1]/input"));
                organisationName15Field.SendKeys("Mukwevho Holdings");

                Thread.Sleep(2000); // Delay for 2 seconds

           
                // Find and fill the Organisation branch field
                IWebElement organisationBranch15Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[6]/input"));
                organisationBranch15Field.SendKeys("Mukwevho Holdings");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Street number field
                IWebElement streetNumber15Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[7]/input"));
                streetNumber15Field.SendKeys("10073");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Street name field
                IWebElement streetName15Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[8]/input"));
                streetName15Field.SendKeys("Sunny-side");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Suburb field
                IWebElement suburb15Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[9]/input"));
                suburb15Field.SendKeys("Phalaborwa");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the city field
                IWebElement city15Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[10]/input"));
                city15Field.SendKeys("Tzaneen");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Postal code field
                IWebElement postalCode15Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[11]/input"));
                postalCode15Field.SendKeys("0744");

                Thread.Sleep(2000); // Delay for 2 seconds

             

                // Click the next button
                IWebElement next115Button = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                next115Button.Click();


                Console.WriteLine("Next Successful!");


                // Find and fill the Number of members in organisation field
                IWebElement numberOfMembersInOrganisation2Field = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[1]/input"));
                numberOfMembersInOrganisation2Field.SendKeys("");


                // Click the next button
                IWebElement nextButton25 = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                nextButton25.Click();

                Thread.Sleep(2000); // Delay for 2 seconds 

                // Find and fill the Number of members in organisation field
                IWebElement numberOfMembersInOrganisationField = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[2]/div/div[1]/input"));
                numberOfMembersInOrganisationField.SendKeys("50");

                Thread.Sleep(2000); // Delay for 2 seconds

                // Find and fill the Number of members in organisation field
                IWebElement element = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/form/div/div/div[2]/div/div[2]/label/span")));

                // Click the element
                element.Click();

                Thread.Sleep(2000); // Delay for 2 seconds


                // Get all open window handles
                List<string> windowHandles = new List<string>(_driver.WindowHandles);

                _driver.SwitchTo().Window(windowHandles[0]);
                Console.WriteLine("Switched back to previous tab: " + _driver.Title);


                Thread.Sleep(2000); // Delay for 2 seconds

                // Click the next button
                IWebElement nextButton2 = _driver.FindElement(By.XPath("/html/body/div/form/div/div/div[3]/div[1]/button"));
                nextButton2.Click();

                Thread.Sleep(2000); // Delay for 2 seconds 

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

        
    
