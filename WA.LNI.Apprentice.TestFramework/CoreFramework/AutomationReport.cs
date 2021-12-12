using System;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using System.Configuration;

namespace WA.LNI.Apprentice.TestFramework
{
    public class AutomationReport : Base
    {
        /// <summary>
        /// Create global variable which will be used in all method
        /// </summary>
        public static ExtentReports Extent;
        public  static ExtentTest Log;

        /// <summary>
        /// This code will run before executing any testcase
        /// </summary>
        public static ExtentReports StartReport()
        {
            try
            {
                string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                string actualPath = path.Substring(0, path.LastIndexOf("bin"));
                string projectPath = new Uri(actualPath).LocalPath;
                //string projectPath = @"D:\ArtsTesting\WA.LNI.Apprentice.TestAutomation\WA.LNI.Apprentice.UIAutomation";
                string reportPath = @"C:\AutomationReports\ARTS\TestReport" + DateTime.Today.ToString("MM-dd-yyyy")+ ".html";
                Extent = new ExtentReports(reportPath,false);
                Extent.AddSystemInfo("Host Name", "ARTS External");
                Extent.AddSystemInfo("Envornment", "Pre-Production");
                Extent.AddSystemInfo("User Name", "CHNG235");
                Extent.LoadConfig(projectPath + "extent-config.xml");
                return Extent;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        /// <summary>
        /// This code will run runs everytime if the test case fails 
        /// </summary>7
        public static string Capture(IWebDriver driver)
        {
               string screenShotName = "TestFalureScreenShot";
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                Screenshot screenshot = ts.GetScreenshot();
                string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                string actualPath = path.Substring(0, path.LastIndexOf("bin")) + "Reports\\ScreenShots\\" + screenShotName + DateTime.Now.ToString("MM-dd-yyyy_hh_mm_ss")+ ".png";
                string projectPath = new Uri(actualPath).LocalPath;
                screenshot.SaveAsFile(projectPath, ScreenshotImageFormat.Png);
                return projectPath;
            }

        /// <summary>
        /// This code will run runs everytime if the test case fails 
        /// </summary>
        public static string Capture(IWebDriver driver, string screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin")) + "Reports\\ScreenShots\\" + screenShotName + DateTime.Now.ToString("MM-dd-yyyy_hh_mm_ss") + ".png";
            string projectPath = new Uri(actualPath).LocalPath;
            screenshot.SaveAsFile(projectPath, ScreenshotImageFormat.Png);
            return projectPath;
        }

        /// <summary>
        /// This code will end the Extent Report exicution 
        /// </summary>
        public static  void EndReport(ExtentTest Test)
        {
            Extent.EndTest(Test);  
        }
    }
}


      


