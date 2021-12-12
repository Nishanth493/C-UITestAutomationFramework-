using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Chrome;

namespace WA.LNI.Apprentice.TestFramework
{
    public class DriverSelection
    {
        /// <summary>
        /// Create global variable which will be used in all method
        /// </summary>
        public static AutomationReport Report;
        public static ExtentReports Extent;
        public static  IWebDriver Driver;

        /// <summary>
        /// Method to select the browser environment for the test case to be executed based on the selection made from TestBase
        /// </summary>
        /// <param name="browser"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public static void InitiateDriver(string url, string browser,string cnn)
        {
            string Drivers = @"..\..\Resources\Drivers";
            if (browser.Equals("IE"))
            {
                InternetExplorerOptions Options=new InternetExplorerOptions();
                Options.IgnoreZoomLevel = true;
                Options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                Options.AcceptInsecureCertificates = false;
                Options.RequireWindowFocus = true;
                Driver = new InternetExplorerDriver(Drivers, Options, TimeSpan.FromSeconds(30));
            }

            else if(browser.Equals("Chrome"))
            {
                ChromeOptions Options = new ChromeOptions();
                Driver = new ChromeDriver(Drivers , Options);
            }

            else if (browser.Equals("Firefox"))
            {
                FirefoxOptions  Options = new FirefoxOptions();
                Driver = new FirefoxDriver(Drivers, Options);
            }

            Driver.Url = url;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);
            Driver.Manage().Window.Maximize();
            var cookies = Driver.Manage().Cookies.AllCookies;
            Selenium.Set(Driver);
            Selenium.Driver = new DriverFunctions(Driver);
            Selenium.Extent = AutomationReport.StartReport();
        }

        /// <summary>
        /// method to close the test browser post test completion 
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public static void CloseDriver()
        {
            Driver.Close();
        }
    }
}