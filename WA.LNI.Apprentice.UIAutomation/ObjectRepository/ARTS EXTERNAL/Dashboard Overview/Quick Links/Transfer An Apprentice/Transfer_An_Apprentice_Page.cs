using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.TransferAnApprentice
{
    public class Transfer_An_Apprentice_Page : Base
    {
        [FindsBy(How = How.LinkText, Using = "Back to program overview")]
        public IWebElement NavigationBackToOverPageLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//h2[@class='lni-u-type--4 lni-u-mb3 lni-u-mr6']")]
        public IWebElement PageHeadingTxt { get; set; }

        [FindsBy(How = How.Id, Using = "apprenticeIdForTransfer")]
        public IWebElement AppTransferIDInputBox { get; set; }

        [FindsBy(How = How.Id, Using = "checkApprenticeID")]
        public IWebElement AppTransferVerifyBtn { get; set; }

        [FindsBy(How = How.Id, Using = "apprenticeNameForTransfer")]
        public IWebElement AppNameForTransferTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@id='apprenticeTransferOptions']//child::div")]
        public IList<IWebElement> AppTransferOptionRdoBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#toTransferAnotherProgram")]
        public IWebElement AppTransferProgramDrpDwn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#programOccupationsToTransfer")]
        public IWebElement TO_Program_AppTransferOccupDrpDwn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#fromAnotherProgramOccupation")]
        public IWebElement TO_Occupation_AppTransferOccupDrpDwn { get; set; }

        [FindsBy(How = How.Id, Using = "transferEffectiveDate")]
        public IWebElement AppEffectiveDateInputBox { get; set; }

        [FindsBy(How = How.Id, Using = "transferPageProgramName")]
        public IWebElement AppTransferPgeCurrentPgrmNameTxt { get; set; }

        [FindsBy(How = How.Id, Using = "transferPageOccupationName")]
        public IWebElement AppTransferPgeCurrentOccupNameTxt { get; set; }

        [FindsBy(How = How.Id, Using = "transferToProgramHours")]
        public IWebElement TO_Program_AppPrevOJTInput { get; set; }

        [FindsBy(How = How.Id, Using = "transferProgramHours")]
        public IWebElement TO_Occupation_AppPrevOJTInput { get; set; }

        [FindsBy(How = How.Id, Using = "rsiPreviousExperienceInTransfer")]
        public IWebElement AppPrevRSIInput { get; set; }

        [FindsBy(How = How.Id, Using = "transferPageComments")]
        public IWebElement AppCommentInputBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#previewBeforeTransfer")]
        public IWebElement AppTransferPreviewPgeBtn { get; set; }

        /// <summary>
        /// Clicks on back to overview page link
        /// </summary>
        public void NavigationBackToOverPage_Lnk()
        {
            Selenium.Driver.Click(NavigationBackToOverPageLnk, "NavigationBackToOverPageLnk");
        }

        /// <summary>
        /// Gets page heading text
        /// </summary>
        public string PageHeading_Txt()
        {
            return Selenium.Driver.GetText(PageHeadingTxt, "PageHeadingTxt");
        }

        /// <summary>
        /// Enters Apprentice ID to transfer 
        /// </summary>
        /// <param Apprentice ID="apprenticeID"></param>
        public void AppTransferID_InputBox(string apprenticeID)
        {
            Selenium.Driver.SendKeys(AppTransferIDInputBox,apprenticeID, "AppTransferID_InputBox");
        }

        /// <summary>
        /// Clicks on Verify button after entering Apprentice ID
        /// </summary>
        public void AppTransferVerify_Btn()
        {
            Selenium.Driver.Click(AppTransferVerifyBtn, "AppTransferVerifyBtn");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Gets the name of the apprentcie 
        /// </summary>
        public string AppNameForTransfer_Txt()
        {
            return Selenium.Driver.GetText(AppNameForTransferTxt, "AppNameForTransferTxt");
        }

        /// <summary>
        /// Clicks 'Transfer to different program' or 'Transfer to differnt occupation' option's radio buttons, based on the radio button index 
        /// </summary>
        /// <param Index number="n"></param>
        public void AppTransferOption_RdoBtn(string n)
        {
            int number = Int32.Parse(n);

            Selenium.Driver.Click(AppTransferOptionRdoBtn[number], "AppTransferOptionRdoBtn[" + number + "]");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Selects porgram from the dropdown, based on given program ID
        /// </summary>
        /// <param Program ID="programID"></param>
        public void AppTransferProgram_DrpDwn(string programID)
        {
            Selenium.Driver.SelectDropDownByValue(AppTransferProgramDrpDwn, programID, "AppTransferProgramDrpDwn[" + programID + "]");
            Thread.Sleep(3000);
        }

        /// <summary>
        ///  Selects porgram from the dropdown, based on given Occupation ID
        /// </summary>
        /// <param Occupation ID="occupationID"></param>
        public void TO_Program_AppTransferOccup_DrpDwn(string occupationID)
        {
            Selenium.Driver.SelectDropDownByValue(TO_Program_AppTransferOccupDrpDwn, occupationID, "TO_Program_AppTransferOccupDrpDwn[" + occupationID + "]");
        }

        /// <summary>
        ///  Selects porgram from the dropdown, based on given Occupation ID
        /// </summary>
        /// <param Occupation ID="occupationID"></param>
        public void TO_Occupation_AppTransferOccup_DrpDwn(string occupationID)
        {
            Selenium.Driver.SelectDropDownByValue(TO_Occupation_AppTransferOccupDrpDwn, occupationID, "TO_Occupation_AppTransferOccupDrpDwn[" + occupationID + "]");
        }


        /// <summary>
        /// Enters apprentice previous OJT hours
        /// </summary>
        /// <param Previous OJT Hours="OJTHours"></param>
        public void TO_Program_AppPrevOJT_Input(string OJTHours)
        { 
            Selenium.Driver.DeleteTxt(TO_Program_AppPrevOJTInput, "TO_Program_AppPrevOJTInput");
            Selenium.Driver.SendKeys(TO_Program_AppPrevOJTInput, OJTHours, "TO_Program_AppPrevOJTInput");
        }

        /// <summary>
        /// Enters apprentice previous OJT hours
        /// </summary>
        /// <param Previous OJT Hours="OJTHours"></param>
        public void TO_Occupation_AppPrevOJT_Input(string OJTHours)
        {
            Selenium.Driver.DeleteTxt(TO_Occupation_AppPrevOJTInput, "TO_Occupation_AppPrevOJTInput");
            Selenium.Driver.SendKeys(TO_Occupation_AppPrevOJTInput, OJTHours, "TO_Occupation_AppPrevOJTInput");
        }

        /// <summary>
        /// Enters the previous RSI hours
        /// </summary>
        /// <param RSI Hours="RSIHours"></param>
        public void AppPrevRSI_Input(string RSIHours)
        {
            Selenium.Driver.DeleteTxt(AppPrevRSIInput, "AppPrevRSIInput");
            Selenium.Driver.SendKeys(AppPrevRSIInput, RSIHours, "AppPrevRSIInput");
        }

        /// <summary>
        /// Enters apprentice 'Effective Date' of transfer
        /// </summary>
        /// <param Date="date"></param>
        public void AppEffectiveDate_InputBox(string date)
        {
            Selenium.Driver.SendKeys(AppEffectiveDateInputBox, date, "AppEffectiveDateInputBox");
        }

        /// <summary>
        /// Gets the apprentice current program information 
        /// </summary>
        public string AppTransferPgeCurrentPgrmName_Txt()
        {
            return Selenium.Driver.GetText(AppTransferPgeCurrentPgrmNameTxt, "AppTransferPgeCurrentPgrmNameTxt");
        }

        /// <summary>
        /// Gets the apprentice current occupation information 
        /// </summary>
        public string AppTransferPgeCurrentOccupName_Txt()
        {
            return Selenium.Driver.GetText(AppTransferPgeCurrentOccupNameTxt, "AppTransferPgeCurrentOccupNameTxt");
        }

        /// <summary>
        /// Enters the comment
        /// </summary>
        /// <param Comment ="comment"></param>
        public void AppComment_InputBox(string comment)
        {
            Selenium.Driver.SendKeys(AppCommentInputBox, comment, "AppCommentInputBox");
        }

        /// <summary>
        /// Clicks on the 'Trnsfer Apprentice' Option to advance to the review page 
        /// </summary>
        public void AppTransferPreviewPge_Btn()
        {
            Selenium.Driver.Click(AppTransferPreviewPgeBtn, "AppTransferPreviewPgeBtn");
            Thread.Sleep(3000);
        }
        
    }
}
