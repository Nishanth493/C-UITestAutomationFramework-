using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;


namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.RegistrationsAndTransfer_creations__Extras_
{
    public class Account_SignUps : Base
    {
        [FindsBy(How = How.Id, Using = "butSignup")]
        public IWebElement SignUpBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='firstName']//following::input[1]")]
        public IWebElement FirstNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='lastName']//following::input[1]")]
        public IWebElement LastNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='emailAddress']//following::input[1]")]
        public IWebElement EmailAddressInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='retypeEmail']//following::input[1]")]
        public IWebElement RetypeEmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='contactPhone']//following::input[1]")]
        public IWebElement PhoneInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='userIdTextBox']//following::input[1]")]
        public IWebElement UserIDInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='password']//following::input[1]")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='retypePassword']//following::input[1]")]
        public IWebElement RetypePasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "secretQuestion")]
        public IWebElement SecretQuestionDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='secretAnswer']//following::input[1]")]
        public IWebElement YourAnswerInput { get; set; }

        [FindsBy(How = How.Id, Using = "chkAgree")]
        public IWebElement AcceptCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='initials']//following::input[1]")]
        public IWebElement YourInitials { get; set; }

        [FindsBy(How = How.Id, Using = "//label[@for='lnkButContinue")]
        public IWebElement ContinueButton { get; set; }

        [FindsBy(How = How.Id, Using = "//label[@for='lnkButCancel")]
        public IWebElement CancelButton { get; set; }

        public void SignUp_Btn()
        {
            Selenium.Driver.Click(SignUpBtn, "SignUpBtn");
        }

        public void LastName_Input(string n)
        {
            Selenium.Driver.SendKeys(LastNameInput, n, "LastName");
        }

        public void EmailAddress_Input(string n)
        {
            Selenium.Driver.SendKeys(EmailAddressInput, n, "EmailAddressInput");
        }

        public void RetypeEmail_Input(string n)
        {
            Selenium.Driver.SendKeys(RetypeEmailInput, n, "RetypeEmailInput");
        }

        public void Phone_Input(string n)
        {
            Selenium.Driver.SendKeys(PhoneInput, n, "PhoneInput");
        }

        public void FirstName_Input(string n)
        {
            Selenium.Driver.SendKeys(FirstNameInput, n, "FirstNameInput");
        }

        public void UserID_Input(string n)
        {
            Selenium.Driver.SendKeys(UserIDInput, n, "UserIDInput");

        }

        public void Password_Input(string n)
        {
            Selenium.Driver.SendKeys(PasswordInput, n, "PasswordInput");
        }

        public void RetypePassword_Input(string n)
        {
            Selenium.Driver.SendKeys(RetypePasswordInput, n, "RetypePasswordInput");
        }


        public void SecretQuestion_DropDown(int n)
        {
            Selenium.Driver.SelectDropDownByIndex(SecretQuestionDropDown, n, "SecretQuestionDropDown");
        }


        public void YourAnswer_Input(string n)
        {
            Selenium.Driver.SendKeys(YourAnswerInput, n, "YourAnswerInput");
        }

        public void Accept_CheckBox()
        {
            Selenium.Driver.Click(AcceptCheckBox, "AcceptCheckBox");
        }

        public void YourInitials_Input(string n)
        {
            Selenium.Driver.SendKeys(YourInitials, n, "YourInitials");
        }

        public void Cancel_Button()
        {
            Selenium.Driver.Click(CancelButton, "CancelButton");
        }

        public void Continue_Button()
        {
            Selenium.Driver.Click(ContinueButton, "ContinueButton");
        }

    }
}
