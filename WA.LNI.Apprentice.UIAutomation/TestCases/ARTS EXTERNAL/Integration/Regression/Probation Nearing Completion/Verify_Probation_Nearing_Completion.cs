using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Probation_Near_Completion;
using System.Configuration;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Regression.ProbationNearingCompletion
{
    [TestClass]
    public class Verify_Probation_Nearing_Completion : TestBase
    {
        string Name;

        /// <summary>
        /// Verify updating probation completion, by autofilling 'Minutes Date' and 'Completion Date' (Positive TC)
        /// Inputs: Minutes date | Completion Date  
        /// Error Message: "Your information has been submitted successfully!"
        /// </summary>
        [TestMethod]
        public void TC000_Verify_Probation_Nearing_Completion()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ProbationNearingCompletion"));
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().MinutesDate_Input(
                ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.AUTOFILLMINUTESDATE));
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().CompletionDate_Input(
                ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.AUTOFILLCOMPLETIONDATE));
            List<string> temp_App_ID = new List<string>();

            for (int i = 0;  i< 10; i++)
            {  
                temp_App_ID.Add(GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ApprenticeID_Txt(i));
            }

            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Submit_Btn();

            Thread.Sleep(3000);

            ExtentReportLog(
                "Your information has been submitted successfully!",
                GetInstance<ActionItems_ProbationNearingCompletion_Page>().ProbationCompletionMessage_Txt(),
                "Submit completion message",
                Name);

            for (int i =0; i<10; i++)
            {
                string query = "SELECT * FROM aprnt.apprentice_pgm_occpn WHERE apprentice_rid = " + temp_App_ID[i] + " AND aprnt_probtn_end_date IS NOT NULL";
                string Prob_End_Date = DBConnection.GetDBData(query, "aprnt_probtn_end_date");

                string[] DB_Date_ = Prob_End_Date.Split(' ');

                Console.WriteLine(DB_Date_[0]);

                string tempDate = ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLECOMPLETIONDATE);

                DateTime parseDate = DateTime.Parse(tempDate);

                string[] VerifyDate = (parseDate.ToString()).Split(' ');

                ExtentReportLog(
                VerifyDate[0],
                DB_Date_[0],
                "Verify updating probation completion, by autofilling 'Minutes Date' and 'Completion Date'(Positive TC) "+
                "Inputs: Minutes date | Completion Date "+
                "Error Message: 'Your information has been submitted successfully!' "+
                "Verify Completion Date Check for " + temp_App_ID[i] + "(Apprentice ID) ",
                Name);

                DBConnection.CloseDB();
            }  
        }


        /// <summary>
        /// Verify updating probation completion, by inputting 'Minutes Date' and 'Completion Date' for a single apprentice (Positive TC)
        /// Inputs: Minutes date | Completion Date  
        /// Error Message: "Your information has been submitted successfully!" 
        /// </summary>
        [TestMethod]
        public void TC001_Verify_Probation_Nearing_Completion()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ProbationNearingCompletion"));
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_MinutesDate_Input(3,
                ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLEMINUTESDATE));
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_Completion_Input(
                ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLECOMPLETIONDATE), 3);
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Submit_Btn();
            string temp_App_ID = GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ApprenticeID_Txt(3);

            ExtentReportLog(
                "Your information has been submitted successfully!",
                GetInstance<ActionItems_ProbationNearingCompletion_Page>().ProbationCompletionMessage_Txt(),
                "Verify updating probation completion, by inputting 'Minutes Date' and 'Completion Date' for a single apprentice (Positive TC) "+
                "Inputs: Minutes date | Completion Date "+
                "Error Message: 'Your information has been submitted successfully!' ",
                Name);

            string query = "SELECT * FROM aprnt.apprentice_pgm_occpn WHERE apprentice_rid = "+ temp_App_ID+" AND aprnt_probtn_end_date IS NOT NULL";
            string Prob_End_Date = DBConnection.GetDBData(query, "aprnt_probtn_end_date");
            string[] DB_Date_ = Prob_End_Date.Split(' ');
            string tempDate = ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLECOMPLETIONDATE);
            DateTime parseDate = DateTime.Parse(tempDate);
            string[] VerifyDate = (parseDate.ToString()).Split(' ');

            ExtentReportLog(
                VerifyDate[0],
                DB_Date_[0],
                "Date Check",
                Name);
        }

        /// <summary>
        /// Verify updating probation completion error messages, by not inputting 'Minutes Date' for a single apprentice (Negative TC)
        /// Inputs:  Completion Date  
        /// Error Message: "Enter Minute date." 
        /// </summary>
        [TestMethod]
        public void TC002_Verify_Probation_Nearing_Completion()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ProbationNearingCompletion"));
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
           // GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_MinutesDate_Input(3,
             //   ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLEMINUTESDATE));
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_Completion_Input(
                ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLECOMPLETIONDATE), 3);
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Submit_Btn();
            string temp_App_ID = GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ApprenticeID_Txt(3);
            ExtentReportLog(
                "Enter Minute date.",
                GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ErrorMessage_Txt(3),
                "Verify updating probation completion error messages, by not inputting 'Minutes Date' for a single apprentice (Negative TC) "+
                "Inputs:  Completion Date "+  
                "Error Message: 'Enter Minute date.'",
                Name);
        }

        /// <summary>
        /// Verify updating probation completion error messages, by not inputting 'Minutes Date' for a single apprentice (Negative TC)
        /// Inputs:  Completion Date  
        /// Error Message: "Enter Completion date." 
        /// </summary>
        [TestMethod]
        public void TC003_Verify_Probation_Nearing_Completion()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ProbationNearingCompletion"));
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();       
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_MinutesDate_Input(3,
                ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLEMINUTESDATE));
            //GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_Completion_Input(
                //ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLECOMPLETIONDATE), 3);
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Submit_Btn();
            string temp_App_ID = GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ApprenticeID_Txt(3);

            ExtentReportLog(
                "Enter Completion date.",
                GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ErrorMessage_Txt(3),
                "Test Case: Verify updating probation completion error messages, by not inputting 'Minutes Date' for a single apprentice (Negative TC)"+ 
                " Inputs:  Completion Date" +
                " Error Message: 'Enter Completion date.'",
                Name);
        }

        /// <summary>
        /// Verify updating probation completion error messages, by inputting 'Completion Date' prior to begin date for a single apprentice (Negative TC)
        /// Inputs:  Completion Date  
        /// Error Message: "Probation completion date: mm/dd/yyyy should be after the probation start date: mm/dd/yyyy" 
        /// </summary>
        [TestMethod]
        public void TC004_Verify_Probation_Nearing_Completion()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ProbationNearingCompletion"));
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
            string BeginDate = GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_Begindate_Txt(3);
            DateTime parseDate = DateTime.Parse(BeginDate);
            DateTime Completion_Date_temp = parseDate.AddDays(-1);
            string Completion_Date = Completion_Date_temp.ToString("MM/dd/yyyy");
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_MinutesDate_Input(3,
                ExcelReader.Get_AI_ProbationNearingCompletion(Name, AI_ProbationNearingCompletion.TABLEMINUTESDATE));
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_Completion_Input(Completion_Date, 3);
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Submit_Btn();
            string temp_App_ID = GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ApprenticeID_Txt(3);
            DateTime parseDate_2 = DateTime.Parse(Completion_Date);
            string[] Completion_Date_2 = (parseDate_2.ToString()).Split(' ');
            string message = "Probation completion date: " + Completion_Date_2[0] + " should be after the probation start date: " + BeginDate;

            ExtentReportLog(
                message,
                GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ErrorMessage_Txt(3),
                "Verify updating probation completion error messages, by inputting 'Completion Date' prior to begin date for a single apprentice (Negative TC) "+
                "Inputs:  Completion Date "+  
                "Error Message: 'Probation completion date: mm/dd/yyyy should be after the probation start date: mm/dd/yyyy' ",
                Name);
        }
    }
}

