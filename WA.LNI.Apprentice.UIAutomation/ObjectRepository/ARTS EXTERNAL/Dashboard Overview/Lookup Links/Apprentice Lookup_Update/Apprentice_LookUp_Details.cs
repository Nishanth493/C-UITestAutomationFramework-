using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Lookup_Links.Apprentice_Lookup_Update
{

    public class Apprentice_LookUp_Details : Base
    {
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container']/div/div[@class='lni-c-element-container lni-u-fl lni-o-cell--5of12 lni-c-container--sm lni-u-mt3']/div/div[@class='lni-c-element-container']/div[1]//dd")]
        public IList<IWebElement> PersonalInfoTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[contains(text(),'Apprentice Status')]//following::dd[1]")]
        public IWebElement AppStatusTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='lni-c-element-container lni-u-ba lni-u-b--black lni-u-pa1']//dd")]
        public IList<IWebElement> AppKeyDatesTxt { get; set; }

        //write a method that returns count of history items by the length of the list
        [FindsByAll]
        [FindsBy(How = How.Id, Using = "//body/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container']/div/div[@class='lni-c-element-container lni-u-fl lni-o-cell--5of12 lni-c-container--sm lni-u-mt3']/div/div[5]/div")]
        public IList<IWebElement> HistoryItemsCountTxt { get; set; }

        //write a method that returns the dates (Cancelled/completed/transferred) from the history items
        [FindsByAll]
        [FindsBy(How = How.Id, Using = "//body/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container']/div/div[@class='lni-c-element-container lni-u-fl lni-o-cell--5of12 lni-c-container--sm lni-u-mt3']/div/div[5]/div/div/span[1]")]
        public IList<IWebElement> HistoryItemsDatesTxt { get; set; }

        //gets all the statuses from the history 
        [FindsByAll]
        [FindsBy(How = How.Id, Using = "//body/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container']/div/div[@class='lni-c-element-container lni-u-fl lni-o-cell--5of12 lni-c-container--sm lni-u-mt3']/div/div[5]/div/div/span[2]")]
        public IList<IWebElement> HistoryItemStatusTxt { get; set; }

        //gets all the programs from the history 
        [FindsByAll]
        [FindsBy(How = How.Id, Using = "//body/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container']/div/div[@class='lni-c-element-container lni-u-fl lni-o-cell--5of12 lni-c-container--sm lni-u-mt3']/div/div[5]/div/div/p[1]")]
        public IList<IWebElement> HistoryItemProgramsTxt { get; set; }

        //gets all the occupations from the history 
        [FindsByAll]
        [FindsBy(How = How.Id, Using = "//body/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container']/div/div[@class='lni-c-element-container lni-u-fl lni-o-cell--5of12 lni-c-container--sm lni-u-mt3']/div/div[5]/div/div/p[2]")]
        public IList<IWebElement> HistoryItemOccupationTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container']/div/div[@class='lni-c-element-container lni-o-cell--6of12 lni-c-container--sm lni-u-fl lni-u-ml4']/div[1]//dd")]
        public IList<IWebElement> AppInfoCloumn_2Txt { get; set; }

        //body//div[@id='application-main']//div[3]//div[5]//a
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body//div[@id='application-main']//div[3]//div[5]//a")]
        public IList<IWebElement> ViewHistoryItemLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "Back to Apprentice Lookup")]
        public IWebElement BackToApprenticeSearchLnk { get; set; }

        [FindsBy(How = How.LinkText, Using = "View Hours History")]
        public IWebElement ViewHistoryLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td[1]/span")]
        public IList<IWebElement> OJTHoursBreakDown_Years_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td[2]/span")]
        public IList<IWebElement> OJTHoursBreakDown_Q1_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td[3]/span")]
        public IList<IWebElement> OJTHoursBreakDown_Q2_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td[4]/span")]
        public IList<IWebElement> OJTHoursBreakDown_Q3_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td[5]/span")]
        public IList<IWebElement> OJTHoursBreakDown_Q4_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td[6]/span")]
        public IList<IWebElement> OJTHoursBreakDown_YearTotals_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr/td[1]/span")]
        public IList<IWebElement> RSIHoursBreakDown_Years_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr/td[2]/span")]
        public IList<IWebElement> RSIHoursBreakDown_Q1_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr/td[3]/span")]
        public IList<IWebElement> RSIHoursBreakDown_Q2_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr/td[4]/span")]
        public IList<IWebElement> RSIHoursBreakDown_Q3_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr/td[5]/span")]
        public IList<IWebElement> RSIHoursBreakDown_Q4_Table { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr/td[6]/span")]
        public IList<IWebElement> RSIHoursBreakDown_YearTotals_Table { get; set; }


        /// <summary>
        /// Get the personal info text, by the inputted index value from list 
        /// 0: First Name | 1: Middle Name | 2: Last Name | 3: Apprentice ID | 4: Address | 5: Gender 
        /// 6: Race or Ehnicity | 7: Highest Education Level Completed | 8: Military Status 
        /// </summary>
        /// <param name="n"></param>
        public string AppPersonalInfo_Txt(int n)
        {
            return Selenium.Driver.GetText(PersonalInfoTxt[n], "PersonalInfoTxt[" + n + "]");
        }

        /// <summary>
        /// Get the Apprentice Status text
        /// </summary>
        public string AppStatus_Txt()
        {
            return Selenium.Driver.GetText(AppStatusTxt, "AppStatusTxt");
        }

        /// <summary>
        /// Get the Apprentice Key Dates text, by the inputted index value from list 
        /// 0: Registration | 1: Transfer | 2: Cancellation | 3: Suspension (start/end) | 4: Probation (start/end) | 5: Completion  
        /// </summary>
        /// <param name="n"></param>
        public string AppKeyDates_Txt(int n)
        {
            return Selenium.Driver.GetText(AppKeyDatesTxt[n], "AppKeyDatesTxt[" + n + "]");
        }

        /// <summary>
        /// Gets the number of history items 
        /// </summary>
        /// <param name="n"></param>
        public int HistoryItemsCount_Txt()
        {
            return HistoryItemsCountTxt.Count;
        }

        /// <summary>
        /// Get the Apprentice History Item Dates (Cancelled/completed/transferred) text, by the inputted index value from list 
        /// Higest index is the latest status date 
        /// </summary>
        /// <param name="n"></param>
        public string HistoryItemsDates_Txt(int n)
        {
            return Selenium.Driver.GetText(AppKeyDatesTxt[n], "AppKeyDatesTxt[" + n + "]");
        }

        /// <summary>
        /// Get the Apprentice History Item statuses text, by the inputted index value from list 
        /// Higest index is the latest status  
        /// </summary>
        /// <param name="n"></param>
        public string HistoryItemStatus_Txt(int n)
        {
            return Selenium.Driver.GetText(HistoryItemStatusTxt[n], "HistoryItemStatusTxt[" + n + "]");
        }

        /// <summary>
        /// Get the Apprentice History Item Programs text, by the inputted index value from list 
        /// Higest index is the latest program  
        /// </summary>
        /// <param name="n"></param>
        public string HistoryItemPrograms_Txt(int n)
        {
            return Selenium.Driver.GetText(HistoryItemProgramsTxt[n], "HistoryItemProgramsTxt[" + n + "]");
        }

        /// <summary>
        /// Get the Apprentice History Item Occupation text, by the inputted index value from list 
        /// Higest index is the latest occupation  
        /// </summary>
        /// <param name="n"></param>
        public string HistoryItemOccupation_Txt(int n)
        {
            return Selenium.Driver.GetText(HistoryItemOccupationTxt[n], "HistoryItemOccupationTxt[" + n + "]");
        }

        /// <summary>
        /// Get the Apprenticeship/Program Info text including Hours, by the inputted index value from list 
        /// 0: Apprenticeship Begin (Date) | 1: Apprenticeship Term (Hours) | 2: Probation Hours Required | 4: Total OJT Hours |
        /// 5: Credited OJT Hours | 6: Total RSI Hours | 7: Credited RSI | 8: Program Name and Id | 9: Sub Program Name 
        /// | 10: Apprenticeship Occupation | 11: License/certification 
        /// </summary>
        /// <param name="n"></param>
        public string AppInfoCloumn_2_Txt(int n)
        {
            return Selenium.Driver.GetText(AppInfoCloumn_2Txt[n], "AppInfoCloumn_2Txt[" + n + "]");
        }

        public void ViewHistoryItem_Lnk(int n)
        {
             Selenium.Driver.Click(ViewHistoryItemLnk[n], "ViewHistoryItemLnk[" + n + "]");
        }

        public void BackToApprenticeSearch_Lnk()
        {
            Selenium.Driver.Click(BackToApprenticeSearchLnk, "BackToApprenticeSearchLnk");
        }

        public void ViewHistory_Lnk()
        {
            Selenium.Driver.Click(ViewHistoryLnk, "ViewHistoryLnk");
        }

        public string OJTHoursBreakDown_Years_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(OJTHoursBreakDown_Years_Table[n], "OJTHoursBreakDown_Years_Table[" + n + "]");
        }


        public string OJTHoursBreakDown_Q1_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(OJTHoursBreakDown_Q1_Table[n], "OJTHoursBreakDown_Q1_Table[" + n + "]");
        }

        public string OJTHoursBreakDown_Q2_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(OJTHoursBreakDown_Q2_Table[n], "OJTHoursBreakDown_Q2_Table[" + n + "]");
        }

        public string OJTHoursBreakDown_Q3_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(OJTHoursBreakDown_Q3_Table[n], "OJTHoursBreakDown_Q3_Table[" + n + "]");
        }

        public string OJTHoursBreakDown_Q4_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(OJTHoursBreakDown_Q4_Table[n], "OJTHoursBreakDown_Q4_Table[" + n + "]");
        }

        public string OJTHoursBreakDown_YearTotals_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(OJTHoursBreakDown_YearTotals_Table[n], "OJTHoursBreakDown_YearTotals_Table[" + n + "]");
        }


        public string RSIHoursBreakDown_Years_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(RSIHoursBreakDown_Years_Table[n], "RSIHoursBreakDown_Years_Table[" + n + "]");
        }

        public string RSIHoursBreakDown_Q1_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(RSIHoursBreakDown_Q1_Table[n], "RSIHoursBreakDown_Q1_Table[" + n + "]");
        }

        public string RSIHoursBreakDown_Q2_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(RSIHoursBreakDown_Q2_Table[n], "RSIHoursBreakDown_Q2_Table[" + n + "]");
        }

        public string RSIHoursBreakDown_Q3_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(RSIHoursBreakDown_Q3_Table[n], "RSIHoursBreakDown_Q3_Table[" + n + "]");
        }

        public string RSIHoursBreakDown_Q4_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(RSIHoursBreakDown_Q4_Table[n], "RSIHoursBreakDown_Q4_Table[" + n + "]");
        }

        public string RSIHoursBreakDown_YearTotals_Table_Txt(int n)
        {
            return Selenium.Driver.GetText(RSIHoursBreakDown_YearTotals_Table[n], "RSIHoursBreakDown_YearTotals_Table[" + n + "]");
        }

    }
}


