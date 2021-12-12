using System;
using OpenQA.Selenium.Support.PageObjects;

using OpenQA.Selenium;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration
{
    public class AppReg_EnterSSN_Page : TestBase
    {
        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement NavigationBackToOverPageLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='lni-u-type--4 lni-u-mb3 lni-u-mr6']")]
        public IWebElement PageHeadingTxt { get; set; }

        [FindsBy(How = How.Id, Using = "ssnNumberForRegistration")]
        public IWebElement SSNInputBox { get; set; }

        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement NavigationBackToOverViewPageLnk { get; set; }

        [FindsBy(How = How.Id, Using = "checkSsnNumber")]
        public IWebElement VerifySSNBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='lni-c-alert--error --inline']")]
        public IWebElement ErrorMsgTxt { get; set; }

        /// <summary>
        /// Enters the SSN number of the registering apprentice
        /// </summary>
        /// <param name="ssnNumber"></param>
        public void EnterSSN(string ssnNumber)
        {
            Selenium.Driver.SendKeys(SSNInputBox, ssnNumber, "SSNInputBox");
        }

        /// <summary>
        /// Clicks on back to overview page link
        /// </summary>
        public void NavigationBackToOverPage_Lnk()
        {
            Selenium.Driver.Click(NavigationBackToOverPageLnk, "NavigationBackToOverPageLnk");
        }

        /// <summary>
        /// Gets page heading text
        /// </summary>
        public string PageHeading_Txt()
        {
            return Selenium.Driver.GetText(PageHeadingTxt, "PageHeadingTxt");
        }

        /// <summary>
        /// Clicks on the 'Verify' button 
        /// </summary>
        public void ClickVerify()
        {
            Selenium.Driver.Click(VerifySSNBtn, "VerifySSNBtn" );
        }

        /// <summary>
        /// Clicks on Navigation link, back to overview page 
        /// </summary>
        public void BackToProgramOverview()
        {
            Selenium.Driver.Click(NavigationBackToOverViewPageLnk, "NavigationBackToOverViewPageLnk");
        }

        /// <summary>
        /// Gets the error message on clicking verify button 
        /// </summary>
        /// <returns></returns>
        public string ErrorMsg_Gettxt()
        {
            return Selenium.Driver.GetText(ErrorMsgTxt, "ErrorMsgTxt");
        }
    }
}
