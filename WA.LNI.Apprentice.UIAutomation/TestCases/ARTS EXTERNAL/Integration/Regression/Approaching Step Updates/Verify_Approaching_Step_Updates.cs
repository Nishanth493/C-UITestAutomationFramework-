using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Approaching_Step_Updates;
using System.Configuration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Lookup_Links.Apprentice_Lookup_Update;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Navigation_To_Apprenticeship_Dashboard;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Regression.Approaching_Step_Updates
{
    [TestClass]
    public class Verify_Approaching_Step_Updates : TestBase
    {
        string Name;

        /// <summary>
        /// Verifying functionality: Updating step of for one apprentice who is ready for step update (Positive TC)
        /// Inputs: Table | Row Number | New Step Number | Effective Date | Minutes Date 
        /// </summary>
        [TestMethod]
        public void TC000_Verify_Approaching_setp_Update()

        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<TwoStep_Verification>().Continuer_Btn();
            GetInstance<LandingPage>().Tasks("128");
            Thread.Sleep(3000);

            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ReadyForStepUpdate"));
            //GetInstance<DashBoard_Overview_Page>().ActionItems_ApproachingStepUpdates_ClickLnk();
            string Apprentice_ID = GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_ApprenticeID_Txt(4);
            string New_Step = GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_Single_Increment_NewStep_Txt(4);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_Single_Increment_NewStep_Input(4);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_EffectiveDate_Input(ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.TABLEEFFECTIVEDATE), 4);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_MinutesDate_Input(ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.TABLEMINUTESDATE), 4);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Submit_Btn();

            ExtentReportLog("Your information has been submitted successfully!", GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().ApproachingStepUpdateMessage_Txt(), "Verifying Messgae", Name);

            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Navigation_BackToOverView_Lnk();
            //GetInstance<DashBoard_Overview_Page>().LookupLinks_AppLookupUpdate_Lnk();
            GetInstance<Apprentice_Lookup_Update>().SearchApprenticeID_Input(Apprentice_ID);
            GetInstance<Apprentice_Lookup_Update>().Search_Btn();

            ExtentReportLog(
                New_Step,
                GetInstance<Apprentice_Lookup_Update>().Table_AppStep_Txt(0),
                "Verify Step Update",
                Name);
        }

        /// <summary>
        /// Verify all apprentice approaching step update, by inputting Autofill-Effective date and Autofill-Minutes date (Positive TC)
        /// Inputs: Autofill Effective date | Autofill Minutes date | Steps  
        /// Error Message: Your information has been submitted successfully!
        /// </summary>
        [TestMethod]
        public void TC001_Verify_Approaching_setp_Update()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            Thread.Sleep(3000);

            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ReadyForStepUpdate"));
            //GetInstance<DashBoard_Overview_Page>().ActionItems_ApproachingStepUpdates_ClickLnk();

            string[] Apprentice_ID = new string[10];
            string[] New_Step = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Apprentice_ID[i] = (GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_ApprenticeID_Txt(i)) ;
                New_Step[i] = GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_Single_Increment_NewStep_Txt(i);
            }

            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().EffectiveDate_Input(ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.AUTOFILLEFFECTIVEDATE));
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().MinutesDate_Input(ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.AUTOFILLMINUTESDATE));
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_Input_All_New_Steps();
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Submit_Btn();
            ExtentReportLog("Your information has been submitted successfully!", GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().ApproachingStepUpdateMessage_Txt(), "Verifying Messgae", Name);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Navigation_BackToOverView_Lnk();
            //GetInstance<DashBoard_Overview_Page>().LookupLinks_AppLookupUpdate_Lnk();

            for (int i = 0; i < 10; i++)
            {
                GetInstance<Apprentice_Lookup_Update>().SearchApprenticeID_Input(Apprentice_ID[i]);
                GetInstance<Apprentice_Lookup_Update>().Search_Btn();
                Thread.Sleep(3000);

                ExtentReportLog(
                    New_Step[i],
                    GetInstance<Apprentice_Lookup_Update>().Table_AppStep_Txt(0),
                    "Verify Step Update",
                    Name);

                Thread.Sleep(1000);
                GetInstance<Apprentice_Lookup_Update>().Reset_Btn();
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Verify error messages by inputting wrong Step Number (Negitive TC)
        /// Inputs: Effective date | Minutes date | Steps  
        /// Error Message: "New step number should be higher than current step"
        /// </summary>
        [TestMethod]
        public void TC002_Verify_Approaching_setp_Update()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            Thread.Sleep(3000);
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ReadyForStepUpdate"));
            //GetInstance<DashBoard_Overview_Page>().ActionItems_ApproachingStepUpdates_ClickLnk();
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_EffectiveDate_Input(
                ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.TABLEEFFECTIVEDATE), 3);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_MinutesDate_Input(
                ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.TABLEMINUTESDATE), 3);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_Single_Decrement_NewStep_Input(3);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Submit_Btn();
            ExtentReportLog("New step number should be higher than current step",
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_ErrorMessage_Txt(2), "Verifying Messgae", Name);
        }

        /// <summary>
        /// Verify error messages by not inputting effective date (Negitive TC)
        /// Inputs: Effective date | Minutes date | Steps  
        /// Error Message: "Enter Effective date."
        /// </summary>
        [TestMethod]
        public void TC003_Verify_Approaching_setp_Update()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ReadyForStepUpdate"));
           // GetInstance<DashBoard_Overview_Page>().ActionItems_ApproachingStepUpdates_ClickLnk();
            //Base.GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_EffectiveDate_Input(ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.TABLEEFFECTIVEDATE), 3);       
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_MinutesDate_Input(
                ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.TABLEMINUTESDATE), 3);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_Single_Decrement_NewStep_Input(3);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Submit_Btn();
            ExtentReportLog("Enter Effective date.",
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_ErrorMessage_Txt(2), "Verifying Messgae", Name);
        }

        /// <summary>
        /// Verify error messages by not inputting minutes date (Positive TC)
        /// Inputs: Effective date | Minutes date | Steps
        /// Error Message: "Your information has been submitted successfully!"
        /// </summary>
        [TestMethod]
        public void TC004_Verify_Approaching_setp_Update()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("Test_ActionItems_ReadyForStepUpdate"));
            //GetInstance<DashBoard_Overview_Page>().ActionItems_ApproachingStepUpdates_ClickLnk();
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_EffectiveDate_Input(
                ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.TABLEEFFECTIVEDATE), 3);
            //Base.GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_MinutesDate_Input(ExcelReader.Get_AI_ApproachingStepUpdate(Name, AI_ReadyToStepUpdate.TABLEMINUTESDATE), 3);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_Single_Increment_NewStep_Input(3);
            GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Submit_Btn();
            ExtentReportLog("Your information has been submitted successfully!",
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().ApproachingStepUpdateMessage_Txt(), 
                "Verifying Messgae", Name);
        }
    }
}