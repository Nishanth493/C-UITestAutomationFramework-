using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation
{
    [TestClass]
    public class TestBase : Base
    {
        DriverSelection DriverSelection = new DriverSelection();

        /// <summary>
        /// This method will start driver engine
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        [TestInitialize]
        public void Start()
        {
            // try
            //{
            Thread.Sleep(2000);
            ExcelReader.Create(ConfigurationManager.AppSettings.Get("TestData"));
                ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestEnvSheet"));
                var ArrayList = ExcelReader.GetEnvData((int)EnvConstants.APPLICATION, (int)EnvConstants.APPURL1, (int)EnvConstants.APPURL2, (int)EnvConstants.BROWSER, (int)EnvConstants.DBCONNECTION);
                DBConnection.ConnectDB(ConfigurationManager.ConnectionStrings["DB_TO_USE"].ConnectionString);
                if ((ArrayList[0].ToString()).ToLower() == "external")
                {
                    DriverSelection.InitiateDriver(ArrayList[1].ToString(), ArrayList[3].ToString(), ArrayList[4].ToString()); // Parameterise
                }
                else if ((ArrayList[0].ToString()).ToLower() == "internal")
                {
                    DriverSelection.InitiateDriver(ArrayList[2].ToString(), ArrayList[3].ToString(), ArrayList[4].ToString()); // Parameterise
                }
                //DriverSelection.InitiateDriver(ArrayList[0].ToString(), ArrayList[1].ToString(), ArrayList[2].ToString()); // Parameterise
                ExcelReader.Create(ConfigurationManager.AppSettings.Get("TestData"));
                ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestDataSheet_Integration"));        
            //}
            /*catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to find the element -> " + e + " || " + " Build Error Message: " + e);
            }*/
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
            Selenium.Extent.EndTest(Selenium.Log);
            Selenium.Extent.Flush();
            DriverSelection.CloseDriver();
            DBConnection.CloseDB();
        }

        public void ExtentReportLog(string actual, string expected, string message, string TestCaseName)
        {
            if (actual.Equals(expected))
                Selenium.Log.Log(LogStatus.Pass, " <b style=" + "color:hsl(147,50%,47%);>" + message + " : " + actual + " == " + expected + "</b> ");
            else
            {
                Selenium.Log.Log(LogStatus.Fail, " <b style=" + "color:hsl(0,60%,50%)>" + message + "  : " + actual + " != " + expected + "</b> ");
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
            }
        }

        public void ExtentReportLog(bool actual, bool expected, string message, string TestCaseName)
        {
            if (actual.Equals(expected))
                Selenium.Log.Log(LogStatus.Pass, " <b style=" + "color:hsl(147,50%,47%);>" + message + " : " + actual + " == " + expected + "</b> ");
            else
            {
                Selenium.Log.Log(LogStatus.Fail, " <b style=" + "color:hsl(0,60%, 0%)>" + message + "  : " + actual + " != " + expected + "</b> ");
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
            }
        }

        public void ExtentReportLog(int actual, int expected, string message, string TestCaseName)
        {
            if (actual.Equals(expected))
                Selenium.Log.Log(LogStatus.Pass, " <b style=" + "color:hsl(147,50%,47%);>" + message + " : " + actual + " == " + expected + "</b> ");
            else
            {
                Selenium.Log.Log(LogStatus.Fail, " <b style=" + "color:hsl(0,60%,50%)>" + message + "  : " + actual + " != " + expected + "</b> ");
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
            }
        }

        public void ExtentReportLog(Dictionary<string, string> actual, Dictionary<string, string> expected, string message, string TestCaseName)
        {
            if (actual.Count == expected.Count) // Require equal count.
            {
                foreach (var pair in actual)
                {
                    string value;
                    if (expected.TryGetValue(pair.Key, out value))
                    {
                        // Require value be equal.
                        if (value != pair.Value)
                        {
                            Selenium.Log.Log(LogStatus.Fail, " <b style=" + "color:hsl(0,60%,50%)>" + message + "  : " + actual + " != " + expected + "</b> ");
                            string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                            Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                        }
                    }
                    else
                    {
                        Selenium.Log.Log(LogStatus.Fail, " <b style=" + "color:hsl(0,60%,50%)>" + message + "  : " + actual + " != " + expected + "</b> ");
                        string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                        Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                    }
                }
            }
            Selenium.Log.Log(LogStatus.Pass, " <b style=" + "color:hsl(147,50%,47%);>" + message + " : " + actual + " == " + expected + "</b> ");
        }


        public void ExtentReportLog(List<string> actual, List<string> expected, string message, string TestCaseName)
        {

            bool x = actual.Any(z => expected.Contains(z));

            if (x == true)
            {
                Selenium.Log.Log(LogStatus.Pass, " <b style=" + "color:hsl(147,50%,47%);>" + message + " : " + actual + " == " + expected + "</b> ");
            }
            else
            {
                Selenium.Log.Log(LogStatus.Fail, " <b style=" + "color:hsl(0,60%,50%)>" + message + "  : " + actual + " != " + expected + "</b> ");
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, TestCaseName);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
            }
        }

        public void ExtentReportInfo(string Info, string message, string TestCaseName)
        {
                Selenium.Log.Log(LogStatus.Info, " <b style=" + "color:hsl(210,100%,65%);>" + message + " = " + Info + "</b> ");         
        }
    }
}
