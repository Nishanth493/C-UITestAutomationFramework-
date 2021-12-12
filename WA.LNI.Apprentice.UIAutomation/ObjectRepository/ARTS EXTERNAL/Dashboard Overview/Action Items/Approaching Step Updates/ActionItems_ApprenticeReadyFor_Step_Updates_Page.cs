using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;


namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Action_Items.Approaching_Step_Updates
{
    public class ActionItems_ApprenticeReadyFor_Step_Updates_Page : Base
    {
        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement Navigation_BackToProgramOverview { get; set; }

        [FindsBy(How = How.Id, Using = "approachingEffDate")]
        public IWebElement EffectiveDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "approachingMinutesDate")]
        public IWebElement MinutesDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[1]/a")]
        public IList<IWebElement> Table_ApprenticeNameIDTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[2]/span")]
        public IList<IWebElement> Table_CurrentStepTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[3]/span")]
        public IList<IWebElement> Table_TotalOJTHrsTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[4]//input")]
        public IList<IWebElement> Table_NewStepInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[5]//input")]
        public IList<IWebElement> Table_EffectiveDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[6]//input")]
        public IList<IWebElement> Table_MinutesDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//child::td[7]/span")]
        public IList<IWebElement> Table_RemoveBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@class='lni-c-table']//tbody/tr/span")]
        public IList<IWebElement> Table_ErrorMessageTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#submitUpdateStepsFromTable")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "showStepUpdateErrorMessage")]
        public IWebElement ApproachingStepUpdateMessageTxt { get; set; }

        /// <summary>
        /// Click on Navigation Link to back to 'Overview' page 
        /// </summary>
        public void Navigation_BackToOverView_Lnk()
        {
            Selenium.Driver.Click(Navigation_BackToProgramOverview, "Navigation_BackToProgramOverview");
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
        /// Enters the minutes date, which autofills the table
        /// </summary>
        /// <param Minutes Date ="n"></param>
        public void MinutesDate_Input(string n)
        {
            Selenium.Driver.SendKeys(MinutesDateInput, n, "MinutesDateInput");
        }

        /// <summary>
        /// Gets the apprentice Name (ID) values from the table, when row numbe is given
        /// </summary>
        /// <param Row Number ="n"></param>
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
        }

        /// <summary>
        /// Gets the Current Step Number values from the table, when row numbe is given
        /// </summary>
        /// <param Row Number ="n"></param>
        public string Table_CuurentStepNumber_Txt(int n)
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
            string CurrentStep =Table_CuurentStepNumber_Txt(m);

            int temp = ((Int32.Parse(CurrentStep)) +1) ;

            string NewStep = Convert.ToString(temp);

            Selenium.Driver.SendKeys(Table_NewStepInput[m], NewStep, "Table_NewStep_Input[" + m + "]");
        }

        /// <summary>
        /// Inputs New Step Number for an apprentice, in the given row
        /// </summary>
        /// <param New Step Number="n"></param>
        /// <param Row Number="m"></param>
        public string Table_Single_Increment_NewStep_Txt(int m)
        {
            string CurrentStep = Table_CuurentStepNumber_Txt(m);

            int temp = ((Int32.Parse(CurrentStep)) + 1);

            string NewStep = Convert.ToString(temp);

            return NewStep;
        }

        public void Table_Single_Decrement_NewStep_Input(int m)
        {
            string CurrentStep = Table_CuurentStepNumber_Txt(m);

            int temp = ((Int32.Parse(CurrentStep)) - 1);

            string NewStep = Convert.ToString(temp);

            Selenium.Driver.SendKeys(Table_NewStepInput[m], NewStep, "Table_NewStep_Input[" + m + "]");
        }

        /// <summary>
        /// Automatically inputs New Step Number(+1) for all the apprentices, in the current page 
        /// </summary>
        /// <param New Step Number="n"></param>
        /// <param Row Number="m"></param>
        public void Table_Input_All_New_Steps()
        {
            int CurrentStep_Length = Table_CurrentStepTxt.Count;
            int temp;

            for (int i = 0; i < CurrentStep_Length; i++)
            {
                temp = (Int32.Parse(Table_CuurentStepNumber_Txt(i)) +1);

                string NewStep = Convert.ToString(temp);

                Selenium.Driver.SendKeys(Table_NewStepInput[i], NewStep, "Table_NewStep_Input[" + i + "]");
            }      
        }

        /// <summary>
        /// Inputs New Step Number for an apprentice, in the given row
        /// </summary>
        /// <param New Step Number="n"></param>
        /// <param Row Number="m"></param>
        public void Table_NewStep_Input(string n, int m)
        {
            
            Selenium.Driver.SendKeys(Table_NewStepInput[m], n, "Table_NewStep_Input[" + m + "]");
        }

        /// <summary>
        /// Gets the total OJT hours, from the given row 
        /// </summary>
        /// <param Row Number ="n"></param>
        /// <param Selection RSI or OJT ="m"></param>
        /// <returns>RSI or OJT</returns>
        public string Table_TotalOJTHrs_Txt(int n, string m)
        {
            return Selenium.Driver.GetText(Table_TotalOJTHrsTxt[n], "Table_TotalOJTHrsTxt[" + n + "]");

            /*
            string Hours_Full = Selenium.Driver.GetText(Table_NewStepInput[n], "Table_NewStep_Input[" + n + "]");
            string[] Hours_Seperate = Hours_Full.Split('/');
            m = m.ToLower();

            if (m == "ojt")
            {
                m = Hours_Seperate[0];
            }

            else if (m == "rsi")
            {
                m = Hours_Seperate[1];
            }
            return m;
            */
        }

        /// <summary>
        /// Enters the effective date, to the given row 
        /// </summary>
        /// <param Effective Date="n"></param>
        /// <param Row Number="m"></param>
        public void Table_EffectiveDate_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_EffectiveDateInput[m], n, "Table_EffectiveDateInput" + m + "]");
        }

        /// <summary>
        /// Enters the Minutes date, to the given row 
        /// </summary>
        /// <param Minutes Date = "n"></param>
        /// <param Row Num = "m"></param>
        public void Table_MinutesDate_Input(string n, int m)
        {
            Selenium.Driver.SendKeys(Table_MinutesDateInput[m], n, "Table_MinutesDateInput" + m + "]");
        }

        /// <summary>
        /// Selects 'Remove' button to delete a row, for a given row number 
        /// </summary>
        /// <param Row Number = "n"></param>
        public void Table_Remove_Btn(int n)
        {
            Selenium.Driver.Click(Table_RemoveBtn[n], "Table_RemoveBtn[" + n + "]");
        }

        /// <summary>
        /// Selects 'Remove' button to delete a row, for a given row number 
        /// </summary>
        /// <param Row Number = "n"></param>
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
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Gets the error message on submission 
        /// </summary>
        /// <returns>Message</returns>
        public string ApproachingStepUpdateMessage_Txt()
        {
            return Selenium.Driver.GetText(ApproachingStepUpdateMessageTxt, "ApproachingStepUpdateMessageTxt");
        }
    }
}
