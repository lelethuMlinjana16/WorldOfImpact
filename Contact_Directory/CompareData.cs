

////using ClosedXML.Excel;
////using OpenQA.Selenium;
////using OpenQA.Selenium.Chrome;
////using OpenQA.Selenium.Support.UI;
////using SeleniumExtras.WaitHelpers;
////using System;
////using System.Collections.Generic;
////using System.IO;
////using System.Linq;
////using NUnit.Framework;
////using OfficeOpenXml;

////namespace WOI_Testsuite.Contact_Directory
////{
////    [TestFixture]
////    public class Contact : TestBase
////    {
////        private WebDriverWait _wait;
////        private string excelPath = @"C:\Users\MankgashaMaenetja\source\repos\WOI_TestSuite\WOI_Testsuite\WorldOfImpact\TestData\NC.xlsx";
////        private string sheetName = "Shelters";

////        [SetUp]
////        public void StartBrowser()
////        {
////            _driver = base.SiteConnection();
////            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
////            _driver.Url = "https://woi-sit.azurewebsites.net/";
////            _driver.Manage().Window.Maximize();
////        }

////        [Test, Order(1)]
////        public void CheckShelterData()
////        {
////            try
////            {
////                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
////            }
////            catch (WebDriverTimeoutException)
////            {
////                Console.WriteLine("Overlay did not disappear within the wait time.");
////            }

////            Thread.Sleep(2000); // Delay for UI loading

////            // Navigate to the Shelters page
////            ClickElement(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[1]/a"));
////            ClickElement(By.XPath("//*[@id='root']/div[2]/header/div[3]/nav/ul/li[1]/div/button/div"));
////            ClickElement(By.XPath("//li[text()='Northern Cape']"));
////            ClickElement(By.XPath("//*[@id='root']/div[2]/div/div/div[1]/div/div[1]/div/button/div"));
////            ClickElement(By.XPath("//li[text()='Shelters']"));

////            // Verify selection
////            IWebElement selectedOptions = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Shelters']")));
////            Assert.That(selectedOptions.Displayed, Is.True, "Shelters was not successfully selected.");
////        }

////        private void ClickElement(By by)
////        {
////            IWebElement element = _wait.Until(ExpectedConditions.ElementToBeClickable(by));
////            try
////            {
////                element.Click();
////            }
////            catch (ElementClickInterceptedException)
////            {
////                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
////            }
////            Thread.Sleep(2000); // Short delay for UI stability
////        }

////        [Test, Order(2)]
////        public void ValidateShelterData()
////        {
////            var excelData = GetExcelData(excelPath, sheetName);
////            var uiData = GetUIData(".table-component .card-header h2"); //Change to the actual CSS Selector of your UI table

////            var discrepancies = ValidateData(uiData, excelData);

////            if (discrepancies.Any())
////            {
////                Console.WriteLine("Discrepancies found:");
////                foreach (var issue in discrepancies)
////                {
////                    Console.WriteLine(issue);
////                }
////                Assert.Fail("Data mismatch found.");
////            }
////            else
////            {
////                Console.WriteLine("UI data matches Excel data perfectly!");
////                Assert.Pass();
////            }
////        }

////        public List<Dictionary<string, string>> GetExcelData(string filePath, string sheetName)
////        {
////            var excelData = new List<Dictionary<string, string>>();

////            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

////            using (var package = new ExcelPackage(new FileInfo(filePath)))
////            {
////                var worksheet = package.Workbook.Worksheets[sheetName];

////                if (worksheet == null)
////                {
////                    throw new Exception($"Sheet {sheetName} not found in {filePath}");
////                }

////                int rowCount = worksheet.Dimension.Rows;

