using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.TransferAnApprentice;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Requests;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.RegistrationsAndTransfer_creations
{
    [TestClass]
    public class Transfer : TestBase
    {
        string Name;
        [TestMethod]
        public void Trans_01()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");

            GetInstance<DashBoard_Overview_Page>().QuickLnks_TransferAnApprenticek_ClickLnk();

            string Tran_Id = "175635";

            GetInstance<Transfer_An_Apprentice_Page>().AppTransferID_InputBox(Tran_Id);

            GetInstance<Transfer_An_Apprentice_Page>().AppTransferVerify_Btn();

           //Base.GetInstance<Transfer_An_Apprentice_Page>().AppTransferOption_RdoBtn(0);

            string TransProgTo = "152";

            GetInstance<Transfer_An_Apprentice_Page>().AppTransferProgram_DrpDwn(TransProgTo);

            Thread.Sleep(3000);

            // Base.GetInstance<Transfer_An_Apprentice_Page>().AppTransferOccup_DrpDwn(1);

            GetInstance<Transfer_An_Apprentice_Page>().AppComment_InputBox("Test");

            GetInstance<Transfer_An_Apprentice_Page>().AppEffectiveDate_InputBox("03/01/2019");

            GetInstance<Transfer_An_Apprentice_Page>().AppTransferPreviewPge_Btn();

            Thread.Sleep(3000);

            GetInstance<Transfer_An_Apprentice_Page>().AppTransferPreviewPge_Btn();

            Thread.Sleep(3000);

            GetInstance<Transfer_An_Apprentice_Preview_Page>().AppTransferReviewSubmit_Btn();

            GetInstance<Transfer_An_Apprentice_Confirmation_Page>().AppTransferConfirmationNavigatePrgmOverview_Lnk();

            Thread.Sleep(3000);

            GetInstance<DashBoard_Overview_Page>().ChangeProgram_Lnk();

            GetInstance<LandingPage>().ChangeProgram(TransProgTo);

            Thread.Sleep(3000);

            GetInstance<DashBoard_Overview_Page>().Reports_ClickTab();

            Thread.Sleep(3000);

            GetInstance<DashBoard_Overview_Page>().Request_ClickTab();

            Thread.Sleep(3000);

            GetInstance<Requests_Page>().Click_TakeAction_Matching_ID(Tran_Id);

            GetInstance<Requests_Page>().Accept_Btn();

            Thread.Sleep(3000);

            ExtentReportLog("Your request was successful.", GetInstance<Requests_Page>().RequestActionSucessMessage_Txt(), "Status Message", Name);

        }
    }
}
