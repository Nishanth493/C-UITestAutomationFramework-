using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.TransferAnApprentice
{
    public class Transfer_An_Apprentice_Preview_Page
    {
        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Apprentice ID:')]//following::span[1]")]
        public IWebElement AppTransferReviewIDTxt { get; set; }

        //[FindsBy(How = How.XPath, Using = "//body[@data-gr-c-s-loaded='true']/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container lni-element-show']/div/div[@class='lni-c-element-container lni-u-mt1 registration-preview']/div/ul[1]//child::li/span")]
        //public IWebElement AppTransferReviewActualIDTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Apprenticeship Program:')]//following::span[1]")]
        public IWebElement AppTransferReviewPrgmTxt { get; set; }

        //[FindsBy(How = How.XPath, Using = "//div[@class='lni-c-element-container lni-element-show']//div[2]//ul[1]//child::span")]
        //public IWebElement AppTransferReviewActualPrgmTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Occupation:')]//following::span[1]")]
        public IWebElement AppTransferReviewOccupTxt { get; set; }

        //[FindsBy(How = How.XPath, Using = "//div[@class='lni-c-element-container lni-element-show']//div[2]//ul[2]//child::span")]
        //public IWebElement AppTransferReviewActualOccupTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Effective Date:')]//following::span[1]")]
        public IWebElement AppTransferReviewEffectiveDateTxt { get; set; }

        //[FindsBy(How = How.XPath, Using = "//body[@data-gr-c-s-loaded='true']/div[@id='ewnWrapper']/div[@id='bodyWrapper']/div[@id='bodyCenter']/div[@id='body']/div[@id='application-main']/div/div/div/div/div/div[@class='lni-c-element-container lni-element-show']/div/div[@class='lni-c-element-container lni-u-mt1 registration-preview']/div/ul[2]//child::span")]
        //public IWebElement AppTransferReviewActualEffectiveDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Comments:')]//following::span[1]")]
        public IWebElement AppTransferReviewCommentTxt { get; set; }

        //[FindsBy(How = How.XPath, Using = "//ul[3]//child::span")]
        //public IWebElement AppTransferReviewActualCommentTxt { get; set; }

        [FindsBy(How = How.Id, Using = "transferApprenticeSubmit")]
        public IWebElement AppTransferReviewSubmitBtn { get; set; }

        [FindsBy(How = How.Id, Using = "editRegistrationInfo")]
        public IWebElement AppTransferReviewEditBtn { get; set; }
        
        /// <summary>
        /// Gets the apprentice ID 
        /// </summary>
        /// <returns>Apprentice ID String</returns>
        public string AppTransferReviewID_Txt()
        {
            return Selenium.Driver.GetText(AppTransferReviewIDTxt, "AppTransferReviewIDTxt");
        }

        /// <summary>
        /// Gets the program information, to which apprentice is going to be transferred 
        /// </summary>
        /// <returns>Program Information String</returns>
        public string AppTransferReviewPrgm_Txt()
        {
            return Selenium.Driver.GetText(AppTransferReviewPrgmTxt, "AppTransferReviewPrgmTxt");
        }

        /// <summary>
        /// Gets the transfer effective date 
        /// </summary>
        /// <returns>Effective Date String</returns>
        public string AppTransferReviewEffectiveDate_Txt()
        {
            return Selenium.Driver.GetText(AppTransferReviewEffectiveDateTxt, "AppTransferReviewEffectiveDateTxt");
        }

        /// <summary>
        /// Gets the comment 
        /// </summary>
        /// <returns>Comment Stirng</returns>
        public string AppTransferReviewComment_Txt()
        {
            return Selenium.Driver.GetText(AppTransferReviewCommentTxt, "AppTransferReviewCommentTxt");
        }

        /// <summary>
        /// Clicks the submit
        /// </summary>
        public void AppTransferReviewSubmit_Btn()
        {
            Selenium.Driver.Click(AppTransferReviewSubmitBtn, "AppTransferReviewSubmitBtn");
        }

        /// <summary>
        /// Clicks on the edit button 
        /// </summary>
        public void AppTransferReviewEdit_Btn()
        {
            Selenium.Driver.Click(AppTransferReviewEditBtn, "AppTransferReviewEditBtn");
        }

    }
}
