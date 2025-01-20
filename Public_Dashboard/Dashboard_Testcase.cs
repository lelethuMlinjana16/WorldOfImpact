using NUnit.Framework;
using OpenQA.Selenium;

namespace WOI_Testsuite.Public_Dashboard
{
    [TestFixture]
    public class Public_Dashboard : TestBase
    {
        private IWebDriver _driver;

        [SetUp]
        public void StartBrowser()
        {
            _driver = base.SiteConnection();
        }

        [Test, Order(1)]
        [Category("SearchIndustry")]
        public void Test_SearchIndustry()
        {
            try
            {
                Console.WriteLine("Running Test: SearchIndustry");
                Delay(2);
                // Add test logic here
            }
            catch (Exception ex)
            {
                throw ex; // Optionally log the exception
            }
        }

        [Test, Order(2)]
        [Category("AnotherTest")]
        public void Test_AnotherFeature()
        {
            try
            {
                Console.WriteLine("Running Test: AnotherFeature");
                Delay(2);
                // Add test logic here
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null;
            }
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}
