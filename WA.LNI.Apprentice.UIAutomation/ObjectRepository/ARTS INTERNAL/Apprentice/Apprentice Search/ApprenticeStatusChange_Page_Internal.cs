using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using System;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search
{
    public class ApprenticeStatusChange_Page_Internal : Base
    {
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ng-tns-c4-152 ui-panel ui-widget ui-widget-content ui-corner-all')]//div[contains(@class,'ui-panel-content ui-widget-content')]//following::div/span[2]")]
        public IList<IWebElement> ApprenticeInfoListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-449 ui-dropdown-label ui-inputtext ui-corner-all ui-placeholder')]")]
        public IWebElement ChangeStatusDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Change Status:')]//following::li")]
        public IList<IWebElement> ChangeStatusDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Effective Date:')]//following::input[1]")]
        public IWebElement EffectiveDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Minute Date:')]//following::input[1]")]
        public IWebElement MinuteDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Cancel')]")]
        public IWebElement CancelLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Update Status')]")]
        public IWebElement UpdateStatusBtn { get; set; }

        /// <summary>
        /// Input n parameter value to get values - 
        /// '0' for 'FIrst Name',       '1' for 'Last Name',       '3' for 'Apprentice ID',
        /// '4' for 'Status',           '5' for 'Program Name',    '6' for 'Occupation Name',
        /// '7' for 'Total OJT Hours',  '8' for 'Total RSI Hours', '9' for 'Occupation Term',
        /// </summary>
        /// <param name="n"></param>
        public string ApprenticeInfo_ListTxt (int n)
        {
           return Selenium.Driver.GetText(ApprenticeInfoListTxt[n], "ApprenticeInfoListTxt[" + n + "]");
        }

        /// <summary>
        /// Selects status value to change to from the dropdown, by inputtind the dropdown index 
        /// </summary>
        /// <param name="n"></param>
        public void ChangeStatus_DrpDwn(int n)
        {
            Selenium.Driver.Click(ChangeStatusDrpDwnBtn, "ChangeStatusDrpDwnBtn");

            Selenium.Driver.Click(ChangeStatusDrpDwnOptions[n], "ChangeStatusDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// inputs effective date 
        /// </summary>
        /// <param name="n"></param>
        public void EffectiveDate_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(EffectiveDateInput,  n, "EffectiveDateInput");
        }

        /// <summary>
        /// Inputs the minutes date
        /// </summary>
        /// <param name="n"></param>
        public void MinuteDate_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(MinuteDateInput, n, "MinuteDateInput");
        }

        /// <summary>
        /// Selects the cancel link
        /// </summary>
        public void Cancel_Lnk()
        {
            Selenium.Driver.Click(CancelLnk, "CancelLnk");
        }

        /// <summary>
        /// Clicks on Update Status button
        /// </summary>
        public void UpdateStatus_Btn()
        {
            Selenium.Driver.Click(UpdateStatusBtn, "UpdateStatusBtn");
        }

    }
}
