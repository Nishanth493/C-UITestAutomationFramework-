using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Queue.AC_QUEUES
{
    public class AC_Queues_ApprenticeRegistration_Page_Internal : Base 
    {
        [FindsBy(How = How.XPath, Using = "//h1[@class = 'ui-g-12 text-center ']")]
        public IWebElement HeadingTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Reason:')]//following::label[1]")]
        public IWebElement ReasonTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Request Date:')]//following::label[1]")]
        public IWebElement RequestDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Name:')]//following::label[1]")]
        public IWebElement NameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Birth Date:')]//following::label[1]")]
        public IWebElement BirthDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Race:')]//following::label[1]")]
        public IWebElement RaceTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Address')]//following::label[1]")]
        public IWebElement AddressTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Email:')]//following::label[1]")]
        public IWebElement EmailTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Education:')]//following::label[1]")]
        public IWebElement EducationTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Program Name:')]//following::label[1]")]
        public IWebElement ProgramNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Employer Name:')]//following::label[1]")]
        public IWebElement EmployerNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Credit Prev Experience:')]//following::label[1]")]
        public IWebElement CreditPrevExperienceTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Step:')]//following::label[1]")]
        public IWebElement StepTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Program Comments:')]//following::label[1]")]
        public IWebElement ProgramCommentsTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Begin Date:')]//following::label[1]")]
        public IWebElement BeginDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'SSN:')]//following::label[1]")]
        public IWebElement SSNTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Gender:')]//following::label[1]")]
        public IWebElement GenderTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ethnic Group:')]//following::label[1]")]
        public IWebElement EthnicGroupTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Phone:')]//following::label[1]")]
        public IWebElement PhoneTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Military Status:')]//following::label[1]")]
        public IWebElement MilitaryStatusTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Occupation:')]//following::label[1]")]
        public IWebElement OccupationTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Credit Prev RSI Experience:')]//following::label[1]")]
        public IWebElement CreditPrevRSIExpTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Occupation:')]//following::label[1]")]
        public IWebElement DirectEnteryTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Comment:')]//following::textarea")]
        public IWebElement CommentInput { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement CancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Deny')]")]
        public IWebElement DenyBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Approve')]")]
        public IWebElement ApproveBtn { get; set; }

        public string Heading_Txt()
        {
            return Selenium.Driver.GetText(HeadingTxt, "HeadingTxt");
        }

        public string Reason_Txt()
        {
            return Selenium.Driver.GetText(ReasonTxt, "ReasonTxt");
        }

        public string RequestedDate_Txt()
        {
            return Selenium.Driver.GetText(RequestDateTxt, "RequestDateTxt");
        }

        public string Name_Txt()
        {
            return Selenium.Driver.GetText(NameTxt, "NameTxt");
        }

        public string BirthDate_Txt()
        {
            return Selenium.Driver.GetText(BirthDateTxt, "BirthDateTxt");
        }

        public string Race_Txt()
        {
            return Selenium.Driver.GetText(RaceTxt, "RaceTxt");
        }

        public string Address_Txt()
        {
            return Selenium.Driver.GetText(AddressTxt, "AddressTxt");
        }

        public string Email_Txt()
        {
            return Selenium.Driver.GetText(EmailTxt, "EmailTxt");
        }

        public string Education_Txt()
        {
            return Selenium.Driver.GetText(EducationTxt, "EducationTxt");
        }

        public string ProgramName_Txt()
        {
            return Selenium.Driver.GetText(ProgramNameTxt, "ProgramNameTxt");
        }

        public string EmployerName_Txt()
        {
            return Selenium.Driver.GetText(RequestDateTxt, "RequestDateTxt");
        }

        public string CreditPrevExperience_Txt()
        {
            return Selenium.Driver.GetText(CreditPrevExperienceTxt, "CreditPrevExperienceTxt");
        }

        public string Step_Txt()
        {
            return Selenium.Driver.GetText(StepTxt, "StepTxt");
        }

        public string ProgramComments_Txt()
        {
            return Selenium.Driver.GetText(ProgramNameTxt, "ProgramNameTxt");
        }

        public string BeginDate_Txt()
        {
            return Selenium.Driver.GetText(BeginDateTxt, "BeginDateTxt");
        }

        public string SSN_Txt()
        {
            return Selenium.Driver.GetText(SSNTxt, "SSNTxt");
        }

        public string Gender_Txt()
        {
            return Selenium.Driver.GetText(GenderTxt, "GenderTxt");
        }

        public string MilitarySTatus_txt()
        {
            return Selenium.Driver.GetText(MilitaryStatusTxt, "MilitaryStatusTxt");
        }

        public string Occupation_Txt()
        {
            return Selenium.Driver.GetText(OccupationTxt, "OccupationTxt");
        }

        public string CreditPrevRSIExp_Txt()
        {
            return Selenium.Driver.GetText(CreditPrevRSIExpTxt, "CreditPrevRSIExpTxt");
        }

        public string DirectEntry_Txt()
        {
            return Selenium.Driver.GetText(DirectEnteryTxt, "DirectEnteryTxt");
        }

        public void Comment_input()
        {
            Selenium.Driver.GetText(CommentInput, "CommentInput");
        }

        public void Cancel_Btn()
        {
            Selenium.Driver.Click(CancelBtn, "CancelBtn");
        }

        public void Deny_Btn()
        {
            Selenium.Driver.Click(DenyBtn, "DenyBtn");
        }

        public void Approve_Btn()
        {
            Selenium.Driver.Click(ApproveBtn, "ApproveBtn");
        }
    }
}
