using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.Step_Update;
using System.Configuration;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Regression.UpdateApprenticeSteps
{
    [TestClass]
    public class Verify_Apprentice_Step_Update :TestBase
    {
        string Name;

        [TestMethod]
        public void TC000_Verify_Apprentice_Step_Update()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_QuickLinks_Step_Update"));
            GetInstance<DashBoard_Overview_Page>().QuickLnks_ApprenticeStepUpdate_ClickLnk();           
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().SelectProgram_DrpDwn(
                ExcelReader.Get_QL_Step_Update(Name, QL_Step_Update.PROGRAMID));          
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Search_Btn();
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_Single_Increment_NewStep_Input(2);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_EffectiveDate_Input(
                ExcelReader.Get_QL_Step_Update(Name, QL_Step_Update.EFFECTIVEDATE),
                2);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Table_MinutesDate_Input(
                ExcelReader.Get_QL_Step_Update(Name, QL_Step_Update.MINUTESDATE),
                2);
            GetInstance<ApprenticeReadyTo_Step_Update_Page>().Submit_ClickBtn();

            ExtentReportLog(
                "Your information has been submitted successfully!",
                GetInstance<ApprenticeReadyTo_Step_Update_Page>().StepUpdateMessage_Txt(), 
                "Step update message", 
                Name);
        }
    }
}
