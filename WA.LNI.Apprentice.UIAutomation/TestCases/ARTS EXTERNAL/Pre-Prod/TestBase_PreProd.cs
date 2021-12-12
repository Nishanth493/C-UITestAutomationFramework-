using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;

namespace WA.LNI.Apprentice.UIAutomation
{


    [TestClass]
    public class TestBase_Preprod : Base
    {
        DriverSelection DriverSelection = new DriverSelection();
       
        /// <summary>
        /// This method will start driver engine
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        [TestInitialize]
        public  void Start()
        {

            ExcelReader.Create(ConfigurationManager.AppSettings.Get("TestData"));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestEnvSheet"));
            var ArrayList = ExcelReader.GetEnvData((int)EnvConstants.APPLICATION, (int)EnvConstants.APPURL1, (int)EnvConstants.APPURL2, (int)EnvConstants.BROWSER, (int)EnvConstants.DBCONNECTION);
            DBConnection.ConnectDB(ConfigurationManager.ConnectionStrings["DB_TO_USE"].ConnectionString);

            if ((ArrayList[0].ToString()).ToLower() == "external")
            {
                DriverSelection.InitiateDriver(ArrayList[1].ToString(), ArrayList[3].ToString(), ArrayList[4].ToString()); // Parameterise
            }
            else if ((ArrayList[0].ToString()).ToLower() == "intenal")
            {
                DriverSelection.InitiateDriver(ArrayList[2].ToString(), ArrayList[3].ToString(), ArrayList[4].ToString()); // Parameterise
            }
            //DriverSelection.InitiateDriver(ArrayList[0].ToString(), ArrayList[1].ToString(), ArrayList[2].ToString()); // Parameterise
            ExcelReader.Create(ConfigurationManager.AppSettings.Get("TestData"));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestDataSheet_PreProd"));   
        }

        [TestCleanup]
        public void GetResult()
        {
            Selenium.Extent.EndTest(Selenium.Log);
            Selenium.Extent.Flush();
            DriverSelection.CloseDriver();
            DBConnection.CloseDB();
        }


        [ClassCleanup]
        public void AfterClass()
        {
            DBConnection.CloseDB();
        }

        public void ExtentReportLog(string actual,string expected,string message, string TestCaseName)
        {

            if (actual.Equals(expected))
                Selenium.Log.Log(LogStatus.Pass, message + " : " + actual + " == " + expected);
            else
            {
                Selenium.Log.Log(LogStatus.Fail, message + "  : " + actual + " != " + expected);
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));

            }
        }

        public void ExtentReportLog(bool actual, bool expected, string message, string TestCaseName)
        {

            if (actual.Equals(expected))
                Selenium.Log.Log(LogStatus.Pass, message + " : " + actual + " == " + expected);
            else
            {
                Selenium.Log.Log(LogStatus.Fail, message + "  : " + actual + " != " + expected);
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));         
            }
        }

        public void ExtentReportLog(int actual, int expected, string message, string TestCaseName)
        {

            if (actual.Equals(expected))
                Selenium.Log.Log(LogStatus.Pass, message + " : " + actual + " == " + expected);
            else
            {
                Selenium.Log.Log(LogStatus.Fail, message + "  : " + actual + " != " + expected);
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
            }
        }

    }
}