////                for (int row = 2; row <= rowCount; row++) // Skipping headers
////                {
////                    var rowData = new Dictionary<string, string>
////                    {
////                        { "Name", worksheet.Cells[row, 1].Text.Trim() },
////                         { "Requirement", worksheet.Cells[row, 2].Text.Trim() },
////                        { "Contact Person", worksheet.Cells[row, 3].Text.Trim() },
////                        { "Contact Number", worksheet.Cells[row, 4].Text.Trim() },
////                        { "Email", worksheet.Cells[row, 5].Text.Trim() }
////                    };

////                    excelData.Add(rowData);
////                }
////            }

////            return excelData;
////        }

////        public List<Dictionary<string, string>> GetUIData(string tableSelector)
////        {
////            var uiData = new List<Dictionary<string, string>>();
////            var rows = _driver.FindElements(By.CssSelector($"{tableSelector} tbody tr"));

////            foreach (var row in rows)
////            {
////                var cells = row.FindElements(By.TagName("td"));
////                if (cells.Count < 4) continue; // Ensure all columns exist

////                var rowData = new Dictionary<string, string>
////                {
////                    { "Name", cells[0].Text.Trim() },
////                     { "Requirement", cells[1].Text.Trim() },
////                    { "Contact Person", cells[2].Text.Trim() },
////                    { "Contact Number", cells[3].Text.Trim() },
////                    { "Email", cells[4].Text.Trim() }
////                };

////                uiData.Add(rowData);
////            }

////            return uiData;
////        }

////        public List<string> ValidateData(List<Dictionary<string, string>> uiData, List<Dictionary<string, string>> excelData)
////        {
////            var discrepancies = new List<string>();

////            foreach (var excelRow in excelData)
////            {
////                var match = uiData.FirstOrDefault(uiRow => uiRow["Name"] == excelRow["Name"]);

////                if (match == null)
////                {
////                    discrepancies.Add($"Missing: {excelRow["Name"]} (Not found in UI)");
////                }
////                else
////                {
////                    foreach (var key in excelRow.Keys)
////                    {
////                        if (match[key] != excelRow[key])
////                        {
////                            discrepancies.Add($"Mismatch for {excelRow["Name"]}: {key} (UI: {match[key]} | Excel: {excelRow[key]})");
////                        }
////                    }
////                }
////            }

////            return discrepancies;
////        }

////        [TearDown]
////        public void CloseBrowser()
////        {
////            _driver.Quit();
////        }
////    }
////}


//using ClosedXML.Excel;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using NUnit.Framework;
//using OfficeOpenXml;

//namespace WOI_Testsuite.Contact_Directory
//{
//    [TestFixture]
//    public class Contact : TestBase
//    {
//        private WebDriverWait _wait;
//        private string excelPath = @"C:\Users\MankgashaMaenetja\source\repos\WOI_TestSuite\WOI_Testsuite\WorldOfImpact\TestData\NC.xlsx";
//        private string sheetName = "Shelters";

//        [SetUp]
//        public void StartBrowser()
//        {
//            _driver = base.SiteConnection();
//            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
//            _driver.Url = "https://woi-sit.azurewebsites.net/";
//            _driver.Manage().Window.Maximize();
//        }

//        [Test, Order(1)]
//        public void CheckShelterData()
//        {
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }
//            Thread.Sleep(2000);

//            ClickElement(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[1]/a"));
//            ClickElement(By.XPath("//*[@id='root']/div[2]/header/div[3]/nav/ul/li[1]/div/button/div"));
//            ClickElement(By.XPath("//li[text()='Northern Cape']"));
//            ClickElement(By.XPath("//*[@id='root']/div[2]/div/div/div[1]/div/div[1]/div/button/div"));
//            ClickElement(By.XPath("//li[text()='Shelters']"));

//            IWebElement selectedOptions = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Shelters']")));
//            Assert.That(selectedOptions.Displayed, Is.True, "Shelters was not successfully selected.");
//        }

