using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC.Home
{
    public class Find_An_Apprenticeship_Program_By_County_Occupation_Home_Public_Page : Base
    {
        
        [FindsBy(How = How.XPath, Using = "//div[@aria-controls='artsProgramSearch_programCounties__slider']")]
        public IWebElement CountyBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//fieldset[@id='artsProgramSearch_programCounties_checkbox-list']//div/label/span[2]")]
        public IList<IWebElement> CountiesChkBoxs { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsProgramSearch_programOccupations")]
        public IWebElement OccupationInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsProgramSearch_searchProgram")]
        public IWebElement SearchBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows apprentice information']//tbody/tr/td[1]/a")]
        public IList<IWebElement> Table_ProgramNameLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows apprentice information']//tbody/tr/td[2]")]
        public IList<IWebElement> Table_OccupationTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows apprentice information']//tbody/tr/td[3]/a")]
        public IList<IWebElement> Table_ProgramIdLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary ='This table shows apprentice information']/tbody/tr/td[4]")]
        public IList<IWebElement> Table_CountiesListTxt { get; set; }

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

        public void Counties_ChkBoxs(int n)
        {
            Selenium.Driver.Click(CountyBtn, "CountyBtn");
            Selenium.Driver.Click(CountiesChkBoxs[n], "CountiesChkBoxs[" + n + "]");
        }

        public void Occupation_Input(string OccupInput)
        {
            Selenium.Driver.SendKeys(OccupationInput, OccupInput, "OccupationInput");
        }
 
        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
        }

        public void Table_ProgramName_Lnk(int n)
        {
            Selenium.Driver.Click(Table_ProgramNameLnk[n], "Table_ProgramNameLnk[" + n + "]");
        }

        public void Table_Occupation_Txt(int n)
        {
            Selenium.Driver.GetText(Table_OccupationTxt[n], "Table_OccupationTxt[" + n + "]");
        }

        public void Table_ProgramId_Lnk(int n)
        {
            Selenium.Driver.Click(Table_ProgramIdLnk[n], "Table_ProgramIdLnk[" + n + "]");
        }

        public void Table_CountiesList_Txt(int n)
        {
            Selenium.Driver.GetText(Table_CountiesListTxt[n], "Table_CountiesListTxt[" + n + "]");
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
