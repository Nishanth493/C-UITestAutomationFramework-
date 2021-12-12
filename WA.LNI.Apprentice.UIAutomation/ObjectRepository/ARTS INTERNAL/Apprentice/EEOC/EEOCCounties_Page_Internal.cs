using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;
using System;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.EEOC
{
    public class EEOCCounties_Page_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ng-tns-c4-64 ui-dropdown ui-widget ui-state-default ui-corner-all ui-helper-clearfix ui-dropdown-open')]")]
        public IWebElement SelectYearBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'font-weight-bold')]//following::ul/li/span")]
        public IList<IWebElement> SelectYearDrpDwn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::table/tbody/tr/td[1]/span")]
        public IList<IWebElement> CountyCodeTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::table/tbody/tr/td[2]/span")]
        public IList<IWebElement> CountyNameTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::table/tbody/tr/td[3]/span/p-inputmask/input")]
        public IList<IWebElement> LaborForceCountInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::table/tbody/tr/td[4]/span/p-inputmask/input")]
        public IList<IWebElement> MinorityCountInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::table/tbody/tr/td[5]/span")]
        public IList<IWebElement> MinorityPercentTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::table/tbody/tr/td[6]/span/p-inputmask/input")]
        public IList<IWebElement> WomenCountInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-g-12 ui-md-12 ui-sm-12')]//child::table/tbody/tr/td[7]/span")]
        public IList<IWebElement> WomenPercentTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@type,'button')]")]
        public IWebElement SaveBtn { get; set; }

        public void SelectYear_DrpDwn(int n)
        {
            Selenium.Driver.Click(SelectYearBtn, "SelectYearBtn");

            Selenium.Driver.Click(SelectYearDrpDwn[n], "SelectYearDrpDwn[" + n + "]");
        }

        public string CountyCode_Txt(int n)
        {
            return Selenium.Driver.GetText(CountyCodeTxt[n], "CountyCodeTxt"+n+"]");
        }

        public string CountyName_Txt(int n)
        {
            return Selenium.Driver.GetText(CountyNameTxt[n], "CountyNameTxt"+n+"]");
        }

        public void LaborForceCount_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(LaborForceCountInput[n], m, "LaborForceCountInput" + n + "]");
        }

        public void MinorityCount_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(MinorityCountInput[n], m, "MinorityCountInput" + n + "]");
        }

        public string MinorityPercent_Txt(int n)
        {
            return Selenium.Driver.GetText(MinorityPercentTxt[n], "MinorityPercentTxt" + n + "]");
        }

        public void WomenCount_Input(int n, string m)
        {
            Selenium.Driver.SendKeys(WomenCountInput[n], m, "WomenCountInput" + n + "]");
        }

        public string WomenPercent_Txt(int n)
        {
            return Selenium.Driver.GetText(WomenPercentTxt[n], "WomenPercentTxt" + n + "]");
        }
        public void Save_Btn()
        {
            Selenium.Driver.Click(SaveBtn, "SaveBtn");
        }
    }
}