//        private void ClickElement(By by)
//        {
//            IWebElement element = _wait.Until(ExpectedConditions.ElementToBeClickable(by));
//            try
//            {
//                element.Click();
//            }
//            catch (ElementClickInterceptedException)
//            {
//                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
//            }
//            Thread.Sleep(2000);
//        }

//        [Test, Order(2)]
//        public void ValidateShelterData()
//        {
//            var excelData = GetExcelData(excelPath, sheetName);
//            var uiData = GetUIData("#root > div.app-container.full-width > div > div > div.contact-directory-content");

//            var discrepancies = ValidateData(uiData, excelData);

//            if (discrepancies.Any())
//            {
//                Console.WriteLine("Discrepancies found:");
//                foreach (var issue in discrepancies)
//                {
//                    Console.WriteLine(issue);
//                }
//                Assert.Fail("Data mismatch found.");
//            }
//            else
//            {
//                Console.WriteLine("UI data matches Excel data perfectly!");
//                Assert.Pass();
//            }
//        }

//        public List<Dictionary<string, string>> GetExcelData(string filePath, string sheetName)
//        {
//            var excelData = new List<Dictionary<string, string>>();
//            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

//            using (var package = new ExcelPackage(new FileInfo(filePath)))
//            {
//                var worksheet = package.Workbook.Worksheets[sheetName];
//                if (worksheet == null)
//                {
//                    throw new Exception($"Sheet {sheetName} not found in {filePath}");
//                }
//                int rowCount = worksheet.Dimension.Rows;
//                for (int row = 2; row <= rowCount; row++)
//                {
//                    var rowData = new Dictionary<string, string>
//                    {
//                        { "Name", worksheet.Cells[row, 1].Text.Trim() },
//                        { "Requirement", worksheet.Cells[row, 2].Text.Trim() },
//                        { "Contact Person", worksheet.Cells[row, 3].Text.Trim() },
//                        { "Contact Number", worksheet.Cells[row, 4].Text.Trim() },
//                        { "Email", worksheet.Cells[row, 5].Text.Trim() }
//                    };
//                    excelData.Add(rowData);
//                }
//            }
//            return excelData;
//        }

//        public List<Dictionary<string, string>> GetUIData(string tableSelector)
//        {
//            var uiData = new List<Dictionary<string, string>>();
//            var rows = _driver.FindElements(By.XPath("/html/body/div/div[2]/div/div/div[2]/div[1]"));

//            foreach (var row in rows)
//            {
//                var cells = row.FindElements(By.ClassName("td"));
//                if (cells.Count < 5) continue;

//                var rowData = new Dictionary<string, string>
//                {
//                    { "Name", cells[0].Text.Trim() },
//                    { "Requirement", cells[1].Text.Trim() },
//                    { "Contact Person", cells[2].Text.Trim() },
//                    { "Contact Number", cells[3].Text.Trim() },
//                    { "Email", cells[4].Text.Trim() }
//                };
//                uiData.Add(rowData);
//            }
//            return uiData;
//        }

//        public List<string> ValidateData(List<Dictionary<string, string>> uiData, List<Dictionary<string, string>> excelData)
//        {
//            var discrepancies = new List<string>();

//            foreach (var excelRow in excelData)
//            {
//                var match = uiData.FirstOrDefault(uiRow => uiRow["Name"] == excelRow["Name"]);
//                if (match == null)
//                {
//                    discrepancies.Add($"Missing: {excelRow["Name"]} (Not found in UI)");
//                }
//                else
//                {
//                    foreach (var key in excelRow.Keys)
//                    {
//                        if (match[key] != excelRow[key])
//                        {
//                            discrepancies.Add($"Mismatch for {excelRow["Name"]}: {key} (UI: {match[key]} | Excel: {excelRow[key]})");
//                        }
//                    }
//                }
//            }
//            return discrepancies;
//        }
//    }
//}



//using ClosedXML.Excel;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using NUnit.Framework;
//using OfficeOpenXml;
//using System.Threading;

