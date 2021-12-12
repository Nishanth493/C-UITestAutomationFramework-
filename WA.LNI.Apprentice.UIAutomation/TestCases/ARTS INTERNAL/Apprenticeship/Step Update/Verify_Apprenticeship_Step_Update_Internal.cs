/*
 * BUGS
 * Bug 77798: In apprentice information page, except step history table arranged in ascending order and remaining all the history values are in descending
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Step_Update;
using System.Collections.Generic;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_INTERNAL.Apprenticeship.Step_Update
{
    [TestClass]
    public class Verify_Apprenticeship_Step_Update_Internal : TestBase
    {
        string Name;

        [TestMethod]
        public void TC001_Verify_Apprenticeship_Step_Update_Internal()
        {
            try
            {
                Name = MethodBase.GetCurrentMethod().Name;
                Selenium.Log = Selenium.Extent.StartTest(Name);
                int status = 1;
                string ProgramID = "152";
                List<string> NewStepInputs = new List<string>();
                List<string> SelectedIDs = new List<string>();
                List<string> error_message = new List<string>();

                string ApprenticeSelection_CheckBox = "0;1;2;3;4;5;6;7;8;9";
                string EffectiveDate = DateTime.Today.ToString("MM/dd/yyyy");
                string MinutesDate = DateTime.Today.ToString("MM/dd/yyyy");             
                Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
                GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
                GetInstance<Left_Menu_Nav_Bar>().Apprentice_StepUpdate_Lnk();
                GetInstance<ApprenticeUpdateStep_Page_Internal>().ProgramID_InputTxt(ProgramID);
                GetInstance<ApprenticeUpdateStep_Page_Internal>().Status_DrpDwn(status);
                GetInstance<ApprenticeUpdateStep_Page_Internal>().Search_Btn();
                GetInstance<ApprenticeUpdateStep_Page_Internal>().ApprenticeSlection_ChkBox(ApprenticeSelection_CheckBox);
                GetInstance<ApprenticeUpdateStep_Page_Internal>().Continue_Btn();
                GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().EffectiveDate_Input(EffectiveDate);
                GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().MinuteDate_Input(MinutesDate);
                GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().ApplyDatesToAll_Lnk();

                SelectedIDs = GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().SelectIDs_ListTxt();

                //Loops through the table adds new step to each input 
                for (int i = 0; i < (GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().CurrentStepNumberTableTxt).Count; i++)
                {
                    if (GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().CurrentStepNumber_Txt(i).ToString() != "")
                    {
                        string new_step = (GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().CurrentStepNumber_Txt(i) + 1).ToString();
                        GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().NewStepNumberTable_Input(i, new_step);
                    }
                }

                GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().UpdateSteps_Btn();

                if (GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().ErrorMessage_PopUp() == "error! Please fix the error(s).")
                {
                    //copying the error message list to a new list 
                    for (int j = 0; j < (GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().Message).Count; j++)
                    {
                        error_message.Add(GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().MessageTable_Txt(j));
                    }
                    for (int k = 0; k < error_message.Count; k++)
                    {
                        if (error_message[k] == "")
                        {
                            
                            continue;
                        }
                        /*
                        else if (error_message[k] == "New step number should be higher than current step")
                        {
                            ExtentReportLog("Test Failed", error_message[k], "Check Algorithum", Name);
                        }

                        else if (error_message[k] == "Enter Effective date.")
                        {
                            ExtentReportLog("Error Message", error_message[k], "Check Test", Name);
                            ExtentReportLog("Test Failed", "", "Check Dates functioality", Name);
                        }

                        else if (error_message[k] == "Effective date should be greater than registration date.")
                        {
                            ExtentReportLog("Error Message", error_message[k], "Check Test", Name);
                            GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().Delete_Btn(k);
                            error_message.RemoveAt(k);
                            SelectedIDs.RemoveAt(k);
                            k = k - 1;
                        }*/
                        else
                        {
                            ExtentReportLog("Error Message", error_message[k], "Check Test", Name);
                            GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().Delete_Btn(k);
                            error_message.RemoveAt(k);
                            SelectedIDs.RemoveAt(k);
                            k = k - 1;
                        }
                    }

                    for (int l = 0; l < (GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().NewStepNumberInput).Count; l++)
                    {
                        NewStepInputs.Add(Selenium.Driver.GetTextJS(GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().NewStepNumberInput[l], "NewStepNumberInput"));
                    }

                    SelectedIDs = GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().SelectIDs_ListTxt();
                    GetInstance<ApprenticeUpdateStepPostSelection_Page_Internal>().UpdateSteps_Btn();

                    //Validating udated hours 
                    for (int j = 0; j < SelectedIDs.Count; j++)
                    {
                        
                        GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppSearch_Lnk();
                        GetInstance<SearchApprentice_Page_Internal>().ApprenticeID_InputTxt(SelectedIDs[j]);
                        Console.WriteLine(SelectedIDs[j]);
                        GetInstance<SearchApprentice_Page_Internal>().Search_Btn();
                        GetInstance<SearchApprentice_Page_Internal>().ApprenticID_TableLnk(0);
                        ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().StepHistory_Step_Txt("0"),
                                                                NewStepInputs[j],
                                                                "Verify apprentice updated OJT Hours History", Name);
                        ExtentReportLog(GetInstance<ApprenticeInformation_Page_Internal>().StepHistory_EffectiveDate_Txt("0"),
                                                                EffectiveDate,
                                                                "Verify apprentice updated OJT Hours Credited Date", Name);
                    }
                }
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Build Falure: " + e);
                throw (e);
            }
        }
    }
}

/*
 * success
 * -------
 * Line 1 - Success!
 * Line 2 - Step sucessfully updated.
 * 
 * Error
 * ------
 * Line 1 - error!
 * Line 2 - Please fix the error(s).
 * 
 * Error Message Column
 * ---------------------
 * Lower Step Number - New step number should be higher than current step
 * Registration date - Effective date should be greater than registration date.
 * Effective Date - Enter Effective date.
 */

