using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.TransferAnApprentice;
using System.Configuration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Training_Agents;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Regression.Taining_Agent
{
    [TestClass]
    public class Verify_Activate_Occupation_For_TA : TestBase
    {
        string Name; 

        [TestMethod]
        public void TC000_Verify_Activate_Occupation_For_TA()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));

            GetInstance<LandingPage>().Tasks("128");

            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_QuickLinks_Activate_Occupation_TA"));

            GetInstance<DashBoard_Overview_Page>().TraingAgent_ClickTab();
            GetInstance<Training_Agents_Page>().Find_InActive_Occupation(
                ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.UBI),
                ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.OCCUPATION),
                ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.EFFECTIVEDATE),
                ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.MINUTESDATE));

            ExtentReportLog("Status Changed Successfully.", GetInstance<Training_Agents_Page>().TAStatusErrorMsg_Txt(), "Test Status Message", Name);

            GetInstance<Training_Agents_Page>().Cancel_Btn();
            GetInstance<Training_Agents_Page>().SearchTrainingAgent_Input(ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.UBI));
            GetInstance<Training_Agents_Page>().SearchTrainingAgent_Btn();

            ExtentReportLog(
                "(Active)",
                GetInstance<Training_Agents_Page>().OccpuationStatusSearchTxt(
                    ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.OCCUPATION)), 
                "Test Status", 
                Name); 
        }
    }
}
