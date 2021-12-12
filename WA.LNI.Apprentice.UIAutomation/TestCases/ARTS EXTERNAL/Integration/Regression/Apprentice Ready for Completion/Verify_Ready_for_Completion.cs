using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Ready_for_Completion;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Regression.Apprentice_Ready_for_Completion
{
    [TestClass]
    public class Verify_Ready_for_Completion : TestBase
    {
        string Name;

        [TestMethod]
        public void TC000_Verify_Ready_for_Completion()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ReadyForCompletion_ClickLnk();
            GetInstance<ActionItems_ReadyForCompletion_Page>().Table_EffectiveDate_Input(0, "04/26/2019");
            GetInstance<ActionItems_ReadyForCompletion_Page>().Table_MinutesDate_Input(0, "04/26/2019");
            GetInstance<ActionItems_ReadyForCompletion_Page>().Submit_Btn();
            ExtentReportLog("Your information has been submitted successfully!", GetInstance<ActionItems_ReadyForCompletion_Page>().ApprenticeCompletionMessage_Txt(), "Completionn Messsage", Name);
        }
    }
}
