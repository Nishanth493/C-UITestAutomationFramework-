using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Transfer;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_INTERNAL.Apprenticeship.Transfer
{
    [TestClass]
    public class Verify_Apprentice_Transfer_Internal : TestBase
    {
        string Name;

        [TestMethod]
        public void TCOOO_Verify_Apprentice_Transfer()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_Transfer_Lnk();

                string App_ID = "204890";
                string Transfer_Program = "Washington State UBC JATC";  
                string Effective_Date = "01/06/2020";

                GetInstance<TransferApprentice_Page_1_Internal>().ApprenticeID_Input(App_ID);
                GetInstance<TransferApprentice_Page_1_Internal>().FindApprentice_Btn();
                GetInstance<TransferApprentice_Page_2_Internal>().TransferDate_Input(Effective_Date);
                GetInstance<TransferApprentice_Page_2_Internal>().ProgramName_Input(Transfer_Program);
                GetInstance<TransferApprentice_Page_2_Internal>().OccupationDrpDwn_Select("2");
                string Transfer_Occupation = Selenium.Driver.GetText(GetInstance<TransferApprentice_Page_2_Internal>().OccupationDrpDwnBtn, "OccupationDrpDwnBtn");
                GetInstance<TransferApprentice_Page_2_Internal>().EmployerNameDrpDwn_Select("0");
                GetInstance<TransferApprentice_Page_2_Internal>().CreditPrevExperience_Input("250");
                GetInstance<TransferApprentice_Page_2_Internal>().CreditPrevRSIExperience_Input("50");
                GetInstance<TransferApprentice_Page_2_Internal>().StepDrpDwn_Select("0");
                GetInstance<TransferApprentice_Page_2_Internal>().Transfer_Btn();
                ExtentReportLog(GetInstance<TransferApprentice_Page_2_Internal>().ErrorMessage_Txt(),
                        "Transfer successful",
                        "Verify Transfer Status",
                        Name
                        );
                if (GetInstance<TransferApprentice_Page_2_Internal>().ErrorMessage_Txt() == "Transfer successful")
                {
                    GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppSearch_Lnk();
                    GetInstance<SearchApprentice_Page_Internal>().ApprenticeID_InputTxt(App_ID);
                    GetInstance<SearchApprentice_Page_Internal>().Search_Btn();
                    ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ApprenticID_TableTxt(0),
                        App_ID,
                        "Verify Search App Id",
                        Name
                        );
                    ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().OccupationName_TableTxt(0),
                        Transfer_Occupation,
                        "Verify Occupation",
                        Name
                        );
                    ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().RegistrationDate_TableTxt(0),
                        Effective_Date,
                        "Verify Transfer Date",
                        Name
                        );
                }
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Build Falure: " + e);
                throw (e);
            }
}
    }
}
