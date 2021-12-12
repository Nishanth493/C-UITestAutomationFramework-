using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository
{
    public class DashBoard_Overview_Page :Base 
    {

        [FindsBy(How = How.LinkText, Using = "Report Hours")]
        public IWebElement MakeUpdate_RSI_OJTReportingLnk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#approachingStepsWidget")]
        public IWebElement MakeUpdate_UpdateAppStepLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Update Status")]
        public IWebElement MakeUpdate_UpdateAppStatusLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Update Status")]
        public IWebElement MakeUpdate_UpdateProgramWagesLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Find an Apprentice")]
        public IWebElement ManageApp_FindAnApprenticeLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Register an Apprentice")]
        public IWebElement ManageApp_RegisterAnApprenticeLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Transfer an Apprentice")]
        public IWebElement ManageApp_TransferAnApprenticeLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Journey Level Recognition")]
        public IWebElement ManageApp_JourneyLevelRegsLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Apprenticeship Preparatory Programs")]
        public IWebElement ManageApp_PreAppPgmsLnk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#approachingStepsWidget")]
        public IWebElement ActionItems_ApproachingStepUpdateLnk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#probationStatusWidget")]
        public IWebElement ActionsItems_ProbationNearingCompletionLnk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#completionStatusWidget")]
        public IWebElement ActionsItems_ReadyForCompletionLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Authorized Signer")]
        public IWebElement LookupLinks_AuthorizedSignerLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Committee Member")]
        public IWebElement LookupLinks_CommitteeMemeberLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Public Lookup")]
        public IWebElement LookupLinks_PublicLookUpLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Committee Meeting Minutes")]
        public IWebElement LookupLinks_CommitteeMeetingMinLnk { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#panel-2")]
        public IWebElement TrainingAgentsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "#panel-3")]
        public IWebElement RequestsTab { get; set; }

        [FindsBy(How = How.XPath, Using = "#panel-4")]
        public IWebElement ReportsTab { get; set; }

        [FindsBy(How = How.LinkText, Using = "Change to another program?")]
        public IWebElement ChangeProgramLnk { get; set; }

        /// <summary>
        /// Clicks on OJT/RSI Reporting Link
        /// </summary>
        /// <param name="n"></param>
        public void MakeUpdate_RSI_OJTReporting_ClickLnk()
        {
            Selenium.Driver.Click(MakeUpdate_RSI_OJTReportingLnk, "MakeUpdate_RSI_OJTReporting_ClickLnk");
        }

        /// <summary>
        /// Clicks on Apprentice Step Update link 
        /// </summary>
        public void MakeUpdate_UpdateAppStep_ClickLnk()
        {
            Selenium.Driver.Click(MakeUpdate_UpdateAppStepLnk, "MakeUpdate_UpdateAppStep_ClickLnk");
        }

        /// <summary>
        /// Clicks on Apprentice Status Update link
        /// </summary>
        public void MakeUpdate_UpdateAppStatus_ClickLnk()
        {
            Selenium.Driver.Click(MakeUpdate_UpdateAppStatusLnk, "MakeUpdate_UpdateAppStatusLnk");
        }

        /// <summary>
        /// Clicks on Update Program Wages Link
        /// </summary>
        public void MakeUpdate_UpdateProgramWages_ClickLnk()
        {
            Thread.Sleep(3000);
            Selenium.Driver.Click(MakeUpdate_UpdateProgramWagesLnk, "ManageApp_FindAnApprenticeLnk");           
        }

        /// <summary>
        /// Clicks on Find An Apprentice Link 
        /// </summary>
        public void ManageApp_FindAnApprentice_ClickLnk()
        {
            Selenium.Driver.Click(ManageApp_FindAnApprenticeLnk, "ManageApp_FindAnApprentice_ClickLnk");
        }

        /// <summary>
        /// Clicks on 'Register an apprentice Link 
        /// </summary>
        public void ManageApp_RegisterAnApprentice_ClickLnk()
        {
            Selenium.Driver.Click(ManageApp_RegisterAnApprenticeLnk, "ManageApp_RegisterAnApprentice_ClickLnk");
        }

        /// <summary>
        /// Clicks on Transfer an Apprentice Link 
        /// </summary>
        public void ManageApp_TransferAnApprentice_ClickLnk()
        {
            Selenium.Driver.Click(ManageApp_TransferAnApprenticeLnk, "ManageApp_TransferAnApprentice_ClickLnk");
        }

        /// <summary>
        /// Clicks on Journey Level Wage Recognition Link 
        /// </summary>
        public void ManageApp_JourneyLevelRegs_ClickLnk()
        {
            Selenium.Driver.Click(ManageApp_JourneyLevelRegsLnk, "ManageApp_JourneyLevelRegs_ClickLnk");
        }

        /// <summary>
        /// Clicks on Pre Apprenticeship Link 
        /// </summary>
        public void ManageApp_PreAppPgms_ClickLnk()
        {
            Selenium.Driver.Click(ManageApp_PreAppPgmsLnk, "ManageApp_PreAppPgms_ClickLnk");
        }

        /// <summary>
        /// Clicks on Approaching Step Update 
        /// </summary>
        public void ActionItems_ApproachingStepUpdate_ClickLnk()
        {
            Selenium.Driver.Click(ActionItems_ApproachingStepUpdateLnk, "ActionItems_ApproachingStepUpdate_ClickLnk");
        }

        /// <summary>
        /// Clicks on Approaching Probation Nearing Completion 
        /// </summary>
        public void ActionsItems_ProbationNearingCompletion_ClickLnk()
        {
            Selenium.Driver.Click(ActionsItems_ProbationNearingCompletionLnk, "ActionsItems_ProbationNearingCompletion_ClickLnk");
        }

        /// <summary>
        /// Clicks on Ready for Completion Link 
        /// </summary>
        public void ActionsItems_ReadyForCompletion_ClickLnk()
        {
            Selenium.Driver.Click(ActionsItems_ReadyForCompletionLnk, "ActionsItems_ReadyForCompletion_ClickLnk");
        }

        /// <summary>
        /// Clicks on Authorized Signer Link
        /// </summary>
        public void LookupLinks_AuthorizedSigner_ClickLnk()
        {
            Selenium.Driver.Click(LookupLinks_AuthorizedSignerLnk, "LookupLinks_AuthorizedSigner_ClickLnk");
        }

        /// <summary>
        /// Clicks on Committee Members Link
        /// </summary>
        public void LookupLinks_CommitteeMemeber_ClickLnk()
        {
            Selenium.Driver.Click(LookupLinks_CommitteeMemeberLnk, "LookupLinks_CommitteeMemeber_ClickLnk");
        }

        /// <summary>
        /// Clicks on Public Lookup Link
        /// </summary>
        public void LookupLinks_PublicLookUp_ClickLnk()
        {
            Selenium.Driver.Click(LookupLinks_PublicLookUpLnk, "LookupLinks_PublicLookUp_ClickLnk");
        }

        /// <summary>
        /// Clicks on Committee Meeting Minutes link
        /// </summary>
        public void LookupLinks_CommitteeMeetingMin_ClickLnk()
        {
            Selenium.Driver.Click(LookupLinks_CommitteeMeetingMinLnk, "LookupLinks_CommitteeMeetingMin_ClickLnk");
        }

        /// <summary>
        /// Clicks on the Training Agents Tab
        /// </summary>
        public void TraingAgent_ClickTab()
        {
            Selenium.Driver.Click(TrainingAgentsTab, "TrainingAgent_Tab");
        }

        /// <summary>
        /// Clicks in Requests Tab
        /// </summary>
        public void Request_ClickTab()
        {
            Selenium.Driver.Click(RequestsTab, "Requests_Tab");
        }

        /// <summary>
        /// Clicks on Reports tab
        /// </summary>
        public void Reports_ClickTab()
        {
            Selenium.Driver.Click(ReportsTab, "Reports_Tab");
        }

        /// <summary>
        /// Clicks on Change Program Link
        /// </summary>
        public void ChangeProgram_Lnk()
        {
            Selenium.Driver.Click(ChangeProgramLnk, "ChangeProgramLnk");
        }
    }
   }

