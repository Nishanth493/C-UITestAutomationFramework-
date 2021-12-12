using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Ready_for_Completion
{
    public class ActionItems_ReadyForCompletion_Page :Base
    {

        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement Navigation_BackToProgramOverview { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Apprentice Ready for Completion')]")]
        public IWebElement PageHeadingTxt { get; set; }

        [FindsBy(How = How.Id, Using = "effectiveDateForCompletion")]
        public IWebElement EffectiveDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "minutesDateForCompletion")]
        public IWebElement MinutesDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[1]/span")]
        public IList<IWebElement> Table_ApprenticeIDTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[2]/span")]
        public IList<IWebElement> Table_BeginDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[3]//child::input")]
        public IList<IWebElement> Table_FinalHoursInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[4]//child::input")]
        public IList<IWebElement> Table_EffectiveDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[5]//child::input")]
        public IList<IWebElement> Table_MinutesDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[6]/span")]
        public IList<IWebElement> Table_RemoverBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//tr/span")]
        public IList<IWebElement> Table_ErrorMessageTxt { get; set; }

        [FindsBy(How = How.Id, Using = "submitReadyForCompletion")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "readyForCompletionErrorMessage")]
        public IWebElement ApprenticeCompletionMessageTxt { get; set; }

        /// <summary>
        /// Clicks on Navigation link, back to overview page 
        /// </summary>
        public void NavigationBackToOverview_Lnk()
        {
            Thread.Sleep(3000);
            Selenium.Driver.Click(Navigation_BackToProgramOverview, "Navigation_BackToProgramOverview");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Gets the page heading text 
        /// </summary>
        public string PageHeading_txt()
        {
            return Selenium.Driver.GetText(PageHeadingTxt, "PageHeadingTxt");
        }

        /// <summary>
        /// Enters the Effective Date, which autofills the table
        /// </summary>
        /// <param Effective Date="n"></param>
        public void EffectiveDate_Input(string n)
        {
            Selenium.Driver.SendKeys(EffectiveDateInput, n, "EffectiveDateInput");
        }

        /// <summary>
        /// Enters the Effective Date, which autofills the table
        /// </summary>
        /// <param Effective Date="n"></param>
        public void MinutesDate_Input(string n)
        {
            Selenium.Driver.SendKeys(MinutesDateInput, n, "MinutesDateInput");
        }

        /// <summary>
        /// Gets the apprentice Name (ID) values from the table, when row numbe is given
        /// </summary>
        /// <param Row Number="n"></param>
        /// <returns>Apprentice Name/ID</returns>
        public string Table_ApprenticNameID_txt(int n)
        {
            return Selenium.Driver.GetText(Table_ApprenticeIDTxt[n], "Table_ApprenticeIDTxt["+n+"]");
        }

        /// <summary>
        /// Returns only the apprentice ID, for the given row number
        /// </summary>
        /// <param Row Number="n"></param>
        /// <returns>Apprentice ID</returns>
        public string Table_ApprenticeID_Txt(int n)
        {
            string temp = Selenium.Driver.GetText(Table_ApprenticeIDTxt[n], "Table_ApprenticeIDTxt[" + n + "]");
            string[] Apprentice_Name_ID = temp.Split('(');
            string[] Apprentice_ID_Temp = Apprentice_Name_ID[1].Split('(');
            string[] Apprentice_ID = Apprentice_Name_ID[1].Split(')');
            return Apprentice_ID[0];
        }

        /// <summary>
        /// Gets the begin date value from the table, from the given row 
        /// </summary>
        /// <param Row Number="m"></param>
        /// <returns>Begin Date String</returns>
        public string Table_BeginDate_txt(int n)
        {
            return Selenium.Driver.GetText(Table_BeginDateTxt[n], "Table_BeginDateTxt[" + n + "]");
        }

        /// <summary>
        /// Enters the Final Hours, to the given row 
        /// </summary>
        /// <param Row Number ="n"></param>
        /// <param Effective Date ="m"></param>
        public void Table_FinalHours_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(Table_FinalHoursInput[n], m, "Table_FinalHoursInput[" + n + "]");
        }

        /// <summary>
        /// Enters the Effective Date, to the given row 
        /// </summary>
        /// <param Row Number ="n"></param>
        /// <param Effective Date ="m"></param>
        public void Table_EffectiveDate_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(Table_EffectiveDateInput[n], m, "Table_EffectiveDateInput["+n+"]");
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
        /// Selects 'Remove' button to delete a row, for a given row number 
        /// </summary>
        /// <param Row Number="n"></param>
        public void Table_Remove_Btn(int n)
        {
            Selenium.Driver.Click(Table_RemoverBtn[n], "Table_RemoverBtn[" + n + "]");
        }

        /// <summary>
        /// Gets the error message, from the given row 
        /// </summary>
        /// <param Row Number="m"></param>
        /// <returns>Begin Date String</returns>
        public string Table_ErrorMessage_txt(int n)
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
        public string ApprenticeCompletionMessage_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeCompletionMessageTxt, "ApprenticeCompletionMessageTxt");
        }



    }
}
