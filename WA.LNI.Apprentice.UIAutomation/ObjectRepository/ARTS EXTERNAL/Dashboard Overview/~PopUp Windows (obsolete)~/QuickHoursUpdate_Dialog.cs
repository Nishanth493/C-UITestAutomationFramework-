using System;
using OpenQA.Selenium.Support.PageObjects;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.DashboardOverview.PopUp_Windows
{
    public class QuickHoursUpdate_Dialog : Base
    {
        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Report Hours')]")]
        public IWebElement TitleTxt { get; set; }

        [FindsBy(How = How.Id, Using = "apprenticeNameToReportHours")]
        public IWebElement ApprenticeNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'From:')]//following::input[1]")]
        public IWebElement FromDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'To:')]//following::input[1]")]
        public IWebElement ToDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='lni-c-form-control lni-c-form-control--required lni-u-ml3 lni-u-mt3']//label[@class='lni-c-form-control__label'][contains(text(),'OJT Hours')]//following::input[1]")]
        public IWebElement OJTHoursInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Unpaid/Supervised')]//following::input[1]")]
        public IWebElement UnpaidRSIHoursInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'RSI Paid')]//following::input[1]")]
        public IWebElement PaidRSIHoursInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@id='creditedHours']//child::div")]
        public IList<IWebElement> AnyCreditedHoursRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Credited OJT Hours:')]//following::input[1]")]
        public IWebElement CreditedOJTHoursInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Credited RSI Hours:')]//following::input[1]")]
        public IWebElement CreditedRSIHoursInput { get; set; }

        [FindsBy(How = How.Id, Using = "//body[@data-gr-c-s-loaded='true']/div[4]/div[1]/div[1]/a[1]")]
        public IWebElement CancelLnk { get; set; }

        [FindsBy(How = How.Id, Using = "submitReportHoursInModal")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//body[@data-gr-c-s-loaded='true']/div[4]/div[1]/button[1]")]
        public IWebElement CloseBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#reportHoursErrorMessage")]
        public IWebElement ErrorTxt { get; set; }



        /// <summary>
        /// Get the title text of the daialog window
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void Heading_GetTxt()
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
        /// Inputs the From Date 
        /// </summary>
        /// <param name="occupationName"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void FromDate_Input(string fromDate)
        {
            Selenium.Driver.SendKeys(FromDateInput, fromDate, "FromDateInput");
        }

        /// <summary>
        /// Inputs the To Date 
        /// </summary>
        /// <param name="occupationName"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void ToDate_Input(string toDate)
        {
            Selenium.Driver.SendKeys(ToDateInput, toDate, "ToDateInput");
        }

        /// <summary>
        /// Inputs the OJT Hours 
        /// </summary>
        /// <param name="occupationName"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void OJTHours_Input(string ojtHours)
        {
            Selenium.Driver.SendKeys(OJTHoursInput, ojtHours, "OJTHoursInput");
        }

        /// <summary>
        /// Inputs the Unpaid RSI Hours 
        /// </summary>
        /// <param name="occupationName"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void RSIUnpaid_Input(string rsiUnpaidHours)
        {
            Selenium.Driver.SendKeys(UnpaidRSIHoursInput, rsiUnpaidHours, "UnpaidRSIHoursInput");
        }

        /// <summary>
        /// Inputs the paid RSI Hours 
        /// </summary>
        /// <param name="occupationName"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void RSIpaid_Input(string rsipaidHours)
        {
            Selenium.Driver.SelectDropDownByValue(UnpaidRSIHoursInput, rsipaidHours, "UnpaidRSIHoursInput");
        }

        /// <summary>
        /// Selects "Yes" for 1 or "No" for 0 for any credited hours option
        /// </summary>
        /// <param name="n"></param>
        public void CreditedHours_RdoBtn(int n)
        {

            Selenium.Driver.Click(AnyCreditedHoursRdoBtn[n], "AnyCreditedHoursRdoBtn["+n+"]");
        }

    }

}
