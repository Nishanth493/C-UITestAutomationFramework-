using System;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Registration
{

    public class AppReg_EnterSSN_Page_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//h1[contains(@class,'ui-g-12 text-center')]")]
        public IWebElement ApprenticeRegTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'ui-autocomplete ui-widget ui-autocomplete-dd')]//button[contains(@type,'button')]")]
        public IWebElement ProgramNameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-autocomplete-panel ui-widget-content ui-corner-all ui-shadow')]//child::ul")]
        public IList<IWebElement> ProgramNameDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Type or Select Program Name')]")]
        public IWebElement ProgramNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'form-group row')]//div[2]//label[1]//following::input[1]")]
        public IWebElement ProgramIdInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Enter SSN:')]//following::input")]
        public IWebElement EnterSSNInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'ui-button-text ui-clickable')][contains(text(),'Find Apprentice')]")]
        public IWebElement FindApprenticeBtn { get; set; }

        /// <summary>
        /// Gets Apprentice Resgitration page Heading for verification
        /// </summary>
        /// <returns></returns>
        public string ApprenticeReg_Text()
        {
           return Selenium.Driver.GetText(ApprenticeRegTxt, "ApprenticeRegTxt");
        }

        /// <summary>
        /// Input Dropdown index value n to select a program from drop down 
        /// </summary>
        /// <param name="n"></param>
        public void ProgramName_SelectDrpDwn(int n)
        {
            Selenium.Driver.Click(ProgramNameDrpDwnBtn, "ProgramNameDrpDwnBtn");

            Selenium.Driver.Click(ProgramNameDrpDwnOptions[n], "ProgramNameDrpDwnOptions["+n+"]");
        }

        /// <summary>
        /// Input program name 
        /// </summary>
        /// <param name="n"></param>
        public void ProgramName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(ProgramNameInput, n, "ProgramNameInput");
        }

        /// <summary>
        /// Input program ID
        /// </summary>
        /// <param name="n"></param>
        public void ProgramId_InputNum(string n)
        {
            Selenium.Driver.SendKeys(ProgramIdInput, n, "ProgramIdInput");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Input SSN number to register a new Apprentice
        /// </summary>
        /// <param name="n"></param>
        public void EnterSSN_InputNum(string n)
        {
            Selenium.Driver.SendKeys(EnterSSNInput, n, "EnterSSNInput");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Clicks on "Find Apprentice" button 
        /// </summary>
        public void FindApprentice_ClickBtn ()
        {
            Selenium.Driver.Click(FindApprenticeBtn, "FindApprenticeBtn");
        }
    }
}
