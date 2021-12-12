using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search
{

    public class SearchApprentice_Page_Internal : Base
    {
        [FindsBy (How = How.XPath, Using = "//input[contains(@name,'lastName')]")]
        public IWebElement LastNameInput { get; set; }

        [FindsBy (How = How.XPath, Using = "//input[contains(@name,'firstName')]")]
        public IWebElement FirstNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'ssn')]")]
        public IWebElement SSNInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'apprenticeId')]")]
        public IWebElement ApprenticeIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-465 ui-dropdown-label ui-inputtext ui-corner-all ui-placeholder')]")]
        public IWebElement StatusDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Status:')]//following::ul[1]/li")]
        public IList<IWebElement> StatusDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'ui-btn')]")]
        public IWebElement ProgramNameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Program Name:')]//following::ul[1]/li")]
        public IList<IWebElement> ProgramNameDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Type or Select Program Name')]")]
        public IWebElement ProgramNameInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#pgmId")]
        public IWebElement ProgramIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-466 ui-dropdown-label ui-inputtext ui-corner-all ui-placeholder')]")]
        public IWebElement OccupationNameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Occupation Name:')]//following::ul[1]/li")]
        public IList<IWebElement> OccupationNameDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-467 ui-dropdown-label ui-inputtext ui-corner-all ui-placeholder')]")]
        public IWebElement SubProgramNameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Sub Program:')]/following::ul[1]/li")]
        public IList<IWebElement> SubProgramNameDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'ui-button-text ui-clickable')][contains(text(),'Search')]")]
        public IWebElement SearchBtn { get; set; }
        
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//td[1]/span/div/a")]
        public IList<IWebElement> ApprenticeIDTableLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//td[2]/span")]
        public IList<IWebElement> FirestNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//td[3]/span")]
        public IList<IWebElement> LastNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//td[4]/span")]
        public IList<IWebElement> ProgramNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//td[5]/span")]
        public IList<IWebElement> OccupationNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//td[6]/span")]
        public IList<IWebElement> RegistrationDateTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//td[7]/span/div/a")]
        public IList<IWebElement> StatusTableTxtLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//td[8]/span/div/a")]
        public IList<IWebElement> EditTableLnk{ get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-paginator-bottom ui-paginator ui-widget ui-widget-header ui-unselectable-text')]//following::a")]
        public IList<IWebElement> NavigationPageNumBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]")]
        public IWebElement CountPerPageDrpDwn { get; set; }

        /// <summary>
        /// inputs apprentice last name 
        /// </summary>
        /// <param name="n"></param>
        public void LastName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(LastNameInput, n, "LastNameInput");
        }

        /// <summary>
        /// Inputs apprentice First Name
        /// </summary>
        /// <param name="n"></param>
        public void FirstName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(FirstNameInput, n, "FirstNameInput");
        }

        /// <summary>
        /// Inputs apprentice SSN 
        /// </summary>
        /// <param name="n"></param>
        public void SSN_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(SSNInput, n, "SSNInput");
        }

        /// <summary>
        /// Inputs Apprentice ID
        /// </summary>
        /// <param name="n"></param>
        public void ApprenticeID_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(ApprenticeIDInput, n, "ApprenticeIDInput");
        }

        /// <summary>
        /// Selects status from the dropdown, by inputting dropdown index value 
        /// </summary>
        /// <param name="n"></param>
        public void Status_DrpDwn (int n)
        {
            Selenium.Driver.Click(StatusDrpDwnBtn, "StatusDrpDwnBtn");
            Selenium.Driver.Click(StatusDrpDwnOptions[n], "StatusDrpDwnOptions[" + n+"]");
        }

        /// <summary>
        /// Selects Program from the dropdown, by inputting dropdown index value 
        /// </summary>
        /// <param name="n"></param>
        public void ProgramName_DrpDwn(int n)
        {
            Selenium.Driver.Click(ProgramNameDrpDwnBtn, "ProgramNameDrpDwnBtn");
            Selenium.Driver.Click(ProgramNameDrpDwnOptions[n], "ProgramNameDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Inputs Program Name 
        /// </summary>
        /// <param name="n"></param>
        public void ProgramName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(ProgramNameInput, n, "ProgramNameInput");
        }

        /// <summary>
        /// Input Program ID
        /// </summary>
        /// <param name="n"></param>
        public void ProgramID_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(ProgramIDInput, n, "ProgramIDInput");
        }

        /// <summary>
        /// Selects Occupation from the dropdown, by inputting index value
        /// </summary>
        /// <param name="n"></param>
        public void OccupationName_DrpDwn(int n)
        {
            Selenium.Driver.Click(OccupationNameDrpDwnBtn, "OccupationNameDrpDwnBtn");
            Selenium.Driver.Click(OccupationNameDrpDwnOptions[n], "OccupationNameDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Selects Sub Program from the dropdown, by inputting index value
        /// </summary>
        /// <param name="n"></param>
        public void SubProgramName_DrpDwn(int n)
        {
            Selenium.Driver.Click(SubProgramNameDrpDwnBtn, "SubProgramNameDrpDwnBtn");
            Selenium.Driver.Click(SubProgramNameDrpDwnOptions[n], "SubProgramNameDrpDwn[" + n + "]");
        }

        /// <summary>
        /// Selects the Search button
        /// </summary>
        /// <param name="n"></param>
        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
        }

        /// <summary>
        /// Gets all the Apprentice ID Column values 
        /// </summary>
        /// <param name="n"></param>
        public string ApprenticID_TableTxt(int n)
        {
            return Selenium.Driver.GetText(ApprenticeIDTableLnk[n], "ApprenticeIDTableLnk[" + n + "]");
        }

        /// <summary>
        /// Gets all the Apprentice ID Column values 
        /// </summary>
        /// <param name="n"></param>
        public void ApprenticID_TableLnk(int n)
        {
            Selenium.Driver.Click(ApprenticeIDTableLnk[n], "ApprenticeIDTableLnk[" + n + "]");
        }

        /// <summary>
        /// Gets all the First Name Column values 
        /// </summary>
        /// <param name="n"></param>
        public string FirstName_TableTxt(int n)
        {
            return Selenium.Driver.GetText(FirestNameTableTxt[n], "FirestNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Last Name Column values 
        /// </summary>
        /// <param name="n"></param>
        public string LastName_TableTxt(int n)
        {
            return Selenium.Driver.GetText(LastNameTableTxt[n], "LastNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Program Name Column values 
        /// </summary>
        /// <param name="n"></param>
        public string ProgramName_TableTxt(int n)
        {
            return Selenium.Driver.GetText(ProgramNameTableTxt[n], "ProgramNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Occupation Name Column values 
        /// </summary>
        /// <param name="n"></param>
        public string OccupationName_TableTxt(int n)
        {
            return Selenium.Driver.GetText(OccupationNameTableTxt[n], "OccupationNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Registration Date column values
        /// </summary>
        /// <param name="n"></param>
        public string RegistrationDate_TableTxt(int n)
        {
            return Selenium.Driver.GetText(RegistrationDateTableTxt[n], "RegistrationDateTableTxt[" + n + "]");
        }

        /// <summary>
        /// Clicks on apprentice status, from the status cloumn by inputting row value 
        /// </summary>
        /// <param name="n"></param>
        public string Status_TableTxt(int n)
        {
            return Selenium.Driver.GetText(StatusTableTxtLnk[n], "StatusTableTxtLnk[" + n + "]");
        }

        /// <summary>
        /// Clicks on apprentice status, from the status cloumn by inputting row value 
        /// </summary>
        /// <param name="n"></param>
        public void Status_TableLnk(int n)
        {
            Selenium.Driver.Click(StatusTableTxtLnk[n], "StatusTableTxtLnk[" + n + "]");
        }

        /// <summary>
        /// Clicks on Edit option, from the status cloumn by inputting row value 
        /// </summary>
        /// <param name="n"></param>
        public void Edit_TableLnk(int n)
        {
            Selenium.Driver.Click(EditTableLnk[n], "EditTableLnk[" + n + "]");
        }

        /// <summary>
        /// input 'n = 0' for 'First Page', 'n = 1' for 'Previous Page', 'n = 2' to 'n = 6' to click on pages '1 to 5', 'n = 7' for 'Next Page', 'n = 8' for 'Last Page'
        /// </summary>
        /// <param name="n"></param>
        public void NavigationPageNum_Btns(int n)
        {
            Selenium.Driver.Click(NavigationPageNumBtn[n], "NavigationPageNumBtn[" + n + "]");
        }

        /// <summary>
        /// Input parameter values "5", "10", "20", "50", "100" count per page 
        /// </summary>
        /// <param name="n"></param>
        public void CountPerPage_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(CountPerPageDrpDwn, n, "CountPerPageDrpDwn");
        }

    }
}
