using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.Regression.RegisterAnApprentice
{
    [TestClass]
    public class Verify_SSN : TestBase
    {
        string Name;
        /// <summary>
        ///  Test Case: Verify SSN# Input, enter valid 9 digit SSN# number (Positive TC)
        /// </summary>

        [TestMethod]
        public void TC67318_Verify_SSN_Input()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN("125856906");
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();
            bool visible = Selenium.Driver.IsVisible(GetInstance<AppReg_Form_Page>().FirstNameInputBox, "FirstNameInputBox");
            ExtentReportLog(true, visible, "Apprentice Registration form is displayed", Name);

        }

        /// <summary>
        /// Verify SSN# input, more than 9 digits (Negative TC)
        /// </summary>
        [TestMethod]
        public void TC67319_Verify_SSN_Input()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium. Log = Selenium.Extent.StartTest(Name);
            Selenium. Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN("22258575910");
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();
            string inputCount = Selenium.Driver.GetAttribute(GetInstance<AppReg_EnterSSN_Page>().SSNInputBox, "value", "SSNInputBox");
            int count = inputCount.Length;

            ExtentReportLog(count, 11, "number of digits allowing", Name);


        }

        /// <summary>
        /// Verify SSN# input, input characters instead of numbers (Negetive TC)
        /// </summary>
        [TestMethod]
        public void TC67320_Verify_SSN_Input()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium. Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN("dfgdfgsfdgs");
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();
            string inputCount = Selenium.Driver.GetAttribute(GetInstance<AppReg_EnterSSN_Page>().SSNInputBox, "value", "SSNInputBox");
            int count = inputCount.Length;
            ExtentReportLog(count, 0, "Not allowing characters", Name);
        }

        /// <summary>
        /// Enter SSN number of an already registered apprentice  (Negative TC)
        /// </summary>
        [TestMethod]
        public void TC67371_Verify_SSN_Input()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN("535335944");
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();

            //ALERT :: Error message is only being displayed in an automation test and unable to loacte the element

            ExtentReportLog(GetInstance<AppReg_EnterSSN_Page>().ErrorMsg_Gettxt(), "An apprentice with this Social Security Number is already registered. Please check the number and re-enter.", "Verifying SSN", Name);

        }

        /// <summary>
        /// Enter SSN number of an already registered apprentice belonging to another program (Negative TC)
        /// </summary>
        [TestMethod]
        public void TC67372_Verify_SSN_Input()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();
            GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();
            GetInstance<AppReg_EnterSSN_Page>().EnterSSN("296645696");
            GetInstance<AppReg_EnterSSN_Page>().ClickVerify();
            //ALERT :: Error message is only being displayed in an automation test and unable to loacte the element

            ExtentReportLog(GetInstance<AppReg_EnterSSN_Page>().ErrorMsg_Gettxt(), "An apprentice with this Social Security Number is already registered. Please check the number and re-enter.", "Verifying SSN", Name);

        }

    }
}
