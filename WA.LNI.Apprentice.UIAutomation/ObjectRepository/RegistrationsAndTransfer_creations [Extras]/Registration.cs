using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration;
using System.Threading;
using System.Configuration;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.RegistrationsAndTransfer_creations
{
    [TestClass]
    public class Registration : TestBase
    {
        string Name;

        [TestMethod]
        public void Reg_001()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks(ExcelReader.GetTestData_Integration(Name, DataConstants.PROGRAMID));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();          
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();          
            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));            
            GetInstance<AppReg_Form_Page>().AppLastName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));           
            GetInstance<AppReg_Form_Page>().Address1_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));          
            GetInstance<AppReg_Form_Page>().City_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));        
            GetInstance<AppReg_Form_Page>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));         
            GetInstance<AppReg_Form_Page>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));            
            GetInstance<AppReg_Form_Page>().AppGenderSelection_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.GENDER));          
            GetInstance<AppReg_Form_Page>().AppDOB_InputBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DOB));         
            GetInstance<AppReg_Form_Page>().EthinicitySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.RACEETHNICITY));     
            GetInstance<AppReg_Form_Page>().EthinicGroupSelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ETHNICGROUP));        
            GetInstance<AppReg_Form_Page>().EducationSelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.EDUCATION));             
            GetInstance<AppReg_Form_Page>().MilitarySelector_chkBox(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.MILITARY));            
            GetInstance<AppReg_Form_Page>().OccupationSelector_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPRENTICEOCCUPATION));             
            //Base.GetInstance<AppReg_Form_Page>().SubProgram_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SUBPROGRAM));
            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));             
            GetInstance<AppReg_Form_Page>().CommentBoxAppReg_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.COMMENT));             
            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));                         
            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();           
            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();            
            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();
            Thread.Sleep(2000);
            //String RegId = Base.GetInstance<AppReg_Confirmation>().AppRegID_NumTxt();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void Reg_002()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks(ExcelReader.GetTestData_Integration(Name, DataConstants.PROGRAMID));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();           
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));            
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();            
            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));           
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
            //Base.GetInstance<AppReg_Form_Page>().SubProgram_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SUBPROGRAM));
            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));          
            GetInstance<AppReg_Form_Page>().CommentBoxAppReg_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.COMMENT));           
            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));            
            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();            
            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();           
            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();
            //String RegId = Base.GetInstance<AppReg_Confirmation>().AppRegID_NumTxt();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void Reg_003()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks(ExcelReader.GetTestData_Integration(Name, DataConstants.PROGRAMID));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();           
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));          
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();          
            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));         
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
            //Base.GetInstance<AppReg_Form_Page>().SubProgram_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SUBPROGRAM));
            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));         
            GetInstance<AppReg_Form_Page>().CommentBoxAppReg_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.COMMENT));          
            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));    
            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();            
            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();             
            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();
            //String RegId = Base.GetInstance<AppReg_Confirmation>().AppRegID_NumTxt();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void Reg_004()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks(ExcelReader.GetTestData_Integration(Name, DataConstants.PROGRAMID));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();
            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));
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
            //Base.GetInstance<AppReg_Form_Page>().SubProgram_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SUBPROGRAM));
            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));             
            GetInstance<AppReg_Form_Page>().CommentBoxAppReg_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.COMMENT));            
            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));            
            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();            
            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();             
            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();
            //String RegId = Base.GetInstance<AppReg_Confirmation>().AppRegID_NumTxt();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void Reg_005()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks(ExcelReader.GetTestData_Integration(Name, DataConstants.PROGRAMID));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();           
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));            
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();            
            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));           
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
            //Base.GetInstance<AppReg_Form_Page>().SubProgram_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SUBPROGRAM));
            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));            
            GetInstance<AppReg_Form_Page>().CommentBoxAppReg_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.COMMENT));            
            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));            
            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();
            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();            
            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();
            //String RegId = Base.GetInstance<AppReg_Confirmation>().AppRegID_NumTxt();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void Reg_006()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks(ExcelReader.GetTestData_Integration(Name, DataConstants.PROGRAMID));
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();            
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();            
            GetInstance<AppReg_Form_Page>().AppFirstName_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));             
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
            //Base.GetInstance<AppReg_Form_Page>().SubProgram_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SUBPROGRAM));
            GetInstance<AppReg_Form_Page>().DirectEntery_RdoBtn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.DIRECTENTERY));            
            GetInstance<AppReg_Form_Page>().CommentBoxAppReg_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.COMMENT));            
            GetInstance<AppReg_Form_Page>().BeginDate_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.BEGINDATE));             
            GetInstance<AppReg_Form_Page>().ConfirmAgreement_ChkBox();             
            GetInstance<AppReg_Form_Page>().RegisterApp_Btn();
            GetInstance<AppReg_Review_Page>().RegisterApprenticeReviewSubmit_Btn();
            //String RegId = Base.GetInstance<AppReg_Confirmation>().AppRegID_NumTxt();
            Thread.Sleep(2000);
        }
    }
}
