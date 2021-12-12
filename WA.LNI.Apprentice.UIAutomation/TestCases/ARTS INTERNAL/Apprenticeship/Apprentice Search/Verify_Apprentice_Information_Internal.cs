/*
 * Apprentice Occupation RID: Select * FROM [aprnt].[apprentice_pgm_occpn] WHERE apprentice_rid = "$APPRENTICE ID$" ORDER BY registration_date DESC
 * 
 * Apprentice Info :-
 * ---------------
 * Apprentice Name - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (FirstName / LastName/ Middle)
 * Education - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (Education)
 * Email - EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (ApprenticeEmail)
 * Phone Number - EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (ApprenticePhone)
 * Address - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (AddressLine1 + CityName + State + ZipCode)
 * SSN - SELECT ssn_num FROM [aprnt].[apprentice] a WHERE a.rid = "$APPRENTICE ID$" (ssn_num)
 * Birth date - SELECT birth_date FROM [aprnt].[apprentice] a WHERE a.rid = "$APPRENTICE ID$" (birth_date)
 * Gender - EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (Gender)
 * Military Status - EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (VetStatus)
 * Race - EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (Race)
 * Hispanice Ethinicity - EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (EthinicGroup)
 * 
 * Transfer History :-
 * ---------------- 
 * Transfer From (Program/Occupation) - EXEC [aprnt].[p_apprentice_transfer_history_loadlist] @apprentice_id = "$APPRENTICE ID$" (TransferFromPgm + TransferFromOccpn)
 * Transfer To (Program/Occupation) - EXEC [aprnt].[p_apprentice_transfer_history_loadlist] @apprentice_id = "$APPRENTICE ID$" (TransferToPgm + TransferTOOccpn)
 * Transfer Date - EXEC [aprnt].[p_apprentice_transfer_history_loadlist] @apprentice_id = "$APPRENTICE ID$" (TranceferDate)
 * 
 * Apprentice Program Occupation Information :- 
 * -----------------------------------------
 * Program Name - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (ProgramId + "-" + ProgramName)
 * Sub Program - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (SubProgram)
 * Occupation - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (OccupationId + "-" + OccupationName)
 * Current Status - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (Status)
 * Registrtaion Date - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (RegistrationDate)
 * Probation Start Date - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (ProbationStartDate)
 * Probation End Date - EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "$ APPRENTICE OCCUPATION ID $" (ProbationEndDate)
 * Direct Entry - Select direct_entry_flg AS DirectEntry FROM [aprnt].[apprentice_pgm_occpn] WHERE rid = "$ APPRENTICE OCCUPATION ID $" (DirectEntry) 
 * Credit From Previous Experience - EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (CreditForPrevousExp)
 * Credit RSI For Previous Experience - EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (CreditForPrevousRSIExp) 
 * Final Hours - SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid = "$ APPRENTICE OCCUPATION ID $" (Final_Hours)) 
 * 
 * Status History:- 
 * --------------
 * Status - SELECT * FROM  [aprnt].[apprentice_pgm_occp_status] WHERE "$ APPRENTICE OCCUPATION ID $" ORDER BY effective_date DESC   (status_code)
 * Effective Date - SELECT * FROM  [aprnt].[apprentice_pgm_occp_status] WHERE "$ APPRENTICE OCCUPATION ID $" ORDER BY effective_date DESC   (effctive_date)
 * 
 * Step History:-
 * ------------
 * Step -      select [effective_date] as EffectiveDate,[step_num] as StepNum from [aprnt].[apprentice_pgm_occp_step]
	           where [apprentice_pgm_occpn_rid]= "$ APPRENTICE OCCUPATION ID $" 
	           order by EffectiveDate,StepNum                                                    (StepNum)
 * 
 * Effective Date -      select [effective_date] as EffectiveDate,[step_num] as StepNum from [aprnt].[apprentice_pgm_occp_step]
	                     where [apprentice_pgm_occpn_rid]= "$ APPRENTICE OCCUPATION ID $" 
	                     order by EffectiveDate,StepNum                                          (EffectiveDate)
 * 
 * RSI Unpaid Hours:- 
 * ----------------
 * Year -  SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
           AND work_hour_type_code LIKE 'RSI_Unpaid'
           ORDER BY year_num DESC, quarter_num DESC                                    (year_num)
 * Quarter - SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
             AND work_hour_type_code LIKE 'RSI_Unpaid'
             ORDER BY year_num DESC, quarter_num DESC                                  (quarter_num)
 * Creat Date - SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
                AND work_hour_type_code LIKE 'RSI_Unpaid'
                ORDER BY year_num DESC, quarter_num DESC                               (create_date)
 * Hours -      SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
                AND work_hour_type_code LIKE 'RSI_Unpaid'
                ORDER BY year_num DESC, quarter_num DESC                               (hrs_qty)
 * 
 * RSI Paid Hours:- 
 * --------------
 * Year -  SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
           AND work_hour_type_code LIKE 'RSI_Paid'
           ORDER BY year_num DESC, quarter_num DESC                                    (year_num)
 * Quarter - SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
             AND work_hour_type_code LIKE 'RSI_Paid'
             ORDER BY year_num DESC, quarter_num DESC                                  (quarter_num)
 * Creat Date - SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
                AND work_hour_type_code LIKE 'RSI_Paid'
                ORDER BY year_num DESC, quarter_num DESC                               (create_date)
 * Hours -      SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
                AND work_hour_type_code LIKE 'RSI_Paid'
                ORDER BY year_num DESC, quarter_num DESC                               (hrs_qty)
 * 
 * OJT Hours:- 
 * --------------
 * Year -  SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
           AND work_hour_type_code LIKE 'OJT'
           ORDER BY year_num DESC, quarter_num DESC                                    (year_num)
 * Quarter - SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
             AND work_hour_type_code LIKE 'OJT'
             ORDER BY year_num DESC, quarter_num DESC                                  (quarter_num)
 * Creat Date - SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
                AND work_hour_type_code LIKE 'OJT'
                ORDER BY year_num DESC, quarter_num DESC                               (create_date)
 * Hours -      SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =$ APPRENTICE OCCUPATION ID $ 
                AND work_hour_type_code LIKE 'OJT'
                ORDER BY year_num DESC, quarter_num DESC                               (hrs_qty)
 * 
 * Additional Hours:- 
 * ----------------
 * Creat Date - SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid = $ APPRENTICE OCCUPATION ID $ 
                AND work_hour_type_code LIKE 'Additional'
                ORDER BY year_num DESC, quarter_num DESC                               (create_date)
 * Hours -      SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid = $ APPRENTICE OCCUPATION ID $ 
                AND work_hour_type_code LIKE 'Additional '
                ORDER BY year_num DESC, quarter_num DESC                               (hrs_qty)
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;
using WA.LNI.Apprentice.UIAutomation.Utilities;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_INTERNAL.Apprenticeship.Apprentice_Search
{
    [TestClass]
    public class Verify_Apprentice_Information_Internal : TestBase
    {
        string Name;
        [TestMethod]
        public void Verify_Apprentice_Information_Internal_000()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppSearch_Lnk();

                string Apprentice_ID = "87544";   //ID: 87544 (3 Programs) //136362 (2 Programs) //202781 (1 Program) 189595

                GetInstance<SearchApprentice_Page_Internal>().ApprenticeID_InputTxt(Apprentice_ID);
                GetInstance<SearchApprentice_Page_Internal>().Search_Btn();
                GetInstance<SearchApprentice_Page_Internal>().ApprenticID_TableLnk(0);
                Thread.Sleep(1000);
                string UI_Name = GetInstance<ApprenticeInformation_Page_Internal>().NameList_Txt();
                string UI_Education = GetInstance<ApprenticeInformation_Page_Internal>().EduicationList_Txt();
                string UI_Email = GetInstance<ApprenticeInformation_Page_Internal>().EmailAddressList_Txt();
                string UI_PhoneNumber = GetInstance<ApprenticeInformation_Page_Internal>().PhoneNumberList_Txt();
                string UI_Address1 = GetInstance<ApprenticeInformation_Page_Internal>().AddressLine1List_Txt();
                string UI_Address2CityStateZip = GetInstance<ApprenticeInformation_Page_Internal>().AddressLine2List_Txt();
                string UI_Address = UI_Address1 + " " + UI_Address2CityStateZip ;

                string [] ssn = (GetInstance<ApprenticeInformation_Page_Internal>().SSNList_Txt()).Split('-');  
                string UI_SSN = ssn[0]+ssn[1]+ssn[2];

                string BirthDate = GetInstance<ApprenticeInformation_Page_Internal>().BirthDateList_Txt();
                string UI_BirthDate = DateTime.Parse(BirthDate).ToString();
                string UI_Gender = GetInstance<ApprenticeInformation_Page_Internal>().GenderList_Txt();
                string UI_MilitaryStatus = GetInstance<ApprenticeInformation_Page_Internal>().MilitaryStatusList_Txt();
                string UI_Race = (GetInstance<ApprenticeInformation_Page_Internal>().RaceList_Txt()).Trim();
                string UI_HispanicEthnicity = GetInstance<ApprenticeInformation_Page_Internal>().HispanicEthnicityList_Txt();
                string UI_ApprenticeID = GetInstance<ApprenticeInformation_Page_Internal>().ApprenticeIDList_Txt();

                //list count starts from 1; 0 is the basic information - number of programs in history is from
                int UI_TotalPrograms = GetInstance<ApprenticeInformation_Page_Internal>().ApprenticeProgramHistoryExpandBtn.Count;

                string DB_ApprenticeID = "Select * FROM [aprnt].[apprentice_pgm_occpn] WHERE apprentice_rid = " + UI_ApprenticeID + " ORDER BY  registration_date DESC, rid DESC;";

                List<string> DB_Apprentice_Occupation_ID = DBConnection.GetDBData_List_String(DB_ApprenticeID, "rid");

                int Programs_Count = DB_Apprentice_Occupation_ID.Count;

                string DB_Apprentice_FirstName = DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[0], "FirstName");
                string DB_Apprentice_MiddleName = DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[0], "MiddleName");
                string DB_Apprentice_LastName = DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[0], "LastName");
                string DB_Apprentice_Name = "";
                if (DB_Apprentice_MiddleName == "" || (DB_Apprentice_MiddleName).ToLower() == "null" || DB_Apprentice_MiddleName == "None")
                {
                    DB_Apprentice_Name = DB_Apprentice_FirstName + " " + DB_Apprentice_LastName;                   
                }
                else { DB_Apprentice_Name = DB_Apprentice_FirstName + " " + DB_Apprentice_MiddleName + " " + DB_Apprentice_LastName; }
                

                string DB_Apprentice_Education = DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = "+DB_Apprentice_Occupation_ID[0], "EducationLevel");
                string DB_Apprentice_Email = DBConnection.GetDBData("EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid =  " + DB_Apprentice_Occupation_ID[0], "ApprenticeEmail");
        
                string DB_Apprentice_Phone = DBConnection.GetDBData("EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[0], "ApprenticePhone");
                if (DB_Apprentice_Phone != "")
                {
                    string[] Apprentice_Phone_0 = DB_Apprentice_Phone.Split('-');
                    DB_Apprentice_Phone = "(" + Apprentice_Phone_0[0] + ") " + Apprentice_Phone_0[1] + "-" + Apprentice_Phone_0[2];
                }

                string DB_Apprentice_Address = DBConnection.GetDBData("EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = "+ DB_Apprentice_Occupation_ID[0], "AddressLine1") + " "
                    + DBConnection.GetDBData("EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[0], "CityName") + " , "
                    + DBConnection.GetDBData("EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[0], "StateCode") + " " 
                    + DBConnection.GetDBData("EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[0], "ZipCode");

                string DB_Apprentice_SSN = DBConnection.GetDBData("SELECT ssn_num FROM [aprnt].[apprentice] a WHERE a.rid = " + UI_ApprenticeID, "ssn_num");
                string DB_Apprentice_DOB = DBConnection.GetDBData("SELECT birth_date FROM [aprnt].[apprentice] a WHERE a.rid = " + UI_ApprenticeID, "birth_date");
                string DB_Apprentice_Gender = DBConnection.GetDBData("EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[0], "Gender");
                string DB_Apprentice_MilitaryStat = DBConnection.GetDBData("EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[0], "VetStatus");
                string DB_Apprentice_Race = DBConnection.GetDBData("EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[0], "Race");

                string DB_Apprentice_HispanicStat = DBConnection.GetDBData("EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[0], "EthnicGroup");
                if (DB_Apprentice_HispanicStat.Equals("Not of Hispanic Origin")) { DB_Apprentice_HispanicStat = "No";  }
                else if (DB_Apprentice_HispanicStat.Equals("Hispanic Origin")) { DB_Apprentice_HispanicStat = "Yes"; }
                else { DB_Apprentice_HispanicStat = ""; }

                //verifing apprentice information 
                ExtentReportLog(UI_ApprenticeID, Apprentice_ID, "Verify ID", Name);
                ExtentReportLog(UI_Name, DB_Apprentice_Name, "Verify Name", Name);
                ExtentReportLog(UI_Education, DB_Apprentice_Education, "Verify Education", Name);
                ExtentReportLog(UI_Email, DB_Apprentice_Email, "Verify Email", Name);
                ExtentReportLog(UI_PhoneNumber, DB_Apprentice_Phone, "Verify Phone Number", Name);
                ExtentReportLog(UI_Address, DB_Apprentice_Address, "Verify Address", Name);
                ExtentReportLog(DB_Apprentice_SSN, UI_SSN, "Verify SSN", Name);
                ExtentReportLog(UI_BirthDate, DB_Apprentice_DOB, "Verify Birth Date", Name);
                ExtentReportLog(UI_Gender, DB_Apprentice_Gender, "Verify Gender", Name);
                ExtentReportLog(UI_MilitaryStatus, DB_Apprentice_MilitaryStat, "Verify Military Status", Name);
                ExtentReportLog(UI_Race, DB_Apprentice_Race, "Verify Race", Name);
                ExtentReportLog(DB_Apprentice_HispanicStat, UI_HispanicEthnicity, "Verify Hispanic Ethinicity", Name);

                if(Programs_Count > 1)
                {
                    for (int k = 2; k <= Programs_Count; k++)
                    {
                        Thread.Sleep(1000);
                        GetInstance<ApprenticeInformation_Page_Internal>().ApprenticeProgramHistoryExpand_Btn((k).ToString());
                    }
                }

                int status_count = 0;
                int step_count = 0;
                int RSIpaid_count = 0;
                int RSIunpaid_count = 0;
                int OJT_count = 0;
                int additional_count = 0;
                int yrs_RSIpaid = 0;
                int yrs_RSIunpaid = 0;
                int yrs_OJT = 0;

                //Verifying information in programs histories 
                for (int j = 0; j < Programs_Count; j++)
                {
                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_Name_Txt(j.ToString()),
                             DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "ProgramId")
                             + "-"
                             + DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "ProgramName"),
                             "Verify Program Name", Name);


                    string subprogram_UI = GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_SubProgrma_Txt(j.ToString());
                    string subprogram_DB = DBConnection.GetDBData("EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "SubProgram");
                    if (subprogram_UI == "" || subprogram_UI == "None" || subprogram_DB == "" || subprogram_DB == "None")
                    {
                        subprogram_UI = "N/A";
                        subprogram_DB = "N/A";
                    }
                    ExtentReportLog(subprogram_UI, subprogram_DB, "Verify Sub Program", Name);

                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_Occupation_Txt(j.ToString()),
                             DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "OccupationId")
                             + "-"
                             + DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "OccupationName"),
                             "Verify Program Occupation", Name);

                    //ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_Employer_Txt(j.ToString()),
                            //DBConnection.GetDBData("---------------------------------------------------"),
                            //"Verify Sub Program", Name);

                    //Verify apprentice status in that program     
                    ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_AlltStatus_Txt(j.ToString()),
                                                            DBConnection.GetDBData("EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "Status"),
                                                            "Verify apprentice status in that program", Name);

                    //Verify apprentice registrtaion date for that program
                    ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_RegistrationDate_Txt(j.ToString())).ToString("MM/dd/yyyy"),
                                                DateTime.Parse(DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "BeginDate")).ToString("MM/dd/yyyy"),
                                                "Verify apprentice registrtaion date for that program", Name);

                    //Verify apprentice probation start date for that program
                    if (GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_ProbationStart_Txt(j.ToString()) != "")
                    {
                        ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_ProbationStart_Txt(j.ToString())).ToString("MM/dd/yyyy"),
                                                    DateTime.Parse(DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "ProbationStartDate")).ToString("MM/dd/yyyy"),
                                                    "Verify apprentice probation start date for that program", Name);
                    }
                    //Verify apprentice probation end date for that program
                    if (GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_ProbationEnd_Txt(j.ToString()) != "")
                    {
                        ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_ProbationEnd_Txt(j.ToString())).ToString("MM/dd/yyyy"),
                                                    DateTime.Parse(DBConnection.GetDBData("EXEC[aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + DB_Apprentice_Occupation_ID[j], "ProbationEndDate")).ToString("MM/dd/yyyy"),
                                                    "Verify apprentice probation end date for that program", Name);
                    }

                    //Verify apprentice direct entery flag of that program
                    string UI_DiretEntry = GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_DirectEntry_Txt(j.ToString());
                    if (UI_DiretEntry == "Yes") { UI_DiretEntry = "True"; } else if (UI_DiretEntry == "No") { UI_DiretEntry = "False"; }
                    ExtentReportLog(UI_DiretEntry,
                        DBConnection.GetDBData("Select direct_entry_flg AS DirectEntry FROM [aprnt].[apprentice_pgm_occpn] WHERE rid = " + DB_Apprentice_Occupation_ID[j], "DirectEntry"),
                        "Verify apprentice direct entery flag of that program", Name);

                    //Verify apprentice Credit For Prevous OJT Exp for that program
                    if (GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_CreditOJT_Txt(j.ToString()) != "")
                    {
                        ExtentReportLog((float.Parse(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_CreditOJT_Txt(j.ToString()))).ToString() + ".00",
                                                DBConnection.GetDBData("EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[j], "CreditForPreviousExp"),
                                                "Verify apprentice Credit For Prevous OJT Exp for that program", Name);
                    }

                    //Verify apprentice Credit For Prevous RSI Exp for that program
                    if (GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_CreditRSI_Txt(j.ToString()) != "")
                    {
                        ExtentReportLog((float.Parse(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_CreditRSI_Txt(j.ToString()))).ToString() + ".00",
                                                DBConnection.GetDBData("EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[j], "CreditForPreviousRSIExp"),
                                                "Verify apprentice Credit For Prevous RSI Exp for that program", Name);
                    }

                    //Verify apprentice final hours for that program
                    if (GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_FinalHours_Txt(j.ToString()) != "")
                    {
                        ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().ProgramHistory_FinalHours_Txt(j.ToString()),
                                                    DBConnection.GetDBData("SELECT * FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[j] + " AND work_hour_type_code LIKE \"Final_Hours\"", "hrs_qty"),
                                                    "Verify apprentice final hours for that program", Name);
                    }

                    //verifying status history and effective dates 
                    List<string> DB_StatusList = DBConnection.GetDBData_List_String("SELECT * FROM [aprnt].[apprentice_pgm_occp_status] WHERE apprentice_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[j] + " ORDER BY effective_date DESC", "status_code");
                    for (int m = 0; m < DB_StatusList.Count; m++)
                    {
                        if (DB_StatusList[m] == "A") { DB_StatusList[m] = "Active"; }
                        else if (DB_StatusList[m] == "C") { DB_StatusList[m] = "Completed"; }
                        else if (DB_StatusList[m] == "L") { DB_StatusList[m] = "Cancelled"; }
                        else if (DB_StatusList[m] == "S") { DB_StatusList[m] = "Suspended"; }
                        else if (DB_StatusList[m] == "T") { DB_StatusList[m] = "Transfered"; }
                        else { DB_StatusList[m] = "---UNKOWN---"; }
                    }

                    List<string> DB_StatusEffectiveDateList = DBConnection.GetDBData_List_String("SELECT * FROM [aprnt].[apprentice_pgm_occp_status] WHERE apprentice_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[j] + " ORDER BY effective_date DESC", "effective_date");
                    if (DB_StatusList.Count != 0)
                    {
                        int l = status_count;
                        for (int temp = 0; temp < DB_StatusEffectiveDateList.Count; temp++)
                        {
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().StatusHistory_Status_Txt(l.ToString()),
                                                        DB_StatusList[temp].ToString(),
                                                        "Verify apprentice Status History for that program", Name);
                            ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().StatusHistory_EffectiveDate_Txt(l.ToString())).ToString("MM/dd/yyyy"),
                                                        DateTime.Parse(DB_StatusEffectiveDateList[temp]).ToString("MM/dd/yyyy"),
                                                        "Verify apprentice Status History for that program", Name);
                            l++;
                        }
                    }

                    //verifying steps and effective date 
                    List<float> DB_StepList = DBConnection.GetDBData_List_Float("SELECT step_num FROM [aprnt].[apprentice_pgm_occp_step] WHERE apprentice_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[j] + "ORDER BY step_num DESC", "step_num");
                    List<string> DB_StepEffectiveDateList = DBConnection.GetDBData_List_String("SELECT effective_date FROM [aprnt].[apprentice_pgm_occp_step] WHERE apprentice_pgm_occpn_rid = " + DB_Apprentice_Occupation_ID[j] + "ORDER BY step_num DESC", "effective_date");

                    if (DB_StepList.Count != 0)
                    {
                        int l = step_count;
                        for (int temp = 0; temp < DB_StepEffectiveDateList.Count; temp++)
                        {
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().StepHistory_Step_Txt(l.ToString()),
                                                        DB_StepList[temp].ToString(),
                                                        "Verify apprentice Steps hours for that program", Name);
                            ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().StepHistory_EffectiveDate_Txt(l.ToString())).ToString("MM/dd/yyyy"),
                                                        DateTime.Parse(DB_StepEffectiveDateList[temp]).ToString("MM/dd/yyyy"),
                                                        "Verify apprentice Steps hours for that program", Name);
                            l++;
                        }
                    }

                    //verifying RSI Paid History Table 
                    List<string> DB_RSIPaid_Yrs = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'RSI_Paid'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "year_num");
                    List<string> DB_RSIPaid_Qtrs = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'RSI_paid'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "quarter_num");
                    List<string> DB_RSIPaid_Date = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'RSI_paid'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "create_date");
                    List<float> DB_RSIPaid_Hrs = DBConnection.GetDBData_List_Float("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'RSI_Paid'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "hrs_qty");
                    int p = yrs_RSIpaid;
                    if (DB_RSIPaid_Hrs.Count != 0)
                    {
                        int l = RSIpaid_count; 

                        if (GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_Years_Txt(l.ToString()) == "No records found.")
                        {
                            p = RSIpaid_count + 1;
                        }

                        for (int temp = 0; temp < DB_RSIPaid_Hrs.Count; temp++)
                        {
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_Years_Txt(p.ToString()),
                                                        DB_RSIPaid_Yrs[temp].ToString(),
                                                        "Verify apprentice RSI Paid Hours History Years for that program", Name);
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_Quater_Txt(l.ToString()),
                                                        DB_RSIPaid_Qtrs[temp].ToString(),
                                                        "Verify apprentice RSI Paid Hours History Qarters for that program", Name);
                            ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_CreatedDate_Txt(l.ToString())).ToString("MM/dd/yyyy"),
                                                        DateTime.Parse(DB_RSIPaid_Date[temp]).ToString("MM/dd/yyyy"),
                                                        "Verify apprentice RSI Paid Hours History Created Date for that program", Name);
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_Hours_Txt(l.ToString()),
                                                        DB_RSIPaid_Hrs[temp].ToString(),
                                                        "Verify apprentice RSI Paid Hours History Hours for that program", Name);
                            l++; p++;
                        }
                    }

                    //verifying RSI UnPaid History Table 
                    List<string> DB_RSIUnPaid_Yrs = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'RSI_Unpaid'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "year_num");
                    List<string> DB_RSIUnPaid_Qtrs = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'RSI_Unpaid'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "quarter_num");
                    List<string> DB_RSIUnPaid_Date = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'RSI_Unpaid'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "create_date");
                    List<float> DB_RSIUnPaid_Hrs = DBConnection.GetDBData_List_Float("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'RSI_Unpaid'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "hrs_qty");
                    int q = yrs_RSIpaid;
                    if (DB_RSIUnPaid_Hrs.Count != 0)
                    {
                        int l = RSIunpaid_count;
                        if (GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_Years_Txt(l.ToString()) == "No records found.")
                        {
                            q = RSIunpaid_count + 1;
                        }
                        
                        for (int temp = 0; temp < DB_RSIUnPaid_Hrs.Count; temp++)
                        {
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIUnpaidHistory_Years_Txt(q.ToString()),
                                                        DB_RSIUnPaid_Yrs[temp].ToString(),
                                                        "Verify apprentice RSI UnPaid Hours History Years for that program", Name);
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIUnpaidHistory_Quater_Txt(l.ToString()),
                                                        DB_RSIUnPaid_Qtrs[temp].ToString(),
                                                        "Verify apprentice RSI UnPaid Hours History Qarters for that program", Name);
                            ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().RSIUnpaidHistory_CreatedDate_Txt(l.ToString())).ToString("MM/dd/yyy"),
                                                        DateTime.Parse(DB_RSIUnPaid_Date[temp]).ToString("MM/dd/yyyy"),
                                                        "Verify apprentice RSI UnPaid Hours History Created Date for that program", Name);
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().RSIUnpaidHistory_Hours_Txt(l.ToString()),
                                                        DB_RSIUnPaid_Hrs[temp].ToString(),
                                                        "Verify apprentice RSI UnPaid Hours History Hours for that program", Name);
                            l++; q++;
                        }
                    }

                    //verifying OJT History Table 
                    List<string> DB_OJT_Yrs = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'OJT'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "year_num");
                    List<string> DB_OJT_Qtrs = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'OJT'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "quarter_num");
                    List<string> DB_OJT_Date = DBConnection.GetDBData_List_String("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'OJT'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "create_date");
                    List<float> DB_OJT_Hrs = DBConnection.GetDBData_List_Float("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'OJT'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date DESC", "hrs_qty");
                    int r = yrs_OJT;
                    if (DB_OJT_Hrs.Count != 0)
                    {
                        int l = OJT_count;
                        if (GetInstance<ApprenticeInformation_Page_Internal>().RSIPaidHistory_Years_Txt(l.ToString()) == "No records found.")
                        {
                            r = OJT_count + 1;
                        }
                        for (int temp = 0; temp < DB_OJT_Hrs.Count; temp++)
                        {                
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().OJTHistory_Years_Txt(r.ToString()),
                                                        DB_OJT_Yrs[temp].ToString(),
                                                        "Verify apprentice OJT History Years for that program", Name);
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().OJTHistory_Quater_Txt(l.ToString()),
                                                        DB_OJT_Qtrs[temp].ToString(),
                                                        "Verify apprentice OJT History Qarters for that program", Name);
                            ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().OJTHistory_CreatedDate_Txt(l.ToString())).ToString("MM/dd/yyyy"),
                                                        DateTime.Parse(DB_OJT_Date[temp]).ToString("MM/dd/yyyy"),
                                                        "Verify apprentice OJT History Created Date for that program", Name);
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().OJTHistory_Hours_Txt(l.ToString()),
                                                        DB_OJT_Hrs[temp].ToString(),
                                                        "Verify apprentice OJT Hours History Hours for that program", Name);
                            l++; r++;
                        }
                    }

                    //verifying Additional Hours History Table 
                    List<float> DB_Additional_Date = DBConnection.GetDBData_List_Float("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'Additional'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date ASC", "create_date");
                    List<float> DB_Additional_Hrs = DBConnection.GetDBData_List_Float("SELECT year_num, quarter_num, create_date, hrs_qty FROM  [aprnt].[apprentice_pgm_occpn_hour] WHERE apprentice_pgm_occpn_rid =" + DB_Apprentice_Occupation_ID[j] +
                        " AND work_hour_type_code LIKE 'Additional'" +
                        " ORDER BY year_num DESC, quarter_num DESC, create_date ASC", "hrs_qty");
                    if (DB_Additional_Hrs.Count != 0)
                    {
                        int l = additional_count;
                        for (int temp = 0 ; temp < DB_Additional_Hrs.Count; temp++)
                        {
                            ExtentReportLog(DateTime.Parse(GetInstance<ApprenticeInformation_Page_Internal>().AdditionalHoursHistory_CreatedDate_Txt(l.ToString())).ToString(),
                                                    DB_Additional_Date[temp].ToString(),
                                                    "Verify apprentice Additional History Created Date for that program", Name);
                            ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().AdditionalHoursHistory_Hours_Txt(l.ToString()),
                                                    DB_Additional_Hrs[temp].ToString(),
                                                    "Verify apprentice Additional Hours History Hours for that program", Name);
                            l++; 
                        }
                    }

                    yrs_RSIpaid = p + RSIpaid_count;
                    yrs_RSIunpaid = q + RSIunpaid_count;
                    yrs_OJT = r + OJT_count;

                    status_count = status_count + DB_StatusList.Count;
                    step_count = step_count + DB_StepList.Count;
                    RSIpaid_count = RSIpaid_count + DB_RSIPaid_Hrs.Count;
                    RSIunpaid_count = RSIunpaid_count + DB_RSIUnPaid_Hrs.Count;
                    OJT_count = OJT_count + DB_OJT_Hrs.Count;
                    additional_count = additional_count + DB_Additional_Hrs.Count;
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

