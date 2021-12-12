using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using WA.LNI.Apprentice.TestFramework;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.TransferAnApprentice
{
    public class Transfer_An_Apprentice_Confirmation_Page
    {

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Thank you!')]")]
        public IWebElement AppTransferConfirmationThankyouTxt { get; set; }

        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement AppTransferConfirmationNavigatePrgmOverviewLnk { get; set; }

        /// <summary>
        ///  Gets the conformation message 
        /// </summary>
        /// <returns>Conformation Message Txt</returns>
        public string AppTransferConfirmationThankyou_Txt()
        {
            return Selenium.Driver.GetText(AppTransferConfirmationThankyouTxt, "AppTransferConfirmationThankyouTxt");
        }

        /// <summary>
        /// Clicks in navigates back to teh overview page link
        /// </summary>
        public void AppTransferConfirmationNavigatePrgmOverview_Lnk()
        {
            Selenium.Driver.Click(AppTransferConfirmationNavigatePrgmOverviewLnk, "AppTransferConfirmationNavigatePrgmOverviewLnk");
            Thread.Sleep(5000);
        }
    }
}
