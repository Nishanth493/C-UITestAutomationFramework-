using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC.Program_Details
{
    public class Program_Details_Public_Page : Base
    {
        //Use Driver Function - Select by SelectByDropdownText
        [FindsBy(How = How.XPath, Using = "//select[@id='occupationType']")]
        public IWebElement OccupationsClick { get; set; }
        /*
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//select[@id='artsProgramDetails_programOccupations_select-input']//option")]
        public IList<IWebElement> OccupationDrpDwn { get; set; }
        */

        [FindsBy(How = How.XPath, Using = "//dt[text()='Program Length']//following-sibling::dd[1]")]
        public IWebElement PgmLengthTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Journey Wage']//following-sibling::dd[1]")]
        public IWebElement JorneyWageTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsProgramDetails_stepHoursTable']//following-sibling::tbody/tr/td[1]")]
        public IList<IWebElement> Table_StepNumberTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsProgramDetails_stepHoursTable']//following-sibling::tbody/tr/td[2]")]
        public IList<IWebElement> Table_StepHoursTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsProgramDetails_stepHoursTable']//following-sibling::tbody/tr/td[3]")]
        public IList<IWebElement> Table_JourneyWageTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Program Name and ID']//following-sibling::dd[1]")]
        public IWebElement ProgramNameIDTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Counties']//following-sibling::span[1]")]
        public IWebElement CountiesTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Address']//following-sibling::dd[1]")]
        public IWebElement AddressTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Contact Information']//following-sibling::dd[1]")]
        public IWebElement ContactInfoTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Website']//following-sibling::a[1]")]
        public IWebElement WebsiteLnkTxt { get; set; }


        public void Occupations_DrpDwn(int n)
        {
            Selenium.Driver.Click(OccupationsClick, "OccupationsClick");
           // Selenium.Driver.Click(OccupationDrpDwn[n], "OccupationDrpDwn["+n+"]");
        }

        public string PgmLength_Txt()
        {
            return Selenium.Driver.GetText(PgmLengthTxt, "PgmLengthTxt");
        }

        public string JorneyWage_Txt()
        {
            return Selenium.Driver.GetText(JorneyWageTxt, "JorneyWageTxt");
        }

        public List<string> Table_StepNumber_Txt()
        {
            List<string> _stepNo = new List<string>();
            for (int i = 0; i < Table_StepNumberTxt.Count; i++)
            {
                _stepNo[i] = Selenium.Driver.GetText(Table_StepNumberTxt[i], "Table_StepNumber_Txt");
            }
            return _stepNo;
        }

        public List<string> Table_StepHours_Txt()
        {
            List<string> _stepHrs = new List<string>();
            for (int i = 0; i < Table_StepHoursTxt.Count; i++)
            {
                _stepHrs[i] = Selenium.Driver.GetText(Table_StepHoursTxt[i], "Table_StepHoursTxt");
            }
            return _stepHrs;
        }


        public List<string> Table_JourneyWage_Txt()
        {
            List<string> _wagePct = new List<string>();
            for (int i = 0; i < Table_JourneyWageTxt.Count; i++)
            {
                _wagePct[i] = Selenium.Driver.GetText(Table_JourneyWageTxt[i], "Table_JourneyWageTxt");
            }
            return _wagePct;
        }

        public string ProgramNameID_Txt()
        {
            return Selenium.Driver.GetText(ProgramNameIDTxt, "ProgramNameIDTxt");
        }

        public string[]  Counties_Txt()
        {
            string[] _counties =  ((Selenium.Driver.GetText(CountiesTxt, "CountiesTxt")).Split(','));
            return _counties;
        }


        public string Address_Txt()
        {
            return Selenium.Driver.GetText(AddressTxt, "AddressTxt");
        }

        public string ContactInfo_Txt()
        {
            return Selenium.Driver.GetText(ContactInfoTxt, "ContactInfoTxt");
        }

        public string WebsiteLnk_Txt()
        {
            return Selenium.Driver.GetText(WebsiteLnkTxt, "WebsiteLnkTxt");
        }
    }
}
