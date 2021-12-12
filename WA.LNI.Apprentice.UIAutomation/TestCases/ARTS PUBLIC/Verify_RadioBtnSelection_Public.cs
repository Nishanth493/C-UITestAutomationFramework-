using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_PUBLIC
{
    [TestClass]
    public class Verify_RadioBtnSelection_Public : TestBase
    {
        string Name;

        [TestMethod]
        public void Verify_RadioBtnSelection_Regualar_Public()
        {
            Name = MethodBase.GetCurrentMethod().Name;

            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);


            GetInstance<ARTS_public_Home_Page>().SearchCriteria_RdoBtn(0);
            GetInstance<ARTS_public_Home_Page>().SearchCriteria_RdoBtn(1);
            GetInstance<ARTS_public_Home_Page>().SearchCriteria_RdoBtn(2);

            //ExtentReportLog(GetInstance<              ().OJTHistory_Hours_Txt("0"),
            //                                               OJTHours,
           //                                               "Verify apprentice updated OJT Hours History", Name);

        }
    }
}
