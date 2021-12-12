using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Step_Update
{
    [TestClass]
    public class ApprenticeUpdateStepPostSelection_Page_Internal
    {
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Effective Date:')]//following::input[1]")]
        public IWebElement EffectiveDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Minute Date:')]//following::input[1]")]
        public IWebElement MinuteDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Apply Date to All Rows')]/i")]
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
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[4]/span[2]/div/span")]
        public IList<IWebElement> CurrentStepNumberTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[5]/span[2]//child::input")]
        public IList<IWebElement> EffectiveDateTableInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[6]/span[2]//child::input")]
        public IList<IWebElement> MinuteDateTableInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[7]/span[2]//child::input")]
        public IList<IWebElement> NewStepNumberInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[8]/span[2]/span")]
        public IList<IWebElement> Message { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-fluid')]//div//tbody[contains(@class,'ui-datatable-data ui-widget-content')]//child::tr/td[9]//button/i")]
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

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Update Steps')]")]
        public IWebElement UpdateStepBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ui-growl-title']")]
        public IWebElement ErrorMessagePopUpLine1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ui-growl-title']//following::p[1]")]
        public IWebElement ErrorMessagePopUpLine2 { get; set; }

        /// <summary>
        /// Inputs Effective Date
        /// </summary>
        /// <param name="n"></param>
        public void EffectiveDate_Input(string n)
        {
            Selenium.Driver.SendKeys(EffectiveDateInput, n, "EffectiveDateInput");
        }

        /// <summary>
        /// Inputs Minute Date
        /// </summary>
        /// <param name="n"></param>
        public void MinuteDate_Input(string n)
        {
            Selenium.Driver.SendKeys(MinuteDateInput, n, "MinuteDateInput");
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
        public string IDTable_Txt(int n)
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
        /// Inputs Cuurent Step Number value, in apirticular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public int CurrentStepNumber_Txt(int n)
        {
            string num = Selenium.Driver.GetText(CurrentStepNumberTableTxt[n], "CurrentStepNumberTableInput[" + n + "]");
            int num_1 = int.Parse(num);
            return num_1;
        }

        /// <summary>
        /// Inputs Effective Date value, in apirticular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void EffectiveDateTable_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(EffectiveDateTableInput[n], m, "EffectiveDateTableInput[" + n + "]");
        }

        /// <summary>
        /// Inputs Minutes Date value, in apirticular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void MinuteDateTable_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(MinuteDateTableInput[n], m, "MinuteDateTableInput[" + n + "]");
        }

        /// <summary>
        /// Inputs New Step value, in apirticular row by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public void NewStepNumberTable_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(NewStepNumberInput[n], m, "NewStepNumberInput[" + n + "]");
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
        /// Clicks on Update Steps button
        /// </summary>
        public void UpdateSteps_Btn()
        {
            Selenium.Driver.Click(UpdateStepBtn, "UpdateStepBtn");
        }

        /// <summary>
        /// Gets the Message test from the message column by inputting row index value (n)
        /// </summary>
        /// <param name="n"></param>
        public string ErrorMessage_PopUp()
        {
            return Selenium.Driver.GetText(ErrorMessagePopUpLine1, "ErrorMessagePopUpLine1")
                + " "+
                Selenium.Driver.GetText(ErrorMessagePopUpLine2, "ErrorMessagePopUpLine2");
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


