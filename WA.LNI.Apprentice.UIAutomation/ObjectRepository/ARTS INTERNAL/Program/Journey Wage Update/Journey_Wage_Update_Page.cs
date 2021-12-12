using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Program.Journey_Wage_Update
{
    public class Journey_Wage_Update_Page : Base
    {

        [FindsBy(How = How.CssSelector, Using = "#pgmId")]
        public IWebElement ProgramIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@label= 'Search']")]
        public IWebElement SearchBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Occupation Name:')]")]
        public IList<IWebElement> OccupationsListTxt{ get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Occupation Name:')]//following::label[text() = 'Latest Wage Amount:']//following::label[1]")]
        public IList<IWebElement> OccupationsLatestWageAmountTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Occupation Name:')]//following::label[text() = 'Last Wage Created:']//following::label[1]")]
        public IList<IWebElement> OccupationsLastWageCreatedTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Occupation Name:')]//following::label[text() = 'Lastest Wage Effective Date:']//following::label[1]")]
        public IList<IWebElement> OccupationsLastWageEffectiveDatetTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Occupation Name:')]//following::label[text() = 'New Wage: ']//following::input[1]")]
        public IList<IWebElement> OccupationsNewWageAmountInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Occupation Name:')]//following::label[text() = 'Effective Date: ']//following::input[1]")]
        public IList<IWebElement> OccupationsEffectiveDateInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//button[@label='Add']")]
        public IList<IWebElement> OccupationsAddBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-growl-icon-close fa fa-close')]//following::span[2]")]
        public IWebElement ConformationMessageTxt { get; set; }

        public void ProgramID_Input(string n)
        {
            Selenium.Driver.SendKeys(ProgramIDInput, n, "ProgramIDInput");
        }
        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
        }

        public string OccupationsList_Txt(int n)
        {
            string occupation = Selenium.Driver.GetText(OccupationsListTxt[n], "OccupationsListTxt["+n+"]");
            return (occupation.Split(':')[1]).Trim();
        }

        public string OccupationsLatestWageAmount_Txt(int n)
        {
            return Selenium.Driver.GetText(OccupationsLatestWageAmountTxt[n], "OccupationsLatestWageAmountTxt[" + n + "]");
        }

        public string OccupationsLastWageCreated_Txt(int n)
        {
            return Selenium.Driver.GetText(OccupationsLastWageCreatedTxt[n], "OccupationsLastWageCreatedTxt[" + n + "]");
        }

        public string OccupationsLastWageEffectiveDatet_Txt(int n)
        {
            return Selenium.Driver.GetText(OccupationsLastWageEffectiveDatetTxt[n], "OccupationsLastWageEffectiveDatetTxt[" + n + "]");
        }

        public void OccupationsNewWageAmount_Input(int n, string Amt)
        {
            Selenium.Driver.SendKeys(OccupationsNewWageAmountInput[n], Amt,"OccupationsNewWageAmountInput[" + n + "]");
        }

        public void OccupationsEffectiveDate_Input(int n, string Date)
        {
            Selenium.Driver.SendKeys(OccupationsEffectiveDateInput[n], Date,"OccupationsEffectiveDateInput[" + n + "]");
        }

        public void OccupationsAdd_Btn(int n)
        {
            Selenium.Driver.Click(OccupationsAddBtn[n], "OccupationsAddBtn[" + n + "]");
        }

        public string ConformationMessage_Txt()
        {
            return Selenium.Driver.GetText(ConformationMessageTxt, "ConformationMessageTxt");
        }
    }
}