/*-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * /
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System.Reflection;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC.Home;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC.Apprentice_Details;
using System.Collections.Generic;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_PUBLIC
{
    [TestClass]
    public class Verify_Apprentice_Information_Public : TestBase
    {
        string Name; 

        [TestMethod]
        public void Verify_ApprenticeInformation_Public()
        {
            string ApprenticeID_Input = "183607";

            Name = MethodBase.GetCurrentMethod().Name;
            string ApprenticeNameID;
            string ApprenticeStatus;
            string RegistrationDate;
            string TransferDate;
            string CancellationDate;
            string SuspensionDateFromTo;
            string ProbaionStartEnd;
            string CompletionDate;
            string CitYStateZip;
            string Gender;
            string Race;
            string Education;
            string Mitlitary;
            string BeginDate;
            string AppTerm;
            string ProbationHrsReq;
            string CurrentStepnEffectiveDate;
            List<string> T_StepHistory;
            List<string> T_StepEffectiveDatesHistory;
            List<string> T_StepHoursHistory;
            List<string> T_JourneyWage;
            string TotalOJT;
            string CreditedOJTHours;
            string TotalRSIHours;
            string CreditedRSIHours;

            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            //select 'I want to find an Apprentice' radio button 
            //and adding different search filters like 
            //'Status Drop Down' /First Name/Last Name/Apprentice ID
            //in home page
            GetInstance<ARTS_public_Home_Page>().SearchCriteria_RdoBtn(0);

            //GetInstance<Find_An_Apprentice_Home_Public_Page>().ApprenticeFirstName_Input("");
            //GetInstance<Find_An_Apprentice_Home_Public_Page>().ApprenticeLastName_Input("");
            GetInstance<Find_An_Apprentice_Home_Public_Page>().ApprenticeApprenticeID_Input(ApprenticeID_Input);
            GetInstance<Find_An_Apprentice_Home_Public_Page>().Search_Btn();
            Thread.Sleep(1000);
            GetInstance<Find_An_Apprentice_Home_Public_Page>().Table_ApprenticeName_Lnk(0);

            //Assigning values 
            ApprenticeNameID = GetInstance<Apprentice_Details_Public_Page>().ApprenticeName_Txt();
            ApprenticeStatus = GetInstance<Apprentice_Details_Public_Page>().ApprenticeStatus_Txt();
            RegistrationDate = GetInstance<Apprentice_Details_Public_Page>().ApprenticeRegistrtaionDate_Txt();
            TransferDate = GetInstance<Apprentice_Details_Public_Page>().ApprenticeTransferDate_Txt();
            CancellationDate = GetInstance<Apprentice_Details_Public_Page>().ApprenticeCancellationDate_Txt();
            SuspensionDateFromTo = GetInstance<Apprentice_Details_Public_Page>().ApprenticeSuspensionStartEndDate_Txt();
            ProbaionStartEnd = GetInstance<Apprentice_Details_Public_Page>().ApprenticeProbationStartEndDate_Txt();
            CompletionDate = GetInstance<Apprentice_Details_Public_Page>().ApprenticeCompletionDate_Txt();
            CitYStateZip = GetInstance<Apprentice_Details_Public_Page>().ApprenticeAddress_Txt();
            Gender = GetInstance<Apprentice_Details_Public_Page>().ApprenticeGender_Txt();
            Race = GetInstance<Apprentice_Details_Public_Page>().ApprenticeRaceNEthinicityDate_Txt();
            Education = GetInstance<Apprentice_Details_Public_Page>().ApprenticeEducation_Txt();
            Mitlitary = GetInstance<Apprentice_Details_Public_Page>().ApprenticeMilitaryStatus_Txt();
            BeginDate = GetInstance<Apprentice_Details_Public_Page>().ApprenticeshipBeginDate_Txt();
            AppTerm = GetInstance<Apprentice_Details_Public_Page>().ApprenticeshipTerm_Txt();
            ProbationHrsReq = GetInstance<Apprentice_Details_Public_Page>().ProbationHoursRequired_Txt();
            CurrentStepnEffectiveDate = GetInstance<Apprentice_Details_Public_Page>().CurrrentStepAndEffectiveDate_Txt();

            GetInstance<Apprentice_Details_Public_Page>().ViewStepHistory_Click();
            Thread.Sleep(1000);
            T_StepHistory = GetInstance<Apprentice_Details_Public_Page>().Tabel_Steps_Txt();
            T_StepEffectiveDatesHistory = GetInstance<Apprentice_Details_Public_Page>().Tabel_StepsEffectiveDate_Txt();
            T_StepHoursHistory = GetInstance<Apprentice_Details_Public_Page>().Tabel_StepHours_Txt();
            T_JourneyWage = GetInstance<Apprentice_Details_Public_Page>().Tabel_JourneyWage_Txt();

            TotalOJT = GetInstance<Apprentice_Details_Public_Page>().TotalOJTHours_Txt();
            CreditedOJTHours = GetInstance<Apprentice_Details_Public_Page>().CreditedOJTTotalHours_Txt();
            TotalRSIHours = GetInstance<Apprentice_Details_Public_Page>().TotalRSIHours_Txt();
            CreditedRSIHours = GetInstance<Apprentice_Details_Public_Page>().CreditedRSIHoursTotal_Txt();

            /****DB***************************************************************************************************/
          /*  string Q_ApprenticeNameID = 
                "SELECT (a.last_name + ', ' + a.first_name) ApprenticeName,  a.rid ID"+
                "FROM[aprnt].[apprentice] a"+
                "WHERE a.rid = "+ ApprenticeID_Input;
            string Db_ApprenticeNameID = DBConnection.GetDBData(Q_ApprenticeNameID, "ApprenticeName")+ " (" + DBConnection.GetDBData(Q_ApprenticeNameID, "ApprenticeName") + ")";

            string Q_ApprenticeStatus = 
                "SELECT TOP 1 a.rid AppID, (a.last_name + ', ' + a.first_name) ApprenticeName, d.pgm_rid PgmID, e.name_text AppStatus, c.effective_date EffectiveDate, c.create_date" + 
                "FROM[aprnt].[apprentice] a"+ 
                "INNER JOIN[aprnt].[apprentice_pgm_occpn] b" +
                "ON a.rid = b.apprentice_rid" + 
                "INNER JOIN[aprnt].[apprentice_pgm_occp_status] c" + 
                "ON b.rid = c.apprentice_pgm_occpn_rid" + 
                "INNER JOIN[pgm].[pgm_occpn] d" + 
                "ON b.pgm_occpn_rid = d.rid" + 
                "INNER JOIN lookup.aprnt_status e" + 
                "ON c.status_code = e.code" +
                "WHERE a.rid = " + ApprenticeID_Input +
                "AND e.name_text LIKE 'Active'" + 
                "ORDER BY c.effective_date DESC";
            string Db_ApprenticeStatus = DBConnection.GetDBData(Q_ApprenticeStatus, "AppStatus");

            string Q_RegistrationDate = 
                "SELECT b.registration_date RegistrationDate" + 
                "FROM[aprnt].[apprentice] a" + 
                "INNER JOIN[aprnt].[apprentice_pgm_occpn] b" + 
                "ON a.rid = b.apprentice_rid" + 
                "WHERE a.rid = 183607" + 
                "ORDER BY b.registration_date";
            string Db_RegistrationDate = DateTime.Parse(DBConnection.GetDBData(Q_RegistrationDate, "RegistrationDate")).ToString("MM/dd/yyyy");

            string Q_TransferDate =
                "SELECT TOP 1 a.rid AppID, (a.last_name + ', ' + a.first_name) ApprenticeName, d.pgm_rid PgmID, e.name_text AppStatus, c.effective_date EffectiveDate, c.create_date" +
                "FROM[aprnt].[apprentice] a" +
                "INNER JOIN[aprnt].[apprentice_pgm_occpn] b" +
                "ON a.rid = b.apprentice_rid" +
                "INNER JOIN[aprnt].[apprentice_pgm_occp_status] c" +
                "ON b.rid = c.apprentice_pgm_occpn_rid" +
                "INNER JOIN[pgm].[pgm_occpn] d" +
                "ON b.pgm_occpn_rid = d.rid" +
                "INNER JOIN lookup.aprnt_status e" +
                "ON c.status_code = e.code" +
                "WHERE a.rid = " + ApprenticeID_Input +
                "AND e.name_text LIKE 'Transfered'" +
                "ORDER BY c.effective_date DESC";
            string Db_TransferDate = DateTime.Parse(DBConnection.GetDBData(Q_RegistrationDate, "EffectiveDate")).ToString("MM/dd/yyyy");

            string Q_CancellationDate =
               "SELECT TOP 1 a.rid AppID, (a.last_name + ', ' + a.first_name) ApprenticeName, d.pgm_rid PgmID, e.name_text AppStatus, c.effective_date EffectiveDate, c.create_date" +
               "FROM[aprnt].[apprentice] a" +
               "INNER JOIN[aprnt].[apprentice_pgm_occpn] b" +
               "ON a.rid = b.apprentice_rid" +
               "INNER JOIN[aprnt].[apprentice_pgm_occp_status] c" +
               "ON b.rid = c.apprentice_pgm_occpn_rid" +
               "INNER JOIN[pgm].[pgm_occpn] d" +
               "ON b.pgm_occpn_rid = d.rid" +
               "INNER JOIN lookup.aprnt_status e" +
               "ON c.status_code = e.code" +
               "WHERE a.rid = " + ApprenticeID_Input +
               "AND e.name_text LIKE 'Cancelled'" +
               "ORDER BY c.effective_date DESC";
            string Db_CancellationDate = DateTime.Parse(DBConnection.GetDBData(Q_RegistrationDate, "EffectiveDate")).ToString("MM/dd/yyyy");

            string Q_SuspensionDateFromTo =
               "SELECT TOP 1 a.rid AppID, (a.last_name + ', ' + a.first_name) ApprenticeName, d.pgm_rid PgmID, e.name_text AppStatus, c.effective_date EffectiveDate, c.create_date" +
               "FROM[aprnt].[apprentice] a" +
               "INNER JOIN[aprnt].[apprentice_pgm_occpn] b" +
               "ON a.rid = b.apprentice_rid" +
               "INNER JOIN[aprnt].[apprentice_pgm_occp_status] c" +
               "ON b.rid = c.apprentice_pgm_occpn_rid" +
               "INNER JOIN[pgm].[pgm_occpn] d" +
               "ON b.pgm_occpn_rid = d.rid" +
               "INNER JOIN lookup.aprnt_status e" +
               "ON c.status_code = e.code" +
               "WHERE a.rid = " + ApprenticeID_Input +
               "AND e.name_text LIKE 'Suspended'" +
               "ORDER BY c.effective_date DESC";
            string Db_SuspensionDateFromTo = DateTime.Parse(DBConnection.GetDBData(Q_RegistrationDate, "EffectiveDate")).ToString("MM/dd/yyyy");

            
            //string Db_ProbaionStartEnd;
            //string Db_ProbaionStartEnd;
            

            string Q_CompletionDate =
               "SELECT TOP 1 a.rid AppID, (a.last_name + ', ' + a.first_name) ApprenticeName, d.pgm_rid PgmID, e.name_text AppStatus, c.effective_date EffectiveDate, c.create_date" +
               "FROM[aprnt].[apprentice] a" +
               "INNER JOIN[aprnt].[apprentice_pgm_occpn] b" +
               "ON a.rid = b.apprentice_rid" +
               "INNER JOIN[aprnt].[apprentice_pgm_occp_status] c" +
               "ON b.rid = c.apprentice_pgm_occpn_rid" +
               "INNER JOIN[pgm].[pgm_occpn] d" +
               "ON b.pgm_occpn_rid = d.rid" +
               "INNER JOIN lookup.aprnt_status e" +
               "ON c.status_code = e.code" +
               "WHERE a.rid = " + ApprenticeID_Input +
               "AND e.name_text LIKE 'Completed'" +
               "ORDER BY c.effective_date DESC";
            string Db_CompletionDate = DateTime.Parse(DBConnection.GetDBData(Q_RegistrationDate, "EffectiveDate")).ToString("MM/dd/yyyy");

            string Q_CitYStateZip=
                "SELECT a.city_name + ', ' + a.state_code + ', ' + a.zip_code AS 'Address'" +
                "FROM [aprnt].[apprentice_address] a" + 
                "INNER JOIN[aprnt].[apprentice_pgm_occpn] b" + 
                "ON a.apprentice_pgm_occpn_rid = b.rid" + 
                "WHERE b.apprentice_rid = " + ApprenticeID_Input;
            string Db_CitYStateZip = DBConnection.GetDBData(Q_CitYStateZip, "Address");

            string Q_Gender =
            "SELECT b.name_text as Gender" +
            "FROM[aprnt].[apprentice] a" +
            "INNER JOIN lookup.gender b" +
            "ON a.gender_code = b.code" +
            "WHERE a.rid =" + ApprenticeID_Input; 
            string Db_Gender = DBConnection.GetDBData(Q_Gender, "Gender");

            string Q_Race =
               "SELECT b.name_text AS Race" +
               "FROM [aprnt].[apprentice_race] a" + 
               "INNER JOIN lookup.aprnt_race b" + 
               "ON a.race_code = b.code" + 
               "WHERE a.apprentice_rid =" + ApprenticeID_Input;
            string Db_Race = DBConnection.GetDBData(Q_Race, "Race");

            string Q_Education =
                "SELECT b.name_text EducationLevel" +
                "FROM[aprnt].[apprentice] a" +
                "INNER JOIN lookup.education_level b" +
                "ON a.education_level_code = b.code" +
                "WHERE a.rid =" + ApprenticeID_Input;             
            string Db_Education = DBConnection.GetDBData(Q_Education, "EducationLevel");

            string Q_Mitlitary =
                "SELECT b.name_text Military" + 
                "FROM[aprnt].[apprentice] a"+ 
                "INNER JOIN lookup.mil_status b" + 
                "ON a.mil_status_code = b.code" + "WHERE a.rid =" + ApprenticeID_Input;
            string Db_Mitlitary = DBConnection.GetDBData(Q_Mitlitary, "Military");

            string Q_BeginDate =
                "SELECT a.aprnt_begin_date BeginDate" + 
                "FROM[aprnt].[apprentice_pgm_occpn] a" + 
                "WHERE a.apprentice_rid =" + ApprenticeID_Input;
            string Db_BeginDate = DateTime.Parse(DBConnection.GetDBData(Q_BeginDate, "BeginDate")).ToString("MM/dd/yyyy");

            string Q_AppTerm =
                "SELECT a.term_qty ApprenticeshipTerm" + 
                "FROM [aprnt].[apprentice_pgm_occpn] a" +
                "WHERE a.apprentice_rid =" + ApprenticeID_Input;
            string Db_AppTerm = DBConnection.GetDBData(Q_AppTerm, "ApprenticeshipTerm");

            string Q_ProbationHrsReq =
                "SELECT b.probtn_hrs_qty ProbationHrsRequired" + 
                "FROM[aprnt].[apprentice_pgm_occpn] a" + 
                "INNER JOIN[pgm].[pgm_occpn] b" + 
                "ON a.pgm_occpn_rid = b.rid" + 
                "WHERE a.apprentice_rid =" + ApprenticeID_Input;
            string Db_ProbationHrsReq = DBConnection.GetDBData(Q_ProbationHrsReq, "ProbationHrsRequired");

            string Q_CurrentStepnEffectiveDate =
                "SELECT TOP 1 a.step_num StepNum, a.effective_date EffectiveDate" +
                "FROM [aprnt].[apprentice_pgm_occp_step] a" +
                "INNER JOIN [aprnt].[apprentice_pgm_occpn] b" +
                "ON a.apprentice_pgm_occpn_rid = b.rid" +
                "WHERE b.apprentice_rid = " + ApprenticeID_Input +
                "ORDER BY a.effective_date DESC";
            string Db_CurrentStepnEffectiveDate = "Step "+ DBConnection.GetDBData(Q_CurrentStepnEffectiveDate, "StepNum") 
                + " - " + DateTime.Parse(DBConnection.GetDBData(Q_CurrentStepnEffectiveDate, "EffectiveDate")).ToString("MM/dd/yyyy");
   
            //Step Hours and Journey Wage need to be scripted                                        
        }
    }
}
*/