using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Queue.AC_QUEUES
{
    public class Queues_Page_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c3-8 ui-dropdown-label ui-inputtext ui-corner-all ui-placeholder')]")]
        public IWebElement SelectACListBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ng-tns-c3-8 ui-dropdown-panel ui-widget-content ui-corner-all ui-helper-hidden ui-shadow ng-trigger ng-trigger-panelState')]//child::ul/li")]
        public IList<IWebElement> SelectACListDrpDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-ac-worklist[1]/div[1]/div[1]/div[1]/div[2]/div[1]/a[1]")]
        public IWebElement RefreshLnk { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Reassigned Temporary")]
        public IWebElement ReassignedTemporaryQueueLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::tbody/tr/td[1]/span")]
        public IList<IWebElement> Table_NameTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::tbody/tr/td[2]/span")]
        public IList<IWebElement> Table_ProgramNameTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::tbody/tr/td[3]/spa/divn")]
        public IList<IWebElement> Table_RequestTypeTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::tbody/tr/td[4]/span/div")]
        public IList<IWebElement> Table_RecevedDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::tbody/tr/td[5]/span")]
        public IList<IWebElement> Table_ReasonTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::tbody/tr/td[6]/span/div/a")]
        public IList<IWebElement> Table_ViewTakeActionRequestTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-paginator-bottom ui-paginator ui-widget ui-widget-header ui-unselectable-text')]//following::a")]
        public IList<IWebElement> NavigationPageNumBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]")]
        public IWebElement CountPerPageDrpDwn { get; set; }

        public void SelectACList_DrpDwn(int n)
        {
            Selenium.Driver.Click(SelectACListBtn, "SelectACListBtn");
            Selenium.Driver.Click(SelectACListDrpDwn[n], "SelectACListDrpDwn["+n+"]");
        }

        public void Refresh_Option()
        {
            Selenium.Driver.Click(RefreshLnk, "RefreshLnk");
        }

        public void ReassignedTemporaryQueue_Option()
        {
            Selenium.Driver.Click(ReassignedTemporaryQueueLnk, "ReassignedTemporaryQueueLnk");
        }

        public string Name_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_NameTxt[n], "Table_NameTxt"+n+"]");
        }

        public string ProgramName_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_ProgramNameTxt[n], "Table_ProgramNameTxt"+n+"]");
        }

        public string Request_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_RequestTypeTxt[n], "Table_RequestTypeTxt" + n + "]");
        }

        public string RecevedDate_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_RecevedDateTxt[n], "Table_RecevedDateTxt" + n+"]");
        }

        public string Reason_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_ReasonTxt[n], "Table_ReasonTxt["+n+"]");
        }

        public string Table_ViewTakeActionRequest_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_ViewTakeActionRequestTxt[n], "Table_ViewTakeActionRequestTxt[" + n + "]");
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
