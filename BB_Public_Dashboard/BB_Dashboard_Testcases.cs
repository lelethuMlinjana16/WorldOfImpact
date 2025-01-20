using System.Data.OleDb;
using System.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System;


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
            // The Map View

            // Click on the first element in the dashboard using JavaScript click as a fallback  
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
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[1]/ul/li[2]/label/input")));
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
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[1]/ul/li[2]/ul/li[4]/label")));
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

            // Navigate to the desired map element
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






            // Define the path to your Excel file
            string filePath = @"C:\Users\MankgashaMaenetja\source\repos\WOI_TestSuite\WOI_Testsuite\WorldOfImpact\TestData\NC.xlsx"; // Update with the actual file path

            // Define the connection string for .xlsx files (Excel 2007 or later)
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            // Create a connection to the Excel file using OLE DB
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Get the schema of the workbook to determine sheet names
                    DataTable sheets = connection.GetSchema("Tables");
                    Console.WriteLine("Sheets in the workbook:");
                    foreach (DataRow row in sheets.Rows)
                    {
                        Console.WriteLine(row["TABLE_NAME"]);
                    }

                    // Define a list of sheet names that we need to read
                    string[] sheetNames = { "One Stop Centers", "Shelters", "Containment Centers" };

                    // Iterate through each sheet
                    foreach (var sheetName in sheetNames)
                    {
                        // Define a query to select data from the current sheet
                        string query = $"SELECT * FROM [{sheetNames}$]";  // Sheet names must be enclosed in square brackets and followed by a '$'
                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the sheet
                        dataAdapter.Fill(dataTable);

                        // Print the data from the sheet
                        Console.WriteLine($"\nData from Sheet: {sheetName}");
                        Console.WriteLine("---------------------------------------------------");

                        // Print the column names (Headers)
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            Console.Write(column.ColumnName.PadRight(20));
                        }
                        Console.WriteLine();

                        // Print the rows of data
                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                Console.Write(item.ToString().PadRight(20));
                            }
                            Console.WriteLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }



            }
        }

        [Test, Order(2)]
        public void Test_SelectBBChartViewDashboard()
        {
            //if (!Test_SelectCrimeDashboard_Completed)
            //{
            //    Assert.Ignore("Skipping this test because Test_SelectCrimeDashboardView did not complete successfully.");
            //}

            // Wait for the overlay to disappear if present
            try
            {
                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Overlay did not disappear within the wait time.");
            }

            // The Chart View

            // Click on the first element in the dashboard using JavaScript click as a fallback
            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[2]/a")));
            try
            {
                firstElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", firstElementToClick);
            }


            // Click on the desired input element
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[1]/ul/li[2]/label/input")));
            try
            {
                inputElementToClick.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", inputElementToClick);
            }

            // Optionally, add verification if needed
            Assert.That(inputElementToClick.Selected, Is.True, "The input element was not successfully selected.");

            // Locate and click the specific element
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[1]/ul/li[2]/ul/li[4]/label")));
            try
            {
                specificLabel.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", specificLabel);
            }



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

            // Verify the selection
            IWebElement thirdSelectedOption = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Sol Plaatje Local Municipality']"))); // Replace 'Desired Option Text' with the actual option text
            Assert.That(thirdSelectedOption.Displayed, Is.True, "The desired option was not successfully selected from the third dropdown.");


            // Verify the element displayed after clicking
            IWebElement firstClickVerificationElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div[2]/div[1]/div[3]")));
            Assert.That(firstClickVerificationElement.Displayed, Is.True, "The expected element did not appear after the first click.");


            //Test_SelectCrimeDashboard_Completed = true;
        }

        [Test, Order (3)]
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
            // The Grid View

            // Click on the first element in the dashboard using JavaScript click as a fallback
            IWebElement firstElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/header/div[3]/nav/ul/li[3]/a")));
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
            IWebElement inputElementToClick = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[1]/ul/li[2]/label/input")));
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
            IWebElement specificLabel = _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div[2]/div[1]/div[1]/ul/li[2]/ul/li[4]/label")));
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
            // Thread.Sleep(2000); // Delay for 2 seconds Wait for the dropdown to be visible
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




