using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository
{
    public class ProgramProfile : Base
    {
        [FindsBy(How = How.CssSelector, Using = "div.greyBackground:nth-child(3) div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.container:nth-child(1) div.clearfix.bottom-30:nth-child(1) div.eight.columns.alpha:nth-child(2) div:nth-child(1) div.launchpadAudience div.text-right div.singleAudienceWrapper > input.orangeButton.dashboardButton.bottom-10")]

        public IWebElement MyTasks { get; set; }

        public void ClickMyTasks()
        {
            Selenium.Driver.Click(MyTasks, "MyTasks");
        }

        public void Profile()
        {
            ClickMyTasks();
        } 

    }
}
