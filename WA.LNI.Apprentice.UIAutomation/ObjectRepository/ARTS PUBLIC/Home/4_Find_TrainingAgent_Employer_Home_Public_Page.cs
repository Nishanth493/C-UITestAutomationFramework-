using System;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC.Home
{
    public class Find_TrainingAgent_Employer_Home_Public_Page : Base
    {
        [FindsBy(How = How.XPath, Using = "//select[@id='artsEmployerSearch_employerStatus_select-input']")]
        public IWebElement SelectStatusBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[@id='artsEmployerSearch_employerStatus_select-input']//option")]
        public IList<IWebElement> ApprenticeStatusDrpDwn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsEmployerSearch_employerName")]
        public IWebElement EmployernameInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsEmployerSearch_employerUbi")]
        public IWebElement EmployerUBIInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsEmployerSearch_employerProgramName")]
        public IWebElement ProgramNameInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsEmployerSearch_searchEmployer")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#`${id}_resetEmployerSearch`")]
        public IWebElement ResetBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows training agent information']//tbody/tr/td[1]/a")]
        public IList<IWebElement> Table_EmployerNameLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows training agent information']//tbody/tr/td[2]/a")]
        public IList<IWebElement> Table_ProgramNameLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows training agent information']//tbody/tr/td[3]")]
        public IList<IWebElement> Table_OccupationNameTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows training agent information']//tbody/tr/td[4]")]
        public IList<IWebElement> Table_EffectiveDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows training agent information']//tbody/tr/td[5]")]
        public IList<IWebElement> Table_EndDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows training agent information']//tbody/tr/td[6]")]
        public IList<IWebElement> Table_ApprenticeStatustxt { get; set; }

        /// <summary>
        /// [0] - Previous page
        /// [1] to [5] - Pages 1 to 5
        /// [6] - Next page 
        /// </summary>
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//a")]
        public IList<IWebElement> PageNavigatonBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='artsEmployerSearch_trainingAgentLookupTable_PageSize_select-input']")]
        public IWebElement RowsCountPerPageBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[@id='artsEmployerSearch_trainingAgentLookupTable_PageSize_select-input']//option")]
        public IList<IWebElement> RowsCountPerPageDrpDwn { get; set; }

        public void SelectStatus_Btn(int n)
        {
            Selenium.Driver.Click(SelectStatusBtn, "SelectStatusBtn");
            Selenium.Driver.Click(ApprenticeStatusDrpDwn[n], "ApprenticeStatusDrpDwn[" + n + "]");
        }

        public void Employername_Input(string EmployerName)
        {
            Selenium.Driver.SendKeys(EmployernameInput, EmployerName, "EmployernameInput");
        }

        public void EmployerUBI_Input(string UbiNumber)
        {
            Selenium.Driver.SendKeys(EmployerUBIInput, UbiNumber, "EmployerUBIInput");
        }

        public void ProgramName_Input(string PgmName)
        {
            Selenium.Driver.SendKeys(ProgramNameInput, PgmName, "ProgramNameInput");
        }

        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
        }

        public void Reset_Btn()
        {
            Selenium.Driver.Click(ResetBtn, "ResetBtn");
        }

        public void Table_EmployerName_Lnk(int n)
        {
            Selenium.Driver.Click(Table_EmployerNameLnk[n], "Table_EmployerNameLnk[" + n + "]");
        }

        public void Table_ProgramName_Lnk(int n)
        {
            Selenium.Driver.Click(Table_ProgramNameLnk[n], "Table_ProgramNameLnk[" + n + "]");
        }

        public void Table_OccupationName_Txt(int n)
        {
            Selenium.Driver.GetText(Table_OccupationNameTxt[n], "Table_OccupationNameTxt[" + n + "]");
        }

        public void Table_EffectiveDate_Txt(int n)
        {
            Selenium.Driver.GetText(Table_EffectiveDateTxt[n], "Table_EffectiveDateTxt[" + n + "]");
        }

        public void Table_EndDate_Txt(int n)
        {
            Selenium.Driver.GetText(Table_EndDateTxt[n], "Table_EndDateTxt[" + n + "]");
        }

        public void Table_ApprenticeStatus_txt(int n)
        {
            Selenium.Driver.GetText(Table_ApprenticeStatustxt[n], "Table_ApprenticeStatustxt[" + n + "]");
        }

        /// <summary>
        /// [0] - Previous page
        /// [1] to [5] - Pages 1 to 5
        /// [6] - Next page 
        /// </summary>
        public void PageNavigaton_Btn(int n)
        {
            Selenium.Driver.Click(PageNavigatonBtn[n], "PageNavigatonBtn[" + n + "]");
        }

        public void RowsCountPerPage_DrpDwn(int n)
        {
            Selenium.Driver.Click(RowsCountPerPageBtn, "RowsCountPerPageBtn");
            Selenium.Driver.Click(RowsCountPerPageDrpDwn[n], "RowsCountPerPageDrpDwn[" + n + "]");
        }
    }
}
