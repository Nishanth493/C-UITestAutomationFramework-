using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Info___Affidavit
{
    public class ApprenticeInformation_Page_internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Apprentice ID:')]//following::div[1]/label")]
        public IWebElement ApprenticeIDListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Name:')]//following::div[1]/label")]
        public IWebElement NameListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Education:')]//following::div[1]/label")]
        public IWebElement EduicationListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Email Address:')]//following::div[1]/label")]
        public IWebElement EmailAddressListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Phone Number:')]//following::div[1]/label")]
        public IWebElement PhoneNumberListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-md-9']//div[1]")]
        public IWebElement AddressLine1ListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-md-9']//div[2]")]
        public IWebElement AddressLine2ListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'SSN:')]//following::div[1]/label")]
        public IWebElement SSNListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Birth Date:')]//following::div[1]/label")]
        public IWebElement BirthDateListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Gender:')]//following::div[1]/label")]
        public IWebElement GenderListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Military Status:')]//following::div[1]/label")]
        public IWebElement MilitaryStatusListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Race:')]//following::div[1]/label")]
        public IWebElement RaceListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Hispanic Ethnicity:')]//following::div[1]/label")]
        public IWebElement HispanicEthnicityListTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'card card-w-title ui-g-12 ui-fluid ui-md-12 ui-sm-12')]//div[contains(@class,'ui-g')]//div[1]//following::div/div/div[2]/label")]
        public IList<IWebElement> ApprenticeProgramOccupationInformationListTxt { get; set; }

        /// <summary>
        /// Input n parameter value to get values -
        /// '0' for 'Apprentice ID',    '1' for 'Name',         '3' for 'Education',
        /// '4' for 'Email Address',    '5' for 'Phone Number', '6' for 'Address',
        /// '7' for 'SSN',              '8' for 'Birth Date',   '9' for 'Gender',
        /// '10' for 'Military Status', '11' for 'Race',        '13' for 'Hispanic Ethnicity'    
        /// </summary>
        /// <param name="n"></param>
       /* public string ApprenticeInfo_ListText(int n)
        {
            return Selenium.Driver.GetText(ApprenticeInfoListTxt[n], "ApprenticeInfoListTxt[+" + n + "]");
        }*/

        /// <summary>
        /// Input n parameter value to get values -
        /// '0' for 'Program Name',                        '1' for 'Sub Program',   '3' for 'Occupation Name',
        /// '4' for 'Registration Date',                   '5' for 'Begin Date',    '6' for 'Probation Start Date',
        /// '7' for 'Probation End Date',                  '8' for 'Direct Entry',  '9' for 'Credit For Previous Experience:',
        /// '10' for 'Credit RSI For Previous Experience', '11' for 'Final Hours'   
        /// </summary>
        /// <param name="n"></param>
        public string ApprenticeProgramOccupationInformation_ListTxt(int n)
        {
            return Selenium.Driver.GetText(ApprenticeProgramOccupationInformationListTxt[n], "ApprenticeProgramOccupationInformationListTxt[" + n + "]");
        }
    }
}
