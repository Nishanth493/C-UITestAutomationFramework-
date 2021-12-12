using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_PUBLIC.Apprentice_Details
{
    public class Apprentice_Details_Public_Page : Base
    {
        //APPRENTICE INFORMATION-----------------------------------------------------------------------------------------------------

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'ID#')]")]
        public IWebElement ApprenticeIDTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[@class='lni-u-mv1 lni-u-heading--3 lni-u-mr1']")]
        public IWebElement ApprenticeNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='lni-u-pv2 lni-o-cell--10of12 lni-u-pr1']/span")]
        public IWebElement ProgramNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='lni-u-pv2 lni-o-cell--10of12 lni-u-pr1']/strong")]
        public IWebElement OccupationNameTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'lni-u-mt1']//span")]
        public IWebElement ApprenticeStatusTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'lni-u-mt1']//div[2]")]
        public IWebElement ApprenticeStatusEffectiveDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='lni-u-pv2 lni-o-cell--10of12 lni-u-pr1']/img")]
        public IWebElement ProgramHistoryExpandBtn { get; set; }

        //Program(s) Details ---------------------------------------------------------------------------------------------------------------------------

        [FindsBy(How = How.XPath, Using = "//div[@class='lni-c-collapse']//div//div//div//div//strong")]
        public IWebElement OccupationsHistoryTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='lni-u-pv2 lni-o-cell--10of12 lni-u-pr1']/span")]
        public IWebElement programHistoryTxt { get; set; }

        //Huse dilimitter ' ' 
        [FindsBy(How = How.XPath, Using = "//div[@class='lni-u-pv2 lni-o-cell--10of12 lni-u-pr1']/span//following::p[contains(text(),'TERM')][1]//following::p[1]")]
        public IWebElement TermHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'REGISTERED')]//following::p[1]")]
        public IWebElement ApprenticeRegisteredDateTxt { get; set; }

        //use dilimitter ' ' 
        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'PROBATION TERM')]//following::p[1]")]
        public IWebElement AppProbationHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'PROBATION PERIOD' )]//following::p[1]")]
        public IWebElement AppProbationPeriodTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'SUSPENSION PERIOD' )]//following::p[1] ")]
        public IWebElement AppSuspensionPeriodTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Total hours:')]//following::span[2]")]
        public IWebElement TotalOJTHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Total hours:')]//following::span[4]")]
        public IWebElement TotalRSIHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Credited hours:')]//following::span[2]")]
        public IWebElement CreditedOJTHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Credited hours:')]//following::span[4]")]
        public IWebElement CreditedRSIHoursTxt { get; set; }

        //OJT Hours History Table Rows




        //PERSONAL INFORMATION-------------------------------------------------------------------------------------------------------

        [FindsBy(How = How.XPath, Using = "//dt[text()='City, State and Zip Code']//following::dd[1]")]
        public IWebElement ApprenticeAddressTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Gender']//following::dd[1]")]
        public IWebElement ApprenticeGenderTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Race or Ethnicity']//following::dd[1]")]
        public IWebElement ApprenticeRaceNEthinicityDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Highest Education Level Completed:']//following::dd[1]")]
        public IWebElement ApprenticeEducationTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Military Status']//following::dd[1]")]
        public IWebElement ApprenticeMilitaryStatusTxt { get; set; }

        //APPRENTICESHIP INFORMATION------------------------------------------------------------------------------------------------

        [FindsBy(How = How.XPath, Using = "//dt[text()='Apprenticeship Began (Date)']//following::dd[1]")]
        public IWebElement ApprenticeshipBeginDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Apprenticeship Term (Hours)']//following::dd[1]")]
        public IWebElement ApprenticeshipTermTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Probation Hours Required']//following::dd[1]")]
        public IWebElement ProbationHoursRequiredTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Wage Progression Step and Effective Date']//following::dd[1]")]
        public IWebElement CurrrentStepAndEffectiveDateTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'View Step History')]")]
        public IWebElement ViewStepHistoryClick { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows step history of apprentices']//tbody/tr/td[1]")]
        public IList<IWebElement> Tabel_StepsTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows step history of apprentices']//tbody/tr/td[2]")]
        public IList<IWebElement> Tabel_EffectiveDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows step history of apprentices']//tbody/tr/td[3]")]
        public IList<IWebElement> Tabel_StepHoursTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//table[@summary='This table shows step history of apprentices']//tbody/tr/td[4]")]
        public IList<IWebElement> Tabel_JourneyWageTxt { get; set; }
/*
        //APPRENTICE TOTAL HOURS----------------------------------------------------------------------------------------------------------

        [FindsBy(How = How.XPath, Using = "//dt[text()='Total OJT Hours']//following::dd[1]")]
        public IWebElement TotalOJTHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Credited OJT Hours']//following::dd[1]")]
        public IWebElement CreditedOJTTotalHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Total RSI Hours']//following::dd[1]")]
        public IWebElement TotalRSIHoursTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Credited RSI Hours']//following::dd[1]")]
        public IWebElement CreditedRSIHoursTotalTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_ojtHoursHistoryTable']//following-sibling::tbody/tr/td[1]")]
        public IList<IWebElement> Table_OJTHistoryYearsTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_ojtHoursHistoryTable']//following-sibling::tbody/tr/td[2]")]
        public IList<IWebElement> Table_OJTHistoryQ1Txt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_ojtHoursHistoryTable']//following-sibling::tbody/tr/td[3]")]
        public IList<IWebElement> Table_OJTHistoryQ2Txt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_ojtHoursHistoryTable']//following-sibling::tbody/tr/td[4]")]
        public IList<IWebElement> Table_OJTHistoryQ3Txt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_ojtHoursHistoryTable']//following-sibling::tbody/tr/td[5]")]
        public IList<IWebElement> Table_OJTHistoryQ4Txt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_ojtHoursHistoryTable']//following-sibling::tbody/tr/td[6]")]
        public IList<IWebElement> Table_OJTHistoryYearTotalTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_rsiHoursHistoryTable']//following-sibling::tbody[1]/tr/td[1]")]
        public IList<IWebElement> Table_RSIHistoryYearsTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_rsiHoursHistoryTable']//following-sibling::tbody[1]/tr/td[2]")]
        public IList<IWebElement> Table_RSIHistoryQ1Txt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_rsiHoursHistoryTable']//following-sibling::tbody[1]/tr/td[3]")]
        public IList<IWebElement> Table_RSIHistoryQ2Txt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_rsiHoursHistoryTable']//following-sibling::tbody[1]/tr/td[4]")]
        public IList<IWebElement> Table_RSIHistoryQ3Txt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_rsiHoursHistoryTable']//following-sibling::tbody[1]/tr/td[5]")]
        public IList<IWebElement> Table_RSIHistoryQ4Txt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_rsiHoursHistoryTable']//following-sibling::tbody[1]/tr/td[6]")]
        public IList<IWebElement> Table_RSIHistoryYearTotalTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_creditedOjtHoursTable']//following-sibling::tbody[1]/tr/td[1]")]
        public IList<IWebElement> Table_CreditedOJTHoursDateEnteredTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_creditedOjtHoursTable']//following-sibling::tbody[1]/tr/td[2]")]
        public IList<IWebElement> Table_CreditedOJTHoursTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_creditedOjtHoursTable']//following-sibling::tbody[1]/tr/td[3]")]
        public IList<IWebElement> Table_CreditedOJTHoursCommentTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_creditedRsiHoursTable']//following-sibling::tbody[1]/tr/td[1]")]
        public IList<IWebElement> Table_CreditedRSIHoursDateEnteredTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_creditedRsiHoursTable']//following::tbody[1]/tr/td[2]")]
        public IList<IWebElement> Table_CreditedRSIHoursTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//tr[@tableid='artsApprenticeDetails_creditedRsiHoursTable']//following-sibling::tbody[1]/tr/td[3]")]
        public IList<IWebElement> Table_CreditedRSIHoursCommentTxt { get; set; }

        //PROGRAM INFORMATION------------------------------------------------------------------------------------------------------------------------------

        [FindsBy(How = How.XPath, Using = "//dt[text()='Apprenticeship Occupation']//following::dd[1]")]
        public IWebElement ApprenticeshipOccupationTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//dt[text()='Total RSI Hours']//following::dd[1]")]
        public IWebElement LicenseCertificationRequirementTxt { get; set; }

        //APPRENTICE HISTORY-----------------------------------------------------------------------------------------------------------------------------------
        
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'lni-c-history-detail__timeline-dot lni-u-absolute lni-u-block')]//following-sibling::div/span[1]")]
        public IList<IWebElement> ApprenticeHistoriesDatesTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'lni-c-history-detail__timeline-dot lni-u-absolute lni-u-block')]//following-sibling::div/span[2]")]
        public IList<IWebElement> ApprenticeHistoriesStatusesTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'lni-c-history-detail__timeline-dot lni-u-absolute lni-u-block')]//following-sibling::div/p[1]")]
        public IList<IWebElement> ApprenticeHistoriesProgramsTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'lni-c-history-detail__timeline-dot lni-u-absolute lni-u-block')]//following-sibling::div/p[2]")]
        public IList<IWebElement> ApprenticeHistoriesOcuupationsTxt { get; set; }


        public string ApprenticeID_Txt()
        {
            string []  id =  (Selenium.Driver.GetText(ApprenticeIDTxt, "ApprenticeIDTxt")).Split('#');
            return id[1];
        }

        public string ApprenticeName_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeNameTxt, "ApprenticeNameTxt");           
        }

        public string ApprenticeStatus_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeStatusTxt, "ApprenticeStatusTxt");
        }

        public string ApprenticeRegistrtaionDate_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeRegistrtaionDateTxt, "ApprenticeRegistrtaionDateTxt");
        }

        public string ApprenticeTransferDate_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeTransferDateTxt, "ApprenticeTransferDateTxt");
        }

        public string ApprenticeCancellationDate_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeCancellationDateTxt, "ApprenticeCancellationDateTxt");
        }

        public string ApprenticeSuspensionStartEndDate_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeSuspensionStartEndDateTxt, "ApprenticeSuspensionStartEndDateTxt");
        }

        public string ApprenticeProbationStartEndDate_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeProbationStartEndDateTxt, "ApprenticeProbationStartEndDateTxt");
        }

        public string ApprenticeCompletionDate_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeCompletionDateTxt, "ApprenticeCompletionDateTxt");
        }

        public string ApprenticeAddress_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeAddressTxt, "ApprenticeAddressTxt");
        }

        public string ApprenticeGender_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeGenderTxt, "ApprenticeGenderTxt");
        }

        public string ApprenticeRaceNEthinicityDate_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeRaceNEthinicityDateTxt, "ApprenticeRaceNEthinicityDateTxt");
        }

        public string ApprenticeEducation_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeEducationTxt, "ApprenticeEducationTxt");
        }

        public string ApprenticeMilitaryStatus_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeMilitaryStatusTxt, "ApprenticeMilitaryStatusTxt");
        }

        public string ApprenticeshipBeginDate_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeshipBeginDateTxt, "ApprenticeshipBeginDateTxt");
        }

        public string ApprenticeshipTerm_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeshipTermTxt, "ApprenticeshipTermTxt");
        }

        public string ProbationHoursRequired_Txt()
        {
            return Selenium.Driver.GetText(ProbationHoursRequiredTxt, "ProbationHoursRequiredTxt");
        }

        public string CurrrentStepAndEffectiveDate_Txt()
        {
            return Selenium.Driver.GetText(CurrrentStepAndEffectiveDateTxt, "CurrrentStepAndEffectiveDateTxt");
        }

        public void ViewStepHistory_Click()
        {
            Selenium.Driver.Click(ViewStepHistoryClick, "ViewStepHistoryClick");
        }

        public List<string> Tabel_Steps_Txt()
        {
            List<string> _steps = new List<string>(Tabel_StepsTxt.Count);
            for (int i = 0; i< Tabel_StepsTxt.Count; i++)
            {
                _steps[i] = Selenium.Driver.GetText(Tabel_StepsTxt[i], "Tabel_StepsTxt");
            }
            return _steps;
        }

        public List<string> Tabel_StepsEffectiveDate_Txt()
        {
            List<string> _effectiveDate = new List<string>();
            for (int i = 0; i < Tabel_EffectiveDateTxt.Count; i++)
            {
                _effectiveDate[i] = Selenium.Driver.GetText(Tabel_EffectiveDateTxt[i], "Tabel_EffectiveDateTxt");
            }
            return _effectiveDate;
        }

        public List<string> Tabel_StepHours_Txt()
        {
            List<string> _stepHours = new List<string>();
            for (int i = 0; i < Tabel_StepHoursTxt.Count; i++)
            {
                _stepHours[i] = Selenium.Driver.GetText(Tabel_StepHoursTxt[i], "Tabel_StepHoursTxt");
            }
            return _stepHours;
        }

        public List<string> Tabel_JourneyWage_Txt()
        {
            List<string> _wagePct = new List<string>();
            for (int i = 0; i < Tabel_JourneyWageTxt.Count; i++)
            {
                _wagePct[i] = Selenium.Driver.GetText(Tabel_JourneyWageTxt[i], "Tabel_JourneyWageTxt");
            }
            return _wagePct;
        }

        public string TotalOJTHours_Txt()
        {
            return Selenium.Driver.GetText(TotalOJTHoursTxt, "TotalOJTHoursTxt");
        }

        public string CreditedOJTTotalHours_Txt()
        {
            return Selenium.Driver.GetText(CreditedOJTTotalHoursTxt, "CreditedOJTTotalHoursTxt");
        }

        public string TotalRSIHours_Txt()
        {
            return Selenium.Driver.GetText(TotalRSIHoursTxt, "TotalRSIHoursTxt");
        }

        public string CreditedRSIHoursTotal_Txt()
        {
            return Selenium.Driver.GetText(CreditedRSIHoursTotalTxt, "CreditedRSIHoursTotalTxt");
        }

        public List<string> Table_OJTHistoryYears_Txt()
        {
            List<string> _years = new List<string>();
            for (int i = 0; i < Table_OJTHistoryYearsTxt.Count; i++)
            {
                _years[i] = Selenium.Driver.GetText(Table_OJTHistoryYearsTxt[i], "OJTHistoryYearsTxt");
            }
            return _years;
        }

        public List<string> Table_OJTHistoryQ1_Txt()
        {
            List<string> _q1 = new List<string>();
            for (int i = 0; i < Table_OJTHistoryYearsTxt.Count; i++)
            {
                _q1[i] = Selenium.Driver.GetText(Table_OJTHistoryQ1Txt[i], "Table_OJTHistoryQ1Txt");
            }
            return _q1;
        }

        public List<string> Table_OJTHistoryQ2_Txt()
        {
            List<string> _q2 = new List<string>();
            for (int i = 0; i < Table_OJTHistoryQ2Txt.Count; i++)
            {
                _q2[i] = Selenium.Driver.GetText(Table_OJTHistoryQ2Txt[i], "Table_OJTHistoryQ2Txt");
            }
            return _q2;
        }

        public List<string> Table_OJTHistoryQ3_Txt()
        {
            List<string> _q3 = new List<string>();
            for (int i = 0; i < Table_OJTHistoryQ3Txt.Count; i++)
            {
                _q3[i] = Selenium.Driver.GetText(Table_OJTHistoryQ3Txt[i], "Table_OJTHistoryQ3Txt");
            }
            return _q3;
        }

        public List<string> Table_OJTHistoryQ4_Txt()
        {
            List<string> _q4 = new List<string>();
            for (int i = 0; i < Table_OJTHistoryQ4Txt.Count; i++)
            {
                _q4[i] = Selenium.Driver.GetText(Table_OJTHistoryQ4Txt[i], "Table_OJTHistoryQ4Txt");
            }
            return _q4;
        }

        public List<string> Table_OJTHistoryYearTotal_Txt()
        {
            List<string> _total = new List<string>();
            for (int i = 0; i < Table_OJTHistoryYearTotalTxt.Count; i++)
            {
                _total[i] = Selenium.Driver.GetText(Table_OJTHistoryYearTotalTxt[i], "Table_OJTHistoryYearTotalTxt");
            }
            return _total;
        }

        public List<string> Table_RSIHistoryYears_Txt()
        {
            List<string> _years = new List<string>();
            for (int i = 0; i < Table_RSIHistoryYearsTxt.Count; i++)
            {
                _years[i] = Selenium.Driver.GetText(Table_RSIHistoryYearsTxt[i], "Table_RSIHistoryYearsTxt");
            }
            return _years;
        }

        public List<string> Table_RSIHistoryQ1_Txt()
        {
            List<string> _q1 = new List<string>();
            for (int i = 0; i < Table_RSIHistoryQ1Txt.Count; i++)
            {
                _q1[i] = Selenium.Driver.GetText(Table_RSIHistoryQ1Txt[i], "Table_RSIHistoryQ1Txt");
            }
            return _q1;
        }
        
        public List<string> Table_RSIHistoryQ2_Txt()
        {
            List<string> _q2 = new List<string>();
            for (int i = 0; i < Table_RSIHistoryQ2Txt.Count; i++)
            {
                _q2[i] = Selenium.Driver.GetText(Table_RSIHistoryQ2Txt[i], "Table_RSIHistoryQ2Txt");
            }
            return _q2;
        }

        public List<string> Table_RSIHistoryQ3_Txt()
        {
            List<string> _q3 = new List<string>();
            for (int i = 0; i < Table_RSIHistoryQ3Txt.Count; i++)
            {
                _q3[i] = Selenium.Driver.GetText(Table_RSIHistoryQ3Txt[i], "Table_RSIHistoryQ3Txt");
            }
            return _q3;
        }

        public List<string> Table_RSIHistoryQ4_Txt()
        {
            List<string> _q4 = new List<string>();
            for (int i = 0; i < Table_RSIHistoryQ4Txt.Count; i++)
            {
                _q4[i] = Selenium.Driver.GetText(Table_RSIHistoryQ4Txt[i], "Table_RSIHistoryQ4Txt");
            }
            return _q4;
        }

        public List<string> Table_RSIHistoryYearTotal_Txt()
        {
            List<string> _total = new List<string>();
            for (int i = 0; i < Table_RSIHistoryYearTotalTxt.Count; i++)
            {
                _total[i] = Selenium.Driver.GetText(Table_RSIHistoryYearTotalTxt[i], "Table_RSIHistoryYearTotalTxt");
            }
            return _total;
        }

        public List<string> Table_CreditedOJTHoursDateEntered_Txt()
        {
            List<string> _dateEntered = new List<string>();
            for (int i = 0; i < Table_CreditedOJTHoursDateEnteredTxt.Count; i++)
            {
                _dateEntered[i] = Selenium.Driver.GetText(Table_CreditedOJTHoursDateEnteredTxt[i], "Table_CreditedOJTHoursDateEnteredTxt");
            }
            return _dateEntered;
        }

        public List<string> Table_CreditedOJTHours_Txt()
        {
            List<string> _creditedHours = new List<string>();
            for (int i = 0; i < Table_CreditedOJTHoursTxt.Count; i++)
            {
                _creditedHours[i] = Selenium.Driver.GetText(Table_CreditedOJTHoursTxt[i], "Table_CreditedOJTHoursTxt");
            }
            return _creditedHours;
        }

        public List<string> Table_CreditedOJTHoursComment_Txt()
        {
            List<string> _comment = new List<string>();
            for (int i = 0; i < Table_CreditedOJTHoursCommentTxt.Count; i++)
            {
                _comment[i] = Selenium.Driver.GetText(Table_CreditedOJTHoursCommentTxt[i], "Table_CreditedOJTHoursCommentTxt");
            }
            return _comment;
        }

        public List<string> Table_CreditedRSIHoursDateEntered_Txt()
        {
            List<string> _dateEntered = new List<string>();
            for (int i = 0; i < Table_CreditedRSIHoursDateEnteredTxt.Count; i++)
            {
                _dateEntered[i] = Selenium.Driver.GetText(Table_CreditedRSIHoursDateEnteredTxt[i], "Table_CreditedRSIHoursDateEnteredTxt");
            }
            return _dateEntered;
        }

        public List<string> Table_CreditedRSIHours_Txt()
        {
            List<string> _creditedHours = new List<string>();
            for (int i = 0; i < Table_CreditedRSIHoursTxt.Count; i++)
            {
                _creditedHours[i] = Selenium.Driver.GetText(Table_CreditedRSIHoursTxt[i], "Table_CreditedRSIHoursTxt");
            }
            return _creditedHours;
        }

        public List<string> Table_CreditedRSIHoursComment_Txt()
        {
            List<string> _comment = new List<string>();
            for (int i = 0; i < Table_CreditedRSIHoursCommentTxt.Count; i++)
            {
                _comment[i] = Selenium.Driver.GetText(Table_CreditedRSIHoursCommentTxt[i], "Table_CreditedRSIHoursCommentTxt");
            }
            return _comment;
        }

        public string ProgramNameAndID_Txt()
        {
            return Selenium.Driver.GetText(ProgramNameAndIDTxt, "ProgramNameAndIDTxt");
        }

        public string ApprenticeshipOccupation_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeshipOccupationTxt, "ApprenticeshipOccupationTxt");
        }

        public string LicenseCertificationRequirement_Txt()
        {
            return Selenium.Driver.GetText(LicenseCertificationRequirementTxt, "LicenseCertificationRequirementTxt");
        }

        public List<string> ApprenticeHistoriesDates_Txt()
        { 
            List<string> _date = new List<string>();
            for (int i = 0; i < ApprenticeHistoriesDatesTxt.Count; i++)
            {
                _date[i] = Selenium.Driver.GetText(ApprenticeHistoriesDatesTxt[i], "ApprenticeHistoriesDatesTxt");
            }
            return _date;
        }

        public List<string> ApprenticeHistoriesStatuses_Txt()
        {
            List<string> _status = new List<string>();
            for (int i = 0; i < ApprenticeHistoriesStatusesTxt.Count; i++)
            {
                _status[i] = Selenium.Driver.GetText(ApprenticeHistoriesStatusesTxt[i], "ApprenticeHistoriesStatusesTxt");
            }
            return _status;
        }

        public List<string> ApprenticeHistoriesPrograms_Txt()
        {
            List<string> _programs = new List<string>();
            for (int i = 0; i < ApprenticeHistoriesProgramsTxt.Count; i++)
            {
                _programs[i] = Selenium.Driver.GetText(ApprenticeHistoriesProgramsTxt[i], "ApprenticeHistoriesProgramsTxt");
            }
            return _programs;
        }

        public List<string> ApprenticeHistoriesOcuupations_Txt()
        {
            List<string> _occupation = new List<string>();
            for (int i = 0; i < ApprenticeHistoriesOcuupationsTxt.Count; i++)
            {
                _occupation[i] = Selenium.Driver.GetText(ApprenticeHistoriesOcuupationsTxt[i], "ApprenticeHistoriesOcuupationsTxt");
            }
            return _occupation;
        }*/
    }
}
