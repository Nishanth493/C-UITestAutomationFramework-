using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.TestFramework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC
{
    public class ARTS_public_Home_Page : Base 
    {
        /// <summary>
        /// [0] - An Apprentice
        /// [1] - An apprenticeship program by county and occupation
        /// [2] - All apprenticeship programs by name
        /// [3] - Training agent/Employer lookup
        /// </summary>
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[@class='lni-u-flex lni-u-flex-wrap lni-u-flex-column lni-u-items-start lni-u-mt1']/div/label")]
        public IList<IWebElement> SearchCriteriaRdoBtn { get; set; }

        /// <summary>
        /// [0] - An Apprentice
        /// [1] - An apprenticeship program by county and occupation
        /// [2] - All apprenticeship programs by name
        /// [3] - Training agent/Employer lookup
        /// </summary>
        /// <param name="n"></param>
        public void SearchCriteria_RdoBtn(int n)
        {
            Selenium.Driver.Click(SearchCriteriaRdoBtn[n], "SearchCriteriaRdoBtn" + n + "]");
        }
    }
}


