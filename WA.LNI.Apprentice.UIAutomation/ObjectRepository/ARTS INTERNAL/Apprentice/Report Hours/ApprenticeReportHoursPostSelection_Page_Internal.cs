using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;
using System;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Report_Hours
{ 
    public class ApprenticeReportHoursPostSelection_Page_Internal
    {
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Start Date:')]//following::input[1]")]
        public IWebElement StartDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'End Date:')]//following::input[1]")]
        public IWebElement EndDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Apply Date to All Rows')]")]
        public IWebElement ApplyDateToAllLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[1]/span[2]")]
        public IList<IWebElement> IdTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[2]/span[2]")]
        public IList<IWebElement> NameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[3]/span[2]")]
        public IList<IWebElement> OccupationNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[4]/span[2]")]
        public IList<IWebElement> StartDateTableInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[5]/span[2]")]
        public IList<IWebElement> EndDateTableInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[6]/span[2]/input")]
        public IList<IWebElement> OJTHoursInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[7]/span[2]/input")]
        public IList<IWebElement> RSIPaidHoursInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[8]/span[2]/input")]
        public IList<IWebElement> RSIUnPaidHoursInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[10]/span[2]")]
        public IList<IWebElement> Message { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[11]/span[2]")]
        public IList<IWebElement> DeleteBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-paginator-bottom ui-paginator ui-widget ui-widget-header ui-unselectable-text')]//child::a")]
        public IList<IWebElement> PageNavigationBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]")]
        public IWebElement CountPerPageDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]//child::option")]
        public IList<IWebElement> CountPerPageDrpDwnOptions { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement CancelLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Update Hours')]")]
        public IWebElement UpdateHoursBtn { get; set; }

        /// <summary>
        /// Inputs Start Date
        /// </summary>
        /// <param name="n"></param>
        public void StartDate_Input(string n)
        {
            Selenium.Driver.SendKeys(StartDateInput, n, "StartDateInput");
        }

        /// <summary>
        /// Inputs End Date
        /// </summary>
        /// <param name="n"></param>
        public void EndDate_Input(string n)
        {
            Selenium.Driver.SendKeys(EndDateInput, n, "EndDateInput");
        }

        /// <summary>
        /// Clicks on the "Apply Date to All Rows" link 
        /// </summary>
        public void ApplyDatesToAll_Lnk()
        {
            Selenium.Driver.Click(ApplyDateToAllLnk, "ApplyDateToAllLnk");
        }

        /// <summary>
        /// Gets ID column values
        /// </summary>
        /// <param name="n"></param>
        public string IDTable_Txt (int n)
        {
            return Selenium.Driver.GetText(IdTableTxt[n], "IdTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets Name column values
        /// </summary>
        /// <param name="n"></param>
        public string NameTable_Txt(int n)
        {
            return Selenium.Driver.GetText(NameTableTxt[n], "NameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets Occupation Name column values
        /// </summary>
        /// <param name="n"></param>
        public string OccupationNameTable_Txt(int n)
        {
            return Selenium.Driver.GetText(OccupationNameTableTxt[n], "OccupationNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Inputs Start Date value, in apirticular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void StartDateTable_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(StartDateTableInput[n], m, "StartDateTableInput[" + n + "]");
        }

        /// <summary>
        /// Inputs End Date value, in apirticular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void EndDateTable_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(EndDateTableInput[n], m, "EndDateTableInput[" + n + "]");
        }

        /// <summary>
        /// Inputs OJT Hours value, in apirticular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void OJTHoursTable_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(OJTHoursInput[n], m, "OJTHoursInput[" + n + "]");
        }

        /// <summary>
        /// Inputs RSI Paid Hours value, in apirticular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void RSIPaidHoursTable_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(RSIPaidHoursInput[n], m, "RSIPaidHoursInput[" + n + "]");
        }

        /// <summary>
        /// Inputs RSI UnPaid Hours value, in a particular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void RSIUnPaidHoursTable_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(RSIUnPaidHoursInput[n], m, "RSIUnPaidHoursInput[" + n + "]");
        }


        /// <summary>
        /// Gets the Message test from the message column by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        public string MessageTable_Txt(int n)
        {
            return Selenium.Driver.GetText(Message[n], "Message[" + n + "]");
        }

        /// <summary>
        /// Clicks on the row Delete button test from the Delete column by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        public void Delete_Btn(int n)
        {
            Selenium.Driver.Click(DeleteBtn[n], "DeleteBtn[" + n + "]");
        }

        /// <summary>
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
        /// Selects the cancel link
        /// </summary>
        public void Cancel_Lnk()
        {
            Selenium.Driver.Click(CancelLnk, "CancelLnk");
        }

        /// <summary>
        /// Clicks on Update Hours button
        /// </summary>
        public void UpdateHours_Btn()
        {
            Selenium.Driver.Click(UpdateHoursBtn, "UpdateHoursBtn");
        }

        public List<string> SelectIDs_ListTxt()
        {
            List<string> n = new List<string>(IdTableTxt.Count);

            for (int i = 0; i < IdTableTxt.Count; i++)
            {
                string _id = Selenium.Driver.GetText(IdTableTxt[i], "IdTableTxt[" + i + "]");
                n.Insert(i, _id);
            }
            return n;
        }


    }
}
