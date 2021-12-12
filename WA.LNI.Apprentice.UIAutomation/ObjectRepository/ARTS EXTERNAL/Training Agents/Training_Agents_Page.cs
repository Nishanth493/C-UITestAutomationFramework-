using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Training_Agents
{
    public class Training_Agents_Page : Base
    {
        [FindsBy(How = How.Id, Using = "totalEmployerCount")]
        public IWebElement TrainingAgentsCountTxt { get; set; }

        [FindsBy(How = How.Id, Using = "filterBytrainingAgent")]
        public IWebElement SearchTrainingAgentInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='lni-c-button --small lni-u-ml2 --control lnicon--search']")]
        public IWebElement SearchTrainingAgentBtn { get; set; }

        [FindsBy(How = How.LinkText, Using = "Add a Training Agent")]
        public IWebElement AddTrainingAgentLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//ul[@class='lni-training-agents lni-u-mb4 lni-o-cell--12of12']/li/span[2]")]
        public IList<IWebElement> TAListTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//button[@class='lni-u-cursor-pointer app-show__details']")]
        public IList<IWebElement> ExpandOccupBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//ul[@class='pagination']//child::li/button")]
        public IList<IWebElement> PageNavigationBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//li[@class='employer-list']//li/span[1]")]
        public IList<IWebElement> OccupationListTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//li[@class='employer-list']//li/span/span")]
        public IList<IWebElement> OccupationStatusTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//li[@class='employer-list']//li/p")]
        public IList<IWebElement> OccupationEffectiveDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//li[@class='employer-list']//li/div/a")]
        public IList<IWebElement> ActivateOrDeactivateLnk { get; set; }

        [FindsBy(How = How.Id, Using = "effectiveDateToUpdateTrainingAgent")]
        public IWebElement Activate_PopUp_EffectivedateInput { get; set; }

        [FindsBy(How = How.Id, Using = "endDateToChangeStatus")]
        public IWebElement Activate_PopUp_EndDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "minutesDateToChangeStatus")]
        public IWebElement Activate_PopUp_MinutesDateInput { get; set; }

        [FindsBy(How = How.Id, Using = "submitTrainingAgentToChangeStatus")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement CancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/button[1]")]
        public IWebElement CloseBtn { get; set; }

        [FindsBy(How = How.Id, Using = "trainingAgentStatusErrorMessage")]
        public IWebElement TAStatusErrorMsgTxt { get; set; }


        public string TrainingAgentsCount_Txt()
        {
            string TACount_CompleteText = Selenium.Driver.GetText(TrainingAgentsCountTxt, "TrainingAgentsCountTxt");
            string SubSTring_TACount = TACount_CompleteText.Substring(Selenium.Driver.GetText(TrainingAgentsCountTxt, "TrainingAgentsCountTxt").Length - 5, 4);
            return SubSTring_TACount;
        }

        public void SearchTrainingAgent_Input(string n)
        {
            Selenium.Driver.DeleteTxt(SearchTrainingAgentInput, "SearchTrainingAgentInput");
            Selenium.Driver.SendKeys(SearchTrainingAgentInput, n, "SearchTrainingAgentInput");
        }

        public void SearchTrainingAgent_Btn()
        {
            Selenium.Driver.Click(SearchTrainingAgentBtn, "SearchTrainingAgentBtn");
            Thread.Sleep(3000);
        }

        public void AddTrainingAgent_Lnk()
        {
            Selenium.Driver.Click(AddTrainingAgentLnk, "AddTrainingAgentLnk");
        }

        public string TAListTable_Txt(int n)
        {
            string TAListID = Selenium.Driver.GetText(TAListTableTxt[n], "TrainingAgentsCountTxt");
            string SubSTring_TACount = TAListID.Substring(TAListID.Length - 10, 9);
            return SubSTring_TACount;
        }

        public void ExpandOccup_Btn(int n)
        {
            Selenium.Driver.Click(ExpandOccupBtn[n], "ExpandOccupBtn["+n+"]");
        }

        public void PageNavigation_Btn(int n)
        {
            Selenium.Driver.Click(PageNavigationBtn[n], "PageNavigationBtn[" + n + "]");
        }

        public string OccupationList_Txt(int n)
        {
            Selenium.Driver.GetText(OccupationListTxt[n], "PageNavigaOccupationListTxt[" + n + "]");

            string oldStr = Selenium.Driver.GetText(OccupationListTxt[n], "OccupationListTxt[" + n + "]");
            string newStrstr = oldStr.Trim();
            return newStrstr;
        }

        public string OccpuationStatusSearchTxt(string Occupation)
        {
            Thread.Sleep(3000);
            Selenium.Driver.Click(ExpandOccupBtn[0], "ExpandOccupBtn[" + 0 + "]");
            Thread.Sleep(3000);

            string status = "";

            for (int i = 0; i < OccupationListTxt.Count; i++)
            {
                string oldStr = Selenium.Driver.GetText(OccupationListTxt[i], "OccupationListTxt[" + i + "]");
                string newStrstr = oldStr.Trim();
                string[] OccupSplitName = newStrstr.Split('(');
                string FinalOccupName = OccupSplitName[0].Trim();

                if (FinalOccupName == Occupation)
                {
                  status = Selenium.Driver.GetText(OccupationStatusTxt[i], "OccupationStatusTxt[" + i + "]");
                }
            }
            return status;
        }


        public string OccupationStatus_Txt(int n)
        {
            return Selenium.Driver.GetText(OccupationStatusTxt[n], "OccupationStatusTxt[" + n + "]");
        }

        public void Find_InActive_Occupation (string TrainingAgnetId, string OccupationName, string EffectiveDate, string MinuteDate)
        {
            Selenium.Driver.SendKeys(SearchTrainingAgentInput, TrainingAgnetId, "SearchTrainingAgentInput");
            Thread.Sleep(3000);

            Selenium.Driver.Click(SearchTrainingAgentBtn, "SearchTrainingAgentBtn");
            Thread.Sleep(3000);
            Selenium.Driver.Click(ExpandOccupBtn[0], "ExpandOccupBtn[" + 0 + "]");
            Thread.Sleep(3000);

            for (int i = 0; i < OccupationListTxt.Count ; i++)
            {
                string oldStr = Selenium.Driver.GetText(OccupationListTxt[i], "PageNavigaOccupationListTxt[" + i + "]");
                string newStrstr = oldStr.Trim();
                string[] OccupSplitName = newStrstr.Split('(');
                string FinalOccupName = OccupSplitName[0].Trim();

                if (FinalOccupName == OccupationName && Selenium.Driver.GetText(OccupationStatusTxt[i], "OccupationStatusTxt") == "(Inactive)")
                {
                    Selenium.Driver.Click(ActivateOrDeactivateLnk[i], "ActivateOrDeactivateLnk[" + i + "]");
                    Selenium.Driver.SendKeys(Activate_PopUp_EffectivedateInput, EffectiveDate, "Activate_PopUp_EffectivedateInput");
                    Selenium.Driver.SendKeys(Activate_PopUp_MinutesDateInput, MinuteDate, "Activate_PopUp_MinutesDateInput");
                    Selenium.Driver.Click(SubmitBtn, "SubmitBtn");
                    return;
                }
                Thread.Sleep(5000);
                /*else
                {
                    throw new System.Exception("The Occupation is Acive");
                }*/
            }
        }

        public void ActivateOrDeactivate_Lnk(int n)
        {
            Selenium.Driver.Click(ActivateOrDeactivateLnk[n], "ActivateOrDeactivateLnk[" + n + "]");
        }

        public void Activate_PopUp_Effectivedate_Input(string m)
        {
            Selenium.Driver.SendKeys(Activate_PopUp_EffectivedateInput, m, "Activate_PopUp_EffectivedateInput");
        }

        public void Activate_PopUp_EndDate_Input(string m)
        {
            Selenium.Driver.SendKeys(Activate_PopUp_EndDateInput, m, "Activate_PopUp_EndDateInput");
        }

        public void Activate_PopUp_MinutesDate_Input(string m)
        {
            Selenium.Driver.SendKeys(Activate_PopUp_MinutesDateInput, m, "Activate_PopUp_MinutesDateInput");
        }

        public void Submit_Btn()
        {
            Selenium.Driver.Click(SubmitBtn, "SubmitBtn");
        }

        public void Cancel_Btn()
        {
            Selenium.Driver.Click(CancelBtn, "CancelBtn");
        }

        public void Close_Btn()
        {
            Selenium.Driver.Click(CloseBtn, "CloseBtn");
        }

        /// <summary>
        /// Status Changed Successfully.
        /// </summary>
        /// <returns></returns>
        public string TAStatusErrorMsg_Txt()
        {
            return Selenium.Driver.GetText(TAStatusErrorMsgTxt, "TAStatusErrorMsgTxt");
        }

    }
}
