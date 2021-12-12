using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.Update_Journey_Level_Wages;
using System.Configuration;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Regression.UpdateJourneyLevelWages
{
    [TestClass]
    public class Verify_JourneyLevelWages : TestBase 
    {
        string Name; 

        [TestMethod]
        public void TC000_Verify_JourneyLevelWages()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            GetInstance<DashBoard_Overview_Page>().QuickLnks_UpdateJourneyLevelWages_ClickLnk();           
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_QuickLinks_Update_Journey_Level_Wages"));
            GetInstance<Update_Journey_Level_Wages_Page>().Table_EffectiveDate_Input(
                2, 
                ExcelReader.Get_QL_Update_Journey_Level_Wages(Name, QL_Update_Journey_Level_Wages.EFFECTIVEDATE));
            GetInstance<Update_Journey_Level_Wages_Page>().Table_NewWageAmount_Input(
                2, 
                ExcelReader.Get_QL_Update_Journey_Level_Wages(Name, QL_Update_Journey_Level_Wages.WAGEAMOUNT));
            GetInstance<Update_Journey_Level_Wages_Page>().Table_Update_Btn(2);
            Thread.Sleep(3000);
            ExtentReportLog(
                "Updated successfully!",
                GetInstance<Update_Journey_Level_Wages_Page>().WageLevelUpdateMessage_Txt(), 
                "Verifying update message", 
                Name);


        }
    }
}
