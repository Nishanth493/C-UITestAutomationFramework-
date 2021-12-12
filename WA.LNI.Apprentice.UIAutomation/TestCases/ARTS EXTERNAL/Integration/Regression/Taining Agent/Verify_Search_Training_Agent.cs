using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.TransferAnApprentice;
using System.Threading;
using System.Configuration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Training_Agents;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Regression.Taining_Agent
{
    [TestClass]
    public class Verify_Search_Training_Agent : TestBase
    {
        string Name;

        /// <summary>
        /// Search Training Agen besed on UBI number 
        /// </summary>
        [TestMethod]
        public void TC000_Verify_Search_Training_Agent()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_QuickLinks_Activate_Occupation_TA"));
            GetInstance<DashBoard_Overview_Page>().TraingAgent_ClickTab();
            GetInstance<Training_Agents_Page>().SearchTrainingAgent_Input(
                ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.UBI));
            GetInstance<Training_Agents_Page>().SearchTrainingAgent_Btn();
            ExtentReportLog(
                ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.UBI),
                GetInstance<Training_Agents_Page>().TAListTable_Txt(0), 
                "Verifying Search", 
                Name);
        }

        /// <summary>
        /// Search based on Training Agent name
        /// </summary>
        [TestMethod]
        public void TC001_Verify_Search_Training_Agent()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_QuickLinks_Activate_Occupation_TA"));
            GetInstance<DashBoard_Overview_Page>().TraingAgent_ClickTab();
            GetInstance<Training_Agents_Page>().SearchTrainingAgent_Input(
                ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.PROGRAMNAME));
            GetInstance<Training_Agents_Page>().SearchTrainingAgent_Btn();
            ExtentReportLog(
                ExcelReader.Get_QL_Activate_Occupation_TA(Name, QL_Activate_Occupation_TA.UBI),
                GetInstance<Training_Agents_Page>().TAListTable_Txt(0), 
                "Verifying Search", 
                Name);
        }
    }
}
