using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;
using System.Threading;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Committee_Meeeting_Minutes
{

    public class Upload_MeetingMinutes_Page : Base
    {
        [FindsBy(How = How.XPath, Using = "//h2[@class='lni-u-ml3 lni-u-mb3']")]
        public IWebElement PopUpHeadingTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='lni-c-file-input__control --small --primary lnicon--arrow--up lni-c-button']")]
        public IWebElement UploadBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/button[1]")]
        public IWebElement CloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Minutes Date:')]//following::input[1]")]
        public IWebElement MinutesDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Comment')]//following::input[1]")]
        public IWebElement CommentInput { get; set; }

        [FindsBy(How = How.Id, Using = "submitAfterMinutesUploaded")]
        public IWebElement SubmitBtn { get; set; }


        public string PopUpHeading_Txt()
        {
            Thread.Sleep(3000);
            return Selenium.Driver.GetText(PopUpHeadingTxt, "PopUpHeadingTxt");
        }

        public void Close_Btn()
        {
            Thread.Sleep(3000);
            Selenium.Driver.Click(CloseBtn, "CloseBtn");
        }



    }
}