//namespace WOI_Testsuite.Contact_Directory
//{
//    [TestFixture]
//    public class Contact : TestBase
//    {
//        private WebDriverWait _wait;
//        private string excelPath = @"C:\Users\MankgashaMaenetja\source\repos\WOI_TestSuite\WOI_Testsuite\WorldOfImpact\TestData\NC.xlsx";
//        private string sheetName = "Shelters";

//        [SetUp]
//        public void StartBrowser()
//        {
//            _driver = base.SiteConnection();
//            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
//            _driver.Url = "https://woi-sit.azurewebsites.net/";
//            _driver.Manage().Window.Maximize();
//        }

//        [Test, Order(1)]
//        public void CheckShelterData()
//        {
//            try
//            {
//                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                Console.WriteLine("Overlay did not disappear within the wait time.");
//            }

//            Thread.Sleep(2000);

//            ClickElement(By.XPath("/html/body/div/div[2]/header/div[2]/nav[1]/ul/li[1]/a"));
//            ClickElement(By.XPath("//*[@id='root']/div[2]/header/div[3]/nav/ul/li[1]/div/button/div"));
//            ClickElement(By.XPath("//li[text()='Northern Cape']"));
//            ClickElement(By.XPath("//*[@id='root']/div[2]/div/div/div[1]/div/div[1]/div/button/div"));
//            ClickElement(By.XPath("//li[text()='Shelters']"));

//            IWebElement selectedOptions = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Shelters']")));
//            Assert.That(selectedOptions.Displayed, Is.True, "Shelters was not successfully selected.");
//        }

//        private void ClickElement(By by)
//        {
//            IWebElement element = _wait.Until(ExpectedConditions.ElementToBeClickable(by));
//            try
//            {
//                element.Click();
//            }
//            catch (ElementClickInterceptedException)
//            {
//                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
//            }
//            Thread.Sleep(2000);
//        }

//        [Test, Order(2)]
//        public void ValidateShelterData()
//        {
//            var excelData = GetExcelData(excelPath, sheetName);
//            var uiData = GetUIData();

//            var discrepancies = ValidateData(uiData, excelData);

//            if (discrepancies.Any())
//            {
//                Console.WriteLine("Discrepancies found:");
//                foreach (var issue in discrepancies)
//                {
//                    Console.WriteLine(issue);
//                }
//                Assert.Fail("Data mismatch found.");
//            }
//            else
//            {
//                Console.WriteLine("UI data matches Excel data perfectly!");
//                Assert.Pass();
//            }
//        }

//        public List<Dictionary<string, string>> GetExcelData(string filePath, string sheetName)
//        {
//            var excelData = new List<Dictionary<string, string>>();
//            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

//            using (var package = new ExcelPackage(new FileInfo(filePath)))
//            {
//                var worksheet = package.Workbook.Worksheets[sheetName];
//                if (worksheet == null)
//                {
//                    throw new Exception($"Sheet {sheetName} not found in {filePath}");
//                }
//                int rowCount = worksheet.Dimension.Rows;
//                for (int row = 2; row <= rowCount; row++)
//                {
//                    var rowData = new Dictionary<string, string>
//                    {
//                        { "Name", worksheet.Cells[row, 1].Text.Trim() },
//                        { "Requirement", worksheet.Cells[row, 2].Text.Trim() },
//                        { "Contact Person", worksheet.Cells[row, 3].Text.Trim() },
//                        { "Contact Number", worksheet.Cells[row, 4].Text.Trim() },
//                        { "Email", worksheet.Cells[row, 5].Text.Trim() }
//                    };
//                    excelData.Add(rowData);
//                }
//            }
//            return excelData;
//        }

//        public List<Dictionary<string, string>> GetUIData()
//        {
//            var uiData = new List<Dictionary<string, string>>();

//            Explicit wait to ensure the element is loaded
//           WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
//            var container = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("#root > div.app-container.full-width > div > div > div.contact-directory-content")));

