using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Ready_for_Completion;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Integration.SmokeTest
{
    [TestClass]
    public class Smoke_Ready_For_Completion : TestBase
    {
        string Name;

        [TestMethod]
        //validating error message 'Minutes date is required' 
        public void TS001_Ready_For_Completion()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
                ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
                GetInstance<LandingPage>().Tasks("128");
                Thread.Sleep(3000);
                GetInstance<DashBoard_Overview_Page>().ActionsItems_ReadyForCompletion_ClickLnk();
                string Input_Date = DateTime.Now.ToString("MM/dd/yyyy");
                GetInstance<ActionItems_ReadyForCompletion_Page>().EffectiveDate_Input(DateTime.Now.ToString("MM/dd/yyyy"));
                GetInstance<ActionItems_ReadyForCompletion_Page>().Submit_Btn();
                ExtentReportLog(GetInstance<ActionItems_ReadyForCompletion_Page>().Table_ErrorMessage_txt(1),
                    "Minutes date is required to update the status",
                    "Validating error Message",
                    Name);
                ExtentReportLog(GetInstance<ActionItems_ReadyForCompletion_Page>().ApprenticeCompletionMessage_Txt(),
                    "Error updating probation, please check your information and try again!",
                    "Validating error Message",
                    Name);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Build Falure: " + e);
                throw (e);
            }
        }

        [TestMethod]
        //validating error message 'Effective Date is required required'
        public void TS002_Ready_For_Completion()
        {
            try
            {  
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ReadyForCompletion_ClickLnk();
            string Input_Date = DateTime.Now.ToString("MM/dd/yyyy");
            GetInstance<ActionItems_ReadyForCompletion_Page>().MinutesDate_Input(DateTime.Now.ToString("MM/dd/yyyy"));
            GetInstance<ActionItems_ReadyForCompletion_Page>().Submit_Btn();
            ExtentReportLog(GetInstance<ActionItems_ReadyForCompletion_Page>().Table_ErrorMessage_txt(1),
                "Effective date is required to update the status",
                "Validating error Message",
                Name);
            ExtentReportLog(GetInstance<ActionItems_ReadyForCompletion_Page>().ApprenticeCompletionMessage_Txt(),
                "Error updating probation, please check your information and try again!",
                "Validating error Message",
                Name);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Build Falure: " + e);
                throw (e);
            }
        }

        [TestMethod]
        //validating Total Hours required for completion 
        //Message: "To complete the program apprentice needs xxxx hours, this apprentice has total of xxxx.xx hours."
        public void TS003_Ready_For_Completion()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
                ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
                GetInstance<LandingPage>().Tasks("128");
                Thread.Sleep(3000);
                GetInstance<DashBoard_Overview_Page>().ActionsItems_ReadyForCompletion_ClickLnk();
                string Input_Date = DateTime.Now.ToString("MM/dd/yyyy");
                GetInstance<ActionItems_ReadyForCompletion_Page>().EffectiveDate_Input(DateTime.Now.ToString("MM/dd/yyyy"));
                GetInstance<ActionItems_ReadyForCompletion_Page>().MinutesDate_Input(DateTime.Now.ToString("MM/dd/yyyy"));
                GetInstance<ActionItems_ReadyForCompletion_Page>().Submit_Btn();

                for (int i = 0; i < GetInstance<ActionItems_ReadyForCompletion_Page>().Table_ErrorMessageTxt.Count; i++)
                {
                    if (GetInstance<ActionItems_ReadyForCompletion_Page>().Table_ErrorMessage_txt(i) != "none")
                    {
                        string apprenticeID = GetInstance<ActionItems_ReadyForCompletion_Page>().Table_ApprenticeID_Txt(i);
                        string list1 = "SELECT SUM(b.hrs_qty) AS 'OJTHour' FROM [aprnt].[apprentice_pgm_occpn] a INNER JOIN [aprnt].[apprentice_pgm_occpn_hour] b ON a.rid=b.apprentice_pgm_occpn_rid WHERE a.apprentice_rid = " + apprenticeID + "AND b.work_hour_type_code ='OJT'";
                        string CurrentAppHours = DBConnection.GetDBData(list1, "OJTHour");
                        string list2 = "SELECT term_qty FROM[aprnt].[apprentice_pgm_occpn] WHERE apprentice_rid = " + apprenticeID;
                        string ReqTermHours = DBConnection.GetDBData(list2, "term_qty");
                        string ExpectedText = "To complete the program apprentice needs " + ReqTermHours + " hours, this apprentice has total of " + CurrentAppHours + " hours.";
                        ExtentReportLog(GetInstance<ActionItems_ReadyForCompletion_Page>().Table_ErrorMessage_txt(i),
                            ExpectedText,
                            "Valodating message for " + apprenticeID + ": ",
                            Name);
                    }
                }

                ExtentReportLog(GetInstance<ActionItems_ReadyForCompletion_Page>().ApprenticeCompletionMessage_Txt(),
                            "Error updating probation, please check your information and try again!",
                            "Validating error Message",
                            Name);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Build Falure: " + e);
                throw (e);
            }
        }
    }
}
