using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.TransferAnApprentice;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Requests;
using System.Configuration;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.Regression.TranseferAnApprentice
{
    [TestClass]
    public class Verify_Apprentice_Transfer_Preprod : TestBase_Preprod
    {
        string Name;
        [TestMethod]
        public void TC6794_Verify_Apprentice_Transfer()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestTransferApprenticeInfoSheet"));
            GetInstance<LandingPage>().Tasks();            
            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().QuickLnks_TransferAnApprenticek_ClickLnk();
            string Tran_Id = ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.APPRENTICEID);
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferID_InputBox(Tran_Id);
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferVerify_Btn();
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferOption_RdoBtn(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.DIFFPROGRAMOROCCUPATION));
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferProgram_DrpDwn(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.PROGRAMID));
            GetInstance<Transfer_An_Apprentice_Page>().TO_Program_AppTransferOccup_DrpDwn(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.OCCUPATION));
            GetInstance<Transfer_An_Apprentice_Page>().TO_Program_AppPrevOJT_Input(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.PREVOJT));
            GetInstance<Transfer_An_Apprentice_Page>().AppPrevRSI_Input(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.PREVRSI));
            GetInstance<Transfer_An_Apprentice_Page>().AppComment_InputBox(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.COMMENT));
            GetInstance<Transfer_An_Apprentice_Page>().AppEffectiveDate_InputBox(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.EFFECTIVEDATE));
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferPreviewPge_Btn();
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferPreviewPge_Btn();
            GetInstance<Transfer_An_Apprentice_Preview_Page>().AppTransferReviewSubmit_Btn();
            GetInstance<Transfer_An_Apprentice_Confirmation_Page>().AppTransferConfirmationNavigatePrgmOverview_Lnk();
            GetInstance<DashBoard_Overview_Page>().ChangeProgram_Lnk();
            GetInstance<LandingPage>().ChangeProgram(ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.PROGRAMID));
            GetInstance<DashBoard_Overview_Page>().Reports_ClickTab();
            GetInstance<DashBoard_Overview_Page>().Request_ClickTab();
            GetInstance<Requests_Page>().Click_TakeAction_Matching_ID(Tran_Id);
            GetInstance<Requests_Page>().Accept_Btn();
            Thread.Sleep(3000);

            ExtentReportLog(
                "Your request was successful.",
                GetInstance<Requests_Page>().RequestActionSucessMessage_Txt(),
                "Status Message",
                Name);
        }

        [TestMethod]
        public void TC0002_Verify_Apprentice_Transfer()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_PreProd(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_PreProd(Name, DataConstants.PASSWORD));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestTransferApprenticeInfoSheet"));
            GetInstance<LandingPage>().Tasks("128");
            GetInstance<DashBoard_Overview_Page>().QuickLnks_TransferAnApprenticek_ClickLnk();
            string Tran_Id = ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.APPRENTICEID);
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferID_InputBox(Tran_Id);
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferVerify_Btn();
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferOption_RdoBtn(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.DIFFPROGRAMOROCCUPATION));
            GetInstance<Transfer_An_Apprentice_Page>().TO_Occupation_AppTransferOccup_DrpDwn(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.OCCUPATION));
            GetInstance<Transfer_An_Apprentice_Page>().TO_Occupation_AppPrevOJT_Input(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.PREVOJT));
            GetInstance<Transfer_An_Apprentice_Page>().AppPrevRSI_Input(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.PREVRSI));
            GetInstance<Transfer_An_Apprentice_Page>().AppComment_InputBox(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.COMMENT));
            GetInstance<Transfer_An_Apprentice_Page>().AppEffectiveDate_InputBox(
                ExcelReader.GetApprenticeTrasData(Name, AppTransInfoConstants.EFFECTIVEDATE));
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferPreviewPge_Btn();
            GetInstance<Transfer_An_Apprentice_Page>().AppTransferPreviewPge_Btn();
            GetInstance<Transfer_An_Apprentice_Preview_Page>().AppTransferReviewSubmit_Btn();
            GetInstance<Transfer_An_Apprentice_Confirmation_Page>().AppTransferConfirmationThankyou_Txt();

            ExtentReportLog(
                "Thank you!",
                GetInstance<Transfer_An_Apprentice_Confirmation_Page>().AppTransferConfirmationThankyou_Txt(),
                "Status Message",
                Name);

            GetInstance<Transfer_An_Apprentice_Confirmation_Page>().AppTransferConfirmationNavigatePrgmOverview_Lnk();
            GetInstance<DashBoard_Overview_Page>().Reports_ClickTab();
            GetInstance<DashBoard_Overview_Page>().Request_ClickTab();
            GetInstance<Requests_Page>().Click_TakeAction_Matching_ID(Tran_Id);
            GetInstance<Requests_Page>().Accept_Btn();
            Thread.Sleep(3000);
            ExtentReportLog(
                "Your request was successful.",
                GetInstance<Requests_Page>().RequestActionSucessMessage_Txt(),
                "Status Message",
                Name);
        }
    }
}




