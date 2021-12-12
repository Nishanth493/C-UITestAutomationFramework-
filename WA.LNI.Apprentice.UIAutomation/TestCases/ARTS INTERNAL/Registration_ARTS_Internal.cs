using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System.Configuration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Registration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;


namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_INTERNAL
{/*
    [TestClass]
    public class Registration_ARTS_Internal : TestBase 
    {
        string Name;
        [TestMethod]
        public void TC000_Internal_Verify_Login()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
            GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
            GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppReg_Lnk();
            GetInstance<AppReg_EnterSSN_Page_Internal>().ProgramId_InputNum("128");
            Thread.Sleep(3000);
            GetInstance<AppReg_EnterSSN_Page_Internal>().EnterSSN_InputNum(
                ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));
            GetInstance<AppReg_EnterSSN_Page_Internal>().FindApprentice_ClickBtn();
            GetInstance<AppReg_Form_Page_Internal>().FirstName_InputTxt(
                ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));
            GetInstance<AppReg_Form_Page_Internal>().LastName_InputTxt(
                ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));
            GetInstance<AppReg_Form_Page_Internal>().AddressLine1_InputTxt(
                ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));
            GetInstance<AppReg_Form_Page_Internal>().City_InputTxt(
                ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));
            GetInstance<AppReg_Form_Page_Internal>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));
            GetInstance<AppReg_Form_Page_Internal>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));
            GetInstance<AppReg_Form_Page_Internal>().Phone_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPLICANTPHONE));
            GetInstance<AppReg_Form_Page_Internal>().Gender_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));
            GetInstance<AppReg_Form_Page_Internal>().MilitaryStatus_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));
            GetInstance<AppReg_Form_Page_Internal>().EthinicGroup_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ETHNICGROUP));
            GetInstance<AppReg_Form_Page_Internal>().Race_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));
            GetInstance<AppReg_Form_Page_Internal>().EducationLevel_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));
            GetInstance<AppReg_Form_Page_Internal>().Occupation_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));
            GetInstance<AppReg_Form_Page_Internal>().CreditPRevOJTExp_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CREDITHOURSOJT));
            GetInstance<AppReg_Form_Page_Internal>().CreditPRevRSIExp_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CREDITHOURSRSI));
            Thread.Sleep(3000);
            //Base.GetInstance<AppReg_Form_Page_Internal>().SubProgramName_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SUBPROGRAM));
            GetInstance<AppReg_Form_Page_Internal>().DirectEntry_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));
            GetInstance<AppReg_Form_Page_Internal>().DOB_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));
            GetInstance<AppReg_Form_Page_Internal>().Step_DrpDwn("2");
            Thread.Sleep(3000);
            GetInstance<AppReg_Form_Page_Internal>().BeginDate_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));
            GetInstance<AppReg_Form_Page_Internal>().Register_Btn();
            Thread.Sleep(5000);
        }
    }*/
}
