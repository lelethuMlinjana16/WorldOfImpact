using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace WOI_Testsuite
{
    public class TestBase
    {
        private ChromeOptions _chromeOptions;
        public IWebDriver _driver, _webDriver;
        private string _userName;
        private string _password;
        [OneTimeSetUp]
        public void StartBrowser()
        {
            _chromeOptions = new ChromeOptions();
            _chromeOptions.AddArguments("--incognito");
            _chromeOptions.AddArguments("--ignore-certificate-errors");
            _driver = new ChromeDriver("C:/Users/MankgashaMaenetja/source/repos/WOI_TestSuite/WOI_Testsuite/bin/Debug/Drivers");
        }


        public IWebDriver SiteConnection()
        {
            _driver.Url = "https://woi-sit.azurewebsites.net/";
            _driver.Manage().Window.Maximize();


            return _driver;
        }


        public void DisconnectBrowser()
        {
            if (_driver != null)

                _driver.Quit();
        }


        public void Delay(int delaySeconds)
        {
            Thread.Sleep(delaySeconds * 1000);
        }
    }
}
