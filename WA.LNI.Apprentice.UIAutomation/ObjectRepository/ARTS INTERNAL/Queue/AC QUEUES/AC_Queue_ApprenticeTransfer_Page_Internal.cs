using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Queue.AC_QUEUES
{
    public class AC_Queue_ApprenticeTransfer_Page_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-ac-worklist[1]/div[1]/div[1]/div[2]/app-ac-apprentice-transfer-request[1]/div[1]/h1[1]")]
        public IWebElement HeadingTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Reason:')]//following::label[1]")]
        public IWebElement ReasonTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Request Date:')]//following::label[1]")]
        public IWebElement RequestDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Name:')]//following::label[1]")]
        public IWebElement NameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Address:')]//following::label[1]")]
        public IWebElement AddressTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Phone:')]//following::label[1]")]
        public IWebElement PhoneTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'From Program:')]//following::label[1]")]
        public IWebElement FromProgramTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'From Occupation:')]//following::label[1]")]
        public IWebElement FromOccupationTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'To Occupation:')]//following::label[1]")]
        public IWebElement ToOccupationTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'To Program:')]//following::label[1]")]
        public IWebElement ToProgramTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Employer Name:')]//following::label[1]")]
        public IWebElement EmployerNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Previous Experience:')]//following::label[1]")]
        public IWebElement CreditPrevExperienceTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Effective Date:')]//following::label[1]")]
        public IWebElement EffectiveDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Apprentice ID:')]//following::label[1]")]
        public IWebElement ApprenticeIDTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Email:')]//following::label[1]")]
        public IWebElement EmailTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Previous RSI Experience:')]//following::label[1]")]
        public IWebElement CreditPrevRSIExpTxt { get; set; }

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

        public string Address_Txt()
        {
            return Selenium.Driver.GetText(AddressTxt, "AddressTxt");
        }

        public string Email_Txt()
        {
            return Selenium.Driver.GetText(EmailTxt, "EmailTxt");
        }

        public string Phone_Txt()
        {
            return Selenium.Driver.GetText(PhoneTxt, "PhoneTxt");
        }

        public string FromProgram_Txt()
        {
            return Selenium.Driver.GetText(ToProgramTxt, "ToProgramTxt");
        }

        public string ToProgram_Txt()
        {
            return Selenium.Driver.GetText(FromProgramTxt, "FromProgramTxt");
        }

        public string EmployerName_Txt()
        {
            return Selenium.Driver.GetText(RequestDateTxt, "RequestDateTxt");
        }

        public string CreditPrevExperience_Txt()
        {
            return Selenium.Driver.GetText(CreditPrevExperienceTxt, "CreditPrevExperienceTxt");
        }

        public string EffectiveDate_Txt()
        {
            return Selenium.Driver.GetText(EffectiveDateTxt, "EffectiveDate");
        }

        public string ApprenticeID_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeIDTxt, "ApprenticeIDTxt");
        }

        public string FromOccupation_Txt()
        {
            return Selenium.Driver.GetText(FromOccupationTxt, "FromOccupationTxt");
        }

        public string ToOccupation_Txt()
        {
            return Selenium.Driver.GetText(ToOccupationTxt, "ToOccupationTxt");
        }

        public string CreditPrevRSIExp_Txt()
        {
            return Selenium.Driver.GetText(CreditPrevRSIExpTxt, "CreditPrevRSIExpTxt");
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
