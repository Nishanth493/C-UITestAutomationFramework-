using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.Step_Update
{
    public class ApprenticeReadyTo_Step_Update_Page : Base
    {
        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement NavigationBackToOverviewLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Apprentice Ready to Update Steps')]")]
        public IWebElement PageHeadingTxt { get; set; }

        [FindsBy(How = How.Id, Using = "usProgramSelect")]
        public IWebElement SelectProgramDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "usFirstName")]
        public IWebElement SearchFirstNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "usLastName")]
        public IWebElement SearchLastNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "usApprenticeId")]
        public IWebElement SearchApprenticeIDInput { get; set; }

        [FindsBy(How = How.Id, Using = "statusToUpdateSteps")]
        public IWebElement SearchStatusDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "usOccupation")]
        public IWebElement SearchOccupationDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "sBeginDateFrom")]
        public IWebElement BeginFromDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "sBeginDateTo")]
        public IWebElement BeginToDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "clearSearchToUs")]
        public IWebElement ResetBtn { get; set; }

        [FindsBy(How = How.Id, Using = "searchToUpdateSteps")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.Id, Using = "stepEffectiveDate")]
        public IWebElement EffectiveDateDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "stepMinutesDate")]
        public IWebElement MinutesDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='lni-c-button --small --control lni-u-ml7 lni-u-fl autofill-dates']")]
        public IWebElement AutoFillBtn { get; set; }

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
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[2]/span")]
        public IList<IWebElement> Table_StatusTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[3]/span")]
        public IList<IWebElement> Table_CurrentStepTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[4]//child::input")]
        public IList<IWebElement> Table_NewStepInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[5]//child::input")]
        public IList<IWebElement> Table_EffectiveDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[6]//child::input")]
        public IList<IWebElement> Table_MinutesDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[7]/button[1]")]
        public IList<IWebElement> Table_HistoryExpandBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::tr/td[7]/button[2]")]
        public IList<IWebElement> Table_HistoryShrinkBtn { get; set; }

        [FindsBy(How = How.Id, Using = "submitStepUpdate")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "updateStepsMessage")]
        public IWebElement StepUpdateErrorMessageTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//thead/tr/th/button")]
        public IWebElement TableHeader_ExpandAllBtn { get; set; }

        /// <summary>
        /// Clicks on back to program overview page link 
        /// </summary>
        public void NavigationBackToOverview_Lnk()
        {
            Selenium.Driver.Click(NavigationBackToOverviewLnk, "NavigationBackToOverviewLnk");
        }

        /// <summary>
        /// Selects Program from the DropDown by inputting the Program ID 
        /// </summary>
        /// <param Row Number="n"></param>
        public void SelectProgram_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(SelectProgramDrpDwn, n, "SelectProgramDrpDwn");
        }

        /// <summary>
        /// Gets the page heading text
        /// </summary>
        public string PageHeading_Txt()
        {
            return Selenium.Driver.GetText(PageHeadingTxt, "PageHeadingTxt");
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
        }

        /// <summary>
        /// Select Occupation from the dropdown, by inputting dropdown value
        /// </summary>
        /// <param Status drop down value="n"></param>
        public void SearchOccupation_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(SearchOccupationDrpDwn, n, "SearchOccupationDrpDwn");
        }
       
        /// <summary>
        /// Enters the Begin From Date, to auto fill all the dates 
        /// </summary>
        /// <param From Date="n"></param>
        public void BeginFromDate_Input(string n)
        {
            Selenium.Driver.SendKeys(BeginFromDateInput, n, "FromDateInput");
        }

        /// <summary>
        /// Enters the Begin To Date, to auto fill all the dates 
        /// </summary>
        /// <param To Date="n"></param>
        public void BeginToDate_Input(string n)
        {
            Selenium.Driver.SendKeys(BeginToDateInput, n, "ToDateInput");

        }

        /// <summary>
        /// Clicks on the 'Reset' button
        /// </summary>
        public void Reset_Btn()
        {
            Thread.Sleep(1000);
            Selenium.Driver.Click(ResetBtn, "ResetBtn");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Clicks on the 'Search" button 
        /// </summary>
        public void Search_Btn()
        {
            Thread.Sleep(1000);
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
            Thread.Sleep(2000);
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
        /// returns the Apprentice ID and error message text by searcheing through all thr rows to check which apprentice row has error 
        /// </summary>
        public List<string> Table_ErrorMessageInfo_Status_Check_Txt()
        {
            string _ErrorTxt_Common_ = Selenium.Driver.GetText(StepUpdateErrorMessageTxt, "StepUpdateErrorMessageTxt");
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
        /// Enters the Effective Date, to auto fill all the dates 
        /// </summary>
        /// <param Effective Date="n"></param>
        public void EffectiveDateDate_Input(string n)
        {
            Selenium.Driver.SendKeys(EffectiveDateDateInput, n, "EffectiveDateDateInput");
        }

        /// <summary>
        /// Enters the Minutes Date, to auto fill all the dates 
        /// </summary>
        /// <param Minutes Date="n"></param>
        public void MinutesDate_Input(string n)
        {
            Selenium.Driver.SendKeys(MinutesDateInput, n, "MinutesDateInput");
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
        /// Gets the Apprentice Name (ID) from teh table, for the given index number 
        /// </summary>
        /// <param Row number="n"></param>
        /// <returns>Apprentice Name (ID)</returns>
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
        /// <param Row Number="n"></param>
        public void Table_ApprenticeNameID_ClickLnk(int n)
        {
            Selenium.Driver.Click(Table_ApprenticeNameLnk[n], "Table_ApprenticeNameLnk[" + n + "]");
        }

        /// <summary>
        /// Gets the status of the apprentice, the given row number 
        /// </summary>
        /// <param Row Number="n"></param>
        /// <returns>Status Text</returns>
        public string Table_Status_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_StatusTxt[n], "Table_StatusTxt[" + n + "]");
        }


        /// <summary>
        /// Gets the cuurent step number of the apprentice, the given row number
        /// </summary>
        /// <param Row Number="n"></param>
        /// <returns>Step Number Text</returns>
        public string Table_CurrentStep_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_CurrentStepTxt[n], "Table_CurrentStepTxt[" + n + "]");
        }

        /// <summary>
        /// Inputs New Step Number for an apprentice, in the given row
        /// </summary>
        /// <param New Step Number="n"></param>
        /// <param Row Number="m"></param>
        public void Table_Single_Increment_NewStep_Input(int m)
        {
            string CurrentStep = Table_CurrentStep_Txt(m);

            int temp = ((Int32.Parse(CurrentStep)) + 1);

            string NewStep = Convert.ToString(temp);

            Selenium.Driver.SendKeys(Table_NewStepInput[m], NewStep, "Table_NewStep_Input[" + m + "]");
        }

        /// <summary>
        /// Inputs New Step Number for an apprentice, in the given row
        /// </summary>
        /// <param New Step Number="n"></param>
        /// <param Row Number="m"></param>
        public void Table_Single_decrement_NewStep_Input(int m)
        {
            string CurrentStep = Table_CurrentStep_Txt(m);

            int temp = ((Int32.Parse(CurrentStep)) - 1);

            string NewStep = Convert.ToString(temp);

            Selenium.Driver.SendKeys(Table_NewStepInput[m], NewStep, "Table_NewStep_Input[" + m + "]");
        }

        /// <summary>
        /// Inputs the new step number for the apprentice, in the given row number        
        /// </summary>
        /// <param New Step Number="n"></param>
        /// <param Row Number="m"></param>
        public void Table_NewStep_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_NewStepInput[m], n, "Table_NewStep_Input[" + m + "]");
        }

        /// <summary>
        /// Inputs the effective date, for the give row number 
        /// </summary>
        /// <param Effective Date ="n"></param>
        /// <param Row Number ="m"></param>
        public void Table_EffectiveDate_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_EffectiveDateInput[m], n, "Table_EffectiveDateInput" + m + "]");
        }

        /// <summary>
        /// Inputs the Minutes date, for the give row number 
        /// </summary>
        /// <param Minutes Date ="n"></param>
        /// <param Row Number ="m"></param>
        public void Table_MinutesDate_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_MinutesDateInput[m], n, "Table_MinutesDateInput" + m + "]");
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
        /// Clicks on the expand hours history button, of the given row number
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
            Selenium.Driver.Click(SubmitBtn, "SubmitBtn");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Gets the Update Steps error message
        /// </summary>
        /// <returns>Error Message String</returns>
        public string StepUpdateMessage_Txt()
        {
            return Selenium.Driver.GetText(StepUpdateErrorMessageTxt, "StepUpdateMessageTxt");
        }

        /// <summary>
        /// Clicks on the expand Expand All button in tabe header
        /// </summary>
        /// <param Row number="n"></param>
        public void TableHeader_ExpandAll_Btn()
        {
            Selenium.Driver.Click(TableHeader_ExpandAllBtn, "TableHeader_ExpandAllBtn");
        }



    }
}
