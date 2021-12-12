using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.Step_Update;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Probation_Near_Completion;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.SmokeTest
{
    [TestClass]
    public class Smoke_Update_Apprentice_Steps : TestBase
    {
        string Name;

        [TestMethod]
        public void TS001_Update_Apprentice_Step()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            Thread.Sleep(3000);

            GetInstance<DashBoard_Overview_Page>().QuickLnks_ApprenticeStepUpdate_ClickLnk();
            Thread.Sleep(3000);

            //Validating Program Selection filter
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SelectProgram_DrpDwn("128");

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();
             
            Thread.Sleep(3000);
            string Result_App_ID = GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeID_Txt(0);

            string query = "EXEC [aprnt].[p_apprentice_details] @apprentice_id = " + Result_App_ID;
            string Result_Pgm_Name = DBConnection.GetDBData(query, "ProgramName");

            ExtentReportLog(
                (Selenium.Driver.GetSelectedTxt(
               GetInstance<ApprenticeReadyTo_Step_Update_Page>().SelectProgramDrpDwn, "128")).Trim(),
                Result_Pgm_Name,
                "PGM NAME VALID",
                Name);

            //Validating First Name filter
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SelectProgram_DrpDwn("128");

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SearchFirstName_Input("David");

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                string FullName = GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameID_Txt(i);
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
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SelectProgram_DrpDwn("128");

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SearchLasttName_Input("Wright");

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                string FullName = GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameID_Txt(i);
                string[] temp1 = FullName.Split(',');
                string LastName = temp1[0];

                ExtentReportLog(
                    LastName.ToLower(),
                    "Wright".ToLower(),
                    "Checking for Last name filter functionlity",
                    Name);
            }

            //Validating Apprentice ID filter
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SelectProgram_DrpDwn("128");

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SearchLasttName_Input("200136");

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                string FullName = GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameID_Txt(i);
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
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SelectProgram_DrpDwn("128");
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SearchStatus_DrpDwn("Active");
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();
            Thread.Sleep(5000);
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Status_Txt(i),
                    "Active",
                    "Checking for Status filter functionlity",
                    Name);
            }

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SearchStatus_DrpDwn("Suspended");
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();
            Thread.Sleep(5000);
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Status_Txt(i),
                    "Suspended",
                    "Checking for Status filter functionlity",
                    Name);
            }
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SearchStatus_DrpDwn("Cancelled");
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Status_Txt(i),
                    "Cancelled",
                    "Checking for Status filter functionlity",
                    Name);
            }
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SearchStatus_DrpDwn("Completed");
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Status_Txt(i),
                    "Completed",
                    "Checking for Status filter functionlity",
                    Name);
            }

            //Validating 'Autofill Date'
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();
            Thread.Sleep(3000);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().EffectiveDateDate_Input("05/13/2019");
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().MinutesDate_Input("05/13/2019");
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().AutoFill_btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    Selenium.Driver.GetAttribute(GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_EffectiveDateInput[i], "value", "Table_EffectiveDateInput[" + i + "]"),
                    "05/13/2019",
                    "Checking for From Date Auto Fill functionlity",
                    Name);

                ExtentReportLog(
                    Selenium.Driver.GetAttribute(GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_MinutesDateInput[i], "value", "Table_MinutesDateInput[" + i + "]"),
                    "05/13/2019",
                    "Checking for To Date Auto Fill functionlity",
                    Name);

            }

            //Validating Error messages: Enter Effective date.
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();

            Thread.Sleep(3000);

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().MinutesDate_Input("11/01/2018");

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().AutoFill_btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_Increment_NewStep_Input(0);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_Increment_NewStep_Input(1);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_Increment_NewStep_Input(2);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_Increment_NewStep_Input(3);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_Increment_NewStep_Input(4);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_Increment_NewStep_Input(5);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_Increment_NewStep_Input(6);

            List<string> _msg_ = new List<string>();
            Thread.Sleep(3000);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Submit_ClickBtn();
            Thread.Sleep(3000);
            _msg_ = GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ErrorMessageInfo_Status_Check_Txt();

            for (int i = 0; i < _msg_.Count; i++)
            {
                string temp = _msg_[i].Substring(_msg_[i].IndexOf(' '));
                string txt_1 = temp.Substring(temp.IndexOf(' ') + 1);
                ExtentReportLog(txt_1, "Enter Effective date.", "CHECK", Name);
            }


            //Validating Error messages: New step number should be higher than current step
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Reset_Btn();

            Thread.Sleep(3000);

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().EffectiveDateDate_Input("11/01/2018");
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().AutoFill_btn();

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_decrement_NewStep_Input(0);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_decrement_NewStep_Input(1);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_decrement_NewStep_Input(2);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_decrement_NewStep_Input(3);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_decrement_NewStep_Input(4);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_decrement_NewStep_Input(5);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_decrement_NewStep_Input(6);


            Thread.Sleep(3000);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Submit_ClickBtn();
            Thread.Sleep(3000);
            _msg_ = GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ErrorMessageInfo_Status_Check_Txt();

            for (int i = 0; i < _msg_.Count; i++)
            {
                string temp = _msg_[i].Substring(_msg_[i].IndexOf(' '));
                string txt_1 = temp.Substring(temp.IndexOf(' ') + 1);
                ExtentReportLog(txt_1, "New step number should be higher than current step", "CHECK", Name);
            }

            //Validating History Expand/ Shrink button
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().TableHeader_ExpandAll_Btn();

            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    Selenium.Driver.GetText(GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_HistoryShrinkBtn[i], "Table_HistoryShrinkBtn[" + i + "]"),
                    "-",
                    "Checking for expand functionlity",
                    Name);
            }

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().TableHeader_ExpandAll_Btn();
            for (int i = 0; i < (GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_ApprenticeNameLnk).Count; i++)
            {
                ExtentReportLog(
                    Selenium.Driver.GetText(GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_HistoryExpandBtn[i], "Table_HistoryExpandBtn[" + i + "]"),
                    "+",
                    "Checking for expand functionlity",
                    Name);
            }


            //Validating page navigation functionality 
            int n = 0;
            while (n != 4)
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
