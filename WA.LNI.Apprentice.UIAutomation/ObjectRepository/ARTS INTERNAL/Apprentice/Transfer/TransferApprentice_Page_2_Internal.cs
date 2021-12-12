using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Transfer
{
    public class TransferApprentice_Page_2_Internal :Base
    {
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'First Name:')]//following::input[1]")]
        public IWebElement FirstNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Last Name:')]//following::input[1]")]
        public IWebElement LastNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Middle Name:')]//following::input[1]")]
        public IWebElement MiddleNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Address line 1:')]//following::input[1]")]
        public IWebElement AddressLine1Input { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Address line 2:')]//following::input[1]")]
        public IWebElement AddressLine2Input { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'City:')]//following::input[1]")]
        public IWebElement CityInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'State:')]//following::label[1]")]
        public IWebElement StateDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'State:')]//following::ul[1]/li/span")]
        public IList<IWebElement> StateDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Zip Code:')]//following::input[1]")]
        public IWebElement ZipCodeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Phone:')]//following::input[1]")]
        public IWebElement PhoneNumInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Email:')]//following::input[1]")]
        public IWebElement EmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Transfer From Program:')]//child::span")]
        public IWebElement TransferFromProgramTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Transfer From Occupation:')]//child::span")]
        public IWebElement TransferFromOccupationTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='mm/dd/yyyy']")]
        public IWebElement TransferDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Program Name:')]//following::input[1]")]
        public IWebElement ProgramNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Program Name:')]//following::button[1]")]
        public IWebElement ProgramNameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Program Name:')]//following::ul[1]/li/span")]
        public IList<IWebElement> ProgramNameDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-1 ui-md-3 ui-sm-12']//label[@class='label-padding font-weight-bold'][contains(text(),'Occupation:')]//following::div[1]")]
        public IWebElement OccupationDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-g-1 ui-md-3 ui-sm-12']//label[@class='label-padding font-weight-bold'][contains(text(),'Occupation:')]//following::div[1]//li/span")]
        public IList<IWebElement> OccupationDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Employer Name:')]//following::div[1]")]
        public IWebElement EmployerNameDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Employer Name:')]//following::div[1]//li/span")]
        public IList<IWebElement> EmployerNameDrpdwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'License #:')]//following::input[1]")]
        public IWebElement LicenseInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Credit Prev Experience:')]//following::input[1]")]
        public IWebElement CreditPrevExperienceInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Credit Prev RSI Experience:')]//following::input[1]")]
        public IWebElement CreditPrevRSIExperienceInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Step:')]//following::div[1]")]
        public IWebElement StepDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Step:')]//following::div[1]//li/span")]
        public IList<IWebElement> StepDrpDwnOptions { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement CancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='ui-button-text ui-clickable'][contains(text(),'Transfer')]")]
        public IWebElement TransferBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ui-growl-item']/div/p")]
        public IWebElement ErrorMessageTxt { get; set; }

        public void FirstName_Input(string n)
        {
            Selenium.Driver.SendKeys(FirstNameInput, n, "FirstNameInput");
        }
        public void LastName_Input(string n)
        {
            Selenium.Driver.SendKeys(LastNameInput, n, "LastNameInput");
        }
        public void MiddleName_Input(string n)
        {
            Selenium.Driver.SendKeys(MiddleNameInput, n, "MiddleNameInput");
        }
        public void AddressLine1_Input(string n)
        {
            Selenium.Driver.SendKeys(AddressLine1Input, n, "AddressLine1Input");
        }
        public void AddressLine2_Input(string n)
        {
            Selenium.Driver.SendKeys(AddressLine2Input, n, "AddressLine2Input");
        }
        public void City_Input(string n)
        {
            Selenium.Driver.SendKeys(CityInput, n, "CityInput");
        }
        public void StateDrpDwn_Select(string n)
        {
            Selenium.Driver.Click(StateDrpDwnBtn, "StateDrpDwnBtn");
            Selenium.Driver.Click(StateDrpDwnOptions[int.Parse(n)], "StateDrpDwnOptions");
        }
        public void ZipCode_Input(string n)
        {
            Selenium.Driver.SendKeys(ZipCodeInput, n, "ZipCodeInput");
        }
        public void PhoneNum_Input(string n)
        {
            Selenium.Driver.SendKeys(PhoneNumInput, n, "PhoneNumInput");
        }
        public void Email_Input(string n)
        {
            Selenium.Driver.SendKeys(EmailInput, n, "EmailInput");
        }
        public string TransferFromProgram_Txt()
        {
            return Selenium.Driver.GetText(TransferFromProgramTxt,  "TransferFromProgramTxt");
        }
        public string TransferFromOccupation_Txt()
        {
            return Selenium.Driver.GetText(TransferFromOccupationTxt, "TransferFromOccupationTxt");
        }
        public void TransferDate_Input(string n)
        {
            Thread.Sleep(3000);
            Selenium.Driver.SendKeys(TransferDateInput, n ,"TransferDateInput");
            Thread.Sleep(3000);
        }
        public void ProgramName_Input(string n)
        {
            Selenium.Driver.SendKeys(ProgramNameInput, n, "ProgramNameInput");
            Selenium.Driver.Click(ProgramNameDrpDwnOptions[0], "ProgramNameDrpDwnOptions");
            Thread.Sleep(3000);
        }
        public void OccupationDrpDwn_Select(string n)
        {
            Selenium.Driver.Click(OccupationDrpDwnBtn, "OccupationDrpDwnBtn");
            Selenium.Driver.Click(OccupationDrpDwnOptions[int.Parse(n)], "OccupationDrpDwnOptions");
        }
        public void EmployerNameDrpDwn_Select(string n)
        {
            Selenium.Driver.Click(EmployerNameDrpDwnBtn, "EmployerNameDrpDwnBtn");
            Selenium.Driver.Click(EmployerNameDrpdwnOptions[int.Parse(n)], "EmployerNameDrpdwnOptions");
        }
        public void License_Input(string n)
        {
            Selenium.Driver.SendKeys(LicenseInput, n, "LicenseInput");
        }
        public void CreditPrevExperience_Input(string n)
        {
            int m = int.Parse(n);
            if (m == 0)
            {
                Selenium.Driver.Clear(CreditPrevExperienceInput, "CreditPrevExperienceInput");
                Selenium.Driver.SendKeys(CreditPrevExperienceInput, "0", "CreditPrevExperienceInput");
            }
            else
            {
                Selenium.Driver.Clear(CreditPrevExperienceInput, "CreditPrevExperienceInput");
                Selenium.Driver.SendKeys(CreditPrevExperienceInput, n, "CreditPrevExperienceInput");
            }
        }
        public void CreditPrevRSIExperience_Input(string n)
        {
            int m = int.Parse(n);
            if (m == 0)
            {
                Selenium.Driver.Clear(CreditPrevRSIExperienceInput, "CreditPrevRSIExperienceInput");
                Selenium.Driver.SendKeys(CreditPrevRSIExperienceInput, "0", "CreditPrevRSIExperienceInput");
            }
            else
            {
                Selenium.Driver.Clear(CreditPrevRSIExperienceInput, "CreditPrevRSIExperienceInput");
                Selenium.Driver.SendKeys(CreditPrevRSIExperienceInput, n, "CreditPrevRSIExperienceInput");
            }
        }
        public void StepDrpDwn_Select(string n)
        {
            Selenium.Driver.Click(StepDrpDwnBtn, "StepDrpDwnBtn");
            Selenium.Driver.Click(StepDrpDwnOptions[int.Parse(n)], "StepDrpDwnOptions");
        }
        public void Cancel_Btn()
        {
            Selenium.Driver.Click(CancelBtn, "CancelBtn");
        }
        public void Transfer_Btn()
        {
            Selenium.Driver.Click(TransferBtn, "TransferBtn");
        }
        public string ErrorMessage_Txt()
        {
            return Selenium.Driver.GetText(ErrorMessageTxt, "ErrorMessageTxt");
        }
    }
}
