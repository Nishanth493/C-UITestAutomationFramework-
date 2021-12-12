using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Info___Affidavit;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_INTERNAL.Apprenticeship.Affidavit_Lookup
{
    [TestClass]
    public class Verify_Affidavit_Lookup : TestBase
    {
        string Name;

        [TestMethod]
        public void TC0001_Verify_Affidavit_Lookup()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
            GetInstance<Left_Menu_Nav_Bar>().Apprentice_ApprInfoAffidavit_Lnk();
            
            string Apprentice_ID = "29685";
            string Apprentic_FirstName = "A";
            string Apprentic_LastName = "SWANSON";

            GetInstance<AffidavitLookup_Page_Internal>().ApprenticeID_InputTxt(Apprentice_ID);
            
            GetInstance<AffidavitLookup_Page_Internal>().Search_Btn();
            
            string ApprenticAffidavitInfo_Current_Query_1 = 
                "EXEC [aprnt].[p_apprentice_details_for_affidavit] @apprentice_rid = "+ Apprentice_ID + ", @first_name = "+ Apprentic_FirstName + ", @last_name = "+ Apprentic_LastName;

            string FirstName_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "FirstName");
            string LastName_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "LastName");
            string ProgramName_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "Program");
            string Occupation_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "OccupationName");
            string Status_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "StatusDesc");
            string[] RegistrationDate_DB_temp = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "BeginDate").Split(' ');
            string RegistrationDate_DB = DateTime.Parse(RegistrationDate_DB_temp[0]).ToString("MM/dd/yyyy");
            //string []  CancelDate_DB_temp = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "CancelDate").Split(' ');
            //string CancelDate_DB = DateTime.Parse(CancelDate_DB_temp[0]).ToString("MM-dd-yyyy");
            string [] CompletionDate_DB_Temp = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "CompletionDate").Split(' ');
            string CompletionDate_DB = DateTime.Parse(CompletionDate_DB_Temp[0]).ToString("MM/dd/yyyy");

            ExtentReportLog(GetInstance<AffidavitLookup_Page_Internal>().FirstName_TableTxt(0),
                FirstName_DB, " Verify First Name", Name);
            ExtentReportLog(GetInstance<AffidavitLookup_Page_Internal>().LastName_TableTxt(0),
                LastName_DB, " Verify Last Name", Name);
            ExtentReportLog(GetInstance<AffidavitLookup_Page_Internal>().ProgramName_TableTxt(0),
                ProgramName_DB, " Verify Program Name", Name);
            ExtentReportLog(GetInstance<AffidavitLookup_Page_Internal>().OccupationName_TableTxt(0),
                Occupation_DB, " Verify Occupation Name", Name);
            ExtentReportLog(GetInstance<AffidavitLookup_Page_Internal>().Status_TableTxt(0),
                Status_DB, " Verify Status", Name);
            ExtentReportLog(GetInstance<AffidavitLookup_Page_Internal>().RegistrationDate_TableTxt(0),
                RegistrationDate_DB, " Verify Registration Date", Name);
            ExtentReportLog(GetInstance<AffidavitLookup_Page_Internal>().CompletionDate_TableTxt(0),
               CompletionDate_DB, " Verify Completion Date", Name);
            //Console.Write(FirstName_DB + LastName_DB + ProgramName_DB + Occupation_DB + Status_DB + RegistrationDate_DB + CancelDate_DB + CompletionDate_DB);
        }
    }
}
