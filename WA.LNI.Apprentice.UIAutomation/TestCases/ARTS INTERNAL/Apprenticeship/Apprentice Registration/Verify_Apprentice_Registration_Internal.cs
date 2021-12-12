using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Registration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Configuration;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_INTERNAL.Apprenticeship.Apprentice_Registration
{
    [TestClass]
    public class Verify_Apprentice_Registration_Internal :TestBase
    {
        string Name;
        [TestMethod]
        public void TC000_Verify_Apprentice_Registration()
        {
            try
            {
                Thread.Sleep(2000);
                //----------------------------Random Name Generator (5 Length)------------------------------- 
                var chars1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                var chars2 = "YZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWX";
                var num = "00123456789";
                var stringChars1 = new char[5];
                var stringChars2 = new char[5];
                var intNum = new char[9];
                var random = new Random();

                for (int i = 0; i < stringChars1.Length; i++)
                {
                    stringChars1[i] = chars1[random.Next(chars1.Length)];
                }

                for (int i = 0; i < stringChars2.Length; i++)
                {
                    stringChars2[i] = chars2[random.Next(chars2.Length)];
                }

                for (int i = 0; i < intNum.Length; i++)
                {
                    intNum[i] = num[random.Next(num.Length)];
                }

                var firstname = new String(stringChars1);

                var lastname = new String(stringChars2);

                var ssn = new string(intNum);

                //--------------------------------------------------------------------------------------------

                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
                GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppReg_Lnk();
                GetInstance<AppReg_EnterSSN_Page_Internal>().ProgramId_InputNum("2156");
                //GetInstance<AppReg_EnterSSN_Page_Internal>().EnterSSN_InputNum(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN)); 
                GetInstance<AppReg_EnterSSN_Page_Internal>().EnterSSN_InputNum(ssn);
                GetInstance<AppReg_EnterSSN_Page_Internal>().FindApprentice_ClickBtn();
                //GetInstance<AppReg_Form_Page_Internal>().FirstName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));
                GetInstance<AppReg_Form_Page_Internal>().FirstName_InputTxt(firstname);
                //GetInstance<AppReg_Form_Page_Internal>().LastName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));
                GetInstance<AppReg_Form_Page_Internal>().LastName_InputTxt(lastname);
                GetInstance<AppReg_Form_Page_Internal>().AddressLine1_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));
                GetInstance<AppReg_Form_Page_Internal>().City_InputTxt( ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));
                GetInstance<AppReg_Form_Page_Internal>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));
                GetInstance<AppReg_Form_Page_Internal>().State_DrpDwn( ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));
                GetInstance<AppReg_Form_Page_Internal>().Phone_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPLICANTPHONE));
                GetInstance<AppReg_Form_Page_Internal>().Gender_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));
                GetInstance<AppReg_Form_Page_Internal>().MilitaryStatus_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));
                GetInstance<AppReg_Form_Page_Internal>().Race_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));
                GetInstance<AppReg_Form_Page_Internal>().EducationLevel_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));
                GetInstance<AppReg_Form_Page_Internal>().Occupation_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));
                GetInstance<AppReg_Form_Page_Internal>().Step_DrpDwn("1");
                GetInstance<AppReg_Form_Page_Internal>().DirectEntry_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));
                GetInstance<AppReg_Form_Page_Internal>().DOB_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));
                GetInstance<AppReg_Form_Page_Internal>().BeginDate_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));
                GetInstance<AppReg_Form_Page_Internal>().Register_Btn();
                int AppID = GetInstance<AppReg_Form_Page_Internal>().AppRegID_NumTxt();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppSearch_Lnk();
                GetInstance<SearchApprentice_Page_Internal>().ApprenticeID_InputTxt(AppID.ToString());
                GetInstance<SearchApprentice_Page_Internal>().Search_Btn();
                ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ApprenticID_TableTxt(0),
                    AppID.ToString(), "Verify App ID", Name);
                ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().FirstName_TableTxt(0),
                    ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME), "Verify First Name", Name);
                 // ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ProgramName_TableTxt(0),
                 // ProgramName, "Verify Program Name", Name);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Build Falure: " + e);
                throw (e);
            }
        }


        [TestMethod]
        public void TC001_Verify_Apprentice_Registration()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
                GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppReg_Lnk();
                GetInstance<AppReg_EnterSSN_Page_Internal>().ProgramId_InputNum("152");
                GetInstance<AppReg_EnterSSN_Page_Internal>().EnterSSN_InputNum(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));
                GetInstance<AppReg_EnterSSN_Page_Internal>().FindApprentice_ClickBtn();
                GetInstance<AppReg_Form_Page_Internal>().FirstName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));
                GetInstance<AppReg_Form_Page_Internal>().LastName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));
                GetInstance<AppReg_Form_Page_Internal>().AddressLine1_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));
                GetInstance<AppReg_Form_Page_Internal>().City_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));
                GetInstance<AppReg_Form_Page_Internal>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));
                GetInstance<AppReg_Form_Page_Internal>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));
                GetInstance<AppReg_Form_Page_Internal>().Phone_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPLICANTPHONE));
                GetInstance<AppReg_Form_Page_Internal>().Gender_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));
                GetInstance<AppReg_Form_Page_Internal>().MilitaryStatus_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));
                GetInstance<AppReg_Form_Page_Internal>().Race_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));
                GetInstance<AppReg_Form_Page_Internal>().EducationLevel_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));
                GetInstance<AppReg_Form_Page_Internal>().Occupation_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));
                GetInstance<AppReg_Form_Page_Internal>().Step_DrpDwn("1");
                GetInstance<AppReg_Form_Page_Internal>().DirectEntry_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));
                GetInstance<AppReg_Form_Page_Internal>().DOB_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));
                GetInstance<AppReg_Form_Page_Internal>().BeginDate_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));
                GetInstance<AppReg_Form_Page_Internal>().Register_Btn();
                int AppID = GetInstance<AppReg_Form_Page_Internal>().AppRegID_NumTxt();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppSearch_Lnk();
                GetInstance<SearchApprentice_Page_Internal>().ApprenticeID_InputTxt(AppID.ToString());
                GetInstance<SearchApprentice_Page_Internal>().Search_Btn();
                ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ApprenticID_TableTxt(0),
                    AppID.ToString(), "Verify App ID", Name);
                ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().FirstName_TableTxt(0),
                    ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME), "Verify First Name", Name);
                // ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ProgramName_TableTxt(0),
                // ProgramName, "Verify Program Name", Name);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Build Falure: " + e);
                throw (e);
            }
        }


        [TestMethod]
        public void TC002_Verify_Apprentice_Registration()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
                GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppReg_Lnk();
                GetInstance<AppReg_EnterSSN_Page_Internal>().ProgramId_InputNum("152");
                GetInstance<AppReg_EnterSSN_Page_Internal>().EnterSSN_InputNum(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));
                GetInstance<AppReg_EnterSSN_Page_Internal>().FindApprentice_ClickBtn();
                GetInstance<AppReg_Form_Page_Internal>().FirstName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));
                GetInstance<AppReg_Form_Page_Internal>().LastName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));
                GetInstance<AppReg_Form_Page_Internal>().AddressLine1_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));
                GetInstance<AppReg_Form_Page_Internal>().City_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));
                GetInstance<AppReg_Form_Page_Internal>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));
                GetInstance<AppReg_Form_Page_Internal>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));
                GetInstance<AppReg_Form_Page_Internal>().Phone_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPLICANTPHONE));
                GetInstance<AppReg_Form_Page_Internal>().Gender_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));
                GetInstance<AppReg_Form_Page_Internal>().MilitaryStatus_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));
                GetInstance<AppReg_Form_Page_Internal>().Race_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));
                GetInstance<AppReg_Form_Page_Internal>().EducationLevel_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));
                GetInstance<AppReg_Form_Page_Internal>().Occupation_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));
                GetInstance<AppReg_Form_Page_Internal>().Step_DrpDwn("1");
                GetInstance<AppReg_Form_Page_Internal>().DirectEntry_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));
                GetInstance<AppReg_Form_Page_Internal>().DOB_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));
                GetInstance<AppReg_Form_Page_Internal>().BeginDate_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));
                GetInstance<AppReg_Form_Page_Internal>().Register_Btn();
                int AppID = GetInstance<AppReg_Form_Page_Internal>().AppRegID_NumTxt();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppSearch_Lnk();
                GetInstance<SearchApprentice_Page_Internal>().ApprenticeID_InputTxt(AppID.ToString());
                GetInstance<SearchApprentice_Page_Internal>().Search_Btn();
                ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ApprenticID_TableTxt(0),
                    AppID.ToString(), "Verify App ID", Name);
                ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().FirstName_TableTxt(0),
                    ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME), "Verify First Name", Name);
                // ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ProgramName_TableTxt(0),
                // ProgramName, "Verify Program Name", Name);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Build Falure: " + e);
                throw (e);
            }
        }


        [TestMethod]
        public void TC003_Verify_Apprentice_Registration()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
                GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppReg_Lnk();
                GetInstance<AppReg_EnterSSN_Page_Internal>().ProgramId_InputNum("152");
                GetInstance<AppReg_EnterSSN_Page_Internal>().EnterSSN_InputNum(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));
                GetInstance<AppReg_EnterSSN_Page_Internal>().FindApprentice_ClickBtn();
                GetInstance<AppReg_Form_Page_Internal>().FirstName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));
                GetInstance<AppReg_Form_Page_Internal>().LastName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));
                GetInstance<AppReg_Form_Page_Internal>().AddressLine1_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));
                GetInstance<AppReg_Form_Page_Internal>().City_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));
                GetInstance<AppReg_Form_Page_Internal>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));
                GetInstance<AppReg_Form_Page_Internal>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));
                GetInstance<AppReg_Form_Page_Internal>().Phone_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPLICANTPHONE));
                GetInstance<AppReg_Form_Page_Internal>().Gender_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));
                GetInstance<AppReg_Form_Page_Internal>().MilitaryStatus_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));
                GetInstance<AppReg_Form_Page_Internal>().Race_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));
                GetInstance<AppReg_Form_Page_Internal>().EducationLevel_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));
                GetInstance<AppReg_Form_Page_Internal>().Occupation_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));
                GetInstance<AppReg_Form_Page_Internal>().Step_DrpDwn("1");
                GetInstance<AppReg_Form_Page_Internal>().DirectEntry_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));
                GetInstance<AppReg_Form_Page_Internal>().DOB_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));
                GetInstance<AppReg_Form_Page_Internal>().BeginDate_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));
                GetInstance<AppReg_Form_Page_Internal>().Register_Btn();
                int AppID = GetInstance<AppReg_Form_Page_Internal>().AppRegID_NumTxt();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppSearch_Lnk();
                GetInstance<SearchApprentice_Page_Internal>().ApprenticeID_InputTxt(AppID.ToString());
                GetInstance<SearchApprentice_Page_Internal>().Search_Btn();
                ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ApprenticID_TableTxt(0),
                    AppID.ToString(), "Verify App ID", Name);
                ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().FirstName_TableTxt(0),
                    ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME), "Verify First Name", Name);
                // ExtentReportLog(GetInstance<SearchApprentice_Page_Internal>().ProgramName_TableTxt(0),
                // ProgramName, "Verify Program Name", Name);
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
