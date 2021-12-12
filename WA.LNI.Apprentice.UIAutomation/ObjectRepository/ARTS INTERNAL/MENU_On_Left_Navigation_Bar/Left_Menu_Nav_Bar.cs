using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar
{

    public class Left_Menu_Nav_Bar : Base
    {
        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-user']")]
        public IWebElement Main_ApprenticeBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Apprentice Registration')]")]
        public IWebElement Apprentice_AppRegLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Apprentice Search')]")]
        public IWebElement Apprentice_AppSearchLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Transfer')]")]
        public IWebElement Apprentice_TransferLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Report Hours']")]
        public IWebElement Apprentice_ReportHoursLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Batch Report Hours')]")]
        public IWebElement Apprentice_BatchReportHoursLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Delete Reported Hours')]")]
        public IWebElement Apprentice_DeleteReportedHoursLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Step Update')]")]
        public IWebElement Apprentice_StepUpdateLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Apprentice Info - Affidavit')]")]
        public IWebElement Apprentice_ApprInfoAffidavitLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'EEOC')]")]
        public IWebElement Apprentice_EEOCLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Upload EEOC')]")]
        public IWebElement Apprentice_UploadEEOCLnk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body.main-body:nth-child(2) div.layout-wrapper.layout-wrapper-menu-active div.layout-sidebar div.layout-tabmenu ul.layout-tabmenu-nav li.active-item:nth-child(2) > a.tabmenuitem-link")]
        public IWebElement Main_Queue { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ng-tns-c2-1']")]
        public IWebElement Apprentice_ACQueueLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[contains(@class,'fa fa-book')]")]
        public IWebElement Main_ProgramTabBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Create New Program')]")]
        public IWebElement Program_CreateProgramLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Journey Wage Update')]")]
        public IWebElement Program_JourneyWageUpdateLnk { get; set; }

        public void Main_Apprentice_Tab()
        {
            Selenium.Driver.Click(Main_ApprenticeBtn, "Main_ApprenticeBtn");
            Thread.Sleep(2000);
        }

        public void Apprentice_AppReg_Lnk()
        {
            Selenium.Driver.Click(Apprentice_AppRegLnk, "Apprentice_AppRegLnk");
        }

        public void Apprentice_AppSearch_Lnk()
        {
            Thread.Sleep(1000);
            Selenium.Driver.Click(Apprentice_AppSearchLnk, "Apprentice_AppSearchLnk");
        }

        public void Apprentice_Transfer_Lnk()
        {
            Selenium.Driver.Click(Apprentice_TransferLnk, "Apprentice_TransferLnk");
        }

        public void Apprentice_ReportHour_Lnk()
        {
            Selenium.Driver.Click(Apprentice_ReportHoursLnk, "Apprentice_ReportHoursLnk");
            Thread.Sleep(2000);
        }


        public void Apprentice_BatchReportHours_Lnk()
        {
            Selenium.Driver.Click(Apprentice_BatchReportHoursLnk, "Apprentice_BatchReportHoursLnk");
        }

        public void Apprentice_DeleteReportedHours_Lnk()
        {
            Selenium.Driver.Click(Apprentice_DeleteReportedHoursLnk, "Apprentice_DeleteReportedHoursLnk");
        }

        public void Apprentice_StepUpdate_Lnk()
        {
            Selenium.Driver.Click(Apprentice_StepUpdateLnk, "Apprentice_StepUpdateLnk");
            Thread.Sleep(5000);
        }

        public void Apprentice_ApprInfoAffidavit_Lnk()
        {
            Selenium.Driver.Click(Apprentice_ApprInfoAffidavitLnk, "Apprentice_ApprInfoAffidavitLnk");
            Thread.Sleep(3000);
        }

        public void Apprentice_EEOC_Lnk()
        {
            Selenium.Driver.Click(Apprentice_EEOCLnk, "Apprentice_EEOCLnk");
        }

        public void Apprentice_UploadEEOC_Lnk()
        {
            Selenium.Driver.Click(Apprentice_UploadEEOCLnk, "Apprentice_UploadEEOCLnk");
        }

        public void Main_Queue_Tab()
        {
            Selenium.Driver.Click(Main_Queue, "Main_Queue");
        }

        public void Apprentice_ACQueue_Lnk()
        {
            Selenium.Driver.Click(Apprentice_ACQueueLnk, "Apprentice_ACQueueLnk");
        }

        public void Main_ProgramTab_Btn()
        {
            Selenium.Driver.Click(Main_ProgramTabBtn, "Main_ProgramTabBtn");
            Thread.Sleep(1000);
        }

        public void Program_CreateProgram_Lnk()
        {
            Selenium.Driver.Click(Program_CreateProgramLnk, "Program_CreateProgramLnk");
        }

        public void Program_JourneyWageUpdate_Lnk()
        {
            Selenium.Driver.Click(Program_JourneyWageUpdateLnk, "Program_JourneyWageUpdateLnk");
        }

    }
}
