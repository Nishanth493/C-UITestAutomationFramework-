using System;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Registration
{
    public class AppReg_Form_Page_Internal : Base
    {

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'FirstName')]")]
        public IWebElement FirstNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'MiddleName')]")]
        public IWebElement MiddleNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'LastName')]")]
        public IWebElement LastNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'AddressLine1')]")]
        public IWebElement AddressLine1Input { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'AddressLine2')]")]
        public IWebElement AddressLine2Input { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'City')]")]
        public IWebElement CityInput { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-apprentice-registration/div/form/div[1]/div[1]/p-panel/div/div[2]/div/div[8]/div[2]/p-dropdown/div/label")]
        public IWebElement StateDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'State, Zip:')]//following::ul[1]/li/span")]
        public IList<IWebElement> StateDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui-dropdown-filter-container ng-tns-c4-434')]//input[contains(@type,'text')]")]
        public IWebElement StateSearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'ZipCode')]")]
        public IWebElement ZipCodeInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'Phone')]")]
        public IWebElement PhoneInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'Email')]")]
        public IWebElement EmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-apprentice-registration/div/form/div[1]/div[1]/p-panel/div/div[2]/div/div[11]/div[2]/p-dropdown/div/label")]
        public IWebElement GenderDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Gender:')]//following::ul[1]/li")]
        public IList<IWebElement> GenderDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Birth Date:')]//following::input[1]")]
        public IWebElement BirthDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-apprentice-registration/div/form/div[1]/div[1]/p-panel/div/div[2]/div/div[13]/div[2]/p-dropdown/div/label")]
        public IWebElement MilitaryStatusDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Military Status:')]//following::ul[1]/li")]
        public IList<IWebElement> MilitaryStatusDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-apprentice-registration/div/form/div[1]/div[1]/p-panel/div/div[2]/div/div[14]/div[2]/p-multiselect/div/div[2]/label")]
        public IWebElement RaceDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Race:')]//following::ul/li")]
        public IList<IWebElement> RaceDrpDwnOptions { get; set; }


        [FindsBy(How = How.XPath, Using = "/ html/body/app-root/div/div/app-apprentice-registration/div/form/div[1]/div[1]/p-panel/div/div[2]/div/div[14]/div[2]/p-multiselect/div/div[4]/div[1]/a")]
        public IWebElement RaceDrpDwnCloseBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-apprentice-registration/div/form/div[1]/div[1]/p-panel/div/div[2]/div/div[15]/div[2]/p-radiobutton/div/div/span")]
        public IList<IWebElement> EthnicGroupRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-apprentice-registration/div/form/div[1]/div[1]/p-panel/div/div[2]/div/div[16]/div[2]/p-dropdown/div/label")]
        public IWebElement EducationLevelDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Education Level:')]//following::ul[1]/li")]
        public IList<IWebElement> EducationLevelDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Begin Date:')]//following::input[1]")]
        public IWebElement BeginDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Program Name:')]//following::label[1]")]
        public IWebElement ProgramNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/div/app-apprentice-registration/div/form/div[1]/div[2]/p-panel/div/div[2]/div/div[3]/div[2]/p-dropdown/div/label")]
        public IWebElement SubProgramBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ng-tns-c3-39 ui-dropdown-panel ui-widget-content ui-corner-all ui-helper-hidden ui-shadow ng-trigger ng-trigger-panelState')]//child::ul/li/span")]
        public IList<IWebElement> SubProgramDrpDwn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-apprentice-registration[1]/div[1]/form[1]/div[1]/div[2]/p-panel[1]/div[1]/div[2]/div[1]/div[3]/div[2]/p-dropdown[1]/div[1]/label[1]")]
        public IWebElement OccupationDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Occupation:')]//following::ul[1]/li")]
        public IList<IWebElement> OccupationDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'CreditForPreviousExperince')]")]
        public IWebElement CreditPrevOJTExperienceInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'PrevRSIExp')]")]
        public IWebElement CreditPrevRSIExperienceInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Step:')]//following::div[1]/p-dropdown")]
        public IWebElement StepDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Step:')]//following::div[1]/p-dropdown//li/span")]
        public IList<IWebElement> StepDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Direct Entry:')]//following::div[1]/p-dropdown")]
        public IWebElement DirectEnteryDrpDwnBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Direct Entry:')]//following::div[1]/p-dropdown//li/span")]
        public IList<IWebElement> DirectEnteryDrpDwnOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@name,'Comments')]")]
        public IWebElement CommentsInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Cancel')]")]
        public IWebElement CancelLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Register')]")]
        public IWebElement RegisterBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'ui-messages-summary')]")]
        public IWebElement MessageTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'ui-messages-detail')]")]
        public IWebElement AppRegIDTxt { get; set; }

        /// <summary>
        /// Inputs apprentice first name
        /// </summary>
        /// <param name="n"></param>
        public void FirstName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(FirstNameInput, n, "FirstNameInput");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Inputs apprentice middle name 
        /// </summary>
        /// <param name="n"></param>
        public void MiddleName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(MiddleNameInput, n, "MiddleNameInput");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Inputs apprentice last name
        /// </summary>
        /// <param name="n"></param>
        public void LastName_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(LastNameInput, n, "LastNameInput");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Inputs apprentice address Line 1
        /// </summary>
        /// <param name="n"></param>
        public void AddressLine1_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(AddressLine1Input, n, "AddressLine1Input");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// inputs apprentice address line 2
        /// </summary>
        /// <param name="n"></param>
        public void AddressLine2_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(AddressLine2Input, n, "AddressLine2Input");
        }

        /// <summary>
        /// Inputs apprentice city 
        /// </summary>
        /// <param name="n"></param>
        public void City_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(CityInput, n, "CityInput");
        }

        /// <summary>
        /// selects state from the dropdown, by inputting dropdown index 
        /// </summary>
        /// <param name="n"></param>
        public void State_DrpDwn(string n)
        {
            int number = Int32.Parse(n);

            Selenium.Driver.Click(StateDrpDwnBtn, "StateDrpDwnBtn");
            Selenium.Driver.Click(StateDrpDwnOptions[number], "StateDrpDwnOptions["+n+"]");
        }

        /// <summary>
        /// Inputs apprentice state 
        /// </summary>
        /// <param name="n"></param>
        public void StateSearch_Input(string n)
        {
            Selenium.Driver.SendKeys(StateSearchInput,  n, "StateSearchInput");
        }

        /// <summary>
        /// Inputs apprentice state 
        /// </summary>
        /// <param name="n"></param>
        public void ZipCode_Input(string n)
        {
            Selenium.Driver.SendKeys(ZipCodeInput, n, "ZipCodeInput");
        }

        /// <summary>
        /// Inputs apprentice Phone Number
        /// </summary>
        /// <param name="n"></param>
        public void Phone_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(PhoneInput, n, "PhoneInput");
        }

        /// <summary>
        /// Inputs apprentice Email
        /// </summary>
        /// <param name="n"></param>
        public void Email_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(EmailInput, n, "EmailInput");
        }

        /// <summary>
        /// Selects gender from dropdown, by entering dropdown index
        /// </summary>
        /// <param name="n"></param>
        public void Gender_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(GenderDrpDwnBtn, "GenderDrpDwnBtn");
            Thread.Sleep(1000);
            Selenium.Driver.Click(GenderDrpDwnOptions[number], "GenderDrpDwnOptions[" + number + "]");
        }

        /// <summary>
        /// Inputs apprentice Birth Date
        /// </summary>
        /// <param name="n"></param>
        public void DOB_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(BirthDateInput, n, "BirthDateInput");
        }

        /// <summary>
        /// Selects Military Status from dropdown, by inputting dropdown index
        /// </summary>
        /// <param name="n"></param>
        public void MilitaryStatus_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(MilitaryStatusDrpDwnBtn, "MilitaryStatusDrpDwnBtn");
            Thread.Sleep(1000);
            Selenium.Driver.Click(MilitaryStatusDrpDwnOptions[number], "MilitaryStatusDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Selects Race from dropdown, by inputting dropdown index
        /// </summary>
        /// <param name="n"></param>
        public void Race_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(RaceDrpDwnBtn, "RaceDrpDwnbtn");
            Thread.Sleep(1000);
            Selenium.Driver.Click(RaceDrpDwnOptions[number], "RaceDrpDwnOptions[" + n + "]");
            Selenium.Driver.Click(RaceDrpDwnCloseBtn, "RaceDrpDwnCloseBtn");
        }

        /// <summary>
        /// Selects Ehinic Group Radio Button, by inputting radio button index
        /// </summary>
        /// <param name="n"></param>
        public void EthinicGroup_RdoBtn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(EthnicGroupRdoBtn[number], "EthnicGroupRdoBtn[" + n + "]");
        }

        /// <summary>
        /// Selects Education Level from dropdown, by inputting dropdown index
        /// </summary>
        /// <param name="n"></param>
        public void EducationLevel_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(EducationLevelDrpDwnBtn, "EducationLevelDrpDwnBtn");
            Thread.Sleep(1000);
            Selenium.Driver.Click(EducationLevelDrpDwnOptions[number], "EducationLevelDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Inputs the Begin Date
        /// </summary>
        /// <param name="n"></param>
        public void BeginDate_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(BeginDateInput, n, "BeginDateInput");
        }

        /// <summary>
        /// Gets the program name text
        /// </summary>
        /// <returns></returns>
        public string ProgramName_Txt()
        {
            return Selenium.Driver.GetText(ProgramNameTxt, "ProgramNameTxt");
        }

        /// <summary>
        /// Gets the Sub-program name text
        /// </summary>
        /// <returns></returns>
        public void SubProgramName_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(SubProgramBtn, "SubProgramBtn");
            Thread.Sleep(1000);
            Selenium.Driver.Click(SubProgramDrpDwn[number], "SubProgramDrpDwn["+number+"]");
        }

        /// <summary>
        /// Selects Occupation Name from dropdown, by inputting radio button index
        /// </summary>
        /// <param name="n"></param>
        public void Occupation_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(OccupationDrpDwnBtn, "OccupationDrpDwnBtn");
            Thread.Sleep(1000);
            Selenium.Driver.Click(OccupationDrpDwnOptions[number], "OccupationDrpDwnOptions[" + n + "]");
        }


        /// <summary>
        /// Inputs OJT credit hours for previous experience
        /// </summary>
        /// <param name="n"></param>
        public void CreditPRevOJTExp_InputTxt(string n)
        {
            Selenium.Driver.Clear(CreditPrevOJTExperienceInput, "CreditPrevOJTExperienceInput");
            Selenium.Driver.SendKeys(CreditPrevOJTExperienceInput, n, "CreditPrevOJTExperienceInput");
        }

        /// <summary>
        /// Input RSI credit hours for previous experience
        /// </summary>
        /// <param name="n"></param>
        public void CreditPRevRSIExp_InputTxt(string n)
        {
            Selenium.Driver.Clear(CreditPrevRSIExperienceInput, "CreditPrevRSIExperienceInput");
            Selenium.Driver.SendKeys(CreditPrevRSIExperienceInput, n, "CreditPrevRSIExperienceInput");
        }

        /// <summary>
        /// Selects Step Number from dropdown, by inputting dropdown index
        /// </summary>
        /// <param name="n"></param>
        public void Step_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(StepDrpDwnBtn, "StepDrpDwnBtn");
            Thread.Sleep(1000);
            Selenium.Driver.Click(StepDrpDwnOptions[number], "StepDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Selects Direct Entry (Yes/No) from dropdown, by inputting dropdown index
        /// </summary>
        /// <param name="n"></param>
        public void DirectEntry_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(DirectEnteryDrpDwnBtn, "DirectEnteryDrpDwnBtn");
            Selenium.Driver.Click(DirectEnteryDrpDwnOptions[number], "DirectEnteryDrpDwnOptions[" + n + "]");
        }

        /// <summary>
        /// Inputs comment
        /// </summary>
        /// <param name="n"></param>
        public void Comment_InputTxt(string n)
        {
            Selenium.Driver.SendKeys(CommentsInput, n, "CommentsInput");
        }

        /// <summary>
        /// Selects cancel option
        /// </summary>
        public void Cancel_Lnk()
        {
            Selenium.Driver.Click(CancelLnk, "CancelLnk");
        }

        /// <summary>
        /// Selects register button
        /// </summary>
        public void Register_Btn()
        {
            Selenium.Driver.Click(RegisterBtn, "RegisterBtn");
        }

        /// <summary>
        /// Gets the status message of apprentice registration
        /// </summary>
        /// <returns></returns>
        public string Message_Txt()
        {
            return Selenium.Driver.GetText(MessageTxt, "MessageTxt");
        }

        /// <summary>
        /// Gets apprentice ID number 
        /// </summary>
        /// <returns></returns>
        public int AppRegID_NumTxt()
        {
            Thread.Sleep(3000);
            string []  FullMsg = Selenium.Driver.GetText(AppRegIDTxt, "AppRegIDTxt").Split(':');
            int Id = Int32.Parse(FullMsg[1]);
            return Id;
        }

    }
}
