using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.LNI.Apprentice.TestFramework
{
   public  class Selenium
    {
        /// <summary>
        /// Create global variable which will be used in all method
        /// </summary>
        public static DriverFunctions Driver;
        public static IWebDriver ObjDriver;
        public static ExtentReports Extent;
        public static ExtentTest Log;
        public static void Set(IWebDriver driver)
        {
            ObjDriver = driver;
        }
    }
}
