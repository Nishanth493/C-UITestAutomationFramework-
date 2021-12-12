using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC.Home
{
    public class Find_All_Apprenticeship_Programs_By_Name_Home_Public_Page : Base
    {
        [FindsBy(How = How.CssSelector, Using = "#artsAllPrograms_programName")]
        public IWebElement ProgramNameSearchInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows list of all available programs in Washington']//tbody/tr/td/a")]
        public IList<IWebElement> Table_ProgramListLnk { get; set; }
 
        /// <summary>
        /// [0] - Previous page
        /// [1] to [5] - Pages 1 to 5
        /// [6] - Next page 
        /// </summary>
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//a")]
        public IList<IWebElement> PageNavigatonBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='artsProgramSearch_programLookupTable_PageSize_select-input']")]
        public IWebElement RowsCountPerPageBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[@id='artsProgramSearch_programLookupTable_PageSize_select-input']//option")]
        public IList<IWebElement> RowsCountPerPageDrpDwn { get; set; }

        public void ProgramNameSearch_Input(string ProgramName)
        {
            Selenium.Driver.SendKeys(ProgramNameSearchInput, ProgramName, "ProgramNameSearchInput");
        }

        public void Table_ProgramList_Lnk(int n)
        {
            Selenium.Driver.Click(Table_ProgramListLnk[n], "Table_ProgramListLnk["+n+"]");
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
