using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository
{ 
    public class LoginPage : Base
    {
        [FindsBy(How=How.XPath,Using = "//*[@id='butLogin']")]
        public IWebElement Btn_Login { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement TxtBox_ID{ get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement TxtBox_Password { get; set; }

        public void EnterLoginId(string userid)
        {
            Selenium.Driver.SendKeysJS(TxtBox_ID, userid, "TxtBox_ID");
        }
        public void EnterPassword(string password)
        {
            Selenium.Driver.SendKeys(TxtBox_Password, password, "TxtBox_Password");
        }
        public  void ClickLoginButton()
        {
            Selenium.Driver.Click(Btn_Login, "Btn_Login");  
        }
        
        public void Login(string username, string password)
        {
            EnterLoginId(username);
            EnterPassword(password);
            Selenium.Driver.Click(TxtBox_ID, "TxtBox_ID");
            Thread.Sleep(1000);
            ClickLoginButton();

        }

    }
}