using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V128.FedCm;

namespace WOI_Testsuite.BB_Public_Dashboard
{
    internal class BB_Dashboard_Testcase
    {
        [TestFixture]
        public class BB_Public_Dashboard : TestBase


        {

            private IWebDriver _driver;
            [SetUp]
            public void startBrowser()
            {

                _driver = base.SiteConnection();
            }

            [Test, Order(1)]
            public void runTestSuite()
            {
                Delay(2);
                SearchIndustry();
        
            }

            [Category("SearchIndustry")]
            public void SearchIndustry()
            {
                try
                {

                   //test
                   //testing 




                }
                catch (Exception ex)
                {
                    DisconnectBrowser();
                    throw ex;
                }
            }
   

            [TearDown]
            public void closeBrowser()
            {
                base.DisconnectBrowser();
            }

        }

    }
}
