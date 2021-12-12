using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Program.Create_New_Program
{
    public class Program_CreateProgram_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='FullTitleText']")]
        public IWebElement ProgramNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//p-dropdown[@name='pgmType']")]
        public IWebElement ProgramTypeDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//p-dropdown[@name='pgmType']//li/span")]
        public IList<IWebElement> ProgramTypeDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//p-dropdown[@name='shopType']")]
        public IWebElement ShopTypeDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//p-dropdown[@name='shopType']//li/span")]
        public IList<IWebElement> ShopTypeDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ContactName']")]
        public IWebElement ContactNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ContactPhoneNumber']")]
        public IWebElement ContactPhoneInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ContactTollFree']")]
        public IWebElement ContacTTollFreeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ContactFaxNumber']")]
        public IWebElement ContactFaxInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ContactEmail']")]
        public IWebElement ContactEmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='WebsiteUrl']")]
        public IWebElement WebSiteUrlInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StandardUrl']")]
        public IWebElement StandardUrlInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//p-multiselect[@name='county']")]
        public IWebElement CountyCoveredChkBox { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//p-multiselect[@name='county']//li/label")]
        public IList<IWebElement> CountyChkBoxOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ProgramApprovalDate']")]
        public IWebElement ProvisonalDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='PermanentDate']")]
        public IWebElement PermanentDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//p-dropdown[@name='selectedAC']")]
        public IWebElement ConsultantDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//p-dropdown[@name='selectedAC']//li/span")]
        public IList<IWebElement> ConsultantDrpDwnOptions { get; set; }

        //[0]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='Address1']")]
        public IList<IWebElement> MailingAddresL1Input { get; set; }

        //[0]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='Address2']")]
        public IList<IWebElement> MailingAddresL2Input { get; set; }

        //[0]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='City']")]
        public IList<IWebElement> MailingAddresCityInput { get; set; }

        //[0]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='State']")]
        public IList<IWebElement> MailingAddresStateInput { get; set; }

        //[0]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='ZipCode']")]
        public IList<IWebElement> MailingAddresZipCodeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='ZipCode']")]
        public IWebElement SameAsMailingClick { get; set; }

        //[1]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='Address1']")]
        public IList<IWebElement> PhysicalAddresL1Input { get; set; }

        //[1]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='Address2']")]
        public IList<IWebElement> PhysicalAddresL2Input { get; set; }

        //[1]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='City']")]
        public IList<IWebElement> PhysicalAddresCityInput { get; set; }

        //[1]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='State']")]
        public IList<IWebElement> PhysicalAddresStateInput { get; set; }

        //[1]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//input[@name='ZipCode']")]
        public IList<IWebElement> PhysicalAddresZipCodeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Add New Occupation']")]
        public IWebElement AddOccupationBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[text()='Remove Occupation']")]
        public IList<IWebElement> RemoveOccupationBtn { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body//div//div//div//div//div//p-panel[1]//div[1]//div//div//div[1]//div[1]//div[1]//div[2]//input[1]")]
        public IList<IWebElement> OccupationFullNameInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body//div//div//div//div//div//p-panel//div[1]//div[2]//div[1]//div[1]//div[1]//div[2]//div[2]//p-dropdown[1]//div[1]//label[1]")]
        public IList<IWebElement> SOCCategoryDrpDwnBtn { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body//div//div//div//div//p-panel//li/span")]
        public IList<IWebElement> SOCCategoryDrpDwnOptions { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body//div//div//div//div//div//p-panel[1]//div[1]//div[2]//div[1]//div[1]//div[1]//div[3]//div[2]//input[1]")]
        public IList<IWebElement> SOCCodeInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[4]/div[2]/input[1]")]
        public IList<IWebElement> SOCTitleInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div/form/div/div[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[4]/div[2]/input[1]")]
        public IList<IWebElement> SOCDecriptionInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[5]/div[2]/select")]
        public IList<IWebElement> ProgrssionTypeDrpDwnBtn { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-program-on-board/div/form/div/div/p-panel/div/div/div/div/div/div/div/select")]
        public IList<IWebElement> ProgrssionTypeDrpDwnOptions { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/input[1]")]
        public IList<IWebElement> JourneyLevelWageInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/input[1]")]
        public IList<IWebElement> TermHoursInput { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[2]/input[1]")]
        public IList<IWebElement> MinTermHoursInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[4]/div[2]/input[1]")]
        public IList<IWebElement> SupplementHoursRSIInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[5]/div[2]/input[1]")]
        public IList<IWebElement> ProbationHoursinput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[6]/div[2]/p-calendar[1]/span[1]/input[1]")]
        public IList<IWebElement> ActiveDateInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-program-on-board[1]/div[1]/form[1]/div/div/p-panel[1]/div[1]/div[2]/div[1]/div[2]/div[2]/button[1]/span[2]")]
        public IList<IWebElement> AddStepBtn { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-program-on-board/div/form/div/div/p-panel/div/div/div/div[3]/div")]
        public IList<IWebElement> WageStepsTabelCount { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-program-on-board/div/form/div/div/p-panel/div/div/div/div[3]/div//tbody/tr/td[1]/input")]
        public IList<IWebElement> WageStepInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-program-on-board/div/form/div/div/p-panel/div/div/div/div[3]/div//tbody/tr/td[2]/input[1]")]
        public IList<IWebElement> WageStepFromInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-program-on-board/div/form/div/div/p-panel/div/div/div/div[3]/div//tbody/tr/td[2]/input[2]")]
        public IList<IWebElement> WageStepToInput { get; set; }

        ///Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-program-on-board/div/form/div/div/p-panel/div/div/div/div[3]/div//tbody/tr/td[3]/input")]
        public IList<IWebElement> WageStepPercentageInput { get; set; }

        //Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-program-on-board/div/form/div/div/p-panel/div/div/div/div[3]/div//tbody/tr/td[4]/button")]
        public IList<IWebElement> WageStepRemoveBtn { get; set; }

        //Store number of clicks 'AddOccupationBtn', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-program-on-board/div/form/div/div/p-panel/div/div/div/div[3]/div//tbody/tr/td[5]/button")]
        public IList<IWebElement> WageStepAddBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@label = 'Add New Committee Member']")]
        public IWebElement AddCommitteeMemberBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Remove Committee Member']")]
        public IList<IWebElement> RemoveCommitteMemberBtn { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add New Committee Member')]//following::div/div[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]")]
        public IList<IWebElement> CommitteeMemeberFirstNameInput { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add New Committee Member')]//following::div/div[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[2]/input[1]")]
        public IList<IWebElement> CommitteeMemeberLastNameInput { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add New Committee Member')]//following::div/div[2]/div[1]/div[1]/div/div/div/p-calendar/span/input")]
        public IList<IWebElement> CommitteeMemeberEffectiveDateInput { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add New Committee Member')]//following::p-panel//div//div//div//div//div//div//div//p-dropdown//div//label")]
        public IList<IWebElement> CommitteeMemeberRepresentativeOfDrDwnBtn { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body//div//div//div//div//p-panel//li/span")]
        public IList<IWebElement> CommitteeMemeberRepresentativeOfDrDwnBtnOptions { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add New Committee Member')]//following::div/div/p-panel/div/div/div/div/div/div/table/tbody/tr/td[1]/p-dropdown[1]/div[1]/label[1]")]
        public IList<IWebElement> SelectRoleDrpDwnBtn { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add New Committee Member')]//following::div/div/p-panel/div/div/div/div/div/div/table/tbody/tr/td[1]/p-dropdown[1]/div[1]/div/div[1]/ul[1]/li")]
        public IList<IWebElement> SelectRoleDrpDwnOptions { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add New Committee Member')]//following::div/div[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/table/tbody/tr/td/p/button")]
        public IList<IWebElement> SelectRoleRemoveBtn { get; set; }

        //Store number of clicks 'AddCommitteMenber', that represents length of teh list
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add New Committee Member')]//following::button[@class= 'btn-green ui-button ui-widget ui-state-default ui-corner-all ui-button-icon-only']")]
        public IList<IWebElement> SelectRoleAddBtn { get; set; }

        //[1]
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[text()='Save Program']")]
        public IList<IWebElement> SaveProgramBtn { get; set; }

        /*
        //span[contains(text(),'Add New Committee Member')]

        */
        public void ProgramName_Input(string n)
        {
            Selenium.Driver.SendKeys(ProgramNameInput, n, "ProgramNameInput");
        }

        public void ProgramType_DrpDwnBtn(string n)
        {
            Selenium.Driver.Click(ProgramTypeDrpDwnBtn, "ProgramTypeDrpDwnBtn");
            Selenium.Driver.Click(ProgramTypeDrpDwnOptions[int.Parse(n)], "ProgramTypeDrpDwnOptions"+n+"]");
        }

        public void ShopType_DrpDwnBtn(string n)
        {
            Selenium.Driver.Click(ShopTypeDrpDwnBtn, "ShopTypeDrpDwnBtn");
            Selenium.Driver.Click(ShopTypeDrpDwnOptions[int.Parse(n)], "ShopTypeDrpDwnOptions" + n + "]");
        }

        public void ContactName_Input(string n)
        {
            Selenium.Driver.SendKeys(ContactNameInput, n, "ContactNameInput");
        }

        public void ContactPhone_Input(string n)
        {
            Selenium.Driver.SendKeys(ContactPhoneInput, n, "ContactPhoneInput");
        }

        public void ContacTTollFree_Input(string n)
        {
            Selenium.Driver.SendKeys(ContacTTollFreeInput, n, "ContacTTollFreeInput");
        }

        public void ContactFax_Input(string n)
        {
            Selenium.Driver.SendKeys(ContactFaxInput, n, "ContactFaxInput");
        }

        public void ContactEmail_Input(string n)
        {
            Selenium.Driver.SendKeys(ContactEmailInput, n, "ContactEmailInput");
        }

        public void WebSiteUrl_Input(string n)
        {
            Selenium.Driver.SendKeys(WebSiteUrlInput, n, "WebSiteUrlInput");
        }

        public void StandardUrl_Input(string n)
        {
            Selenium.Driver.SendKeys(StandardUrlInput, n, "StandardUrlInput");
        }

        /// <summary>
        /// returns counties List Text 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> CountyCovered_ChkBox(List<string> n)
        {
            List<string> counties = new List<string>(); 
            Selenium.Driver.Click(CountyCoveredChkBox, "CountyCoveredChkBox");

            for (int i = 0; i < n.Count; i++)
            {
                counties.Add(Selenium.Driver.GetText(CountyChkBoxOptions[int.Parse(n[i])], "CountyChkBoxOptions[" + n[i] + "]"));
                Selenium.Driver.Click(CountyChkBoxOptions[int.Parse(n[i])], "CountyChkBoxOptions[" + n[i] + "]");
            }
            Selenium.Driver.Click(CountyCoveredChkBox, "CountyCoveredChkBox");
            return counties;
        }

        public void ProvisonalDate_Input(string n)
        {
            Selenium.Driver.SendKeys(ProvisonalDateInput, n, "ProvisonalDateInput");
        }

        public void PermanentDate_Input(string n)
        {
            Selenium.Driver.SendKeys(PermanentDateInput, n, "PermanentDateInput");
        }

        public void Consultant_DrpDwnBtn(string n)
        {
            Selenium.Driver.Click(ConsultantDrpDwnBtn, "ConsultantDrpDwnBtn");
            Selenium.Driver.Click(ConsultantDrpDwnOptions[int.Parse(n)], "ConsultantDrpDwnOptions" + n + "]");
        }

        public void MailingAddresL1_Input(string n)
        {
            Selenium.Driver.SendKeys(MailingAddresL1Input[0], n, "MailingAddresL1Input");
        }

        public void MailingAddresL2_Input(string n)
        {
            Selenium.Driver.SendKeys(MailingAddresL2Input[0], n, "MailingAddresL2Input");
        }

        public void MailingAddresCity_Input(string n)
        {
            Selenium.Driver.SendKeys(MailingAddresCityInput[0], n, "MailingAddresCityInput");
        }

        public void MailingAddresState_Input(string n)
        {
            Selenium.Driver.SendKeys(MailingAddresStateInput[0], n, "MailingAddresStateInput");
        }

        public void MailingAddresZipCode_Input(string n)
        {
            Selenium.Driver.SendKeys(MailingAddresZipCodeInput[0], n, "MailingAddresZipCodeInput");
        }

        public void SameAsMailing_Click()
        {
            Selenium.Driver.Click(SameAsMailingClick, "MailingAddresZipCodeInput");
        }

        public void PhysicalAddresL1_Input(string n)
        {
            Selenium.Driver.SendKeys(PhysicalAddresL1Input[1], n, "PhysicalAddresL1Input");
        }

        public void PhysicalAddresL2_Input(string n)
        {
            Selenium.Driver.SendKeys(PhysicalAddresL2Input[1], n, "PhysicalAddresL2Input");
        }

        public void PhysicalAddresCity_Input(string n)
        {
            Selenium.Driver.SendKeys(PhysicalAddresCityInput[1], n, "PhysicalAddresCityInput");
        }

        public void PhysicalAddresState_Input(string n)
        {
            Selenium.Driver.SendKeys(PhysicalAddresStateInput[1], n, "PhysicalAddresStateInput");
        }

        public void PhysicalAddresZipCode_Input(string n)
        {
            Selenium.Driver.SendKeys(PhysicalAddresZipCodeInput[1], n, "PhysicalAddresZipCodeInput");
        }

        public void AddOccupation_Btn()
        {
            Selenium.Driver.ScrollToElement(PhysicalAddresZipCodeInput[1], "PhysicalAddresZipCodeInput");
            AddOccupationBtn.Click();
        }

        public void RemoveOccupation_Btn(int n)
        {
            Selenium.Driver.Click(RemoveOccupationBtn[n], "RemoveOccupationBtn"+n+"]");
        }

        public void OccupationFullName_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(OccupationFullNameInput[n], input, "OccupationFullNameInput");
        }

        public void SOCCategory_DrpDwn(int n, string DropDownOption)
        {
            Selenium.Driver.Click(SOCCategoryDrpDwnBtn[n], "SOCCategoryDrpDwnBtn[" + n + "]");
            Selenium.Driver.Click(SOCCategoryDrpDwnOptions[int.Parse(DropDownOption)], "SOCCategoryDrpDwnOptions["+ DropDownOption + "]");
        }

        public void SOCCode_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(SOCCodeInput[n], input, "SOCCodeInput");
        }

        public void SOCTitle_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(SOCTitleInput[n], input, "SOCTitleInput");
        }

        public void SOCDecription_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(SOCDecriptionInput[n], input, "SOCDecriptionInput");
        }

        public void ProgrssionType_DrpDwn(string n,string Index)
        {
            Selenium.Driver.SelectDropDownByIndex(ProgrssionTypeDrpDwnOptions[int.Parse(n)], int.Parse(Index),"ProgrssionTypeDrpDwnOptions" + n + "]");
        }

        public void JourneyLevelWage_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(JourneyLevelWageInput[n], input, "JourneyLevelWageInput");
        }

        public void TermHours_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(TermHoursInput[n], input, "TermHoursInput");
        }

        public void MinTermHours_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(MinTermHoursInput[n], input, "MinTermHoursInput");
        }

        public void SupplementHoursRSI_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(SupplementHoursRSIInput[n], input, "SupplementHoursRSIInput");
        }

        public void ProbationHours_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(ProbationHoursinput[n], input, "ProbationHoursinput");
        }

        public void ActiveDate_Input(int n, string input)
        {
            Selenium.Driver.SendKeys(ActiveDateInput[n], input, "ActiveDateInput");
        }

        public void AddStep_Btn(int n)
        {
            Selenium.Driver.Click(AddStepBtn[n], "AddStepBtn" + n + "]");
        }

        public void WageStep_Input(int n, string StepNumber)
        {
            Selenium.Driver.SendKeys(WageStepInput[n], StepNumber, "WageStepInput" + n + "]");
        }

        public void WageStepFrom_Input(int n, string WageStepFromHours)
        {
            Selenium.Driver.SendKeys(WageStepFromInput[n], WageStepFromHours, "WageStepFromInput" + n + "]");
        }

        public void WageStepTo_Input(int n, string WageStepFromHours)
        {
            Selenium.Driver.SendKeys(WageStepToInput[n], WageStepFromHours, "WageStepToInput" + n + "]");
        }

        public void WageStepPercentage_Input(int n, string WageStepPercent)
        {
            Selenium.Driver.SendKeys(WageStepPercentageInput[n], WageStepPercent, "WageStepPercentageInput" + n + "]");
        }

        public void WageStepRemove_Btn(int n)
        {
            Selenium.Driver.Click(WageStepRemoveBtn[n], "WageStepRemoveBtn" + n + "]");
        }

        public void WageStepAdd_Btn(int n)
        {
            Selenium.Driver.Click(WageStepAddBtn[n], "WageStepAddBtn" + n + "]");
        }

        public void AddCommitteeMember_Btn()
        {
            Selenium.Driver.ScrollToElement(AddCommitteeMemberBtn, "AddCommitteeMemberBtnAddCommitteeMemberBtn");
            AddCommitteeMemberBtn.Click();

            //Selenium.Driver.Click(AddCommitteeMemberBtn, "AddCommitteeMemberBtn]");
        }

        public void RemoveCommitteMember_Btn(int n)
        {
            Selenium.Driver.Click(RemoveCommitteMemberBtn[n], "RemoveCommitteMemberBtn" + n + "]");
        }

        public void CommitteeMemeberFirstName_Input(int n, string CommitteeMemberFirstName)
        {
            Selenium.Driver.SendKeys(CommitteeMemeberFirstNameInput[n], CommitteeMemberFirstName, "CommitteeMemeberFirstNameInput" + n + "]");
        }

        public void CommitteeMemeberLastName_Input(int n, string CommitteeMemberLastName)
        {
            Selenium.Driver.SendKeys(CommitteeMemeberLastNameInput[n], CommitteeMemberLastName, "CommitteeMemeberLastNameInput" + n + "]");
        }

        public void CommitteeMemeberEffectiveDate_Input(int n, string CommitteeMemberEffectiveDate)
        {
            Selenium.Driver.SendKeys(CommitteeMemeberLastNameInput[n], CommitteeMemberEffectiveDate, "CommitteeMemberEffectiveDate" + n + "]");
        }

        public void CommitteeMemeberRepresentativeOf_DrDwn(int n, int ReprentativeOf)
        {
            Selenium.Driver.Click(CommitteeMemeberRepresentativeOfDrDwnBtn[n], "CommitteeMemeberRepresentativeOfDrDwnBtn" + n + "]");
            Selenium.Driver.Click(CommitteeMemeberRepresentativeOfDrDwnBtnOptions[ReprentativeOf], "CommitteeMemeberRepresentativeOfDrDwnBtnOptions" + ReprentativeOf + "]");
        }

        public void SelectRole_DrpDwn(int n, int roleOption)
        {
            Selenium.Driver.Click(SelectRoleDrpDwnBtn[n], "SelectRoleDrpDwnBtn" + n + "]");
            Selenium.Driver.Click(SelectRoleDrpDwnOptions[roleOption], "SelectRoleDrpDwnOptions" + roleOption + "]");
        }

        public void SelectRoleRemove_Btn(int n)
        {
            Selenium.Driver.Click(SelectRoleRemoveBtn[n], "SelectRoleRemoveBtn" + n + "]");
        }

        public void SelectRoleAdd_Btn(int n)
        {
            Selenium.Driver.Click(SelectRoleAddBtn[n], "SelectRoleAddBtn" + n + "]");
        }

        public void SaveProgram_Btn()
        {
            Selenium.Driver.Click(SaveProgramBtn[1], "SaveProgramBtn");
            Thread.Sleep(2000);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------Functionalities
        public int Add_Occupation(
            string OccupationFullName, string OccupationCount, string SOCCategoryDrpDwnValue, string SOCCode, string SOCDecription, string ProgressType,
            string JourneyLevelWage, string TermInput, string MinTermInput ,string SupplimentRSIHours, string ProbationHours, string ActiveDate,
            string NumberOfSteps, int stepsadded, Dictionary<string, string > WageLevelFromTo, List <string> WageStepPercent)
        {
            int n = int.Parse(OccupationCount);
            Selenium.Driver.Click(AddOccupationBtn, "AddOccupationBtn");
            Selenium.Driver.SendKeys(OccupationFullNameInput[n],OccupationFullName, "OccupationFullNameInput["+ OccupationCount + "]");
            SOCCategory_DrpDwn(n, SOCCategoryDrpDwnValue );
            Selenium.Driver.SendKeys(SOCCodeInput[n], SOCCode, "SOCCodeInput");
            Selenium.Driver.SendKeys(SOCDecriptionInput[n], SOCDecription, "SOCDecription[" + n + "]");
            ProgrssionType_DrpDwn(n.ToString(), ProgressType);
            Selenium.Driver.SendKeys(JourneyLevelWageInput[n], JourneyLevelWage, "JourneyLevelWageInput["+n+"]");
            Selenium.Driver.SendKeys(TermHoursInput[n], TermInput, "TermHoursInput");
            Selenium.Driver.SendKeys(MinTermHoursInput[n], MinTermInput, "MinTermHoursInput");
            Selenium.Driver.SendKeys(SupplementHoursRSIInput[n], SupplimentRSIHours, "SupplementHoursRSIInput");
            Selenium.Driver.SendKeys(ProbationHoursinput[n], ProbationHours, "ProbationHoursinput");
            Selenium.Driver.SendKeys(ActiveDateInput[n], ActiveDate, "ActiveDateInput");

            int stepsadded_0 =stepsadded;
            int initialStep = 1;
            int temp = 0;
            for (int i = 0; i < int.Parse(NumberOfSteps); i++)
            {
                //foreach (KeyValuePair<string, string> item in WageLevelFromTo)
                //{
                    Selenium.Driver.Click(AddStepBtn[int.Parse(OccupationCount)], "AddStepBtn[" + OccupationCount + "]");
                    Selenium.Driver.SendKeys(WageStepInput[stepsadded_0 + i], initialStep.ToString(), "WageStepInput[" + stepsadded_0 + i + "]");
                    Selenium.Driver.SendKeys(WageStepFromInput[stepsadded_0 + i], WageLevelFromTo.Keys.ElementAt(i), "WageStepFromInput[" + stepsadded_0 + i + "]");
                    Selenium.Driver.SendKeys(WageStepToInput[stepsadded_0 + i], WageLevelFromTo[WageLevelFromTo.Keys.ElementAt(i)], "WageStepToInput[" + stepsadded_0 + i + "]");
                    Selenium.Driver.SendKeys(WageStepPercentageInput[stepsadded_0 + i], WageStepPercent[i], "WageStepPercentageInput[" + stepsadded_0 + i + "]");
               //}
                initialStep++;
                temp = i + 1;
           }
            stepsadded_0 = temp;

            return stepsadded_0;
        }

        public string Add_Committee_Memeber (string CommMembernumber, string FirstName, string LastName, string  EffectiveDate, string  RepOf, string EnteryNumber, List<string>Roles)
        {
            Thread.Sleep(1000);
            AddCommitteeMember_Btn();
            int n = int.Parse(CommMembernumber);
            Selenium.Driver.SendKeys(CommitteeMemeberFirstNameInput[n], FirstName, "CommitteeMemeberFirstNameInput");
            Selenium.Driver.SendKeys(CommitteeMemeberLastNameInput[n], LastName, "CommitteeMemeberFirstNameInput");
            Thread.Sleep(1000);
            Selenium.Driver.Click(CommitteeMemeberRepresentativeOfDrDwnBtn[n], "CommitteeMemeberRepresentativeOfDrDwnBtn");
            Selenium.Driver.SendKeys(CommitteeMemeberEffectiveDateInput[n], EffectiveDate, "CommitteeMemeberFirstNameInput");
            Selenium.Driver.Click(CommitteeMemeberRepresentativeOfDrDwnBtnOptions[int.Parse(RepOf)], "CommitteeMemeberRepresentativeOfDrDwnBtnOptions["+ int.Parse(RepOf) + "]");
            List<string> RolesList = new List<string>();
            int NumberOfRoles = int.Parse(EnteryNumber);
            int temp=0;
            int temp_a = 0;
            for (int i = NumberOfRoles; i < (Roles.Count + NumberOfRoles); i++)
            {

                Selenium.Driver.Click(SelectRoleDrpDwnBtn[i], "SelectRoleDrpDwnBtn[" + i + "]");

                if (temp_a < Roles.Count)
                {
                    //Save selected roles 
                    RolesList.Add(Selenium.Driver.GetText(SelectRoleDrpDwnOptions[int.Parse(Roles[temp_a])],
                        "SelectRoleDrpDwnOptions[" + int.Parse(Roles[temp_a]) + "]"));

                    Selenium.Driver.Click(SelectRoleDrpDwnOptions[int.Parse(Roles[temp_a])],
                        "SelectRoleDrpDwnOptions[" + int.Parse(Roles[temp_a]) + "]");
                    temp_a++;
                }
                else
                {
                    temp_a = 0;
                    Selenium.Driver.Click(SelectRoleDrpDwnOptions[int.Parse(Roles[temp_a])], "SelectRoleDrpDwnOptions[" + int.Parse(Roles[temp_a]) + "]");
                }
                if(i < ((Roles.Count + NumberOfRoles)-1))
                {
                    Selenium.Driver.Click(SelectRoleAddBtn[int.Parse(CommMembernumber)], "SelectRoleAddBtn[" + CommMembernumber + "]");
                }                         
                temp = i+1;
            }
            //Selenium.Driver.Click(SelectRoleRemoveBtn[(temp)], "SelectRoleRemoveBtn[" + (temp) + "]");
            NumberOfRoles = temp+1;
            return NumberOfRoles.ToString();
         }
    }
}
