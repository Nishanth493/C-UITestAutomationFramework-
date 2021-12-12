using System;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration
{

    public class AppReg_Confirmation : Base
    {
        [FindsBy(How = How.Id, Using = "registrationStatusMessage")]
        public IWebElement RegistrationSucessfulTxt { get; set; }

        [FindsBy(How = How.Id, Using = "apprenticeIdAfterSubmitting")]
        public IWebElement RegistrationIDTxt { get; set; }

        /// <summary>
        /// Gets the registration Success message 
        /// </summary>
        /// <returns>Conformation Message  String </returns>
        public string AppRegSucessful_TxtMsg()
        {
            return Selenium.Driver.GetText(RegistrationSucessfulTxt, "RegistrationSucessfulTxt");
        }

        /// <summary>
        /// Gets the newly registerd apprentice ID from the conformation message 
        /// </summary>
        /// <returns>Apprentice ID String</returns>
        public string AppRegID_NumTxt()
        {
            string FullMsg = Selenium.Driver.GetText(RegistrationIDTxt, "RegistrationIDTxt");
            int len = FullMsg.Length;
            string Id = FullMsg.Substring(15, 6);
            return Id;
        }
    }
}
