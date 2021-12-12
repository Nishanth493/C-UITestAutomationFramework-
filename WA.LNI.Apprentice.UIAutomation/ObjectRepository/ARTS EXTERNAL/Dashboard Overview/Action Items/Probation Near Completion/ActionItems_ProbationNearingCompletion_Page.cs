using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;


namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Probation_Near_Completion
{
    public class ActionItems_ProbationNearingCompletion_Page : Base
    {
        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement Navigation_BackToProgramOverview { get; set; }

        [FindsBy(How = How.Id, Using = "probationMinutesDate")]
        public IWebElement MinutesDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "probationCompletionDate")]
        public IWebElement CompletionDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[1]/a")]
        public IList<IWebElement> Table_ApprenticeNameIDTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[2]/span")]
        public IList<IWebElement> Table_BeginDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[4]//input")]
        public IList<IWebElement> Table_MinutesDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[5]//input")]
        public IList<IWebElement> Table_CompletionDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[6]/span")]
        public IList<IWebElement> Table_RemoveBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[5]//following::span[1]")]
        public IList<IWebElement> Table_ErrorMessageTxt { get; set; }

        [FindsBy(How = How.Id, Using = "submitProbationUpdate")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "probationUpdateErrorMessage")]
        public IWebElement ProbationCompletionMessageTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//ul[@class='pagination']//li/button")]
        public IList<IWebElement> PageNavigationBtn { get; set; }

        /// <summary>
        /// Clicks on Navigation link, back to overview page 
        /// </summary>
        public void Navigation_BackToOverView_Lnk()
        {
            Selenium.Driver.Click(Navigation_BackToProgramOverview, "Navigation_BackToProgramOverview");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Enters the Minutes Date, which autofills the table
        /// </summary>
        /// <param Effective Date="n"></param>
        public void MinutesDate_Input(string n)
        {
            Selenium.Driver.SendKeys(MinutesDateInput, n, "MinutesDateInput");
        }

        /// <summary>
        /// Enters the Completion Date, which autofills the table
        /// </summary>
        /// <param Completion Date ="n"></param>
        public void CompletionDate_Input(string n)
        {
            Selenium.Driver.SendKeys(CompletionDateInput, n, "CompletionDateInput");
        }

        /// <summary>
        /// Gets the apprentice Name (ID) values from the table, when row numbe is given
        /// </summary>
        /// <param Row Number="n"></param>
        /// <returns>Apprentice Name/ID</returns>
        public string Table_ApprenticeNameID_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_ApprenticeNameIDTxt[n], "Table_ApprenticeNameIDTxt[" + n + "]");
        }

        /// <summary>
        /// Returns only the apprentice ID, for the given row number
        /// </summary>
        /// <param Row Number="n"></param>
        /// <returns>Apprentice ID</returns>
        public string Table_ApprenticeID_Txt(int n)
        {
            string temp = Selenium.Driver.GetText(Table_ApprenticeNameIDTxt[n], "Table_ApprenticeNameIDTxt[" + n + "]");
            string[] Apprentice_Name_ID = temp.Split('(');
            string[] Apprentice_ID_Temp = Apprentice_Name_ID[1].Split('(');
            string[] Apprentice_ID = Apprentice_Name_ID[1].Split(')');
            return Apprentice_ID[0];
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Gets the begin date value from the table, from the given row 
        /// </summary>
        /// <param Row Number="m"></param>
        /// <returns>Begin Date String</returns>
        public string Table_Begindate_Txt(int m)
        {
            return Selenium.Driver.GetText(Table_BeginDateTxt[m], "Table_BeginDateTxt" + m + "]");
        }

        /// <summary>
        /// Enters the Minutes date, to the given row 
        /// </summary>
        /// <param Row Number ="n"></param>
        /// <param Minutes Date ="m"></param>
        public void Table_MinutesDate_Input(int n, string m)
        {
             Selenium.Driver.SendKeys(Table_MinutesDateInput[n], m, "Table_MinutesDateInput[" + n + "]");
        }

        /// <summary>
        ///  Enters the Completion date, to the given row
        /// </summary>
        /// <param Completion Date="n"></param>
        /// <param Row Number="m"></param>
        public void Table_Completion_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_CompletionDateTxt[m], n, "Table_CompletionDateTxt" + m + "]");
        }

        /// <summary>
        /// Selects 'Remove' button to delete a row, for a given row number 
        /// </summary>
        /// <param Row Number="n"></param>
        public void Table_Remove_Btn(int n)
        {
            Selenium.Driver.Click(Table_RemoveBtn[n], "Table_RemoveBtn[" + n + "]");
        }

        /// <summary>
        /// Gets error messages from each row, for a given row number 
        /// </summary>
        /// <param Row Number="n"></param>
        public string Table_ErrorMessage_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_ErrorMessageTxt[n], "Table_ErrorMessageTxt[" + n + "]");
        }


        /// <summary>
        /// Clicks on 'Submit' Button
        /// </summary>
        public void Submit_Btn()
        {
            Selenium.Driver.Click(SubmitBtn, "SubmitBtn");
        }

        /// <summary>
        /// Gets the error message on submission 
        /// </summary>
        /// <returns>Message</returns>
        public string ProbationCompletionMessage_Txt()
        {
            return Selenium.Driver.GetText(ProbationCompletionMessageTxt, "ProbationCompletionMessageTxt");
        }

        /// <summary>
        /// Clicks on the page number 
        /// </summary>
        public void PageNavigation_Btn(int n)
        {
            Selenium.Driver.Click(PageNavigationBtn[n], "PageNavigationBtn["+n+"]");
        }




    }
}
