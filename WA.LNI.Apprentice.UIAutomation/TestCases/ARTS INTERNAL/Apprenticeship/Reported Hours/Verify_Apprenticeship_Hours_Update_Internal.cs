using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Report_Hours;
using System.Collections.Generic;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_INTERNAL.Apprenticeship.Reported_Hours
{
    [TestClass]
    public class Verify_Apprenticeship_Hours_Update_Internal : TestBase
    {
        string Name;

        /// <summary>
        /// Scenario: Searching apprentices based on Program ID and active status 
        /// Inputs: Program ID; Apprentice Status; Selection Check Boxes; From Date; To Date; OJT Hours; RSI Paid Hours; RSI Unpaid Hours
        /// Store: Apprentice ID, Hours Count, From Date, To Date 
        /// Validating: Hours update sucess, updated hours for each apprentice, From/To Date of the reported hours,  
        /// </summary>
        [TestMethod]
        public void TC0000_Verify_Apprenticeship_Hours_Update_Internal()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;            
                Selenium.Log = Selenium.Extent.StartTest(Name);
                List<string> SelectedIDs = new List<string>();
                string ProgramID = "152";
                string Status = "1";
                string ApprenticeSelectionCheckBoxes = "7;8;9";  //0 4 5 1 3 6 2
                string OJTHours = "10";
                string RSIPaidHours = "10";
                string RSIUnpaid = "10";
                string FromDate = "01/20/2019";
                string ToDate = "01/21/2019";

                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_ReportHour_Lnk();
                
                GetInstance<ApprenticeReportHours_Page_Internal>().ProgramID_InputTxt(ProgramID);
                GetInstance<ApprenticeReportHours_Page_Internal>().Status_DrpDwn(Status);
                GetInstance<ApprenticeReportHours_Page_Internal>().Search_Btn();
                GetInstance<ApprenticeReportHours_Page_Internal>().ApprenticeSlection_ChkBox(ApprenticeSelectionCheckBoxes);
                GetInstance<ApprenticeReportHours_Page_Internal>().Continue_Btn();
                //Thread.Sleep(5000);
                SelectedIDs = GetInstance<ApprenticeReportHoursPostSelection_Page_Internal>().SelectIDs_ListTxt();
                GetInstance<ApprenticeReportHoursPostSelection_Page_Internal>().StartDate_Input(FromDate);
                GetInstance<ApprenticeReportHoursPostSelection_Page_Internal>().EndDate_Input(ToDate);
                GetInstance<ApprenticeReportHoursPostSelection_Page_Internal>().ApplyDatesToAll_Lnk();

                for (int i = 0; i < SelectedIDs.Count; i++)
                {
                    GetInstance<ApprenticeReportHoursPostSelection_Page_Internal>().OJTHoursTable_Input(i,OJTHours);
                    GetInstance<ApprenticeReportHoursPostSelection_Page_Internal>().RSIPaidHoursTable_Input(i,RSIPaidHours);
                    GetInstance<ApprenticeReportHoursPostSelection_Page_Internal>().RSIUnPaidHoursTable_Input(i,RSIUnpaid);
                }

                GetInstance<ApprenticeReportHoursPostSelection_Page_Internal>().UpdateHours_Btn();

                //Validating udated hours 
                for (int j = 0; j < SelectedIDs.Count; j++)
                {
                    GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppSearch_Lnk();
                    GetInstance<SearchApprentice_Page_Internal>().ApprenticeID_InputTxt(SelectedIDs[j]);
                    GetInstance<SearchApprentice_Page_Internal>().Search_Btn();
                    GetInstance<SearchApprentice_Page_Internal>().ApprenticID_TableLnk(0);
                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().OJTHistory_Hours_Txt("0"),
                                                            OJTHours,
                                                            "Verify apprentice updated OJT Hours History", Name);
                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().OJTHistory_CreatedDate_Txt("0"),
                                                            DateTime.Today.ToString("MM/dd/yyyy"),
                                                            "Verify apprentice updated OJT Hours Credited Date", Name);
                    //ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().OJTHistory_Hours_Txt("0"),
                      //                                      ToDate,
                        //                                    "Verify apprentice updated OJT Hours History", Name);
                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_Hours_Txt("0"),
                                                            RSIPaidHours,
                                                            "Verify apprentice updated RSI Paid Hours History", Name);
                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_CreatedDate_Txt("0"),
                                                            DateTime.Today.ToString("MM/dd/yyyy"),
                                                            "Verify apprentice updated RSI Paid Hours Credited Date", Name);
                    //ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_Hours_Txt("0"),
                      //                                      ToDate,
                        //                                    "Verify apprentice updated OJT Hours History", Name);
                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIUnpaidHistory_Hours_Txt("0"),
                                                            RSIUnpaid,
                                                            "Verify apprentice updated RSI Unpaid Hours History", Name);
                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIUnpaidHistory_CreatedDate_Txt("0"),
                                                             DateTime.Today.ToString("MM/dd/yyyy"),
                                                            "Verify apprentice updated RSI Unpaid Hours Credited Date", Name);
                    //ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIUnpaidHistory_Hours_Txt("0"),
                      //                                      ToDate,
                        //                                    "Verify apprentice updated OJT Hours History", Name);
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















