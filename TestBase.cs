using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Data;
using System.Data.OleDb;
using System.Threading;

namespace WOI_Testsuite
{
    public class TestBase
    {
        private ChromeOptions _chromeOptions;
        protected IWebDriver _driver;
        protected WebDriverWait _wait;
        private string _userName;
        private string _password;

        [OneTimeSetUp]
        public void StartBrowser()
        {
            _chromeOptions = new ChromeOptions();
            _chromeOptions.AddArguments("--incognito");
            _chromeOptions.AddArguments("--ignore-certificate-errors");
            _driver = new ChromeDriver("C:/Users/MankgashaMaenetja/source/repos/WOI_TestSuite/WOI_Testsuite/WorldOfImpact/bin/Debug/Drivers");

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            _driver.Url = "https://woi-sit.azurewebsites.net/";
            _driver.Manage().Window.Maximize();
        }

        //public void ReadData()
        //{
        //    // Define the path to your Excel file and the sheet name
        //    string filePath = @"C:\Users\MankgashaMaenetja\source\repos\WOI_TestSuite\WOI_Testsuite\WorldOfImpact\TestData\NC.xlsx"; // Update this with the actual path to your Excel file
        //    string sheetName = "Shelters"; // Replace with the actual sheet name in your Excel file

        //    // Call the ReadExcelData method to retrieve the data
        //    DataTable excelData = ReadExcelData(filePath, sheetName);

        //    // Example: Iterate through the rows and use the data in your test
        //    Console.WriteLine("Data from Excel:");
        //    foreach (DataRow row in excelData.Rows)
        //    {
        //        foreach (var item in row.ItemArray)
        //        {
        //            Console.Write(item.ToString() + "\t");
        //        }
        //        Console.WriteLine();
        //    }

        //    // Example: Use data from the Excel sheet in your test
        //    /*  string someValueFromExcel = excelData.Rows[0]["Contact Person"].ToString();*/ // Replace 'ColumnName' with the actual column name
        //                                                                                      //Console.WriteLine($"Using value from Excel: {someValueFromExcel}");

        //    // Proceed with the rest of your test logic
        //    try
        //    {
        //        _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("overlay")));
        //    }
        //    catch (WebDriverTimeoutException)
        //    {
        //        Console.WriteLine("Overlay did not disappear within the wait time.");
        //    }
        //    Thread.Sleep(2000);

        //}

        public IWebDriver SiteConnection()
        {
            if (_driver == null)
            {
                throw new InvalidOperationException("WebDriver is not initialized. Ensure StartBrowser() is called before using SiteConnection().");
            }

            return _driver;
        }

        [OneTimeTearDown]
        public void DisconnectBrowser()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null; // Clear reference to prevent reuse
            }
            }

            public void Delay(int delaySeconds)
            {
                Thread.Sleep(delaySeconds * 1000);
            }

            public DataTable ReadExcelData(string filePath, string sheetName)
            {
                try
                {
                    // Define the connection string for .xlsx files
                    string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0 Xml;HDR=YES;'";

                    // Create a connection to the Excel file
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        // Query to read data from the specified sheet
                        string query = $"SELECT * FROM [{sheetName}$]";

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable; // Return the populated DataTable
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading Excel file: " + ex.Message);
                    throw;
                }
            }


        }
    }








