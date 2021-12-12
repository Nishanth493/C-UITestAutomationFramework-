using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Info___Affidavit
{

    public class AffidavitLookup_Page_Internal : Base
    {
        [FindsBy(How = How.CssSelector, Using = "#SerachLastName")]
        public IWebElement LastNameInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SerachFirstName")]
        public IWebElement FirstNameInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ApprenticeId")]
        public IWebElement ApprenticeIDInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#AffidavitId")]
        public IWebElement AffidavitIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement SearchBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td/span/a")]
        public IList<IWebElement> ApprenticeIDTableLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td[2]/span[2]")]
        public IList<IWebElement> FirestNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td[3]/span[2]")]
        public IList<IWebElement> LastNameTableTxt { get; set; }


        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td[4]/span[2]")]
        public IList<IWebElement> ProgramNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td[5]/span[2]")]
        public IList<IWebElement> OccupationNameTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td[6]/span[2]")]
        public IList<IWebElement> StatusTableTxtLnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td[7]/span[2]")]
        public IList<IWebElement> RegistrationDateTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td[8]/span[2]")]
        public IList<IWebElement> CancelDateTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-12 ui-md=12 ui-sm-12']//child::td[9]/span[2]")]
        public IList<IWebElement> CompletionDateTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-paginator-bottom ui-paginator ui-widget ui-widget-header ui-unselectable-text')]//following::a")]
        public IList<IWebElement> NavigationPageNumBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'ui-paginator-rpp-options ui-widget ui-state-default')]")]
        public IWebElement CountPerPageDrpDwn { get; set; }

        /// <summary>
        /// inputs apprentice last name 
        /// </summary>
        /// <param name="n"></param>
        public void LastName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(LastNameInput, n, "LastNameInput");
        }

        /// <summary>
        /// Inputs apprentice First Name
        /// </summary>
        /// <param name="n"></param>
        public void FirstName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(FirstNameInput, n, "FirstNameInput");
        }

        /// <summary>
        /// Inputs Apprentice ID
        /// </summary>
        /// <param name="n"></param>
        public void ApprenticeID_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(ApprenticeIDInput, n, "ApprenticeIDInput");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Inputs Affidavit ID
        /// </summary>
        /// <param name="n"></param>
        public void AffidavitID_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(AffidavitIDInput, n, "AffidavitIDInput");
        }

        /// <summary>
        /// Selects the Search button
        /// </summary>
        /// <param name="n"></param>
        public void Search_Btn()
        {
            Selenium.Driver.Click(SearchBtn, "SearchBtn");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Gets all the Apprentice ID Column values 
        /// </summary>
        /// <param name="n"></param>
        public void ApprenticID_TableLnk(int n)
        {
            Selenium.Driver.Click(ApprenticeIDTableLnk[n], "ApprenticeIDTableLnk[" + n + "]");
        }

        /// <summary>
        /// Gets all the First Name Column values 
        /// </summary>
        /// <param name="n"></param>
        public string FirstName_TableTxt(int n)
        {
            return Selenium.Driver.GetText(FirestNameTableTxt[n], "FirestNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Last Name Column values 
        /// </summary>
        /// <param name="n"></param>
        public string LastName_TableTxt(int n)
        {
            return Selenium.Driver.GetText(LastNameTableTxt[n], "LastNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Program Name Column values 
        /// </summary>
        /// <param name="n"></param>
        public string   ProgramName_TableTxt(int n)
        {
            return Selenium.Driver.GetText(ProgramNameTableTxt[n], "ProgramNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Occupation Name Column values 
        /// </summary>
        /// <param name="n"></param>
        public string  OccupationName_TableTxt(int n)
        {
            return Selenium.Driver.GetText(OccupationNameTableTxt[n], "OccupationNameTableTxt[" + n + "]");
        }

        /// <summary>
        /// Clicks on apprentice status, from the status cloumn by inputting row value 
        /// </summary>
        /// <param name="n"></param>
        public string Status_TableTxt(int n)
        {
            return Selenium.Driver.GetText(StatusTableTxtLnk[n], "StatusTableTxtLnk[" + n + "]");
        }

        /// <summary>
        /// Gets all the Registration Date column values
        /// </summary>
        /// <param name="n"></param>
        public string RegistrationDate_TableTxt(int n)
        {
            return Selenium.Driver.GetText(RegistrationDateTableTxt[n], "RegistrationDateTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Registration Date column values
        /// </summary>
        /// <param name="n"></param>
        public string CancelDate_TableTxt(int n)
        {
            return Selenium.Driver.GetText(CancelDateTableTxt[n], "CancelDateTableTxt[" + n + "]");
        }

        /// <summary>
        /// Gets all the Registration Date column values
        /// </summary>
        /// <param name="n"></param>
        public string CompletionDate_TableTxt(int n)
        {
            return Selenium.Driver.GetText(CompletionDateTableTxt[n], "CompletionDateTableTxt[" + n + "]");
        }

        /// <summary>
        /// input 'n = 0' for 'First Page', 'n = 1' for 'Previous Page', 'n = 2' to 'n = 6' to click on pages '1 to 5', 'n = 7' for 'Next Page', 'n = 8' for 'Last Page'
        /// </summary>
        /// <param name="n"></param>
        public void NavigationPageNum_Btns(int n)
        {
            Selenium.Driver.Click(NavigationPageNumBtn[n], "NavigationPageNumBtn[" + n + "]");
        }

        /// <summary>
        /// Input parameter values "5", "10", "20", "50", "100" count per page 
        /// </summary>
        /// <param name="n"></param>
        public void CountPerPage_DrpDwn(string n)
        {
            Selenium.Driver.SelectDropDownByValue(CountPerPageDrpDwn, n, "CountPerPageDrpDwn");
        }
    }
}
