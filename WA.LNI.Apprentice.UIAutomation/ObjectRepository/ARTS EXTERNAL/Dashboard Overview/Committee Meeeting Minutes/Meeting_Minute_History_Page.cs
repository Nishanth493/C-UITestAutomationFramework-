using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;
using System.Threading;


namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Committee_Meeeting_Minutes
{

    public class Meeting_Minute_History_Page : Base
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='lni-u-mt3']")]
        public IWebElement PageHeadingTxt { get; set; }

        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement NavigationBackToOverviewLnk { get; set; }

        public string PageHeading_Txt()
        {
            Thread.Sleep(3000);
            return Selenium.Driver.GetText(PageHeadingTxt, "PageHeadingTxt");
        }
   
        public void NavigationBackToOverview_Lnk()
        {
            Selenium.Driver.Click(NavigationBackToOverviewLnk, "NavigationBackToOverviewLnk");
        }

    }
}
