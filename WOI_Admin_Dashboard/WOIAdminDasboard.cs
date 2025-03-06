using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOI_Testsuite.WOI_Admin_Dashboard
{


    [TestFixture]

    public class WOIAdminDasboard_Testcases : TestBase
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
        public void WOI()
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


            try
            {


                // Find and fill the username field
                IWebElement usernameField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(1) > div > input")));
                usernameField.SendKeys("mankgasha@digitalsolutionfoundry.co.za");

                // Find and fill the password field
                IWebElement passwordField = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.auth-container > div > div:nth-child(3) > div:nth-child(2) > div > input")));
                passwordField.SendKeys("Password@123456789");

                // Click the login button
                IWebElement loginButton = _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[4]/div[1]/button"));
                loginButton.Click();


                Console.WriteLine("Login Successful!");

            }
            catch (ElementClickInterceptedException)
            {
                Console.WriteLine($"Login Failed");
            }

            //Click the View all applications


            IWebElement viewAll = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div > div:nth-child(1) > div > div.section-content.healthcheck > div.stat-card.bottom.healthcheck > a > div.stat-label.bottom.healthcheck")));
            try
            {
                viewAll.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", viewAll);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            ////Select the View

            //IWebElement view = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.organisation-content > div > div.table-body > div:nth-child(1) > div:nth-child(4) > div > div > div")));
            //try
            //{
            //    view.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", view);
            //}
            //Thread.Sleep(2000); // Delay for 2 seconds


            ////Select the Approve button

            //IWebElement approveButton = _wait.Until(d => d.FindElement(By.CssSelector("#approve-button")));
            //try
            //{
            //    approveButton.Click();
            //}
            //catch (ElementClickInterceptedException)
            //{
            //    ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", approveButton);
            //}
            //Thread.Sleep(2000); // Delay for 2 seconds


            //View all the applications


            IWebElement selectAll = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.organisation-container-search > div.component-filter-container > div.filter-component > div > button")));
            try
            {
                selectAll.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", selectAll);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            //Select the All from the dropdown option


            IWebElement allOption = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.organisation-container-search > div.component-filter-container > div.filter-component > div > ul > li:nth-child(1)")));
            try
            {
                allOption.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", allOption);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            //return to the admin landing page

            IWebElement landingpage = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > header > div.header-top > div > a")));
            try
            {
                landingpage.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", landingpage);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            //click the manage

            IWebElement managepage = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div > div:nth-child(2) > div > div.section-header.questionnare.healthcheck > div > div.suffix.health-check > h2")));
            try
            {
                managepage.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", managepage);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            //click the preview

            IWebElement previewLink = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.questionnaire-body > div:nth-child(2) > div:nth-child(1) > div.survey-header > div.quest-header-left > a")));
            try
            {
                previewLink.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", previewLink);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            //Click the View previous questionnaires

            IWebElement previewQ = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.questionnaire-body > div:nth-child(2) > div.previous-view > strong")));
            try
            {
                previewQ.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", previewQ);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            //return to landing page

            IWebElement returnL = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.questionnaire-header > div > div.prefix > h1")));
            try
            {
                returnL.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", returnL);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            //Go to the profile

            IWebElement profileWOI = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > header > div.header-top > nav.desktop > ul > li:nth-child(2) > div > button > h3 > span")));
            try
            {
                profileWOI.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", profileWOI);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            //Select the Manage Users and Groups


            IWebElement manageUsersandGroups = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > header > div.header-top > nav.desktop > ul > li:nth-child(2) > div > ul > li:nth-child(3)")));
            try
            {
                manageUsersandGroups.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", manageUsersandGroups);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            //Filter by users


            IWebElement filterUsers = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-usergroup-container-search > div.component-filter-container > div.filter-component > div > button")));
            try
            {
                filterUsers.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", filterUsers);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            //Select user


            IWebElement selectUser = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-usergroup-container-search > div.component-filter-container > div.filter-component > div > ul > li:nth-child(1)")));
            try
            {
                selectUser.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", selectUser);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            //Select manage

            IWebElement selectManage = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-usergroup-content > div > div.table-body > div:nth-child(1) > div:nth-child(3) > div > div > div")));
            try
            {
                selectManage.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", selectManage);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            //Select Cancel

            IWebElement cancelButton = _wait.Until(d => d.FindElement(By.CssSelector("#cancel-button")));
            try
            {
                cancelButton.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", cancelButton);
            }
            Thread.Sleep(2000); // Delay for 2 seconds


            //Go back to landing page


            IWebElement backToLanding = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > div > div > div.manage-usergroup-container-search > div.container-header > div.prefix > h1")));
            try
            {
                backToLanding.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", backToLanding);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            //Go to the profile

            IWebElement profile = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > header > div.header-top > nav.desktop > ul > li:nth-child(2) > div > button > h3 > span")));
            try
            {
                profile.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", profile);
            }
            Thread.Sleep(2000); // Delay for 2 seconds

            //Select the Logout


            IWebElement logOut = _wait.Until(d => d.FindElement(By.CssSelector("#root > div.authenticated-layout > header > div.header-top > nav.desktop > ul > li:nth-child(2) > div > ul > li:nth-child(4)")));
            try
            {
                logOut.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", logOut);
            }
            Thread.Sleep(2000); // Delay for 2 seconds
        }
    }
}
