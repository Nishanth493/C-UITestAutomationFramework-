using System;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration
{

    public class AppReg_Review_Page : Base
    {
        [FindsBy(How = How.Id, Using = "registerApprentice")]
        public IWebElement RegisterAppReviewSubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "editRegistrationInfo")]
        public IWebElement RegisterAppReviewEditBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='registrationFailureMessage']")]
        public IWebElement RegFalureMsg { get; set; }

        /// <summary>
        /// Clicks on confirm Apprentice Registration button
        /// </summary>
        public void RegisterApprenticeReviewSubmit_Btn()
        {
            Selenium.Driver.Click(RegisterAppReviewSubmitBtn, "RegisterAppReviewSubmitBtn");
        }

        /// <summary>
        /// Clicks on the apprentice information 'Edit' button
        /// </summary>
        public void RegisterApprenticeReviewEdit_Btn()
        {
            Selenium.Driver.Click(RegisterAppReviewEditBtn, "RegisterAppReviewEditBtn");
        }

        /// <summary>
        /// Gets the apprentice registration error message 
        /// </summary>
        /// <returns>Error message String</returns>
        public string RegFalureMsg_txt()
        {
           return Selenium.Driver.GetText(RegFalureMsg, "RegFalureMsg");
        }
    }
}
