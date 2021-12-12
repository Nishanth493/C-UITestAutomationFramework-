using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository
{
    public class LandingPage : Base
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='launchItems']/div[3]/div[2]/div/input")]
        public IWebElement AdditionalTasks { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.greyBackground:nth-child(3) div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.container:nth-child(1) div.clearfix.bottom-30:nth-child(1) div.eight.columns.alpha:nth-child(2) div:nth-child(1) div.launchpadAudience div.text-right div.singleAudienceWrapper > input.orangeButton.dashboardButton.bottom-10")]
        public IWebElement MyTasks { get; set; }

        [FindsBy(How = How.Id, Using = "artspreprod")]
        public IWebElement Apprentice{get; set;}

        [FindsBy(How = How.XPath, Using = "//input[@value = 'Apprenticeship Sponsor Tasks']")]
        public IWebElement ApprenticeshipSponsoredTaks { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Apprenticeships')]")]
        public IWebElement ApprenticeTaskOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#arts")]
        public IWebElement ApprenticeDev { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#selectApprenticeProgramId")]
        public IWebElement PrgrmDrpDwn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#programDetailsPage")]
        public IWebElement Go { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "#Home")]
        public IWebElement LandingPageHomeTabTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-button")]
        public IWebElement ArtsInternalMenuBtn { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Home")]
        public IWebElement HomeTab { get; set; }

        public void ToLandingPage()
        {
           /* if (Selenium.Driver.IsDisplayed(ArtsInternalMenuBtn, "ArtsInternalMenuBtn") == true)
            {
                Selenium.Driver.Click(ArtsInternalMenuBtn, "ArtsInternalMenuBtn");
            }*/
           // else
            //{
                if (Selenium.Driver.IsDisplayed(AdditionalTasks, "AdditionalTasks") == true)
                {
                    Selenium.Driver.Click(AdditionalTasks, "AdditionalTasks");
                }
                else if (Selenium.Driver.IsDisplayed(MyTasks, "MyTasks") == true)
                {
                    Selenium.Driver.Click(MyTasks, "MyTasks");
                }

                if (Selenium.Driver.IsDisplayed(ApprenticeDev, "ApprenticeDev") == true)
                {
                    Selenium.Driver.Click(ApprenticeDev, "ApprenticeDev");
                }
                else
                {
                    Selenium.Driver.Click(Apprentice, "Apprentice");
                }
            /*  else if (Selenium.Driver.IsVisible(LandingPageHomeTabTxt, "LandingPageHomeTabTxt"))
              {

              }
               */
           // Selenium.Driver.WaitForElementClickable(LandingPageHomeTabTxt, 1000);
            //  Selenium.Driver.WatiForTextToBePresentInElementBy(LandingPageHeadingTxt, "Program Overview", 10000);

             }
        


        public void ToLandingPage(string programID)
        {
            Selenium.Driver.Click(ApprenticeshipSponsoredTaks, "ApprenticeshipSponsoredTaks");
            Selenium.Driver.Click(ApprenticeTaskOption, "ApprenticeTaskOption");

            if (Selenium.Driver.IsVisible(PrgrmDrpDwn, "PrgrmDrpDwn") == true)
            {
                Selenium.Driver.SelectDropDownByValue(PrgrmDrpDwn, programID, "PrgrmDrpDwn");
                Selenium.Driver.Click(Go, "Go");
            }

          }
            
        public void Tasks()
        {
            ToLandingPage();
            Thread.Sleep(2000);
           // Selenium.Driver.WatiForTextToBePresentInElementBy(LandingPageHeadingTxt, "Washington State UBC JATC", 5000);
        }

        public void Tasks(string ProgramID)
        {
            ToLandingPage(ProgramID);
            Thread.Sleep(3000);
            // Selenium.Driver.WatiForTextToBePresentInElementBy(LandingPageHeadingTxt, "Washington State UBC JATC", 5000);
        }

        public void ChangeProgram(string ProgramId)
        {
            Selenium.Driver.SelectDropDownByValue(PrgrmDrpDwn, ProgramId, "PrgrmDrpDwn");
            Selenium.Driver.Click(Go, "Go");
            Thread.Sleep(2000);
        }
    }
}
