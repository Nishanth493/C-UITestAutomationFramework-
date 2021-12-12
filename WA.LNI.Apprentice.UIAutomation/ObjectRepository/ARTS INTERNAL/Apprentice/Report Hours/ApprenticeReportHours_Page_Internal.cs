using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Report_Hours
{
    public class ApprenticeReportHours_Page_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Last Name:')]//following::input[1]")]
        public IWebElement LastNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'First Name:')]//following::input[1]")]
        public IWebElement FirstNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'SSN:')]//following::input[1]")]
        public IWebElement SSNInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Apprentice ID:')]//following::input[1]")]
        public IWebElement ApprenticeIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Program ID:')]//following::input[1]")]
        public IWebElement ProgramIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Status:')]//following::p-dropdown[1]")]
        public IWebElement StatusDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Status:')]//following::div[1]/div/div/ul//span")]
        public IList<IWebElement> StatusDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'ui-autocomplete ui-widget ui-autocomplete-dd')]//button[contains(@type,'button')]")]
        public IWebElement ProgramNameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Program Name:')]//following::span[1]/div/ul/li")]
        public IList<IWebElement> ProgramNameDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Type or Select Program Name')]")]
        public IWebElement ProgramNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-463 ui-dropdown-label ui-inputtext ui-corner-all ui-placeholder')]")]
        public IWebElement OccupationNameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Occupation Name:')]//following::div[1]/div/div/ul/li")]
        public IList<IWebElement> OccupationNameDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ng-tns-c4-430 ui-dropdown ui-widget ui-state-default ui-corner-all ui-helper-clearfix ui-dropdown-open')]")]
        public IWebElement SubProgramDrpDwnBtn{ get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Sub Program:')]//following::div[1]/div/div/ul/li")]
        public IList<IWebElement> SubProgramDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'ui-button-text ui-clickable')][contains(text(),'Search')]")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Continue')]")]
        public IWebElement ContinueBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-lg-11 ui-md-11 ui-sm-12')]//div//app-common-search-apprentice-results//child::div/b")]
        public IWebElement SelectionCountTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content ui-datatable-hoverable-rows')]//child::tr/td/span/input")]
        public IList<IWebElement> ApprenticeSelectionTableChkBox { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content ui-datatable-hoverable-rows')]//child::tr/td[2]/span")]
        public IList<IWebElement> ApprenticeIDTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content ui-datatable-hoverable-rows')]//child::tr/td[3]/span")]
        public IList<IWebElement> FirstNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = " //tbody[contains(@class,'ui-datatable-data ui-widget-content ui-datatable-hoverable-rows')]//child::tr/td[4]/span")]
        public IList<IWebElement> LastNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content ui-datatable-hoverable-rows')]//child::tr/td[5]/span")]
        public IList<IWebElement> ProgramNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content ui-datatable-hoverable-rows')]//child::tr/td[6]/span")]
        public IList<IWebElement> OccupationNameTableTxt { get; set; }
        
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tbody[contains(@class,'ui-datatable-data ui-widget-content ui-datatable-hoverable-rows')]//child::tr/td[7]/span")]
        public IList<IWebElement> StatusTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-paginator-bottom ui-paginator ui-widget ui-widget-header ui-unselectable-text')]//child::a")]
        public IList<IWebElement> PageNumberNavigationBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]")]
        public IWebElement CountPerPageDrpDwnBtn{ get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]//child::option")]
        public IList<IWebElement> CountPerPageDrpDwnOptions { get; set; }

        /// <summary>
        /// Input Apprentce Last Name to search
        /// </summary>
        /// <param name="n"></param>
        public void LastName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(LastNameInput, n, "LastNameInput");
        }

        /// <summary>
        /// Input Apprentice First Name to search
        /// </summary>
        /// <param name="n"></param>
        public void FirstName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(FirstNameInput, n, "LastNameInput");
        }

        /// <summary>
        /// Input Apprentice SSN to search
        /// </summary>
        /// <param name="n"></param>
        public void SSN_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(SSNInput, n, "SSNInput");
        }

        /// <summary>
        /// Input Apprentice ID to search
        /// </summary>
        /// <param name="n"></param>
        public void ApprenticeID_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(ApprenticeIDInput, n, "ApprenticeIDInput");
        }

        /// <summary>
        /// Input Program ID to search 
        /// </summary>
        /// <param name="n"></param>
        public void ProgramID_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(ProgramIDInput, n, "ProgramIDInput");
            Thread.Sleep(500);
        }

        /// <summary>
        /// input '0', '1', '2', '3', '4' to select 'Active', 'Completed', 'Cancelled', 'Suspended', 'Transfered'
        /// </summary>
        /// <param name="n"></param>
        public void Status_DrpDwn(string n)
        {
            int _p = int.Parse(n);
            Selenium.Driver.Click(StatusDrpDwnBtn, "StatusDrpDwn]");
            Selenium.Driver.Click(StatusDrpDwnOptions[_p], "StatusDrpDwnOptions["+_p+"]");
            Thread.Sleep(500);
        }

        /// <summary>
        /// input dropdown Index number to select Program (Current Program count '0' to '240')
        /// </summary>
        /// <param name="n"></param>
        public void ProgramName_DrpDwn(int n)
        {
            Selenium.Driver.Click(ProgramNameDrpDwnBtn, "ProgramNameDrpDwnBtn");
            Selenium.Driver.Click(ProgramNameDrpDwnOptions[n], "ProgramNameDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Input Program name 
        /// </summary>
        /// <param name="n"></param>
        public void ProgramName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(ProgramNameInput, n, "ProgramNameInput");
        }

        /// <summary>
        /// Input dropdown index number to select an occupation
        /// </summary>
        /// <param name="n"></param>
        public void OccupationName_DrpDwn(int n)
        {
            Selenium.Driver.Click(OccupationNameDrpDwnBtn, "OccupationNameDrpDwnBtn");

            Selenium.Driver.Click(OccupationNameDrpDwnOptions[n], "OccupationNameDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Input dropdown index number to select a Sub-program
        /// </summary>
        /// <param name="n"></param>
        public void SubProgram_DrpDwn(int n)
        {
            Selenium.Driver.Click(SubProgramDrpDwnBtn, "SubProgramDrpDwnBtn");

            Selenium.Driver.Click(SubProgramDrpDwnOptions[n], "SubProgramDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Clicks search button
        /// </summary>
        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
        }

        /// <summary>
        /// Clicks Continue button
        /// </summary>
        public void Continue_Btn()
        {
            Selenium.Driver.Click(ContinueBtn, "ContinueBtn");
        }

        /// <summary>
        /// Gets the number of selections made 
        /// </summary>
        public void SelectionCount_Txt()
        {
            Selenium.Driver.GetText(SelectionCountTxt, "SelectionCountTxt");
        }

        /// <summary>
        /// Clicks on the Check Box from the table 
        /// </summary>
        /// <param name="n"></param>
        public void ApprenticeSlection_ChkBox(string n)
        {
            string[] x = n.Split(';');

            for (int i = 0; i < x.Length; i++)
            {
                Selenium.Driver.Click(ApprenticeSelectionTableChkBox[int.Parse(x[i])], "ApprenticeSelectionTableChkBox[" + x[i] + "]");
            }       
        }

        /// <summary>
        /// Gets the Apprentice ID columns values 
        /// </summary>
        /// <param name="n"></param>
        public void ApprenticeIDTable_Txt(int n)
        {
            Selenium.Driver.GetText(ApprenticeIDTableTxt[n], "ApprenticeIDTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the First Name columns values 
        /// </summary>
        /// <param name="n"></param>
        public void FirstNameTable_Txt(int n)
        {
            Selenium.Driver.GetText(FirstNameTableTxt[n], "FirstNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Last Name columns values 
        /// </summary>
        /// <param name="n"></param>
        public void LastNameTable_Txt(int n)
        {
            Selenium.Driver.GetText(LastNameTableTxt[n], "LastNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Program Name columns values 
        /// </summary>
        /// <param name="n"></param>
        public void ProgramNameTable_Txt(int n)
        {
            Selenium.Driver.GetText(ProgramNameTableTxt[n], "ProgramNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Occuptaion Name columns values 
        /// </summary>
        /// <param name="n"></param>
        public void OccupationNameTable_Txt(int n)
        {
            Selenium.Driver.GetText(OccupationNameTableTxt[n], "OccupationNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Status columns values 
        /// </summary>
        /// <param name="n"></param>
        public void StatusTable_Txt(int n)
        {
            Selenium.Driver.GetText(StatusTableTxt[n], "StatusTableTxt[" + n + "]");
        }

        /// <summary>
        /// Clicks on the Page navigation values
        /// </summary>
        /// <param name="n"></param>
        public void PageNumberNavigation_Btn(int n)
        {
            Selenium.Driver.Click(PageNumberNavigationBtn[n], "PageNumberNavigationBtn[" + n + "]");
        }

        /// <summary>
        /// Selects count per page value from the dropdown, by inputting the index values 
        /// </summary>
        /// <param name="n"></param>
        public void CountPerPage_DrpDwn(int n)
        {
            Selenium.Driver.Click(CountPerPageDrpDwnBtn, "CountPerPageDrpDwnBtn");

            Selenium.Driver.Click(CountPerPageDrpDwnOptions[n], "CountPerPageDrpDwnOptions[" + n + "]");
        }

    }
}
