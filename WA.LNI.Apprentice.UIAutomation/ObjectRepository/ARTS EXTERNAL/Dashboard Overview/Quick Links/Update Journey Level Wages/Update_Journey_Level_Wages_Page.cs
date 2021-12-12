using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.Update_Journey_Level_Wages
{

    public class Update_Journey_Level_Wages_Page : Base
    {
        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement Navigation_BackTOProgramOverviewLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Update Journey Level Wages')]")]
        public IWebElement PageHeadingTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[1]/span")]
        public IList<IWebElement> Table_OccupationNameTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[2]/span")]
        public IList<IWebElement> Table_OccupationIDTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[3]/span")]
        public IList<IWebElement> Table_LastWageAmtEffectiveDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[4]/span")]
        public IList<IWebElement> Table_LastWageAmtTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[5]//child::input")]
        public IList<IWebElement> Table_EffectiveDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[6]//child::input")]
        public IList<IWebElement> Table_WageAmountInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[7]/button")]
        public IList<IWebElement> Table_UpdateBtn { get; set; }

        [FindsBy(How = How.Id, Using = "journeyLevelWageErrorMessage")]
        public IWebElement WageLevelUpdateMessageTxt { get; set; }


        /// <summary>
        /// Clicks on back to program overview page link 
        /// </summary>
        public void Navigation_BackTOProgramOverview_Lnk()
        {
            Selenium.Driver.Click(Navigation_BackTOProgramOverviewLnk, "NavigationBackToOverviewLnk");
        }

        /// <summary>
        /// Gets the page heading text
        /// </summary>
        public string PageHeading_Txt()
        {
            return Selenium.Driver.GetText(PageHeadingTxt, "PageHeadingTxt");
        }

        /// <summary>
        /// Gets occupation name, for the given row number 
        /// </summary>
        /// <param Row number="n"></param>
        /// <returns>Occupation</returns>
        public string Table_OccupationName_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_OccupationNameTxt[n], "Table_OccupationNameTxt[" + n + "]");
        }

        /// <summary>
        ///  Gets occupation ID, for the given row number
        /// </summary>
        /// <param Row Number="n"></param>
        /// <returns>Occupation ID</returns>
        public string Table_OccupationID_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_OccupationIDTxt[n], "Table_OccupationIDTxt[" + n + "]");
        }

        /// <summary>
        ///  Gets effective date of last wage amount , for the given row number
        /// </summary>
        /// <param Row Number="n"></param>
        /// <returns>Previous Wage Effective Date String</returns>
        public string Table_LastWageAmtEffectiveDate_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_LastWageAmtEffectiveDateTxt[n], "Table_LastWageAmtEffectiveDateTxt[" + n + "]");
        }

        /// <summary>
        /// Gets occupation name, for the given row number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string Table_LastWageAmount_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_LastWageAmtTxt[n], "Table_LastWageAmtTxt[" + n + "]");
        }

        /// <summary>
        /// Enters Effective Date, for the given row number
        /// </summary>
        /// <param Row Number="n"></param>
        /// <param Effective Date="m"></param>
        public void Table_EffectiveDate_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(Table_EffectiveDateInput[n], m, "Table_EffectiveDateInput[" + n + "]");
        }

        /// <summary>
        /// Enters New Wage Amount, for the given row number
        /// </summary>
        /// <param Row Number="n"></param>
        /// <param New Wage Amount="m"></param>
        public void Table_NewWageAmount_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(Table_WageAmountInput[n], m, "Table_WageAmountInput[" + n + "]");
        }

        /// <summary>
        /// Clicks on 'Update' button, for the given row number
        /// </summary>
        /// <param Row Number="n"></param>
        public void Table_Update_Btn(int n)
        {
            Selenium.Driver.Click(Table_UpdateBtn[n], "Table_UpdateBtn[" + n + "]");
        }

        /// <summary>
        /// Clicks on 'Back to overview page' navigation link 
        /// </summary>
        public void Navigation_BackToProgramOverview_Clicknk( )
        {
            Selenium.Driver.Click(Navigation_BackTOProgramOverviewLnk, "Navigation_BackTOProgramOverviewLnk");
        }

        /// <summary>
        /// gets the update error message 
        /// </summary>
        /// <returns>Error message string </returns>
        public string WageLevelUpdateMessage_Txt()
        {
            return Selenium.Driver.GetText(WageLevelUpdateMessageTxt, "WageLevelUpdateMessageTxt");
        }
    }
}
