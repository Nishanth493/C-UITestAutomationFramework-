using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Navigation_To_Apprenticeship_Dashboard
{
    [TestClass]
    public class TwoStep_Verification : Base
    {

        [FindsBy(How = How.CssSelector, Using = "#continueButton")]

        public IWebElement ContinuerBtn { get; set; }

        public void Continuer_Btn()
        {
            Selenium.Driver.Click(ContinuerBtn, "ContinuerBtn");
        }
    }
}
