using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;
using System;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Delete_Reported_Hours
{

    public class DeleteReportedHours_Page_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Type or Select Program Name')]")]
        public IWebElement ProgramInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@type,'button')]")]
        public IWebElement ProgrameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-autocomplete-panel ui-widget-content ui-corner-all ui-shadow')]//child::span")]
        public IList<IWebElement> ProgramNameDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='mPgmId']")]
        public IWebElement ProgrameIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Select Hour:')]//following::div[1]")]
        public IWebElement SelectHourDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-dropdown-trigger ui-state-default ui-corner-right')]//following::li/span")]
        public IList<IWebElement> SelectHoursDrpDwnOptions { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//th[1]//following::tr/td[1]/span[2]")]
        public IList<IWebElement> ApprenticeIDTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//th[1]//following::tr/td[2]/span[2]")]
        public IList<IWebElement> FirstNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//th[1]//following::tr/td[3]/span[2]")]
        public IList<IWebElement> LastNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//th[1]//following::tr/td[4]/span[2]")]
        public IList<IWebElement> YearTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//th[1]//following::tr/td[5]/span[2]")]
        public IList<IWebElement> QuarterTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//th[1]//following::tr/td[6]/span[2]")]
        public IList<IWebElement> HoursTypeTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//th[1]//following::tr/td[7]/span[2]")]
        public IList<IWebElement> HoursTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-paginator-bottom ui-paginator ui-widget ui-widget-header ui-unselectable-text')]//child::a")]
        public IList<IWebElement> PageNavigationBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]")]
        public IWebElement CountPerPageDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]//child::option")]
        public IList<IWebElement> CountPerPageDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@type,'submit')]")]
        public IWebElement DeleteBtn { get; set; }

        /// <summary>
        /// Inputs Program Name
        /// </summary>
        /// <param name="n"></param>
        public void Program_Input(string n)
        {
            Selenium.Driver.SendKeys(ProgramInput, n, "ProgramInput");
        }

        /// <summary>
        /// Selects Program from the dropdown, by inputting program dropdwon index
        /// </summary>
        /// <param name="n"></param>
        public void ProgrameDrpDwn_Btn(int n)
        {
            Selenium.Driver.Click(ProgrameDrpDwnBtn, "ProgrameDrpDwnBtn");

            Selenium.Driver.Click(ProgramNameDrpDwnOptions[n], "ProgramNameDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Inputs the program ID
        /// </summary>
        /// <param name="n"></param>
        public void ProgramID_Input(string n)
        {
            Selenium.Driver.SendKeys(ProgrameIDInput, n, "ProgrameIDInput");
        }

        /// <summary>
        /// Selects the hour option from the dropdown, by inputting the dropdown index values
        /// </summary>
        /// <param name="n"></param>
        public void SelectHourDrpDwn_Btn(int n)
        {
            Selenium.Driver.Click(SelectHourDrpDwnBtn, "SelectHourDrpDwnBtn");

            Selenium.Driver.Click(SelectHoursDrpDwnOptions[n], "SelectHoursDrpDwnOptions" + n + "]");
        }

        /// <summary>
        /// Gets the apprentice ID value from the table 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string ApprenticeIDTable_Txt (int n )
        {
            return Selenium.Driver.GetText(ApprenticeIDTableTxt[n], "ApprenticeIDTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the apprentice First Name value from the table
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string FirstNameTable_Txt(int n)
        {
            return Selenium.Driver.GetText(FirstNameTableTxt[n], "FirstNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the apprentice Last Name value from the table
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string LastNameTable_Txt(int n)
        {
            return Selenium.Driver.GetText(LastNameTableTxt[n], "LastNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Year value from the table
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string YearTable_Txt(int n)
        {
            return Selenium.Driver.GetText(YearTableTxt[n], "YearTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Quarter value from the table
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string QuarterTable_Txt(int n)
        {
            return Selenium.Driver.GetText(QuarterTableTxt[n], "QuarterTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Hours type value from the table
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string HoursTypeTable_Txt(int n)
        {
            return Selenium.Driver.GetText(HoursTypeTableTxt[n], "HoursTypeTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the Hours value from the table
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string HoursTable_Txt(int n)
        {
            return Selenium.Driver.GetText(HoursTableTxt[n], "HoursTableTxt[" + n + "]");
        }

        ///<summary>
        /// Clicks on the Page navigation values
        /// </summary>
        /// <param name="n"></param>
        public void PageNumberNavigation_Btn(int n)
        {
            Selenium.Driver.Click(PageNavigationBtn[n], "PageNavigationBtn[" + n + "]");
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
        
        /// <summary>
        /// clicks on Delete button
        /// </summary>
        public void Delete_Btn()
        {
            Selenium.Driver.Click(DeleteBtn, "DeleteBtn");
        }
    }
}
