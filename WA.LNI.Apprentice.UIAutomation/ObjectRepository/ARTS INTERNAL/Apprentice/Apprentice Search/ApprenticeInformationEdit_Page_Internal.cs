using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search
{

    public class ApprenticeInformationEdit_Page_Internal : Base
    {
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-lg-6 col-md-12')]//child::input")]
        public IList<IWebElement> ApprenticeInfoEditInput { get; set; }

        /// <summary>
        /// Inputs of paramenter "n" 
        /// '0' for 'First Name',      '1' for 'Middle Name',   '3' for 'Last Name',
        /// '4' for 'Email Address',   '5' for 'Phone Number',  '6' for 'Address Line 1' ,
        /// '7' for 'Address Line 2',  '8' for 'City',          '9' for 'Zip',
        /// '10' for 'SSN',            '11' for 'Birth Day'
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void ApprenticeInfoEdit_InputTxt(int n, string m)
        {
            Selenium.Driver.SendKeys(ApprenticeInfoEditInput[n], m, "ApprenticeInfoEditInput[" + n + "]");
        }
    }
}
