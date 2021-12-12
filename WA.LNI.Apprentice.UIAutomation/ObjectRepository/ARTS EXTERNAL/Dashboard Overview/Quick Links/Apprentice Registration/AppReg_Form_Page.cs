using System;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.Apprentice_Registration
{
    public class AppReg_Form_Page : Base
    {
        [FindsBy(How = How.CssSelector, Using = "div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.lni-o-layout--simple div:nth-child(3) div:nth-child(1) div.lni-c-element-container.lni-element-show:nth-child(1) div:nth-child(1) > div.lni-c-collapse.lni-reset-transition-duration.lni-u-mt2:nth-child(7)")]
        public IWebElement App_RegForm { get; set; }

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement FirstNameInputBox { get; set; }

      /*[FindsBy(How = How.XPath, Using = "//input[@id='firstName']//preceding::span[2]")]
        public IWebElement FirstNameInputBoxErrorTxt { get; set; }
        */
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//ul[@class='lni-u-reset-list']//child::li")]
        public IList<IWebElement> ErrorMsgListLnks { get; set; }

        [FindsBy(How = How.Id, Using = "initial")]
        public IWebElement initialInputBox { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement LastNameInputBox { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//*[@id='suffix']//child::option")]
        public IList<IWebElement> SuffixDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "primaryAddress_address1")]
        public IWebElement Address1InputBox { get; set; }

        [FindsBy(How = How.Id, Using = "primaryAddress_address2")]
        public IWebElement Address2InputBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#primaryAddress_city")]
        public IWebElement CityInputBox { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//*[@id='primaryAddress_state']//child::option")]
        public IList<IWebElement> StateDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "primaryAddress_zipCode")]
        public IWebElement ZipCodeInputBox { get; set; }

        [FindsBy(How = How.Id, Using = "applicantPhone_phone")]
        public IWebElement PhoneInputBox { get; set; }

        [FindsBy(How = How.Id, Using = "applicantEmail")]
        public IWebElement EmailInputBox { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@id='apprenticeGenderForRegistration']//child::div")]
        public IList<IWebElement> GenderSelectionRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='birthDate-wrapper']//div[@class='lni-u-flex lni-u-items-stretch']//preceding::span[2]")]
        public IWebElement DOBErrormsg { get; set; }

        [FindsBy(How = How.Id, Using = "birthDate")]
        public IWebElement DOBInputBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.lni-o-layout--simple div.lni-c-element-container.lni-element-show:nth-child(1) div.lni-c-collapse.lni-reset-transition-duration.lni-u-mt2:nth-child(7) div.lni-c-element-container:nth-child(5) div:nth-child(1) div.lni-c-form-control--datepicker.lni-c-form-control--custom-width.lni-c-form-control--required:nth-child(4) div.lni-u-flex.lni-u-items-stretch > button.lni-c-datepicker__button.lni-c-button--control.lni-u-flex.lni-u-items-center")]
        public IWebElement DobCalenderOption { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//*[@class='flatpickr-calendar animate arrowTop open']//child::div")]
        public IList<IWebElement> DobCalenderSelector { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//*[@class='lni-u-flex lni-u-flex-column lni-u-items-start']//child::div")]
        public IList<IWebElement> EthnicitySelectorChkBox { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@id='ethnicGroup']//div//span")]
        public IList<IWebElement> EthnicGroupSelectorChkBox { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@id='highestEducationLevel']//child::div")]
        public IList<IWebElement> EducationRdoBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@id='militaryStatus']//child::div")]
        public IList<IWebElement> MilitaryStatusRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='apprenticeshipOccupation']")]
        public IWebElement OccupationDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "occupationLicenseNumber")]
        public IWebElement LicenceOrCerificateNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='registrationSubProgram']")]
        public IWebElement SubProgramDrppDwn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//*[@id='applicantQualifiedForDirectEntry']//child::div/label")]
        public IList<IWebElement> DirectEntryRdoBtn { get; set; }

        [FindsBy(How = How.Id, Using = "apprenticeBeginDate")]
        public IWebElement BeginDateInputBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.lni-o-layout--simple div.lni-c-element-container.lni-element-show:nth-child(1) div.lni-c-collapse.lni-reset-transition-duration.lni-u-mt2:nth-child(7) div.lni-c-element-container.lni-u-mt4:nth-child(6) div:nth-child(1) div.lni-c-form-control--datepicker.lni-c-form-control--custom-width.lni-c-form-control--required:nth-child(7) div.lni-u-flex.lni-u-items-stretch > button.lni-c-datepicker__button.lni-c-button--control.lni-u-flex.lni-u-items-center")]
        public IWebElement BeginDateCalenderOption { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='flatpickr-calendar animate open arrowBottom']//child::div")]
        public IList<IWebElement> BeginDateCalenderSelector { get; set; }

        [FindsBy(How = How.Id, Using = "creditHours")]
        public IWebElement PreviousOJTCreditHoursInput { get; set; }

        [FindsBy(How = How.Id, Using = "rsiPreviousExperience")]
        public IWebElement PreviousRSICreditHoursInput { get; set; }

        [FindsBy(How = How.Id, Using = "registrationPageComments")]
        public IWebElement CommentsAppRegInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.lni-o-layout--simple div.lni-c-element-container.lni-element-show:nth-child(1) div.lni-c-collapse.lni-reset-transition-duration.lni-u-mt2:nth-child(7) div.lni-c-element-container.lni-u-mt4:nth-child(6) div:nth-child(1) div.lni-c-checkbox:nth-child(15) > label.lni-c-checkbox__label")]
        public IWebElement confirmAgreementChkBox { get; set; }

        [FindsBy(How = How.Id, Using = "previewApprenticeRegistration")]
        public IWebElement RegisterApprenticeBtn { get; set; }


        /// <summary>
        /// Enters the
        /// </summary>
        /// <param name="firstName"></param>
        public void AppFirstName_Input (string firstName)
        {
            Selenium.Driver.SendKeys(FirstNameInputBox, firstName, "FirstNameInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Gets all the error message list
        /// </summary>
        /// <param list number ="n"></param>
        public string AppFormErrorMsgList_Txt(int n)
        {
            return Selenium.Driver.GetText(ErrorMsgListLnks[n], "ErrorMsgListLnks["+n+"]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Gets all the error message list
        /// </summary>
        /// <param list number ="n"></param>
        public void AppFormErrorMsgList_Lnk(int n)
        {
            Thread.Sleep(1000);
            Selenium.Driver.Click(ErrorMsgListLnks[n], "ErrorMsgListLnks[" + n + "]");
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Enters the initial 
        /// </summary>
        /// <param Initual ="initial"></param>
        public void AppInitial_Input(string initial)
        {
            Selenium.Driver.SendKeys(initialInputBox, initial, "initialInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the Last Name 
        /// </summary>
        /// <param Lst Name ="lastName"></param>
        public void AppLastName_Input(string lastName)
        {
            Selenium.Driver.SendKeys(LastNameInputBox, lastName, "LastNameInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Apprentice suffix, by inputting "0" for "Sr.", "1" for "Jr.", "2" for "II", "3" for "III", "4" for "IV" 
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void Suffic_DrpDwn(string n)
        {
            int number = Int32.Parse(n);             
            Selenium.Driver.Click(SuffixDrpDwn[number], "SuffixDrpDwn["+n+"]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters address in the address line 1
        /// </summary>
        /// <param Address Line 1 ="address1"></param>
        public void Address1_Input(string address1)
        {
            Selenium.Driver.SendKeys(Address1InputBox,address1, "Address1InputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters address in the address line 2
        /// </summary>
        /// <param Address Line 2="address2"></param>
        public void Address2_Input(string address2)
        {
            Selenium.Driver.SendKeys(Address2InputBox, address2, "Address2InputBoxaddress2");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the city
        /// </summary>
        /// <param City="city"></param>
        public void City_Input(string city)
        {
            Selenium.Driver.SendKeys(CityInputBox, city, "CityInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Apprentice State, by inputting a range from "0" to "58", states arranged in alphabetical order
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void State_DrpDwn(string n)
        {
            int number = Int32.Parse(n);             
            Selenium.Driver.Click(StateDrpDwn[number], "StateDrpDwn["+n+"]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// enters the ZIP Code
        /// </summary>
        /// <param Zip Code ="zip"></param>
        public void ZipCode_Input(string zip)
        {
            Selenium.Driver.SendKeys(ZipCodeInputBox, zip, "ZipCodeInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the phone number 
        /// </summary>
        /// <param Phone Number ="phone"></param>
        public void AppPhone_Input(string phone)
        {
            Selenium.Driver.SendKeys(PhoneInputBox, phone, "PhoneInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the Email ID
        /// </summary>
        /// <param Email ID="email"></param>
        public void AppEmail_Input(string email)
        {
            Selenium.Driver.SendKeys(EmailInputBox,email, "EmailInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Apprentice gender, by inputting a range from "0" for "Male", "1" for "Female"
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void AppGenderSelection_RdoBtn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(GenderSelectionRdoBtn[number], "GenderSelectionRdoBtn["+n+"]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the date of birth
        /// </summary>
        /// <param Birth Date ="dob"></param>
        public void AppDOB_InputBox(string dob)
        {
            Selenium.Driver.SendKeys(DOBInputBox, dob, "DOBInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Date of birth Error Message 
        /// </summary>
        /// <returns></returns>
        public string AppDOBerrormsg_Txt()
        {
            return Selenium.Driver.GetText(DOBErrormsg, "DOBErrormsg");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Apprentice Ethinicity/Race, by inputting a range from 
        /// "0" for "Not Specified", "1" for "Asian", "2" for "Black or African American", 
        /// "3" for "Hispanic", "4" for "American Indian or Alaska Native", "5" for "White"
        /// "6" for "Native Hawaiian or Pacific Islander", "7" for "Not Elsewhere Classified"
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void EthinicitySelector_chkBox(string n)
        {
            int number = Int32.Parse(n);
            int listCount = EthnicitySelectorChkBox.Count;

            while (number < listCount)
            {  
                for ( int i = 0; i < number; i++)
                { 
                Selenium.Driver.Click(EthnicitySelectorChkBox[i], "EthnicitySelectorChkBox[" + i + "]");
                }
                break;
            }
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Apprentice Ethinicity/Race, by inputting a range from 
        /// "0" for "Not Specified", "1" for "Asian", "2" for "Black or African American", 
        /// "3" for "Hispanic", "4" for "American Indian or Alaska Native", "5" for "White"
        /// "6" for "Native Hawaiian or Pacific Islander", "7" for "Not Elsewhere Classified"
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void EthinicGroupSelector_chkBox(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(EthnicGroupSelectorChkBox[number], "EthnicGroupSelectorChkBox[" + n + "]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Apprentice Education, by inputting a range from 
        /// "0" for "Not Specified", "1" for "8th grade or less", "2" for "Some high school (9th-12th)", 
        /// "3" for "GED", "4" for "High school graduate", "5" for "College or greater"
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void EducationSelector_chkBox(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(EducationRdoBtn[number], "EducationRdoBtn["+n+"]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Apprentice Ethinicity/Race, by inputting a range from 
        /// "0" for "Not Specified", "1" for "8th grade or less", "2" for "Some high school (9th-12th)", 
        /// "3" for "GED", "4" for "High school graduate", "5" for "College or greater"
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void MilitarySelector_chkBox(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.Click(MilitaryStatusRdoBtn[number], "MilitaryStatusRdoBtn["+n+"]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Program Occupation, by inputting a range from 1 to  number of occupation in that program
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void OccupationSelector_DrpDwn(string n)
        {
            int number = Int32.Parse(n);  
            Selenium.Driver.SelectDropDownByValue(OccupationDrpDwn, n, "OccupationDrpDwn");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the Lisence number
        /// </summary>
        /// <param name="LicNum"></param>
        public void LicenceNumber_Input(string LicNum)
        {
            Selenium.Driver.SendKeys(LicenceOrCerificateNumber, LicNum, "LicenceOrCerificateNumber");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select eligibility for Apprentice Direct Entry, by inputting "0" for "yes" and "1" for "No"
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void DirectEntery_RdoBtn(string n)
        {
            int number = Int32.Parse(n);             
            Selenium.Driver.Click(DirectEntryRdoBtn[number], "DirectEntryRdoBtn["+n+"]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Program Occupation, by inputting a range from 1 to  number of occupation in that program
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void SubProgram_DrpDwn(string n)
        {
            int number = Int32.Parse(n);
            Selenium.Driver.SelectDropDownByIndex(SubProgramDrppDwn, number, "SubProgramDrppDwn");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the Begin Date
        /// </summary>
        /// <param Begin Date="BeginDate"></param>
        public void BeginDate_Input(string BeginDate)
        {
            Selenium.Driver.SendKeys(BeginDateInputBox, BeginDate, "BeginDateInputBox");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Clicks on Calender option 
        /// </summary>
        public void BeginDateCalender_Btn()
        {
            Selenium.Driver.Click(BeginDateCalenderOption, "BeginDateCalenderOption");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Select Begin Date from Calender,
        /// </summary>
        /// <param name="n"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void BeginDateCalander_Selector(int n)
        {
            Selenium.Driver.Click(BeginDateCalenderSelector[n], "BeginDateCalenderSelector["+n+"]");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the Previous OJT credits 
        /// </summary>
        /// <param Prev. OJT Hours="previousCreditHours"></param>
        public void CreditPreviousOJTExp_Input(string previousCreditHours)
        {
            Selenium.Driver.SendKeys(PreviousOJTCreditHoursInput, previousCreditHours, "PreviousOJTCreditHoursInput");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enters the Previous RSI credits 
        /// </summary>
        /// <param Prev. RSI Hours="previousCreditHours"></param>
        public void CreditPreviousRSIExp_Input(string previousCreditHours)
        {
            Selenium.Driver.SendKeys(PreviousRSICreditHoursInput, previousCreditHours, "PreviousRSICreditHoursInput");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Enter the comments in the comment box
        /// </summary>
        /// <param Comment="comments"></param>
        public void CommentBoxAppReg_Input(string comments)
        {
            Selenium.Driver.SendKeys(CommentsAppRegInput, comments, "CommentsAppRegInput");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Clicks on the check Box to confirm the agreement 
        /// </summary>
        public void ConfirmAgreement_ChkBox()
        {
            Thread.Sleep(1000);
            Selenium.Driver.ActionMoveToElemenet(confirmAgreementChkBox, "confirmAgreementChkBox");
            Thread.Sleep(1000);
            Selenium.Driver.Click(confirmAgreementChkBox, "confirmAgreementChkBox");
        }

        /// <summary>
        /// Cliks on the 'Register Apprentice' Button 
        /// </summary>
        public void RegisterApp_Btn()
        {
            Selenium.Driver.Click(RegisterApprenticeBtn, "RegisterApprenticeBtn");
            Thread.Sleep(1000);
        }

    }
}
