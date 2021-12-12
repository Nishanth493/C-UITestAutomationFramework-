using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.RSI_OJT_Reporting
{
    public class ApprenticeReadyTo_Report_Hours_Page : Base
    {
        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement NavigationBackToOverviweLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Apprentice Ready to Report Hours')]")]
        public IWebElement PageHeadingTxt { get; set; }

        [FindsBy(How = How.Id, Using = "rhProgramSelect")]
        public IWebElement SelectProgramDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "firstNameToReport")]
        public IWebElement SearchFirstNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "lastNameToReport")]
        public IWebElement SearchLastNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "apprenticeIdToReport")]
        public IWebElement SearchApprenticeIDInput { get; set; }

        [FindsBy(How = How.Id, Using = "statusToReportHours")]
        public IWebElement SearchStatusDrpDwn { get; set; }

        /// <summary>
        /// 0 - RSI & OJT, 1 - RSI, 2 - OJT
        /// </summary>
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//legend[@class='lni-c-input-list__legend']//following::label/span")]
        public IList<IWebElement> PreferenceHoursRdoBtns { get; set; }

        [FindsBy(How = How.Id, Using = "reportHoursFromDate")]
        public IWebElement FromDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "reportHoursToDate")]
        public IWebElement ToDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='lni-c-button --small --control lni-u-ml3']")]
        public IWebElement AutoFillBtn { get; set; }

        [FindsBy(How = How.Id, Using = "clearReportingHoursSearch")]
        public IWebElement ResetBtn { get; set; }

        [FindsBy(How = How.Id, Using = "searchApprenticeReportHours")]
        public IWebElement SearchBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//thead/tr/th/span")]
        public IList<IWebElement> TableHeaderTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//thead/tr/th/button")]
        public IWebElement TableHeader_ExpandAllBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[1]/a")]
        public IList<IWebElement> Table_ApprenticeNameLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//tr[@class= 'lni-grid--left' ]//td[@class='lni-c-table__td td-label']//span[@class='lni-c-toggletip__wrapper']//button[@style='visibility: visible;']")]
        public IList<IWebElement> Table_ErrorMessageInfoBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[1]//child::p")]
        public IList<IWebElement> Table_ErrorMessageInfoBtnTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[3]/div[2]/table[1]/tbody[1]/tr/td[2]/span")]
        public IList<IWebElement> Table_StatusTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//tr/td[3]//child::input")]
        public IList<IWebElement> Table_FromDateinput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//tr/td[4]//child::input")]
        public IList<IWebElement> Table_ToDateinput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='other']")]
        public IList<IWebElement> Table_RSIPaidInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='unpaid']")]
        public IList<IWebElement> Table_RSIUnPaidInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='ojt']")]
        public IList<IWebElement> Table_OJTInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[6]/button[1]")]
        public IList<IWebElement> Table_HistoryExpandBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[6]/button[2]")]
        public IList<IWebElement> Table_HistoryShrinkBtn { get; set; }

        [FindsBy(How = How.Id, Using = "submitRsiOjtHours")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "reportHoursMessage")]
        public IWebElement ReportHoursErrorMessageTxt { get; set; }

        /// <summary>
        /// Clicks on back to overview page navigation link 
        /// </summary>
        public void NavigationBackToOverviwe_Lnk()
        {
            Selenium.Driver.Click(NavigationBackToOverviweLnk, "NavigationBackToOverviweLnk");
        }

        /// <summary>
        /// Clicks on back to overview page navigation link 
        /// </summary>
        public string PageHeading_Txt()
        {
            return Selenium.Driver.GetText(PageHeadingTxt, "PageHeadingTxt");
        }

        /// <summary>
        /// Selects Program from the DropDown by inputting the Program ID 
        /// </summary>
        /// <param Row Number="n"></param>
        public void SelectProgram_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(SelectProgramDrpDwn, n, "SelectProgramDrpDwn");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Inputs apprentice First Name
        /// </summary>
        /// <param First Name="n"></param>
        public void SearchFirstName_Input(string n)
        {
            Selenium.Driver.SendKeys(SearchFirstNameInput, n, "SearchFirstNameInput");
        }

        /// <summary>
        /// Input apprentice Last Name
        /// </summary>
        /// <param name="n"></param>
        public void SearchLasttName_Input(string n)
        {
            Selenium.Driver.SendKeys(SearchLastNameInput, n, "SearchLastNameInput");
        }

        /// <summary>
        /// Select Status from the dropdown, by inputting dropdown value
        /// </summary>
        /// <param Status drop down value="n"></param>
        public void SearchStatus_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(SearchStatusDrpDwn, n, "SearchStatusDrpDwn");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Clicks on the (RSI & OJT) or (RSI) or (OJT) radiobuttons
        /// </summary>
        /// <param Hours radio button index="n"></param>
        public void PreferenceHours_RdoBtns(string n)
        {
            int m = Int32.Parse(n);
            Selenium.Driver.Click(PreferenceHoursRdoBtns[m], "PreferenceHoursRdoBtns" + m + "]");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Enters the From Date, to auto fill all the dates 
        /// </summary>
        /// <param From Date="n"></param>
        public void FromDate_Input(string n)
        {
            Selenium.Driver.SendKeys(FromDateInput, n, "FromDateInput");
        }

        /// <summary>
        /// Enters the To Date, to auto fill all the dates 
        /// </summary>
        /// <param To Date="n"></param>
        public void ToDate_Input(string n)
        {
            Selenium.Driver.SendKeys(ToDateInput, n, "ToDateInput");
        }

        /// <summary>
        /// Clicks on the auto fill button
        /// </summary>
        /// <param To Date="n"></param>
        public void AutoFill_btn()
        {
            Selenium.Driver.Click(AutoFillBtn, "AutoFillBtn");
        }

        /// <summary>
        /// Clicks on the 'Reset' button
        /// </summary>
        public void Reset_Btn()
        {
            Selenium.Driver.Click(ResetBtn, "ResetBtn");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Clicks on the 'Search" button 
        /// </summary>
        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// retruns the error message info fora pirticular apprentice 
        /// </summary>
        public string Table_ErrorMessageInfo_Btn_Txt(int n)
        {
            Selenium.Driver.Click(Table_ErrorMessageInfoBtn[n], "Table_ErrorMessageInfoBtn" + n + "]");
            Thread.Sleep(1000);
            return Selenium.Driver.GetText(Table_ErrorMessageInfoBtnTxt[n], "Table_ErrorMessageInfoBtnTxt" + n + "]");
        }

        /// <summary>
        /// retruns the error message info, is there is only 1 error
        /// </summary>
        public string Table_ErrorMessageInfo_Btn_Txt_0(int m)
        {
            Selenium.Driver.Click(Table_ErrorMessageInfoBtn[0], "Table_ErrorMessageInfoBtn]");
            return Selenium.Driver.GetText(Table_ErrorMessageInfoBtnTxt[m], "Table_ErrorMessageInfoBtnTxt]");
        }

        /// <summary>
        /// returns the Apprentice ID and error message text by searcheing through all thr rows to check which apprentice row has error 
        /// </summary>
        public List<string> Table_ErrorMessageInfo_Status_Check_Txt()
        {
            string _ErrorTxt_Common_ = Selenium.Driver.GetText(ReportHoursErrorMessageTxt, "ReportHoursErrorMessageTxt");
            string Error_AppID_ = "";
            string Error_Txt_ = "";
            List<string> _Errors_ = new List<string>();
  
            for (int i = 0; i < Table_ErrorMessageInfoBtn.Count; i++)
            {
                    Error_AppID_ = Table_ApprenticeID_Txt(i);
                    Error_Txt_ = Table_ErrorMessageInfo_Btn_Txt(i);
                    _Errors_.Add(Error_AppID_ + " " + Error_Txt_);
            }
            return _Errors_;
        }
            
 

        /// <summary>
        /// returns the header text based on the inputted index 
        /// </summary>
        /// <param List count="n"></param>
        /// <returns>Table Header Text</returns>
        public string TableHeader_Txt(int n)
        {
            return Selenium.Driver.GetText(TableHeaderTxt[n], "TableHeaderTxt" );
        }

        /// <summary>
        /// Gets the Apprentice Name (ID) from teh table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        /// <returns></returns>
        public string Table_ApprenticeNameID_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_ApprenticeNameLnk[n], "Table_ApprenticeNameLnk[" + n + "]");
        }

        /// <summary>
        /// Gets the Apprentice ID from the table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        /// <returns></returns>
        public string Table_ApprenticeID_Txt(int n)
        {
            string temp = Selenium.Driver.GetText(Table_ApprenticeNameLnk[n], "Table_ApprenticeNameLnk[" + n + "]");
            string[] Apprentice_Name_ID = temp.Split('(');
            string[] Apprentice_ID_Temp = Apprentice_Name_ID[1].Split('(');
            string[] Apprentice_ID = Apprentice_Name_ID[1].Split(')');
            return Apprentice_ID[0];
        }

        /// <summary>
        /// Clicks on the apprentice name from the table, for the given row index number
        /// </summary>
        /// <param name="n"></param>
        public void Table_ApprenticeNameID_ClickLnk (int n)
        {
            Selenium.Driver.Click(Table_ApprenticeNameLnk[n], "Table_ApprenticeNameLnk[" + n + "]");
        }

        /// <summary>
        /// Gets the status of the apprentice, the given row number 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string Table_Status_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_StatusTxt[n], "Table_StatusTxt[" + n + "]");
        }

        /// <summary>
        /// Sends text into 'From date' input field
        /// </summary>
        /// <param Input text="n"></param>
        /// <param list index="m"></param>
        public void Table_FromDate_Input(string n, int m)
        {
             Selenium.Driver.SendKeys(Table_FromDateinput[m], n, "Table_FromDateinput[" + n + "]");
        }

        /// <summary>
        /// Sends text into 'To date' input field
        /// </summary>
        /// <param Input text="n"></param>
        /// <param list index="m"></param>
        public void Table_ToDate_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_ToDateinput[m], n, "Table_ToDateinput[" + n + "]");
        }

        /// <summary>
        /// Inputs RSI Paid hours in the table, for the give row number
        /// </summary>
        /// <param RSI Paid Hours="n"></param>
        /// <param Row Number="m"></param>
        public void Table_RSIPaid_Input(string n, int m )
        {
            Selenium.Driver.SendKeys(Table_RSIPaidInput[m], n , "Table_RSIPaidInput[" + m + "]");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Inputs RSI Unpaid hours in the table, for the give row number
        /// </summary>
        /// <param RSI Unpaid Hours="n"></param>
        /// <param Row Number="m"></param>
        public void Table_RSIUnPaid_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_RSIUnPaidInput[m], n, "Table_RSIUnPaidInput[" + m + "]");
        }

        /// <summary>
        /// Inputs OJT hours in the table, for the give row number
        /// </summary>
        /// <param OJT Hours="n"></param>
        /// <param Row Number="m"></param>
        public void Table_OJT_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_OJTInput[m], n, "Table_OJTInput[" + m + "]");
        }

        /// <summary>
        /// Clicks on the expand Expand All button in tabe header
        /// </summary>
        /// <param Row number="n"></param>
        public void TableHeader_ExpandAll_Btn()
        {
            Selenium.Driver.Click(TableHeader_ExpandAllBtn, "TableHeader_ExpandAllBtn");
        }

        /// <summary>
        /// Clicks on the expand hours history button, of the given row number
        /// </summary>
        /// <param Row number="n"></param>
        public void Table_Expand_ClickBtn(int n)
        {
            Selenium.Driver.Click(Table_HistoryExpandBtn[n], "Table_HistoryExpandBtn[" + n + "]");
        }

        /// <summary>
        /// Clicks on the minimize hours history button, of the given row number
        /// </summary>
        /// <param Row number="n"></param>
        public void Table_Shrink_ClickBtn(int n)
        {
            Selenium.Driver.Click(Table_HistoryShrinkBtn[n], "Table_HistoryShrinkBtn[" + n + "]");
        }

        /// <summary>
        /// Clicks on the submit button 
        /// </summary>
        public void Submit_ClickBtn()
        {
            Thread.Sleep(3000);
            Selenium.Driver.Click(SubmitBtn, "SubmitBtn");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Gets the report hours error message
        /// </summary>
        /// <returns></returns>
        public string ReportHoursMessage_Txt ()
        {
            return Selenium.Driver.GetText(ReportHoursErrorMessageTxt, "ReportHoursErrorMessageTxt");
        }
    }
}
