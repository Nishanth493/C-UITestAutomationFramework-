/*
 * Change Program Link:  Change to another program?     - link list 
 * 
 * Tabs Home: //a[contains(text(),'Home')]
 * Tabs TA: //a[contains(text(),'Training Agents')]
 * Tabs Requests: //a[contains(text(),'Training Agents')]
 * Tabs Reports: //a[contains(text(),'Reports')]
 * 
 * Dashboard Action Items: //h3[contains(text(),'Quick Links')]//following::ul[1]/li/a
 * Dashboard Quick Links: //h3[contains(text(),'Quick Links')]//following::ul[1]/li/a
 * Dashboard Committee Meeting: //h3[contains(text(),'Committee Meeting Minutes')]//following::ul[1]/li/a
 * Dashboard Lookup Links: //h3[contains(text(),'Lookup Links')]//following::ul[1]//li/a
 * 
*/
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository
{
    public class QuickStepUpdate_Dialog : Base 
    {
        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Step Update')]")]
        public IWebElement TitleTxt { get; set; }

        [FindsBy(How = How.Id, Using = "apprenticeNameToUpdate")]
        public IWebElement ApprenticeNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='effectiveDateToStepUpdate-wrapper']//label[@class='lni-c-form-control__label'][contains(text(),'Effective Date:')]//following::div[1]/input")]
        public IWebElement EffectiveDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='meetingDateToStepUpdate-wrapper']//label[@class='lni-c-form-control__label'][contains(text(),'Committee Meeting Date:')]//following::div[1]/input")]
        public IWebElement CommitteeMeetingDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "stepNumberToUpdate")]
        public IWebElement CurrentStepNumberTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Step Number')]//following::input[1]")]
        public IWebElement NewStepNumberInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='lni-c-element-container lni-u-mt4 lni-u-mb3']//div//a[@class='lni-u-ml3 lni-cursor-pointer'][contains(text(),'Cancel')]")]
        public IWebElement Cancellnk { get; set; }

        [FindsBy(How = How.XPath, Using = "submitToStepUpdate")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//body[@data-gr-c-s-loaded='true']/div[3]/div[1]/button[1]")]
        public IWebElement CloseBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#stepUpdateErrorMessage")]
        public IWebElement ErrorTxt { get; set; }
        
        /// <summary>
        /// Get the title text of the daialog window
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void Heading_GetTxt ()
        {
            Selenium.Driver.GetText(TitleTxt, "TitleTxt");
        }

        /// <summary>
        /// Gets the Apprentice name text 
        /// </summary>
        /// <param name="stepNumber"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void ApprenticeName_GetTxt()
        {
            Selenium.Driver.GetText(ApprenticeNameTxt, "ApprenticeNameTxt");
        }

        /// <summary>
        /// Inputs the effective date 
        /// </summary>
        /// <param name="occupationName"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void EffectiveDate_Input(string effectiveDate)
        {

            Selenium.Driver.SendKeys(EffectiveDateInput, effectiveDate, "EffectiveDateInput");
        }

        /// <summary>
        /// Inputs the committe meeting minutes date 
        /// </summary>
        /// <param name="occupationName"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void committeeMeetingDate_Input(string meetingDate)
        {

            Selenium.Driver.SelectDropDownByValue(CommitteeMeetingDateInput, meetingDate, "CommitteeMeetingDateInput");
        }

        /// <summary>
        /// Gets the apprentice current step number text
        /// </summary>
        /// <param name="statusName"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void CurrentStep_GetTxt()
        {

            Selenium.Driver.GetText(CurrentStepNumberTxt, "CurrentStepNumberTxt");
        }

        /// <summary>
        /// Inputs new step number 
        /// </summary>
        /// <param name=""></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void NewStepNumber_Input(string newStep)
        {

            Selenium.Driver.SendKeys(NewStepNumberInput, newStep, "NewStepNumberInput");
        }

        /// <summary>
        /// Clicks o cancel link
        /// </summary>
        /// <param name=""></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void Cancle_ClickLnk()
        {

            Selenium.Driver.Click(Cancellnk, "Cancellnk");
        }

        /// <summary>
        /// Clicks Submit Button
        /// </summary>
        public void Submit_ClickBtn()
        {
            Selenium.Driver.Click(SubmitBtn, "SubmitBtn");
        }

        /// <summary>
        /// Click on close button
        /// </summary>
        public void Close_ClickBtn()
        {
            Selenium.Driver.Click(CloseBtn, "CloseBtn");
        }

        /// <summary>
        /// Gets the error meesage text
        /// </summary>
        /// <returns></returns>
        public string ErrorMsg_GetTxt()
        {
           return Selenium.Driver.GetText(ErrorTxt, "ErrorTxt");
        }

    }

   }

