using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Approaching_Step_Updates;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.SmokeTest
{
    [TestClass]
    public class Smoke_Ready_For_Step_Update :TestBase
    {
        string Name;
        [TestMethod]
        public void TS001_Ready_To_Step_Update()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            Thread.Sleep(3000);

            GetInstance<DashBoard_Overview_Page>().ActionItems_ApproachingStepUpdates_ClickLnk();
            Thread.Sleep(3000);

            string Input_Date = DateTime.Now.ToString("MM/dd/yyyy");

            //Verifying Autofill All Date functionality 
            Selenium.Driver.SendKeys(
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().EffectiveDateInput, Input_Date, "Input_Date");
            Selenium.Driver.SendKeys(
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().MinutesDateInput, Input_Date, "Input_Date");
            Selenium.Driver.Click(
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().EffectiveDateInput, "EffectiveDateInput");

            int Table_Count = (GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_MinutesDateInput).Count;

            for (int i = 0; i < Table_Count; i++)
            {
                ExtentReportLog(
                    Selenium.Driver.GetAttribute(GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_EffectiveDateInput[i], 
                        "value", 
                        "Table_EffectiveDateInput["+i+"]"),
                    Input_Date,
                    "Verifying Input",
                    Name);

                ExtentReportLog(
                    Selenium.Driver.GetAttribute(
                        GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_MinutesDateInput[i], 
                        "value", 
                        "Table_MinutesDateInput["+i+"]"),
                    Input_Date,
                    "Verifying Input",
                    Name);
            }

            Thread.Sleep(3000);
            Selenium.Driver.Click(
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Navigation_BackToProgramOverview, "Navigation_BackToProgramOverview");

            Thread.Sleep(3000);
            GetInstance<DashBoard_Overview_Page>().ActionItems_ApproachingStepUpdates_ClickLnk();
            Thread.Sleep(3000);

            //Verifying each date input functionality
            for (int i = 0; i < Table_Count; i++)
            {
                Selenium.Driver.SendKeys(
                    GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_EffectiveDateInput[i], 
                    "04/23/2019", 
                    "Table_EffectiveDateInput[" + i + "]");
  
                Selenium.Driver.SendKeys(
                    GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_MinutesDateInput[i], 
                    "04/20/2019", 
                    "Table_MinutesDateInput[" + i + "]");
            }

            for (int i = 0; i < Table_Count; i++)
            {  
                ExtentReportLog(
                    Selenium.Driver.GetAttribute(
                        GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_EffectiveDateInput[i], 
                        "value", 
                        "Table_EffectiveDateInput[" + i + "]"),
                    "04/23/2019",
                    "Verifying input",
                    Name);

                ExtentReportLog(
                    Selenium.Driver.GetAttribute(
                        GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_MinutesDateInput[i], 
                        "value", 
                        "Table_MinutesDateInput[" + i + "]"),
                    "04/20/2019",
                    "Verifying input",
                    Name);
            }
           
            /*
            //Verifying functionality step inputbox 
            NameValueCollection AppID_NewStep = new NameValueCollection();
            List<string> New_Step = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_Single_Increment_NewStep_Input(i);
                New_Step.Add(GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_ApprenticeID_Txt(i));
            }

            for (int i = 0; i < 10; i++)
            {
                AppID_NewStep.Add(
                    Selenium.Driver.GetAttribute(
                        GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_NewStepInput[i], "value", "Table_NewStepInput[" + i + "]"),
                    GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_ApprenticeID_Txt(i));
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(AppID_NewStep[GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_ApprenticeID_Txt(i)]);
            }
            for (int i = 0; i < 10; i++)
            {
                ExtentReportLog(
                    AppID_NewStep[GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_ApprenticeID_Txt(i)],
                    Selenium.Driver.GetAttribute(
                        GetInstance<ActionItems_ApprenticeReadyFor_Step_Updates_Page>().Table_NewStepInput[i], "value", "Table_NewStepInput[" + i + "]"),
                    "downt",
                    Name
                    );
            }
            */
        }
    }
}
