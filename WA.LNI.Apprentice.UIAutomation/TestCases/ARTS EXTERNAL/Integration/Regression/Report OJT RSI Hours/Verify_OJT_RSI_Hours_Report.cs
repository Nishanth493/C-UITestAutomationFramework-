using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.RSI_OJT_Reporting;
using System.Threading;
using System.Configuration;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Regression.Report_OJT_RSI_Hours
{
    [TestClass]
    public class Verify_OJT_RSI_Hours_Report : TestBase
    {
        string Name;

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TC000_Verify_Report_Hours()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RSI_OJTReporting_ClickLnk();
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_QuickLinks_OJT_RIS_Hours"));
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SelectProgram_DrpDwn(ExcelReader.Get_QL_OJT_RSI_Hours(Name, QL_OJT_RSI_Hours.PROGRAMID));
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().PreferenceHours_RdoBtns(ExcelReader.Get_QL_OJT_RSI_Hours(Name, QL_OJT_RSI_Hours.RSIOROJT));          
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();            
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input(ExcelReader.Get_QL_OJT_RSI_Hours(Name, QL_OJT_RSI_Hours.RSIPAID), 7);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIUnPaid_Input(ExcelReader.Get_QL_OJT_RSI_Hours(Name, QL_OJT_RSI_Hours.RSIUNPAID), 7);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_OJT_Input(ExcelReader.Get_QL_OJT_RSI_Hours(Name, QL_OJT_RSI_Hours.OJT), 7);
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().FromDate_Input(ExcelReader.Get_QL_OJT_RSI_Hours(Name, QL_OJT_RSI_Hours.AUTOFILLFROMDATE));
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().ToDate_Input(ExcelReader.Get_QL_OJT_RSI_Hours(Name, QL_OJT_RSI_Hours.AUTOFILLTODATE));
            GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Submit_ClickBtn();

            if (GetInstance<ApprenticeReadyTo_Report_Hours_Page>().ReportHoursMessage_Txt() == "Error reporting the hours, please check the information you have entered and try again.")
            {
                ExtentReportLog("", GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ErrorMessageInfo_Btn_Txt_0(7), "Error", Name);
            }
            else
            {
                ExtentReportLog("Your information has been submitted successfully!", GetInstance<ApprenticeReadyTo_Report_Hours_Page>().ReportHoursMessage_Txt(), "Status Message ", Name);
            }
        }
    }
}
