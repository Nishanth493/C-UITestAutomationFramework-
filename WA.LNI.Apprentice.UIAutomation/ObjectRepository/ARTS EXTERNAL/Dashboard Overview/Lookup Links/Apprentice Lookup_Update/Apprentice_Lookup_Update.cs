using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Lookup_Links.Apprentice_Lookup_Update
{
    public class Apprentice_Lookup_Update : Base
    {
        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement NavigationBackToProgramLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[@class='lni-u-type--4 lni-u-mb3']")]
        public IWebElement PageHeadingTxt { get; set; }

        [FindsBy(How = How.Id, Using = "apprenticeProgramLookup")]
        public IWebElement SelectProgramDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "apFirstName")]
        public IWebElement SearchFirstNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "apLastName")]
        public IWebElement SearchLastNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "apLookupId")]
        public IWebElement SearchApprenticeIDInput { get; set; }

        [FindsBy(How = How.Id, Using = "apLookupStatus")]
        public IWebElement SearchStatusDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "aProgramSteps")]
        public IWebElement SearchStepDrpDwn { get; set; }
    
        [FindsBy(How = How.Id, Using = "aProgramOccupations")]
        public IWebElement SearchOccupationDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "apClearSearch")]
        public IWebElement ResetBtn { get; set; }

        [FindsBy(How = How.Id, Using = "apSearchClick")]
        public IWebElement SearchBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]/tr//td[1]/a")]
        public IList<IWebElement> Table_ApprenticeNameLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]//child::tr/td[2]/span")]
        public IList<IWebElement> Table_AppStepTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]//child::tr/td[3]/span")]
        public IList<IWebElement> Table_AppOJTnRSITxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]//child::tr/td[4]/span")]
        public IList<IWebElement> Table_AppStatusTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]//child::tr/td[5]/a")]
        public IList<IWebElement> Table_AppAddAdditionalCreditLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]//child::tr/td[6]/a")]
        public IList<IWebElement> Table_AppUpdateStatusLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/table[1]/tbody[1]//child::tr/td[7]/a")]
        public IList<IWebElement> Table_AppChangeProbationLnk { get; set; }


        /// <summary>
        /// Clicks on back to program overview page link 
        /// </summary>
        public void NavigationBackToProgram_Lnk()
        {
            Selenium.Driver.Click(NavigationBackToProgramLnk, "NavigationBackToProgramLnk");
        }

        /// <summary>
        /// Gets the page heading text
        /// </summary>
        public string PageHeading_Txt()
        {
            Thread.Sleep(3000);
            return Selenium.Driver.GetText(PageHeadingTxt, "PageHeadingTxt");
        }

        /// <summary>
        /// Selects Program from the DropDown by inputting the Program ID 
        /// </summary>
        /// <param Row Number="n"></param>
        public void SelectProgram_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(SelectProgramDrpDwn, n, "SelectProgramDrpDwn");
        }

        /// <summary>
        /// Inputs apprentice First Name
        /// </summary>
        /// <param First Name="n"></param>
        public void SearchFirstName_Input(string n)
        {
            Selenium.Driver.SendKeys(SearchFirstNameInput, n, "SearchFirstNameInput");
        }

        /// <summary>
        /// Input apprentice Last Name
        /// </summary>
        /// <param name="n"></param>
        public void SearchLasttName_Input(string n)
        {
            Selenium.Driver.SendKeys(SearchLastNameInput, n, "SearchLastNameInput");
        }

        /// <summary>
        /// Input apprentice ID Last Name
        /// </summary>
        /// <param Apprentice ID="n"></param>
        public void SearchApprenticeID_Input(string n)
        {
            Selenium.Driver.SendKeys(SearchApprenticeIDInput, n, "SearchApprenticeIDInput");
        }


        /// <summary>
        /// Select Status from the dropdown, by inputting dropdown value
        /// </summary>
        /// <param Status drop down value="n"></param>
        public void SearchStatus_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(SearchStatusDrpDwn, n, "SearchStatusDrpDwn");
        }

        /// <summary>
        /// Select Step count from the dropdown, by inputting dropdown value
        /// </summary>
        /// <param Step Count drop down value="n"></param>
        public void SearchStep_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(SearchStepDrpDwn, n, "SearchStepDrpDwn");
        }

        /// <summary>
        /// Select Occupation from the dropdown, by inputting dropdown value
        /// </summary>
        /// <param Occupation drop down value="n"></param>
        public void SearchOccupation_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(SearchOccupationDrpDwn, n, "SearchOccupationDrpDwn");
        }

        /// <summary>
        /// Clicks on the 'Reset' button
        /// </summary>
        public void Reset_Btn()
        {
            Selenium.Driver.Click(ResetBtn, "ResetBtn");
        }

        /// <summary>
        /// Clicks on the 'Search" button 
        /// </summary>
        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
        }

        /// <summary>
        /// Gets the Apprentice Name (ID) from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        /// <returns>Apprentice Name (ID)</returns>
        public string Table_ApprenticeNameID_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_ApprenticeNameLnk[n], "Table_ApprenticeNameLnk[" + n + "]");
        }

        /// <summary>
        /// Clicks the Apprentice Name (ID) from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        public void Table_ApprenticeNameID_Lnk(int n)
        {
            Selenium.Driver.Click(Table_ApprenticeNameLnk[n], "Table_ApprenticeNameLnk[" + n + "]");
        }

        /// <summary>
        /// Gets the Step Number from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        /// <returns>Step Number</returns>
        public string Table_AppStep_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_AppStepTxt[n], "Table_AppStepTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the OJT/RSI Hours from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        /// <returns>OJT/RSI</returns>
        public string Table_AppOJTnRSI_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_AppOJTnRSITxt[n], "Table_AppOJTnRSITxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Status from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        /// <returns>Status</returns>
        public string Table_AppStatus_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_AppStatusTxt[n], "Table_AppStatusTxt[" + n + "]");
        }

        /// <summary>
        /// Clicks the on Add Additional Credit link from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        public void Table_AppAddAdditionalCredit_Lnk(int n)
        {
            Selenium.Driver.Click(Table_AppAddAdditionalCreditLnk[n], "Table_AppAddAdditionalCreditLnk[" + n + "]");
        }

        /// <summary>
        /// Clicks the on Change Status link from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        public void Table_AppUpdateStatus_Lnk(int n)
        {
            Selenium.Driver.Click(Table_AppUpdateStatusLnk[n], "Table_AppUpdateStatusLnk[" + n + "]");
        }

        /// <summary>
        /// Clicks the on Change Probation link from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        public void Table_AppChangeProbation_Lnk(int n)
        {
            Selenium.Driver.Click(Table_AppChangeProbationLnk[n], "Table_AppChangeProbationLnk[" + n + "]");
        }

    }
}
