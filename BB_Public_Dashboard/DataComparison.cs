using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace WOI_Testsuite.Crime_Public_Dashboard
{
    public class DataComparison : TestBase
    {
        private WebDriverWait _wait;
        private IWebDriver _driver;

        public DataComparison(WebDriverWait wait, IWebDriver driver)
        {
            _wait = wait;
            _driver = driver;
        }

        public void CompareDataFromExcelAndApp(string excelFilePath, string sheetName, string appDataXpath)
        {
            // Step 1: Get data from the Excel file
            List<string> excelData = ReadDataFromExcel(excelFilePath, sheetName);
            // Check for duplicates in Excel data
            CheckForDuplicates(excelData, "Excel");

            // Step 2: Get data from the app using Selenium
            List<string> appData = GetAppData(appDataXpath);
            // Check for duplicates in App data
            CheckForDuplicates(appData, "App");

            // Step 3: Compare the data
            CompareExcelAndAppData(excelData, appData);
        }

        private List<string> ReadDataFromExcel(string excelFilePath, string sheetName)
        {
            List<string> data = new List<string>();

            // Define the path to your Excel file
            string filePath = @"C:\Users\MankgashaMaenetja\source\repos\WOI_TestSuite\WOI_Testsuite\WorldOfImpact\TestData\NC.xlsx"; // Update with the actual file path

            // Define the connection string for .xlsx files (Excel 2007 or later)
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to read data from the Excel sheet
                    string query = $"SELECT * FROM [{sheetName}$]";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Add data from the specified column to the list (adjust as needed)
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Assuming we are comparing the first column (adjust as needed)
                        data.Add(row[0].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading Excel: " + ex.Message);
                }
            }

            return data;
        }

        private List<string> GetAppData(string appDataXpath)
        {
            List<string> data = new List<string>();

            try
            {
                // Wait until the elements with app data are visible
                var elements = _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(appDataXpath)));

                // Extract the data from the elements (adjust as necessary for your use case)
                foreach (var element in elements)
                {
                    data.Add(element.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading app data: " + ex.Message);
            }

            return data;
        }

        private void CheckForDuplicates(List<string> data, string sourceName)
        {
            var duplicates = new HashSet<string>();
            var uniqueData = new HashSet<string>();

            foreach (var item in data)
            {
                if (uniqueData.Contains(item))
                {
                    duplicates.Add(item); // Add to duplicates if already exists in the unique set
                }
                else
                {
                    uniqueData.Add(item); // Add to unique set if not already present
                }
            }

            // Log any duplicates found
            if (duplicates.Count > 0)
            {
                Console.WriteLine($"Duplicates found in {sourceName}:");
                foreach (var duplicate in duplicates)
                {
                    Console.WriteLine($"- {duplicate}");
                }
            }
            else
            {
                Console.WriteLine($"No duplicates found in {sourceName}.");
            }
        }

        private void CompareExcelAndAppData(List<string> excelData, List<string> appData)
        {
            // Compare the two datasets (simple comparison here, adjust as needed)
            bool isEqual = true;

            if (excelData.Count != appData.Count)
            {
                Console.WriteLine("The number of rows in Excel and app data do not match.");
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < excelData.Count; i++)
                {
                    if (excelData[i] != appData[i])
                    {
                        Console.WriteLine($"Mismatch at row {i + 1}: Excel value = '{excelData[i]}', App value = '{appData[i]}'");
                        isEqual = false;
                    }
                }
            }

            // Final assertion (can be used in NUnit tests)
            //Assert.IsTrue(isEqual, "Data comparison failed between Excel and app.");
        }
    }
}