//            Fetch all shelter cards within the container
//           var shelterCards = container.FindElements(By.CssSelector(".table-component"));

//            foreach (var card in shelterCards)
//            {
//                try
//                {
//                    var shelterNameElement = card.FindElement(By.CssSelector(".card-header h2"));
//                    string shelterName = shelterNameElement.Text.Trim();

//                    string requirement = "Shelters"; // Static as per UI structure
//                    string contactPerson = "No contacts found";
//                    string contactNumber = "N/A";
//                    string email = "N/A";

//                    Extract contact details inside the card
//                    var contactDetails = card.FindElements(By.CssSelector(".col span"));
//                    if (contactDetails.Count > 0)
//                    {
//                        contactPerson = contactDetails[0].Text.Trim();
//                        contactNumber = contactDetails.Count > 1 ? contactDetails[1].Text.Trim() : "N/A";
//                    }

//                    var rowData = new Dictionary<string, string>
//            {
//                { "Name", shelterName },
//                { "Requirement", requirement },
//                { "Contact Person", contactPerson },
//                { "Contact Number", contactNumber },
//                { "Email", email }
//            };

//                    uiData.Add(rowData);
//                }
//                catch (NoSuchElementException ex)
//                {
//                    Console.WriteLine($"Skipping card due to missing elements: {ex.Message}");
//                }
//            }

//            return uiData;
//        }



//        public List<string> ValidateData(List<Dictionary<string, string>> uiData, List<Dictionary<string, string>> excelData)
//        {
//            var discrepancies = new List<string>();

//            foreach (var excelRow in excelData)
//            {
//                var match = uiData.FirstOrDefault(uiRow => uiRow["Name"] == excelRow["Name"]);
//                if (match == null)
//                {
//                    discrepancies.Add($"Missing: {excelRow["Name"]} (Not found in UI)");
//                }
//                else
//                {
//                    foreach (var key in excelRow.Keys)
//                    {
//                        if (!match.ContainsKey(key))
//                        {
//                            discrepancies.Add($"UI does not contain key: {key} for {excelRow["Name"]}");
//                            continue;
//                        }

//                        if (match[key] != excelRow[key])
//                        {
//                            discrepancies.Add($"Mismatch for {excelRow["Name"]}: {key} (UI: {match[key]} | Excel: {excelRow[key]})");
//                        }
//                    }
//                }
//            }

//            return discrepancies;
//        }
//    }
//}

using ClosedXML.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using OfficeOpenXml;
using System.Threading;

namespace WOI_Testsuite.Contact_Directory
{
    [TestFixture]
    public class Contact : TestBase
    {
        private WebDriverWait _wait;
        private string excelPath = @"C:\Users\MankgashaMaenetja\source\repos\WOI_TestSuite\WOI_Testsuite\WorldOfImpact\TestData\NC.xlsx";
        private string sheetName = "Shelters";
        private string sheetName1 = "Contaiment Centers";

        [SetUp]
        public void StartBrowser()
        {
            _driver = base.SiteConnection();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Url = "https://woi-sit.azurewebsites.net/";
            _driver.Manage().Window.Maximize();
        }

        [Test, Order(1)]
        public void CheckShelterData()
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

            // Clicking the Northern Cape and Shelters options using CSS selectors
            ClickElement(By.CssSelector("nav ul li:nth-child(1) a"));
            ClickElement(By.CssSelector("header nav ul li:nth-child(1) div button div"));
            ClickElement(By.CssSelector("li[text()='Northern Cape']"));
            ClickElement(By.CssSelector("div div div div button div"));
            ClickElement(By.CssSelector("li[text()='Shelters']"));

