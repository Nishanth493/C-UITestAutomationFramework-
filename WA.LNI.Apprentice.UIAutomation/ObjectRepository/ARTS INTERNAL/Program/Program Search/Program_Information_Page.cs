using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Program.Program_Search
{
    public class Program_Information_Page : Base
    {

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Program Id:']//following::span[1]")]
        public IWebElement ProgramIDTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Full Name:']//following::span[1]")]
        public IWebElement ProgramFullNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Status Description:']//following::span[1]")]
        public IWebElement StatusDecriptionTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Status Date:']//following::span[1]")]
        public IWebElement StatusDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Secret Code:']//following::span[1]")]
        public IWebElement SecretCodeBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Email Data:']//following::span[1]")]
        public IWebElement EmailDataTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Site Url:']//following::a[1]")]
        public IWebElement SiteURLTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Toll Free Phone Number:']//following::span[1]")]
        public IWebElement TollFreePhoneTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Phone Number:']//following::span[1]")]
        public IWebElement PhoneNumberTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Fax Number:']//following::span[1]")]
        public IWebElement FaxNumberTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Region Number:']//following::span[1]")]
        public IWebElement RegionNumberTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Provisional Date:']//following::span[1]")]
        public IWebElement ProvisonalDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Open Shop:']//following::span[1]")]
        public IWebElement ShopTypetxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Permanent Date:']//following::span[1]")]
        public IWebElement PermanentDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Contact Name:']//following::span[1]")]
        public IWebElement ContactNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Program Type:']//following::span[1]")]
        public IWebElement ProgramTypeTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Standard Amended Date:']//following::span[1]")]
        public IWebElement StandardAmendmentDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Program Out of State Name:']//following::span[1]")]
        public IWebElement ProgramOutOfStateNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'L&I Contact Name:']//following::span[1]")]
        public IWebElement LNIContactNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Program Official Standards URL:']//following::a[1]")]
        public IWebElement ProgramOfficialStandardURLTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'IIIA Exemption Type:']//following::span[1]")]
        public IWebElement IIIAExemptionTypeTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'IIIB Exemption Type:']//following::span[1]")]
        public IWebElement IIIBExemptionTypeTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[text()='Mailing Address']")]
        public IWebElement MailingAddressTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[text()='Physical Address']")]
        public IWebElement PhysicalAddressTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Counties']//following::a[1]")]
        public IWebElement ExpandCountiesBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Counties']//following::tbody[1]/tr/td")]
        public IList<IWebElement> CountiesListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//html//body//app-root//div//div//app-program-search//app-program-detail//div//app-program-occupation//p-panel//div//div//span[contains(text(),'Occupation')]//following::a[1]")]
        public IWebElement ExpandOccupationBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[text()='Occupation Name:']//following::div[1]")]
        public IWebElement SelectProgramOccupationDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[text()='Occupation Name:']//following::ul[1]/li/span")]
        public IList<IWebElement> SelectProgramOccupationDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Occupation Full Name:']//following::span[1]")]
        public IWebElement OccFullNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Effective Date:']//following::span[1]")]
        public IWebElement EffectiveDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Inactive Date:']//following::span[1]")]
        public IWebElement InactiveDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Soc Code:']//following::span[1]")]
        public IWebElement SocCodeTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Soc Description:']//following::span[1]")]
        public IWebElement SOCDecriptionTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Probation Hours:']//following::span[1]")]
        public IWebElement ProbationHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'supplement Hours:']//following::span[1]")]
        public IWebElement SupplimentHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Term Hours:']//following::span[1]")]
        public IWebElement TermHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Min Term Hours:']//following::span[1]")]
        public IWebElement MinTermHoursTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[text() = 'Journey Level Wage Rate:']//following::tbody[1]/tr/td[1]")]
        public IList<IWebElement> JourneyLevelRateTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[text() = 'Journey Level Wage Rate:']//following::tbody[1]/tr/td[2]")]
        public IList<IWebElement> JourneyLevelRateEffectiveDateTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[text()='Steps:']//following::tbody[1]/tr/td[1]")]
        public IList<IWebElement> StepCountTableTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[text()='Steps:']//following::tbody[1]/tr/td[2]")]
        public IList<IWebElement> StepJourneyLevelPercentTableTxt { get; set; }

        public string ProgramID_Txt()
        {
            return Selenium.Driver.GetText(ProgramIDTxt, "ContactPhoneInput");
        }

        public string ProgramFullName_Txt()
        {
            return Selenium.Driver.GetText(ProgramFullNameTxt, "ProgramFullNameTxt");
        }

        public string StatusDecription_Txt()
        {
            return Selenium.Driver.GetText(StatusDecriptionTxt, "StatusDecriptionTxt");
        }

        public string StatusDate_Txt()
        {
            return Selenium.Driver.GetText(StatusDateTxt, "StatusDateTxt");
        }

        public void SecretCode_Btn()
        {
            Selenium.Driver.Click(SecretCodeBtn, "SecretCodeBtn");
        }

        public string EmailData_Txt()
        {
            return Selenium.Driver.GetText(EmailDataTxt, "EmailDataTxt");
        }

        public string SiteURL_Txt()
        {
            return Selenium.Driver.GetText(SiteURLTxt, "SiteURLTxt");
        }

        public string TollFreePhone_Txt()
        {
            return Selenium.Driver.GetText(TollFreePhoneTxt, "TollFreePhoneTxt");
        }

        public string PhoneNumber_Txt()
        {
            return Selenium.Driver.GetText(PhoneNumberTxt, "PhoneNumberTxt");
        }
        public string FaxNumber_Txt()
        {
            return Selenium.Driver.GetText(FaxNumberTxt, "FaxNumberTxt");
        }

        public string RegionNumber_Txt()
        {
            return Selenium.Driver.GetText(RegionNumberTxt, "RegionNumberTxt");
        }

        public string ProvisonalDate_Txt()
        {
            return Selenium.Driver.GetText(ProvisonalDateTxt, "ProvisonalDateTxt");
        }

        public string ShopType_txt()
        {
            return Selenium.Driver.GetText(ShopTypetxt, "ProvisonalDaShopTypetxtteTxt").Trim();
        }

        public string PermanentDate_Txt()
        {
            return Selenium.Driver.GetText(PermanentDateTxt, "PermanentDateTxt");
        }

        public string ContactName_Txt()
        {
            return Selenium.Driver.GetText(ContactNameTxt, "ContactNumberTxt");
        }

        public string ProgramType_Txt()
        {
            return Selenium.Driver.GetText(ProgramTypeTxt, "ProgramTypeTxt");
        }

        public string StandardAmendmentDate_Txt()
        {
            return Selenium.Driver.GetText(StandardAmendmentDateTxt, "StandardAmendmentDateTxt");
        }

        public string ProgramOutOfStateName_Txt()
        {
            return Selenium.Driver.GetText(ProgramOutOfStateNameTxt, "ProgramOutOfStateNameTxt");
        }

        public string LNIContactName_Txt()
        {
            return Selenium.Driver.GetText(LNIContactNameTxt, "LNIContactNameTxt");
        }
        public string ProgramOfficialStandardURL_Txt()
        {
            return Selenium.Driver.GetText(ProgramOfficialStandardURLTxt, "ProgramOfficialStandardURLTxt");
        }

        public string IIIAExemptionType_Txt()
        {
            return Selenium.Driver.GetText(IIIAExemptionTypeTxt, "IIIAExemptionTypeTxt");
        }

        public string IIIBExemptionType_Txt()
        {
            return Selenium.Driver.GetText(IIIBExemptionTypeTxt, "IIIBExemptionTypeTxt");
        }

        public string MailingAddress_Txt()
        {
            string MailingAddress = Selenium.Driver.GetText(MailingAddressTxt, "MailingAddressTxt");
            string[] MailingAddresss1 = MailingAddress.Split(new string[] { "Address" }, StringSplitOptions.None);
            return MailingAddresss1[1].Trim();
        }

        public string PhysicalAddress_Txt()
        {
            string PhysicalAddress = Selenium.Driver.GetText(PhysicalAddressTxt, "PhysicalAddressTxt");
            string [] PhysicalAddress1 =  PhysicalAddress.Split(new string[] { "Address" }, StringSplitOptions.None);
            return PhysicalAddress1[1].Trim();
        }

        public void ExpandCounties_Btn()
        {
            Selenium.Driver.Click(ExpandCountiesBtn, "ExpandCountiesBtn");
        }

        public string CountiesList_Txt(int n)
        {
            return Selenium.Driver.GetText(CountiesListTxt[n], "CountiesListTxt");
        }

        public void ExpandOccupation_Btn()
        {
            Selenium.Driver.Click(ExpandOccupationBtn, "ExpandOccupationBtn");
        }

        public void SelectProgramOccupation_DrpDwn(string n)
        {
            Selenium.Driver.Click(SelectProgramOccupationDrpDwnBtn, "SelectProgramOccupationDrpDwnBtn");
            Selenium.Driver.Click(SelectProgramOccupationDrpDwnOptions[int.Parse(n)], "SelectProgramOccupationDrpDwnOptions[" + n + "]");
        }

        public string OccFullName_Txt()
        {
            return Selenium.Driver.GetText(OccFullNameTxt, "OccFullNameTxt");
        }

        public string EffectiveDate_Txt()
        {
            return Selenium.Driver.GetText(EffectiveDateTxt, "EffectiveDateTxt");
        }

        public string InactiveDate_Txt()
        {
            return Selenium.Driver.GetText(InactiveDateTxt, "InactiveDateTxt");
        }

        public string SocCode_Txt()
        {
            return Selenium.Driver.GetText(SocCodeTxt, "SocCodeTxt");
        }

        public string SOCDecription_Txt()
        {
            return Selenium.Driver.GetText(SOCDecriptionTxt, "SOCDecriptionTxt");
        }

        public string ProbationHours_Txt()
        {
            return Selenium.Driver.GetText(ProbationHoursTxt, "ProbationHoursTxt");
        }

        public string SupplimentHours_Txt()
        {
            return Selenium.Driver.GetText(SupplimentHoursTxt, "SupplimentHoursTxt");
        }

        public string TermHours_Txt()
        {
            return Selenium.Driver.GetText(TermHoursTxt, "TermHoursTxt");
        }

        public string MinTermHours_Txt()
        {
            return Selenium.Driver.GetText(MinTermHoursTxt, "MinTermHoursTxt");
        }

        public List<string> JourneyLevelRateTable_Txt()
        {
            List<string> n = new List<string>();

            for (int i = 0; i < JourneyLevelRateTableTxt.Count; i++)
            {
                n[i] = Selenium.Driver.GetText(JourneyLevelRateTableTxt[i], "JourneyLevelRateTableTxt");
            }
            return n;
        }

        public List<string> JourneyLevelRateEffectiveDateTable_Txt()
        {
            List<string> n = new List<string>();
            for (int i = 0; i < JourneyLevelRateEffectiveDateTableTxt.Count; i++)
            {
                n[i] = Selenium.Driver.GetText(JourneyLevelRateEffectiveDateTableTxt[i], "JourneyLevelRateEffectiveDateTableTxt");
            }
            return n;
        }

        public Dictionary<string,string> StepHoursDecileTable_Txt()
        {
            Dictionary<string, string> n = new Dictionary<string, string>();
            for (int i = 0; i < StepCountTableTxt.Count; i++)
            {
                string temp = Selenium.Driver.GetText(StepCountTableTxt[i], "StepCountTableTxt");
                string[] temp1 = temp.Split('(');
                string[] temp2 = temp1[1].Split(')');
                string[] temp3 = temp2[0].Split(' ');
                n.Add(temp3[0], temp3[2]);
            }
            return n;
        }

        public List<string> StepCountTable_Txt()
        {
            List<string> n = new List<string>();
            for (int i = 0; i < StepCountTableTxt.Count; i++)
            {
                string temp = Selenium.Driver.GetText(StepCountTableTxt[i], "StepCountTableTxt");
                string[] temp1 = temp.Split(' ');
                n.Add(temp1[0] + " " + temp1[1]);
            }
            return n;
        }

        public List<string> StepJourneyLevelPercentTable_Txt()
        {
            List<string> n = new List<string>();
            for (int i = 0; i < StepJourneyLevelPercentTableTxt.Count; i++)
            {
                n[i] = Selenium.Driver.GetText(StepJourneyLevelPercentTableTxt[i], "StepJourneyLevelPercentTableTxt");
            }
            return n;
        }
    }
}

