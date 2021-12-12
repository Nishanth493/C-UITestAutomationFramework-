using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using System.Reflection;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration;
using System.Threading;
using System.Configuration;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.Regression.RegisterAnApprentice
{
    [TestClass]
    public class Verify_Register_Apprentice : TestBase
    {
        string Name;

        /// <summary>
        /// Verify Apprentice Registration, input valid apprentice information (Positive TC)
        /// </summary>
        [TestMethod]
        public void TC67340_Verify_Regestering_Apprentice()
        {
            
        }
      
        /// <summary>
        /// If apprentices is under 16. then hard stop too young (Negative TC) 
        /// </summary>
        [TestMethod]
        public void TC65652_Verify_Regestering_Apprentice()
        {/*
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();

            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));

            GetInstance<DashBoard_OverviewPage>().RegisterAnApprenticeLnk_ClickLnk();

            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));

            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();

            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));

            GetInstance<AppReg_Form_Page>().AppInitial_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.INITIAL));

            GetInstance<AppReg_Form_Page>().AppLastName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));

            GetInstance<AppReg_Form_Page>().Suffic_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SUFFIX));

            GetInstance<AppReg_Form_Page>().Address1_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));

            GetInstance<AppReg_Form_Page>().City_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));

            GetInstance<AppReg_Form_Page>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));

            GetInstance<AppReg_Form_Page>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));

            GetInstance<AppReg_Form_Page>().AppGenderSelection_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));

            GetInstance<AppReg_Form_Page>().AppDOB_InputBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));

            GetInstance<AppReg_Form_Page>().EducationSelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));

            ExtentReportLog("Age should be at least 16 years" , GetInstance<AppReg_Form_Page>().AppDOBerrormsg_Txt(), "Verifing Apprentice min age", Name);
        }

        /// <summary>
        /// If apprentice SSN# is in ARTS but not active in any program, and try to register in new program with same SSN#. The Apprentice need to be successfully registered (Positive TC)
        /// </summary>

        [TestMethod]
        public void TC67882_Verify_Regestering_Apprentice()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();

            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));

            GetInstance<DashBoard_Overview_Page>().RegisterAnApprenticeLnk_ClickLnk();

            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));

            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();

            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));

            GetInstance<AppReg_Form_Page>().AppInitial_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.INITIAL));

            GetInstance<AppReg_Form_Page>().AppLastName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));

            GetInstance<AppReg_Form_Page>().Address1_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));

            GetInstance<AppReg_Form_Page>().City_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));

            GetInstance<AppReg_Form_Page>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));

            GetInstance<AppReg_Form_Page>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));

            GetInstance<AppReg_Form_Page>().AppGenderSelection_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));

            GetInstance<AppReg_Form_Page>().AppDOB_InputBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));

            GetInstance<AppReg_Form_Page>().EthinicitySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));

            GetInstance<AppReg_Form_Page>().EducationSelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));

            GetInstance<AppReg_Form_Page>().MilitarySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));

            GetInstance<AppReg_Form_Page>().OccupationSelector_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));

            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));

            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));

            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();

            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();

            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();

            String RegId = GetInstance<AppReg_Confirmation>().AppRegID_NumTxt();

            GetInstance<AppReg_EnterSSN_Page>().BackToProgramOverview();


            GetInstance<DashBoard_Overview_Page>().EnterLastNameOrID_SendTxt(RegId);


            GetInstance<DashBoard_OverviewPage>().SelectSearch_ClickBtn();
            //Thread.Sleep(10000);

            String first = ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME);

            String last = ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME);

            String full = last + ", " + first;

            ExtentReportLog(full + " (" + RegId + ")", GetInstance<DashBoard_OverviewPage>().AppListSelectName_GetTxt(0), "Verifing Apprentice Registration", Name);
        }

        /// <summary>
        /// If apprentice SSN# is in ARTS but not active in any program, and try to register in new program with same SSN# but the Birth Date do not match then hard stop to call AC (Negative TC)
        /// </summary>

        [TestMethod]
        public void TC65654_Verify_Regestering_Apprentice()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();

            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));

            GetInstance<DashBoard_OverviewPage>().RegisterAnApprenticeLnk_ClickLnk();

            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));

            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();

            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));

            GetInstance<AppReg_Form_Page>().AppInitial_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.INITIAL));

            GetInstance<AppReg_Form_Page>().AppLastName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));

            GetInstance<AppReg_Form_Page>().Address1_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));

            GetInstance<AppReg_Form_Page>().City_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));

            GetInstance<AppReg_Form_Page>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));

            GetInstance<AppReg_Form_Page>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));

            GetInstance<AppReg_Form_Page>().AppGenderSelection_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));

            GetInstance<AppReg_Form_Page>().AppDOB_InputBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));

            GetInstance<AppReg_Form_Page>().EthinicitySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));

            GetInstance<AppReg_Form_Page>().EducationSelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));

            GetInstance<AppReg_Form_Page>().MilitarySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));

            GetInstance<AppReg_Form_Page>().OccupationSelector_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));

            Thread.Sleep(1000);

            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));

            Thread.Sleep(1000);

            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));

            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();

            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();

            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();

            Thread.Sleep(1000);

            String FalureMsg = GetInstance<AppReg_Review_Page>().RegFalureMsg_txt();

            Thread.Sleep(1000);

            ExtentReportLog(FalureMsg, "The record for this ssn does not match with our record.","Verifing Apprentice Registration", Name);

        }
        */


/*
        /// <summary>
        /// Verify Apprentice Registration, input valid apprentice information (Positive TC)
        /// </summary>
        [TestMethod]
        public void TC67885_Verify_Regestering_Apprentice()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();

            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));

            GetInstance<DashBoard_OverviewPage>().RegisterAnApprenticeLnk_ClickLnk();

            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));

            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();

            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));

            GetInstance<AppReg_Form_Page>().AppInitial_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.INITIAL));

            GetInstance<AppReg_Form_Page>().AppLastName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));

            GetInstance<AppReg_Form_Page>().Address1_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));

            GetInstance<AppReg_Form_Page>().City_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));

            GetInstance<AppReg_Form_Page>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));

            GetInstance<AppReg_Form_Page>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));

            GetInstance<AppReg_Form_Page>().AppGenderSelection_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));

            GetInstance<AppReg_Form_Page>().AppDOB_InputBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));

            GetInstance<AppReg_Form_Page>().EthinicitySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));

            GetInstance<AppReg_Form_Page>().EducationSelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));

            GetInstance<AppReg_Form_Page>().MilitarySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));

            GetInstance<AppReg_Form_Page>().OccupationSelector_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));

            Thread.Sleep(1000);

            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));

            Thread.Sleep(1000);

            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));

            GetInstance<AppReg_Form_Page>().CreditPreviousExp_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CREDITHOURSRSI));

            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();

            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();

            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();

            String RegId = GetInstance<AppReg_Confirmation>().AppRegID_NumTxt();

            GetInstance<AppReg_EnterSSN_Page>().BackToProgramOverview();

            GetInstance<DashBoard_OverviewPage>().EnterLastNameOrID_SendTxt(RegId);
            
            GetInstance<DashBoard_OverviewPage>().SelectSearch_ClickBtn();

            GetInstance<DashBoard_OverviewPage>().AppListSelectHours_GetTxt(0);


            ExtentReportLog(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CREDITHOURSRSI), GetInstance<DashBoard_OverviewPage>().AppListSelectHours_GetTxt(0), "Verifing Apprentice Previous Credit Hours", Name);

        }
        */
        /*
        /// <summary>
        /// Verify apprentice registration, input  previous credit hours more than the occupation allotted hours (Negative TC)
        /// </summary>
        [TestMethod]
        public void TC67888_Verify_Regestering_Apprentice()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();

            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));

            GetInstance<DashBoard_OverviewPage>().RegisterAnApprenticeLnk_ClickLnk();

            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));

            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();

            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));

            GetInstance<AppReg_Form_Page>().AppInitial_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.INITIAL));

            GetInstance<AppReg_Form_Page>().AppLastName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));

            GetInstance<AppReg_Form_Page>().Address1_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));

            GetInstance<AppReg_Form_Page>().City_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));

            GetInstance<AppReg_Form_Page>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));

            GetInstance<AppReg_Form_Page>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));

            GetInstance<AppReg_Form_Page>().AppGenderSelection_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));

            GetInstance<AppReg_Form_Page>().AppDOB_InputBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));

            GetInstance<AppReg_Form_Page>().EthinicitySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));

            GetInstance<AppReg_Form_Page>().EducationSelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));

            GetInstance<AppReg_Form_Page>().MilitarySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));

            GetInstance<AppReg_Form_Page>().OccupationSelector_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));

            Thread.Sleep(1000);

            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));

            Thread.Sleep(1000);

            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));

            GetInstance<AppReg_Form_Page>().CreditPreviousExp_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CREDITHOURSRSI));

            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();

            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();

            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();

            Thread.Sleep(1000);

            String FalureMsg = GetInstance<AppReg_Review_Page>().RegFalureMsg_txt();

            Thread.Sleep(1000);

            ExtentReportLog(FalureMsg, "Previous credit hours can't be greater than term of occupation.", "Verifing Apprentice Previous Credit Hours", Name);
*/
        }
       

            
        }

    }

