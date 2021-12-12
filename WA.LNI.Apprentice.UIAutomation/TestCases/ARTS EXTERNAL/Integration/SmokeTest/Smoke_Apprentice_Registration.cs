using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration;
using OpenQA.Selenium;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.Integration.SmokeTest
{
    [TestClass]
    public class Smoke_Apprentice_Registration : TestBase
    {
        string Name;

        //Verifying Social Security Number input 
        [TestMethod]
        public void TS000_Apprentice_Registration()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

                GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
                ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
                GetInstance<LandingPage>().Tasks("128");
                GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();
                GetInstance<AppReg_EnterSSN_Page>().EnterSSN("25254785");
                ExtentReportLog(GetInstance<AppReg_EnterSSN_Page>().ErrorMsg_Gettxt(), "Social Security Number must be 9 digits."
                    ,"Verifying error message for length of ssn \n", Name);
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
        public void TS001_Apprentice_Registration()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

                GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
                ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
                GetInstance<LandingPage>().Tasks("128");
                GetInstance<DashBoard_Overview_Page>().QuickLnks_RegisterAnApprenticeLnk_ClickLnk();
                GetInstance<AppReg_EnterSSN_Page>().EnterSSN("125252489");
                GetInstance<AppReg_EnterSSN_Page>().ClickVerify();
                GetInstance<AppReg_Form_Page>().RegisterApp_Btn();
                //GetInstance<AppReg_Form_Page>().AppFormErrorMsgList_Lnk(0);           
                string[] Element_Ids = { "firstName", "lastName", "primaryAddress_address1", "primaryAddress_city",
                                         "primaryAddress_zipCode", "apprenticeGenderForRegistration", "birthDate", "raceOrEthnicity",
                                         "ethnicGroup", "highestEducationLevel", "militaryStatus", "apprenticeshipOccupation",
                                         "applicantQualifiedForDirectEntry", "confirmAgreement"};
                for (int i = 0; i < Element_Ids.Length; i++)
                {
                    GetInstance<AppReg_Form_Page>().AppFormErrorMsgList_Lnk(i);
                    IWebElement activeElement = Selenium.ObjDriver.SwitchTo().ActiveElement();
                    String id = activeElement.GetAttribute("id");
                    if(id == "") { continue; }
                    else { ExtentReportLog(id, Element_Ids[i], "Verifing Error Links", Name); }                   
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
