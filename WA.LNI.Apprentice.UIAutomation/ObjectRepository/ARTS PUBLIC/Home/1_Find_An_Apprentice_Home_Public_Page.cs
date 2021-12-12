using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC.Home
{
    public class Find_An_Apprentice_Home_Public_Page : Base
    {
        [FindsBy(How = How.XPath, Using = "//select[@id='artsApprenticeSearch_apprenticeStatus_select-input']")]
        public IWebElement ApprenticeStatusDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[@id='artsApprenticeSearch_apprenticeStatus_select-input']//option")]
        public IList<IWebElement> ApprenticeStatusDrpDwn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsApprenticeSearch_apprFirstName")]
        public IWebElement ApprenticeFirstNameInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsApprenticeSearch_apprLastName")]
        public IWebElement ApprenticeLastNameInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#artsApprenticeSearch_apprId")]
        public IWebElement ApprenticeApprenticeIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='artsApprenticeSearch_apprenticeSearch']")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='artsApprenticeSearch_resetApprenticeSearch']")]
        public IWebElement ResetBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary ='This table shows apprentice information']/tbody/tr/td[1]/a")]
        public IList<IWebElement> Table_ApprenticeNameLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary ='This table shows apprentice information']/tbody/tr/td[2]")]
        public IList<IWebElement> Table_ApprenticeIDTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary ='This table shows apprentice information']/tbody/tr/td[3]/a")]
        public IList<IWebElement> Table_ProgramIDLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary ='This table shows apprentice information']/tbody/tr/td[4]")]
        public IList<IWebElement> Table_OccupationTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary ='This table shows apprentice information']/tbody/tr/td[5]")]
        public IList<IWebElement> Table_ApprenticeStatustxt { get; set; }
        
        /// <summary>
        /// [0] - Previous page
        /// [1] to [5] - Pages 1 to 5
        /// [6] - Next page 
        /// </summary>
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//a")]
        public IList<IWebElement> PageNavigatonBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='artsApprenticeSearch_apprenticeLookupTable_PageSize_select-input']")]
        public IWebElement RowsCountPerPageBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[@id='artsApprenticeSearch_apprenticeLookupTable_PageSize_select-input']//option")]
        public IList<IWebElement> RowsCountPerPageDrpDwn { get; set; }

        public void ApprenticeStatus_DrpDwn(int n)
        {
            Selenium.Driver.Click(ApprenticeStatusDrpDwnBtn, "SearchCriteriaRdoBtn");
            Selenium.Driver.Click(ApprenticeStatusDrpDwn[n], "ApprenticeStatusDrpDwn["+n+"]");
        }

        public void ApprenticeFirstName_Input (string NameInput)
        {
            Selenium.Driver.SendKeys(ApprenticeFirstNameInput, NameInput, "ApprenticeFirstNameInput");
        }

        public void ApprenticeLastName_Input(string NameInput)
        {
            Selenium.Driver.SendKeys(ApprenticeLastNameInput, NameInput, "ApprenticeLastNameInput");
        }

        public void ApprenticeApprenticeID_Input(string AppId)
        {
            Selenium.Driver.SendKeys(ApprenticeApprenticeIDInput, AppId, "ApprenticeApprenticeIDInput");
        }

        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
        }

        public void Reset_Btn()
        {
            Selenium.Driver.Click(ResetBtn,"ResetBtn");
        }

        public void Table_ApprenticeName_Lnk(int n)
        {
            Selenium.Driver.Click(Table_ApprenticeNameLnk[n], "Table_ApprenticeNameLnk["+n+"]");
        }

        public void Table_ApprenticeID_Txt(int n)
        {
            Selenium.Driver.GetText(Table_ApprenticeIDTxt[n], "Table_ApprenticeIDTxt[" + n + "]");
        }

        public void Table_ProgramID_Lnk(int n)
        {
            Selenium.Driver.Click(Table_ProgramIDLnk[n], "Table_ProgramIDLnk[" + n + "]");
        }

        public void Table_Occupation_Txt(int n)
        {
            Selenium.Driver.GetText(Table_OccupationTxt[n], "Table_OccupationTxt[" + n + "]");
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
