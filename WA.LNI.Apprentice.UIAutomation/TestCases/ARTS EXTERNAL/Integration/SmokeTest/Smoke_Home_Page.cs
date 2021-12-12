using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelevantCodes.ExtentReports;
using System.Reflection;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Approaching_Step_Updates;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Probation_Near_Completion;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Ready_for_Completion;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.RSI_OJT_Reporting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.Step_Update;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.Update_Journey_Level_Wages;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.TransferAnApprentice;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Committee_Meeeting_Minutes;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Lookup_Links.Apprentice_Lookup_Update;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.SmokeTest
{
    [TestClass]
    public class Smoke_Home_Page : TestBase
    {
        string Name;
        [TestMethod]
        public void TC001_Smoke_HomePage()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            Thread.Sleep(3000);

           //Check if all the Action Items Links are working 
            GetInstance<DashBoard_Overview_Page>().ActionItems_ApproachingStepUpdates_ClickLnk();
            ExtentReportLog(
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().PageHeading_Txt(),
                "Apprentice Ready for Step Updates",
                "Checking page link",
                Name);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Navigation_BackToOverView_Lnk();
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
            ExtentReportLog(
                GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageHeading_Txt(),
                "Apprentice Ready for Probation Update",
                "Checking page link",
                Name);
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Navigation_BackToOverView_Lnk();
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ReadyForCompletion_ClickLnk();

            ExtentReportLog(
                GetInstance<ActionItems_ReadyForCompletion_Page>().PageHeading_txt(),
                "Apprentice Ready for Completion",
                "Checking page link",
                Name);

            GetInstance<ActionItems_ReadyForCompletion_Page>().NavigationBackToOverview_Lnk();

            //Checks of all the Quick Links are working            
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RSI_OJTReporting_ClickLnk();

            ExtentReportLog(
                GetInstance<ApprenticeReadyTo_Report_Hours_Page>().PageHeading_Txt(),
                "Apprentice Ready to Report Hours",
                "Checking page link",
                Name);

            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().NavigationBackToOverviwe_Lnk();
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().QuickLnks_ApprenticeStepUpdate_ClickLnk();

            ExtentReportLog(
                GetInstance<ApprenticeReadyTo_Step_Update_Page>().PageHeading_Txt(),
                "Apprentice Ready to Update Steps",
                "Checking page link",
                Name);

            GetInstance<ApprenticeReadyTo_Step_Update_Page>().NavigationBackToOverview_Lnk();
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();

            ExtentReportLog(
                GetInstance<AppReg_EnterSSN_Page>().PageHeading_Txt(),
                "Register an Apprentice",
                "Checking page link",
                Name);

            GetInstance<AppReg_EnterSSN_Page>().NavigationBackToOverPage_Lnk();
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().QuickLnks_TransferAnApprenticek_ClickLnk();

            ExtentReportLog(
                GetInstance<Transfer_An_Apprentice_Page>().PageHeading_Txt(),
                "Transfer an Apprentice",
                "Checking page link",
                Name);

            GetInstance<Transfer_An_Apprentice_Page>().NavigationBackToOverPage_Lnk();
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().QuickLnks_UpdateJourneyLevelWages_ClickLnk();

            ExtentReportLog(
                GetInstance<Update_Journey_Level_Wages_Page>().PageHeading_Txt(),
                "Update Journey Level Wages",
                "Checking page link",
                Name);
            GetInstance<Update_Journey_Level_Wages_Page>().Navigation_BackTOProgramOverview_Lnk();

            //Checks of all the Committee Meeting Minutes Links are working 
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().CommitteeMeetingMinutes_UploadMinutes_ClickLnk();
            ExtentReportLog(
                GetInstance<Upload_MeetingMinutes_Page>().PopUpHeading_Txt(),
                "Upload Minutes",
                "Checking page link",
                Name);
            GetInstance<Upload_MeetingMinutes_Page>().Close_Btn();
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().CommitteeMeetingMinutes_MeetingMinutesHistory_ClickLnk();
            ExtentReportLog(
                GetInstance<Meeting_Minute_History_Page>().PageHeading_Txt(),
                "5-Year History of Committee Meetings",
                "Checking page link",
                Name);
            GetInstance<Meeting_Minute_History_Page>().NavigationBackToOverview_Lnk();
            //Checks of all the Committee Meeting Minutes Links are working
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().LookupLinks_AppLookupUpdate_Lnk();
            ExtentReportLog(
                GetInstance<Apprentice_Lookup_Update>().PageHeading_Txt(),
                "Apprentice Lookup/Update",
                "Checking page link",
                Name);
            GetInstance<Apprentice_Lookup_Update>().NavigationBackToProgram_Lnk();



        }
    }
}
