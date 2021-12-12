using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.RSI_OJT_Reporting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Probation_Near_Completion;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.SmokeTest
{
    [TestClass]
    public class Smoke_OJT_RSI_Report_Hours : TestBase
    {
        string Name;

        [TestMethod]
        public void TS001_OJT_RSI_Report_Hours()
        {
            //Search filters functionality validation 
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");       
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RSI_OJTReporting_ClickLnk();
    
            //Validating Program Selection filter
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SelectProgram_DrpDwn("128");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();
            string Result_App_ID = GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeID_Txt(0);
            string query = "EXEC [aprnt].[p_apprentice_details] @apprentice_id = " + Result_App_ID;
            string Result_Pgm_Name = DBConnection.GetDBData(query, "ProgramName");

            ExtentReportLog(
                (Selenium.Driver.GetSelectedTxt(
               GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SelectProgramDrpDwn, "128")).Trim(),
                Result_Pgm_Name,
                "PGM NAME VALID",
                Name);

            //Validating First Name filter
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SelectProgram_DrpDwn("128");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SearchFirstName_Input("David");

            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                string FullName = GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameID_Txt(i);
                string[] temp1 = FullName.Split(',');
                string[] temp2 = (temp1[1].Trim()).Split(' ');
                string FirstName = temp2[0];

                ExtentReportLog(
                    FirstName.ToLower(),
                    "David".ToLower(),
                    "Checking for first name filter functionlity",
                    Name);
            }

            //Validating Last Name filter
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SelectProgram_DrpDwn("128");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SearchLasttName_Input("Wright");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                string FullName = GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameID_Txt(i);
                string[] temp1 = FullName.Split(',');
                string LastName = temp1[0];

                ExtentReportLog(
                    LastName.ToLower(),
                    "Wright".ToLower(),
                    "Checking for Last name filter functionlity",
                    Name);
            }

            //Validating Apprentice ID filter
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SelectProgram_DrpDwn("128");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SearchLasttName_Input("200136");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                string FullName = GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameID_Txt(i);
                string[] temp1 = FullName.Split('(');
                string[] temp2 = temp1[1].Split(')');
                string Apprentice_Id = temp2[0];

                ExtentReportLog(
                    Apprentice_Id,
                    "200136",
                    "Checking for Apprentice ID filter functionlity",
                    Name);
            }

            //Validating status filter 
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SelectProgram_DrpDwn("128");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SearchStatus_DrpDwn("Active");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_Status_Txt(i),
                    "Active",
                    "Checking for Status filter functionlity",
                    Name);
            }
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SearchStatus_DrpDwn("Suspended");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_Status_Txt(i),
                    "Suspended",
                    "Checking for Status filter functionlity",
                    Name);
            }
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SearchStatus_DrpDwn("Cancelled");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_Status_Txt(i),
                    "Cancelled",
                    "Checking for Status filter functionlity",
                    Name);
            }
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SearchStatus_DrpDwn("Completed");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_Status_Txt(i),
                    "Completed",
                    "Checking for Status filter functionlity",
                    Name);
            }

            //RSI & OJT, RSI, OJT search filters
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().PreferenceHours_RdoBtns("0");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();

            ExtentReportLog(
                GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_Txt(1) + " & " + GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_Txt(2),
                "RSI Hours & OJT Hours",
                "Verifing Hours Preference",
                Name);

            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().PreferenceHours_RdoBtns("1");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();

            ExtentReportLog(
                GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_Txt(1) + " " + GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_Txt(2) + " " + GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_Txt(3),
                "From To RSI Hours",
                "Verifing Hours Preference",
                Name);

            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().PreferenceHours_RdoBtns("2");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();

            ExtentReportLog(
                GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_Txt(1) + " " + GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_Txt(2) + " " + GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_Txt(3),
                "From To OJT Hours",
                "Verifing Hours Preference",
                Name);

            //Validating 'Autofill Date'
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().FromDate_Input("05/13/2019");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().ToDate_Input("05/13/2019");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().AutoFill_btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    Selenium.Driver.GetAttribute(GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_FromDateinput[i], "value", "Table_FromDateinput[" + i + "]"),
                    "05/13/2019",
                    "Checking for From Date Auto Fill functionlity",
                    Name);

                ExtentReportLog(
                    Selenium.Driver.GetAttribute(GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ToDateinput[i], "value", "Table_FromDateinput[" + i + "]"),
                    "05/13/2019",
                    "Checking for To Date Auto Fill functionlity",
                    Name);
            }
            
            //Validating History Expand/ Shrink button
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_ExpandAll_Btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    Selenium.Driver.GetText(GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_HistoryShrinkBtn[i], "Table_HistoryShrinkBtn[" + i + "]"),
                    "-",
                    "Checking for expand functionlity",
                    Name);
            }

            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().TableHeader_ExpandAll_Btn();
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    Selenium.Driver.GetText(GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_HistoryExpandBtn[i], "Table_HistoryExpandBtn[" + i + "]"),
                    "+",
                    "Checking for expand functionlity",
                    Name);
            }

            //Validating Error messages: Date range should be with in the quarter of the year
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().PreferenceHours_RdoBtns("1");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().FromDate_Input("08/01/2018");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().ToDate_Input("11/01/2018");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().AutoFill_btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 0);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 1);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 2);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 3);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 4);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 5);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 6);

            List<string> _msg_ = new List<string>();
            Thread.Sleep(3000);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Submit_ClickBtn();
            Thread.Sleep(3000);
            _msg_ = GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ErrorMessageInfo_Status_Check_Txt();

            for (int i = 0; i < _msg_.Count; i++)
            {
                string[] txt_0 = _msg_[i].Split('(');
                string temp = txt_0[0].Substring(txt_0[0].IndexOf(' '));
                string txt_1 = temp.Substring(temp.IndexOf(' ') + 1);
                ExtentReportLog(txt_1, "Date range should be with in the quarter of the year ", "CHECK", Name);
            }

            //Validating Error messages: Enter From/To date.
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 0);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 1);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 2);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 3);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 4);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 5);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 6);   
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Submit_ClickBtn();
            
            _msg_ = GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ErrorMessageInfo_Status_Check_Txt();

            for (int i = 0; i < _msg_.Count; i++)
            {
                string[] txt_0 = _msg_[i].Split(':');
                string temp = txt_0[0].Substring(txt_0[0].IndexOf(' '));
                string txt_1 = temp.Substring(temp.IndexOf(' ') + 1);
                ExtentReportLog(txt_1, "Start Date and End Dates are required.", "CHECK", Name);
            }

            // Validating Error messages: From Date should not be earlier than begin date for apprentice
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().FromDate_Input("01/01/2000");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().ToDate_Input("03/31/2000");
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().AutoFill_btn();
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 0);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 1);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 2);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 3);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 4);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 5);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 6);         
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Submit_ClickBtn();
            _msg_ = GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ErrorMessageInfo_Status_Check_Txt();

            for (int i = 0; i < _msg_.Count; i++)
            {
                string[] txt_0 = _msg_[i].Split(':');
                string temp = txt_0[0].Substring(txt_0[0].IndexOf(' '));
                string txt_1 = temp.Substring(temp.IndexOf(' ') + 1);
                ExtentReportLog(txt_1, "From Date should not be earlier than begin date for apprentice", "CHECK", Name);
            }

            //Validating page navigation functionality 
            int n = 0;
            while ( n != 4)
            {
                Thread.Sleep(3000);
                int Count = ((GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageNavigationBtn).Count) - 2;
                GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageNavigation_Btn(Count);

                ExtentReportLog(
                    Selenium.Driver.GetAttribute(
                        GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageNavigationBtn[3],
                        "disabled",
                        "PageNavigation_Btn[3]"),
                    "true",
                    "Validating page navigation functionality",
                    Name
                    );
                Thread.Sleep(2000);
                n++; 
            }
        }
    }
}
