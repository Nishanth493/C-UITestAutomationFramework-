using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Transfer
{

    public class TransferApprentice_Page_1_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'font-weight-bold')]//following::input[1]")]
        public IWebElement ApprenticeIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@type,'submit')]")]
        public IWebElement FindApprenticeBtn { get; set; }

        /// <summary>
        /// Inputs the Apprentice ID
        /// </summary>
        /// <param name="n"></param>
        public void ApprenticeID_Input(string n)
        {
            Selenium.Driver.SendKeys(ApprenticeIDInput, n, "ApprenticeIDInput");
        }

        /// <summary>
        /// Clicks on Find Apprentice Button
        /// </summary>
        public void FindApprentice_Btn()
        {
            Selenium.Driver.Click(FindApprenticeBtn, "FindApprenticeBtn");
        }
    }
}