            IWebElement selectedOptions = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("span[text()='Shelters']")));
            Assert.That(selectedOptions.Displayed, Is.True, "Shelters was not successfully selected.");
        }

        private void ClickElement(By by)
        {
            IWebElement element = _wait.Until(ExpectedConditions.ElementToBeClickable(by));
            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", element);
            }
            Thread.Sleep(2000);
        }

        [Test, Order(2)]
        public void ValidateShelterData()
        {
            var excelData = GetExcelData(excelPath, sheetName);
            var uiData = GetUIData();

            // Compare the data
            CompareData(excelData, uiData);
        }

        public List<Dictionary<string, string>> GetExcelData(string filePath, string sheetName)
        {
            var excelData = new List<Dictionary<string, string>>();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[sheetName];
                if (worksheet == null)
                {
                    throw new Exception($"Sheet {sheetName} not found in {filePath}");
                }
                int rowCount = worksheet.Dimension.Rows;
                for (int row = 2; row <= rowCount; row++)
                {
                    var rowData = new Dictionary<string, string>
                    {
                         { "Name", worksheet.Cells[row, 1].Text.Trim() + " | " + worksheet.Cells[row, 8].Text.Trim() },
                        { "Requirement", worksheet.Cells[row, 2].Text.Trim() },
                        { "Contact Person", worksheet.Cells[row, 3].Text.Trim() },
                        { "Contact Number", worksheet.Cells[row, 4].Text.Trim() },
                        { "Email", worksheet.Cells[row, 5].Text.Trim() }
                        
                    };
                    excelData.Add(rowData);
                }
            }
            return excelData;
        }
        //0639563708
        public List<Dictionary<string, string>> GetUIData()
        {
            var uiData = new List<Dictionary<string, string>>();

            // Explicit wait to ensure the element is loaded
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            var container = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(".contact-directory-content")));

            // Fetch all shelter cards within the container
            var shelterCards = container.FindElements(By.CssSelector(".table-component"));

            foreach (var card in shelterCards)
            {
                try
                {
                    var shelterNameElement = card.FindElement(By.CssSelector(".card-header h2"));
                    string shelterName = shelterNameElement.Text.Trim();

                    string requirement = "Containment Centers "; // Static as per UI structure
                  

                    var rowData = new Dictionary<string, string>
                    {
                        { "Name", shelterName },
                        { "Requirement", requirement },
                        //{ "Contact Person", contactPerson },
                        //{ "Contact Number", contactNumber },
                        //{ "Email", email }
                    };

                    uiData.Add(rowData);
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine($"Skipping card due to missing elements: {ex.Message}");
                }
            }

            return uiData;
        }

        public void CompareData(List<Dictionary<string, string>> excelData, List<Dictionary<string, string>> uiData)
        {
            var discrepancies = new List<string>();

            // Iterate over Excel data
            foreach (var excelRow in excelData)
            {
                var uiRow = uiData.FirstOrDefault(u => u["Name"] == excelRow["Name"]);

                // If we don't find the Excel row in the UI data
                if (uiRow == null)
                {
                    discrepancies.Add($"Missing entry for {excelRow["Name"]} in the UI.");
                    continue;
                }

                // Compare each field in the Excel row with the UI row
                foreach (var key in excelRow.Keys)
                {
                    if (!uiRow.ContainsKey(key))
                    {
                        discrepancies.Add($"Missing key '{key}' for {excelRow["Name"]} in the UI.");
                        continue;
                    }

                    if (excelRow[key] != uiRow[key])
                    {
                        discrepancies.Add($"Mismatch for {excelRow["Name"]}: {key} (UI: {uiRow[key]} | Excel: {excelRow[key]})");
                    }
                }
            }

            // Report discrepancies
            if (discrepancies.Any())
            {
                Console.WriteLine("Discrepancies found:");
                foreach (var issue in discrepancies)
                {
                    Console.WriteLine(issue);
                }
                Assert.Fail("Data mismatch found.");
            }
            else
            {
                Console.WriteLine("UI data matches Excel data perfectly!");
                Assert.Pass();
            }
        }
    }
}




