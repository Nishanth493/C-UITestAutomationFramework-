using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Probation_Near_Completion;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_EXTERNAL.SmokeTest
{
    [TestClass]
    public class Smoke_Probation_Nearing_Completion : TestBase
    {
        string Name;

        [TestMethod]
        public void TS001_Prebation_Nearing_Completion()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("128");
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().MinutesDate_Input("05/09/2019");
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().CompletionDate_Input("05/09/2019");
            Selenium.Driver.Click(GetInstance<ActionItems_ProbationNearingCompletion_Page>().MinutesDateInput, "MinutesDateInput");

             //Checking for autofill functionality 
             for (int i = 0; i < 10; i++)
             {
                 ExtentReportLog(
                     Selenium.Driver.GetAttribute(
                         GetInstance<ActionItems_ProbationNearingCompletion_Page>().MinutesDateInput,
                         "value",
                         "MinutesDateInput"),
                     "05/09/2019",
                     "test",
                      Name);

                 ExtentReportLog(
                     Selenium.Driver.GetAttribute(
                         GetInstance<ActionItems_ProbationNearingCompletion_Page>().CompletionDateInput,
                         "value",
                         "CompletionDateInput"),
                     "05/09/2019",
                     "test",
                      Name);
             }

             //Error Message Validation: "Enter Completion Date"
             GetInstance<ActionItems_ProbationNearingCompletion_Page>().Navigation_BackToOverView_Lnk();
             GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
             GetInstance<ActionItems_ProbationNearingCompletion_Page>().MinutesDate_Input("05/09/2019");
             Selenium.Driver.Click(GetInstance<ActionItems_ProbationNearingCompletion_Page>().CompletionDateInput, "CompletionDateInput");
             GetInstance<ActionItems_ProbationNearingCompletion_Page>().Submit_Btn();

             ExtentReportLog(
                 GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ErrorMessage_Txt(2),
                 "Enter Completion date.",
                 "Validating Error message ",
                 Name);

             //Error Message Validation: "Enter Minute date."
             GetInstance<ActionItems_ProbationNearingCompletion_Page>().Navigation_BackToOverView_Lnk();
             GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
             GetInstance<ActionItems_ProbationNearingCompletion_Page>().CompletionDate_Input("05/09/2019");
             Selenium.Driver.Click(GetInstance<ActionItems_ProbationNearingCompletion_Page>().MinutesDateInput, "MinutesDateInput");
             GetInstance<ActionItems_ProbationNearingCompletion_Page>().Submit_Btn();

             ExtentReportLog(
                 GetInstance<ActionItems_ProbationNearingCompletion_Page>().Table_ErrorMessage_Txt(2),
                 "Enter Minute date.",
                 "Validating Error message ",
                 Name);
/*
            //Validating page navigation functionality 
            GetInstance<ActionItems_ProbationNearingCompletion_Page>().Navigation_BackToOverView_Lnk();
            Thread.Sleep(5000);
            GetInstance<DashBoard_Overview_Page>().ActionsItems_ProbationNearingCompletion_ClickLnk();
            Thread.Sleep(3000);

            while (
                Selenium.Driver.GetAttribute(
                    GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageNavigationBtn[
                        ((GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageNavigationBtn).Count) - 2],
                    "disabled",
                    "is button enabled") == "false") 
            {
                int Count = ((GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageNavigationBtn).Count) - 2;
                GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageNavigation_Btn(Count);

                ExtentReportLog(
                    Selenium.Driver.GetAttribute(
                        GetInstance<ActionItems_ProbationNearingCompletion_Page>().PageNavigationBtn[3],
                        "disabled",
                        "PageNavigation_Btn[3]"),
                    "true",
                    "Validating page navigation functionality",
                    Name
                    );
            }  */     
        }
    }
}










