/* 
 First Name:  "EXEC [aprnt].[p_apprentice_details] @apprentice_id = @App_ID" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "FirstName")
 Last Name: "EXEC [aprnt].[p_apprentice_details] @apprentice_id = @App_ID" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "LastName")
 Apprentice ID: "EXEC [aprnt].[p_apprentice_details] @apprentice_id = @App_ID" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "ApprenticeId")
                Apprentice_Occupation_Rid: "EXEC [aprnt].[p_apprentice_details] @apprentice_id = @App_ID" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "ApprenticeOccupationRid")

 Address1: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "AddressLisne1")
 City: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "City")
 State: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "State")
 ZipCode: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "ZipCode")
 Gender: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "Gender")

 Race: "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "Race")

 EducationLevel: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "EducationLevel")
 Military Status: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "VetStatus")

 Apprentice ID: "EXEC [aprnt].[p_apprentice_details] @apprentice_id = @App_ID" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "StatusDecription")

 RegistrtaionDate: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "RegistrationDate")
 
 TransferDate: "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "TransferDate")
 Cancellation:
 Suspension (start): "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "SuspensionStartDate")
 Suspension (end): "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "SuspensionEndDate")

 Probation (start): "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "ProbationStartDate")
 Probation (end): "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "ProbationEndDate")

 Completion: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "CompletionDate")

 ApprenticeshipTerm (Hours): "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "OccupationTerm")
 ProbationHoursRequired: "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "ProbationHoursRequired")

 Wage Progression Step and Effective Date:
 ~~ StepNumber- "select Top 1 [step_num] as StepNum from [aprnt].[apprentice_pgm_occp_step] where [apprentice_pgm_occpn_rid]=24659 order by StepNum Desc"
 ~~ EffectiveDate- "select Top 1 [effective_date] as EffectiveDate from [aprnt].[apprentice_pgm_occp_step] where [apprentice_pgm_occpn_rid]=24659 order by EffectiveDate Desc"

 TotalOJT Hours: "EXEC [aprnt].[p_apprentice_details] @apprentice_id = @App_ID" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "TotalOJT")

 Credited OJT Hours:"EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "CreditForPreviousExp")

 TotalRSI Hours:"EXEC [aprnt].[p_apprentice_details] @apprentice_id = @App_ID" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "TotalRSI")

 Credited RSI Hours:"EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "CreditForPreviousRSIExp")

 ProgramID:"EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "ProgramId")

 Sub Program Name: "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "SuspensionStartDate")

 Apprenticeship Occupation: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "SubProgram")

 LicenseNum: "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid = @Apprentice_Occupation_Rid" | DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "LicenseNum")
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Lookup_Links.Apprentice_Lookup_Update;
using System.Collections.Generic;
using System.Configuration;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Integration.SmokeTest
{
    [TestClass]
    public class Smoke_Apprentice_Information :TestBase
    {
        string Name;
        [TestMethod]
        public void TS000_Apprentice_Info()
        {
            try
            {
                string[] ID_s = { };
                for (int p = 0; p < ID_s.Length; p++)
                {
                    Name = MethodBase.GetCurrentMethod().Name;
                    Selenium.Log = Selenium.Extent.StartTest(Name);
                    Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

                    GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
                    ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
                    GetInstance<LandingPage>().Tasks(ExcelReader.GetTestData_Integration(Name, DataConstants.PROGRAMID));
                    GetInstance<DashBoard_Overview_Page>().LookupLinks_AppLookupUpdate_Lnk();

                    ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_SmokeTest_Apprentice_Information"));

                    string ApprenticeID = ExcelReader.Get_TS_Apprentice_Information(Name, TS_Apprentice_Information.APPRENTICEID);

                    GetInstance<Apprentice_Lookup_Update>().SearchApprenticeID_Input(ApprenticeID);
                    GetInstance<Apprentice_Lookup_Update>().Search_Btn();
                    GetInstance<Apprentice_Lookup_Update>().Table_ApprenticeNameID_Lnk(0);

                    //Validating personal info First Name, Middle Name, Last Name, Apprentice ID, Address
                    //Gender, Race or Ethnicity, Highest Education Level Completed & Military Status 

                    //string ApprenticPersonalInfo_Current_Query_1 = "EXEC [aprnt].[p_apprentice_details] @apprentice_id ="+ ApprenticeID;

                    string ApprenticPersonalInfo_Current_Query_1 = "SELECT TOP(1) ap.first_name As FirstName, \n" +
                                                                    "ap.last_name AS LastName, \n" +
                                                                    "Isnull(st.status_code, st_first.status_code)[Status], \n" +
                                                                    "p.full_name AS ProgramName, \n" +
                                                                    "oc.full_title_text AS OccupationName, \n" +
                                                                    "ap.rid AS ApprenticeId, \n" +
                                                                    "apo.rid AS ApprenticeOccupationRid, \n" +
                                                                    "Isnull(lk.name_text, lk1.name_text) AS StatusDescription, \n" +
                                                                    "app_hours.TotalOJT, \n" +
                                                                    "app_hours.TotalRSI, \n" +
                                                                    "po.term_hrs_qty AS OccupationTerm, \n" +
                                                                    "po.pgm_rid AS ProgramId \n" +
                                                                    "FROM   aprnt.apprentice ap \n" +
                                                                    "INNER JOIN aprnt.apprentice_pgm_occpn apo \n" +
                                                                    "ON ap.rid = apo.apprentice_rid \n" +
                                                                    "OUTER apply(SELECT TOP(1) * \n" +
                                                                    "FROM   aprnt.apprentice_pgm_occp_status apos \n" +
                                                                    "WHERE  apo.rid = apos.apprentice_pgm_occpn_rid \n" +
                                                                    "AND apos.[effective_date] <= Getdate() \n" +
                                                                    "ORDER  BY apos.[effective_date] DESC) st \n" +
                                                                    "-- if effective date is in future and there is only one record available for status then show this record with out of considering effective date \n" +
                                                                    "OUTER apply(SELECT TOP(1) * \n" +
                                                                    "FROM   aprnt.apprentice_pgm_occp_status apos \n" +
                                                                    "WHERE  apo.rid = apos.apprentice_pgm_occpn_rid \n" +
                                                                    "ORDER  BY apos.[effective_date] DESC) st_first \n" +
                                                                    "OUTER apply(SELECT  SUM(CASE WHEN occ_hr.[work_hour_type_code] in ('RSI_Paid', 'RSI_Unpaid') THEN ISNULL(occ_hr.[hrs_qty], 0) ELSE 0 END) TotalRSI, \n" +
                                                                    "SUM(CASE WHEN occ_hr.[work_hour_type_code] in ('OJT') THEN ISNULL(occ_hr.[hrs_qty], 0) ELSE 0 END) TotalOJT \n" +
                                                                    "FROM   aprnt.apprentice_pgm_occpn_hour occ_hr \n" +
                                                                    "WHERE occ_hr.apprentice_pgm_occpn_rid = apo.rid \n" +
                                                                    ") app_hours \n" +
                                                                    "INNER JOIN pgm.pgm_occpn po " +
                                                                    "ON po.rid = apo.pgm_occpn_rid \n" +
                                                                    "INNER JOIN pgm.pgm p \n" +
                                                                    "ON p.rid = po.pgm_rid \n" +
                                                                    "INNER JOIN occpn.occpn oc \n" +
                                                                    "ON oc.rid = po.occpn_rid \n" +
                                                                    "INNER JOIN[lookup].[aprnt_status] lk \n" +
                                                                    "ON lk.code = st.status_code \n" +
                                                                    "INNER JOIN[lookup].[aprnt_status] lk1 \n" +
                                                                    "ON lk1.code = st_first.status_code \n" +
                                                                    "WHERE  apo.apprentice_rid =" + ApprenticeID + "\n" +
                                                                    "ORDER BY Isnull(apo.aprnt_begin_date, apo.registration_date) DESC";

                    string FirstName_temp_0 = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_1, "FirstName");
                    string[] FirstName_temp_1 = FirstName_temp_0.Split(' ');
                    string FirstName = FirstName_temp_1[0];
                    string LastName = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_1, "LastName");
                    string Apprentice_Id = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_1, "ApprenticeId");

                    string Apprentice_Occupation_rid = DBConnection.GetDBData("SELECT TOP 1 * FROM [aprnt].[apprentice_pgm_occpn] a WHERE a.apprentice_rid= " + ApprenticeID + " ORDER BY a.aprnt_begin_date DESC", "rid");

                    string ApprenticPersonalInfo_Current_Query_2 = "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid =" + Apprentice_Occupation_rid;

                    string Address1 = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "AddressLine1");
                    //string Address2 = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "aprnt_addr2_data");
                    string City = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "City");
                    string State = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "State");
                    string Zip = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "ZipCode");
                    string address_Cust = Address1 + ", " + City + ", " + State + ", " + Zip;

                    string Gender = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "Gender");

                    string ApprenticPersonalInfo_Current_Query_3 = "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = " + Apprentice_Occupation_rid;

                    string Race = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "Race");
                    string Education = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "EducationLevel");
                    string Military = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "VetStatus");
                    string Tranfer = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "TransferDate");
                    string Cancellation = "";
                    string Suspension_Start_Original = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "SuspensionStartDate");
                    string[] ss_temp0 = Suspension_Start_Original.Split(' ');
                    string Suspension_Start = ss_temp0[0];

                    string Suspension_End_Original = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "SuspensionEndDate");
                    string[] se_temp0 = Suspension_End_Original.Split(' ');
                    string Suspension_End = se_temp0[0];

                    string Suspension = Suspension_Start + " to " + Suspension_End;

                    string Probation_Start_Original = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "ProbationStartDate");
                    string[] ps_temp0 = Probation_Start_Original.Split(' ');
                    string Probation_Start = ps_temp0[0];

                    string Probation_End_Original = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "ProbationEndDate");
                    string[] pe_temp0 = Probation_End_Original.Split(' ');
                    string Probation_End = pe_temp0[0];

                    string Probation = Probation_Start + " to " + Probation_End;

                    string CompletionDate = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "CompletionDate");

                    //string[] BeginDate = (DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "aprnt_begin_date")).Split(' ') ;

                    string Apprenticeship_Hour_Required = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "OccupationTerm");
                    string Probation_Hour_Required = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "ProbabtionHoursRequired");

                    string wageProgression_Step = DBConnection.GetDBData("select Top 1 [step_num] from [aprnt].[apprentice_pgm_occp_step] where [apprentice_pgm_occpn_rid]=" + Apprentice_Occupation_rid + " order by [step_num] Desc", "step_num");
                    string wageProgression_EffectiveDate_Original = DBConnection.GetDBData("select Top 1 [effective_date] from [aprnt].[apprentice_pgm_occp_step] where [apprentice_pgm_occpn_rid]=" + Apprentice_Occupation_rid + " order by [effective_date] Desc", "effective_date");
                    string[] wp_temp0 = wageProgression_EffectiveDate_Original.Split(' ');
                    string wageProgression_EffectiveDate = wp_temp0[0];
                    string Wage_ProgressionStep_and_EffectiveDate = "Step " + wageProgression_Step + " - " + wageProgression_EffectiveDate;

                    string Total_OJT_Query = "select  SUM((ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0))) AS TotalOJT from \n" +
                                                 "(select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n" +
                                                 "from[aprnt].[apprentice_pgm_occpn_hour] \n" +
                                                 "where[apprentice_pgm_occpn_rid]= " + Apprentice_Occupation_rid + " and work_hour_type_code in ('OJT')" +
                                                 "group by[year_num],[quarter_num] \n" +
                                                 ") as q \n" +
                                                 "PIVOT \n" +
                                                 "( \n" +
                                                 "sum(RISHours) \n" +
                                                 "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n" +
                                                 ") as pvt";

                    string Total_OJT_Hours = DBConnection.GetDBData(Total_OJT_Query, "TotalOJT");
                    if (Total_OJT_Hours == "") { Total_OJT_Hours = "0"; }
                    else { float TOJT_temp_0 = float.Parse(Total_OJT_Hours); Total_OJT_Hours = TOJT_temp_0.ToString(); }

                    string Total_Credited_OJT_Hours = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "CreditForPreviousExp");
                    if (Total_Credited_OJT_Hours == "") { Total_Credited_OJT_Hours = "0"; }
                    else { float TCOJT_temp_0 = float.Parse(Total_Credited_OJT_Hours); Total_Credited_OJT_Hours = TCOJT_temp_0.ToString(); }

                    string Total_RSI_Query = "select  SUM((ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0))) AS TotalRSI from \n" +
                                             "(select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n" +
                                             "from[aprnt].[apprentice_pgm_occpn_hour] \n" +
                                             "where[apprentice_pgm_occpn_rid]= " + Apprentice_Occupation_rid + " and work_hour_type_code in ('RSI_Paid','RSI_Unpaid')" +
                                             "group by[year_num],[quarter_num] \n" +
                                             ") as q \n" +
                                             "PIVOT \n" +
                                             "( \n" +
                                             "sum(RISHours) \n" +
                                             "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n" +
                                             ") as pvt";

                    string Total_RSI_Hours = DBConnection.GetDBData(Total_RSI_Query, "TotalRSI");
                    if (Total_RSI_Hours == "") { Total_RSI_Hours = "0"; }
                    else { float TRSI_temp_0 = float.Parse(Total_RSI_Hours); Total_RSI_Hours = TRSI_temp_0.ToString(); }

                    string Total_Credited_RSI_Hours = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "CreditForPreviousRSIExp");
                    if (Total_Credited_RSI_Hours == "") { Total_Credited_RSI_Hours = "0"; }
                    else { float TCRSI_temp_0 = float.Parse(Total_Credited_RSI_Hours); Total_Credited_RSI_Hours = TCRSI_temp_0.ToString(); }


                    String OJT_Years_Total_Query = "select YearNumber,Q1,Q2,Q3,Q4, (ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0)) AS Total from \n" +
                                                    "( \n" +
                                                    "select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n" +
                                                    "from[aprnt].[apprentice_pgm_occpn_hour] \n" +
                                                    "where[apprentice_pgm_occpn_rid]=" + Apprentice_Occupation_rid + "and work_hour_type_code in ('OJT') \n" +
                                                    "group by[year_num],[quarter_num] \n" +
                                                    ") as q \n" +
                                                    "PIVOT \n" +
                                                    "( \n" +
                                                    "sum(RISHours) \n" +
                                                    "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n" +
                                                    ") as pvt \n" +
                                                    "order by YearNumber \n";

                    List<float> OJT_Years_Total = DBConnection.GetDBData_List_Float(OJT_Years_Total_Query, "Total");
                    GetInstance<Apprentice_LookUp_Details>().ViewHistory_Lnk();
                    Thread.Sleep(2000);


                    for (int i = 0; i < OJT_Years_Total.Count; i++)
                    {

                        ExtentReportLog(
                            GetInstance<Apprentice_LookUp_Details>().OJTHoursBreakDown_YearTotals_Table_Txt(i),
                            (OJT_Years_Total[i]).ToString(),
                            "Test OJT hours Break Down",
                            Name
                            );
                    }

                    String RSI_Years_Total_Query = "select YearNumber,Q1,Q2,Q3,Q4, (ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0)) AS Total from \n" +
                                                    "( \n" +
                                                    "select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n" +
                                                    "from[aprnt].[apprentice_pgm_occpn_hour] \n" +
                                                    "where[apprentice_pgm_occpn_rid]=" + Apprentice_Occupation_rid + "and work_hour_type_code in ('RSI_Paid','RSI_Unpaid') \n" +
                                                    "group by[year_num],[quarter_num] \n" +
                                                    ") as q \n" +
                                                    "PIVOT \n" +
                                                    "( \n" +
                                                    "sum(RISHours) \n" +
                                                    "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n" +
                                                    ") as pvt \n" +
                                                    "order by YearNumber \n";

                    List<float> RSI_Years_Total = DBConnection.GetDBData_List_Float(RSI_Years_Total_Query, "Total");

                    for (int i = 0; i < OJT_Years_Total.Count; i++)
                    {
                        ExtentReportLog(
                            GetInstance<Apprentice_LookUp_Details>().RSIHoursBreakDown_YearTotals_Table_Txt(i),
                            (RSI_Years_Total[i]).ToString(),
                            "Test RSI hours Break Down",
                            Name
                            );
                    }

                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(0), FirstName, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(2), LastName, "Validating Info", Name);
                    //ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(1), MiddleName, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(3), ApprenticeID, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(4), address_Cust, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(5), Gender, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(6), Race, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(7), Education, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(8), Military, "Validating Info", Name);
                    //ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(0) , BeginDate[0], "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(4), Total_OJT_Hours, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(5), Total_Credited_OJT_Hours, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(6), Total_RSI_Hours, "Validating Info", Name);
                    ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(7), Total_Credited_RSI_Hours, "Validating Info", Name);

                    if (
                        Int32.Parse(DBConnection.GetDBData(
                            "SELECT Count(rid) as Count FROM [aprnt].[apprentice_pgm_occpn] a WHERE a.apprentice_rid= " + ApprenticeID, "Count"))
                            >= 1)
                    {
                        GetInstance<Apprentice_LookUp_Details>().BackToApprenticeSearch_Lnk();

                        for (int i = 0;
                            i < (Int32.Parse(DBConnection.GetDBData(
                            "SELECT Count(rid) as Count FROM [aprnt].[apprentice_pgm_occpn] a WHERE a.apprentice_rid= " + ApprenticeID, "Count"))) - 1;
                            i++)
                        {
                            GetInstance<Apprentice_Lookup_Update>().Table_ApprenticeNameID_Lnk(0);
                            GetInstance<Apprentice_LookUp_Details>().ViewHistoryItem_Lnk(((
                                (GetInstance<Apprentice_LookUp_Details>().ViewHistoryItemLnk).Count) - 1) - i);

                            Thread.Sleep(5000);

                            Apprentice_Occupation_rid = DBConnection.GetDBData(
                                "SELECT  * FROM [aprnt].[apprentice_pgm_occpn] a WHERE a.apprentice_rid= " +
                                ApprenticeID + " ORDER BY a.aprnt_begin_date DESC OFFSET " + (i + 1) +
                                " ROW FETCH NEXT 1 ROWS ONLY ", "rid");

                            ApprenticPersonalInfo_Current_Query_2 =
                                    "EXEC [aprnt].[p_apprentice_get_print_details] @aprnt_pgm_occpn_rid =" +
                                    Apprentice_Occupation_rid;

                            Address1 = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "AddressLine1");
                            //string Address2 = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "aprnt_addr2_data");
                            City = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "City");
                            State = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "State");
                            Zip = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "ZipCode");
                            address_Cust = Address1 + ", " + City + ", " + State + ", " + Zip;

                            Gender = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "Gender");

                            ApprenticPersonalInfo_Current_Query_3 = "EXEC [aprnt].[usp_apprentice_detail] @ProgramOccupationId = " +
                                    Apprentice_Occupation_rid;

                            Race = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "Race");
                            Education = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "EducationLevel");
                            Military = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "VetStatus");
                            Tranfer = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "TransferDate");

                            Cancellation = "";

                            Suspension_Start_Original = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "SuspensionStartDate");
                            string[] ss1_temp0 = Suspension_Start_Original.Split(' ');
                            Suspension_Start = ss1_temp0[0];

                            Suspension_End_Original = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "SuspensionEndDate");
                            string[] se1_temp0 = Suspension_End_Original.Split(' ');
                            Suspension_End = se1_temp0[0];

                            Suspension = Suspension_Start + " to " + Suspension_End;

                            Probation_Start_Original = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "ProbationStartDate");
                            string[] ps1_temp0 = Probation_Start_Original.Split(' ');
                            Probation_Start = ps1_temp0[0];

                            Probation_End_Original = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "ProbationEndDate");
                            string[] pe1_temp0 = Probation_End_Original.Split(' ');
                            Probation_End = pe1_temp0[0];

                            Probation = Probation_Start + " to " + Probation_End;

                            CompletionDate = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "CompletionDate");

                            //string[] BeginDate = (DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query, "aprnt_begin_date")).Split(' ') ;

                            Apprenticeship_Hour_Required = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "OccupationTerm");
                            Probation_Hour_Required = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_3, "ProbabtionHoursRequired");

                            wageProgression_Step = DBConnection.GetDBData("select Top 1 [step_num] from [aprnt].[apprentice_pgm_occp_step] where [apprentice_pgm_occpn_rid]=" + Apprentice_Occupation_rid + " order by [step_num] Desc", "step_num");
                            wageProgression_EffectiveDate_Original = DBConnection.GetDBData("select Top 1 [effective_date] from [aprnt].[apprentice_pgm_occp_step] where [apprentice_pgm_occpn_rid]=" + Apprentice_Occupation_rid + " order by [effective_date] Desc", "effective_date");
                            string[] wp1_temp0 = wageProgression_EffectiveDate_Original.Split(' ');
                            wageProgression_EffectiveDate = wp1_temp0[0];
                            Wage_ProgressionStep_and_EffectiveDate = "Step " + wageProgression_Step + " - " + wageProgression_EffectiveDate;

                            Total_OJT_Query = "select  SUM((ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0))) AS TotalOJT from \n" +
                                                "(select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n" +
                                                "from[aprnt].[apprentice_pgm_occpn_hour] \n" +
                                                "where[apprentice_pgm_occpn_rid]= " + Apprentice_Occupation_rid + " and work_hour_type_code in ('OJT')" +
                                                "group by[year_num],[quarter_num] \n" +
                                                ") as q \n" +
                                                "PIVOT \n" +
                                                "( \n" +
                                                "sum(RISHours) \n" +
                                                "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n" +
                                                ") as pvt";

                            Total_OJT_Hours = DBConnection.GetDBData(Total_OJT_Query, "TotalOJT");

                            if (Total_OJT_Hours == "") { Total_OJT_Hours = "0"; }
                            else { float TOJT_temp_0 = float.Parse(Total_OJT_Hours); Total_OJT_Hours = TOJT_temp_0.ToString(); }

                            Total_Credited_OJT_Hours = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "CreditForPreviousExp");
                            if (Total_Credited_OJT_Hours == "") { Total_Credited_OJT_Hours = "0"; }
                            else { float TCOJT_temp_0 = float.Parse(Total_Credited_OJT_Hours); Total_Credited_OJT_Hours = TCOJT_temp_0.ToString(); }

                            Total_RSI_Query = "select  SUM((ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0))) AS TotalRSI from \n" +
                                                "(select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n" +
                                                "from[aprnt].[apprentice_pgm_occpn_hour] \n" +
                                                "where[apprentice_pgm_occpn_rid]= " + Apprentice_Occupation_rid + " and work_hour_type_code in ('RSI_Paid','RSI_Unpaid')" +
                                                "group by[year_num],[quarter_num] \n" +
                                                ") as q \n" +
                                                "PIVOT \n" +
                                                "( \n" +
                                                "sum(RISHours) \n" +
                                                "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n" +
                                                ") as pvt";

                            Total_RSI_Hours = DBConnection.GetDBData(Total_RSI_Query, "TotalRSI");

                            if (Total_RSI_Hours == "") { Total_RSI_Hours = "0"; }
                            else { float TRSI_temp_0 = float.Parse(Total_RSI_Hours); Total_RSI_Hours = TRSI_temp_0.ToString(); }

                            Total_Credited_RSI_Hours = DBConnection.GetDBData(ApprenticPersonalInfo_Current_Query_2, "CreditForPreviousRSIExp");
                            if (Total_Credited_RSI_Hours == "") { Total_Credited_RSI_Hours = "0"; }
                            else { float TCRSI_temp_0 = float.Parse(Total_Credited_RSI_Hours); Total_Credited_RSI_Hours = TCRSI_temp_0.ToString(); }

                            OJT_Years_Total_Query = "select YearNumber,Q1,Q2,Q3,Q4, (ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0)) AS Total from \n" +
                                                        "( \n" +
                                                        "select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n" +
                                                        "from[aprnt].[apprentice_pgm_occpn_hour] \n" +
                                                        "where[apprentice_pgm_occpn_rid]=" + Apprentice_Occupation_rid + "and work_hour_type_code in ('OJT') \n" +
                                                        "group by[year_num],[quarter_num] \n" +
                                                        ") as q \n" +
                                                        "PIVOT \n" +
                                                        "( \n" +
                                                        "sum(RISHours) \n" +
                                                        "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n" +
                                                        ") as pvt \n" +
                                                        "order by YearNumber \n";

                            OJT_Years_Total = DBConnection.GetDBData_List_Float(OJT_Years_Total_Query, "Total");

                            for (int j = 0; j < OJT_Years_Total.Count; j++)
                            {

                                ExtentReportLog(
                                    GetInstance<Apprentice_LookUp_Details>().OJTHoursBreakDown_YearTotals_Table_Txt(j),
                                    (OJT_Years_Total[j]).ToString(),
                                    "Test OJT hours Break Down",
                                    Name
                                    );
                            }

                            RSI_Years_Total_Query = "select YearNumber,Q1,Q2,Q3,Q4, (ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0)) AS Total from \n" +
                                                "( \n" +
                                                "select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n" +
                                                "from[aprnt].[apprentice_pgm_occpn_hour] \n" +
                                                "where[apprentice_pgm_occpn_rid]=" + Apprentice_Occupation_rid + "and work_hour_type_code in ('RSI_Paid','RSI_Unpaid') \n" +
                                                "group by[year_num],[quarter_num] \n" +
                                                ") as q \n" +
                                                "PIVOT \n" +
                                                "( \n" +
                                                "sum(RISHours) \n" +
                                                "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n" +
                                                ") as pvt \n" +
                                                "order by YearNumber \n";

                            OJT_Years_Total = DBConnection.GetDBData_List_Float(RSI_Years_Total_Query, "Total");

                            for (int j = 0; j < OJT_Years_Total.Count; j++)
                            {

                                ExtentReportLog(
                                    GetInstance<Apprentice_LookUp_Details>().RSIHoursBreakDown_YearTotals_Table_Txt(j),
                                    (OJT_Years_Total[j]).ToString(),
                                    "Test OJT hours Break Down",
                                    Name
                                    );
                            }

                            ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(0), FirstName, "Validating Info", Name);
                            ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(2), LastName, "Validating Info", Name);
                            //ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(1), MiddleName, "Validating Info", Name);
                            ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(3), ApprenticeID, "Validating Info", Name);
                            Thread.Sleep(2000);
                            ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(4), address_Cust, "Validating Info", Name);
                            ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(5), Gender, "Validating Info", Name);
                            ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(6), Race, "Validating Info", Name);
                            ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(7), Education, "Validating Info", Name);
                            ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppPersonalInfo_Txt(8), Military, "Validating Info", Name);
                            //ExtentReportLog(GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(0) , BeginDate[0], "Validating Info", Name);

                            ExtentReportLog(
                                GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(4), Total_OJT_Hours, "Validating Info",
                                Name);
                            ExtentReportLog(
                                GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(5), Total_Credited_OJT_Hours, "Validating Info",
                                Name);
                            ExtentReportLog(
                                GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(6), Total_RSI_Hours, "Validating Info",
                                Name);
                            ExtentReportLog(
                                GetInstance<Apprentice_LookUp_Details>().AppInfoCloumn_2_Txt(7), Total_Credited_RSI_Hours, "Validating Info",
                                Name);
                            GetInstance<Apprentice_LookUp_Details>().BackToApprenticeSearch_Lnk();
                        }
                    }
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
