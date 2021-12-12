using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;
using RelevantCodes.ExtentReports;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Program.Create_New_Program;
using System;
using System.Collections.Generic;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Program.Program_Search;

namespace WA.LNI.Apprentice.UIAutomation.TestCases.ARTS_INTERNAL.Program.Create_New_Program
{
    [TestClass]
    public class Verify_Create_Program : TestBase
    {
        string Name;

        [TestMethod]
        public void TC000_Verify_Create_Program()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);

            //DATA----------------------------------------------------------------------------------------------------
            string ProgramName = "Eastern Washington UBC";
            string ProgramType = "1";
            string ShopType = "1";
            string ContactName = "Test Contact Name";
            string ContactPhone = "(589) 969-8408";
            string ContactTollFree = "(589) 969-8408";
            string ContactFax = "(978) 848-9807";
            string ContactEmail = "tau@gmail.com";
            string Website = "http://arts.unit-test.wads.wa.gov/#/programonboard";
            string StandardURL = "http://arts.unit-test.wads.wa.gov/#/programonboard";
            //Give ascending numbers only
            List<string> CountyCovered = new List<string>()
            {"1", "2", "3", "4", "8", "12", "13", "14", "18"};
            string ProvisionalDate = "01/05/2018";
            string PermanentDate = "01/05/2018";
            string ConsultantName = "1";
            string MailingAddressL1 = "12B washington ST";
            string MailingAddressL2 = "Suit C2";
            string MailingAddressCity = "Olympia";
            string MailingAddressState = "WA";
            string MailingAddresszip = "98502";
            string PhysicalAddressL1 = "1258 Walnut Creek";
            string PhysicalAddressL2 = "APT B42";
            string PhysicalAddressCity = "Olympia";
            string PhysicalAddressState = "WA";
            string PhysicalAddresszip = "98502";
            string NewProgramID = "";

            //Occupation-0
            string Occ0_FullName = "Occupation Full Name 1";
            string Occ0_Count = "0";
            string Occ0_SOCCategoryDrpDwn = "1";
            string Occ0_SOCCode = "45454545";
            //string Occ0_SOCTitle = "SOC Title";
            string Occ0_SOCDecription = "SOC Decription 1";
            string Occ0_ProgressionTypeDrpDwn = "0";
            string Occ0_JourneyWageLevel = "40";
            string Occ0_TermHours = "4000";
            string Occ0_MinTermHours = "2500";
            string Occ0_RSIHours = "1000";
            string Occ0_ProbationHours = "1500";
            string Occ0_ActiveDate = "11/15/2019";
            string Occ0_NumberOfSteps = "4";
            
            Dictionary<string, string> Occ0_WageLevelFromTo = new Dictionary<string, string>()
            {
                {"0","804" },
                {"805", "1752" },
                {"1753", "3001" },
                {"3002", "4000" }
            };

            List<string> Occ0_WageStepPecent = new List<string>()
            {
                "10", "35", "55", "95"
            };

            //Occupation-1
            string Occ1_FullName = "Occupation Full Name 2";
            string Occ1_Count = "1";
            string Occ1_SOCCategoryDrpDwn = "1";
            string Occ1_SOCCode = "84848466";
            //string Occ1_SOCTitle = "SOC Title 2";
            string Occ1_SOCDecription = "SOC Decription 2";
            string Occ1_ProgressionTypeDrpDwn = "0";
            string Occ1_JourneyWageLevel = "28.2";
            string Occ1_TermHours = "5000";
            string Occ1_MinTermHours = "3000";
            string Occ1_RSIHours = "1000";
            string Occ1_ProbationHours = "1500";
            string Occ1_ActiveDate = "11/15/2019";
            string Occ1_NumberOfSteps = "5";
            Dictionary<string, string> Occ1_WageLevelFromTo = new Dictionary<string, string>()
            {
                {"0","1000" },
                {"1001", "2000" },
                {"2001", "3000" },
                {"3001", "4000" },
                {"4001", "5000" }
            };
            List<string> Occ1_WageStepPecent = new List<string>()
            {
                "10", "35", "55", "75", "95"
            };

            //addative
            //hardcoded
            int StepsAdded = 0;

            //Committee Member 0
            string Comm0_CommitteeMember = "0";
            string Comm0_CommitteeMemberFirstName = "Harry";
            string Comm0_CommitteeMemberLasttName = "King";
            string Comm0_EffectiveDate = "11/10/2019";
            string Comm0_RepOf = "0";
            List <string> Comm0_Roles = new List<string>(){ "0", "1", "2", "3" };

            //Committee Member 1
            string Comm1_CommitteeMember = "1";
            string Comm1_CommitteeMemberFirstName = "Joe";
            string Comm1_CommitteeMemberLasttName = "Fotner";
            string Comm1_EffectiveDate = "11/10/2019";
            string Comm1_RepOf = "1";
            List<string> Comm1_Roles = new List<string>() { "0", "1", "2", "3", "4" };
       
            //addative 
            //hardcoded
            string EtryNumber = "0";

            //Creating Program----------------------------------------------------------------------------------
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<Left_Menu_Nav_Bar>().Main_ProgramTab_Btn();
            GetInstance<Left_Menu_Nav_Bar>().Program_CreateProgram_Lnk();
            GetInstance<Program_CreateProgram_Internal>().ProgramName_Input(ProgramName);
            GetInstance<Program_CreateProgram_Internal>().ProgramType_DrpDwnBtn(ProgramType);
            GetInstance<Program_CreateProgram_Internal>().ShopType_DrpDwnBtn(ShopType);
            GetInstance<Program_CreateProgram_Internal>().ContactName_Input(ContactName);
            GetInstance<Program_CreateProgram_Internal>().ContactPhone_Input(ContactPhone);
            GetInstance<Program_CreateProgram_Internal>().ContacTTollFree_Input(ContactTollFree);
            GetInstance<Program_CreateProgram_Internal>().ContactFax_Input(ContactFax);
            GetInstance<Program_CreateProgram_Internal>().ContactEmail_Input(ContactEmail);
            GetInstance<Program_CreateProgram_Internal>().WebSiteUrl_Input(Website);
            GetInstance<Program_CreateProgram_Internal>().StandardUrl_Input(StandardURL);
            CountyCovered = GetInstance<Program_CreateProgram_Internal>().CountyCovered_ChkBox(CountyCovered);
            GetInstance<Program_CreateProgram_Internal>().MailingAddresL1_Input(MailingAddressL1);
            GetInstance<Program_CreateProgram_Internal>().Consultant_DrpDwnBtn(ConsultantName);      
            GetInstance<Program_CreateProgram_Internal>().ProvisonalDate_Input(ProvisionalDate);          
            GetInstance<Program_CreateProgram_Internal>().MailingAddresL2_Input(MailingAddressL2);
            GetInstance<Program_CreateProgram_Internal>().MailingAddresCity_Input(MailingAddressCity);
            GetInstance<Program_CreateProgram_Internal>().MailingAddresState_Input(MailingAddressState);
            GetInstance<Program_CreateProgram_Internal>().MailingAddresZipCode_Input(MailingAddresszip);
            GetInstance<Program_CreateProgram_Internal>().PhysicalAddresL1_Input(PhysicalAddressL1);
            GetInstance<Program_CreateProgram_Internal>().PhysicalAddresL2_Input(PhysicalAddressL2);
            GetInstance<Program_CreateProgram_Internal>().PhysicalAddresCity_Input(PhysicalAddressCity);
            GetInstance<Program_CreateProgram_Internal>().PhysicalAddresState_Input(PhysicalAddressState);
            GetInstance<Program_CreateProgram_Internal>().PhysicalAddresZipCode_Input(PhysicalAddresszip);
            GetInstance<Program_CreateProgram_Internal>().PermanentDate_Input(PermanentDate);        

            //Adding New Occupation 
            StepsAdded = GetInstance<Program_CreateProgram_Internal>().Add_Occupation(Occ0_FullName, Occ0_Count, Occ0_SOCCategoryDrpDwn, Occ0_SOCCode, Occ0_SOCDecription,
                Occ0_ProgressionTypeDrpDwn, Occ0_JourneyWageLevel, Occ0_TermHours, Occ0_MinTermHours, Occ0_RSIHours, Occ0_ProbationHours, Occ0_ActiveDate, Occ0_NumberOfSteps, StepsAdded,
                Occ0_WageLevelFromTo, Occ0_WageStepPecent);

            GetInstance<Program_CreateProgram_Internal>().Add_Occupation(Occ1_FullName, Occ1_Count, Occ1_SOCCategoryDrpDwn, Occ1_SOCCode, Occ1_SOCDecription,
                Occ1_ProgressionTypeDrpDwn, Occ1_JourneyWageLevel, Occ1_TermHours, Occ1_MinTermHours, Occ1_RSIHours, Occ1_ProbationHours, Occ1_ActiveDate, Occ1_NumberOfSteps, StepsAdded,
                Occ1_WageLevelFromTo, Occ1_WageStepPecent);

            //Adding new Committee Member
            EtryNumber = GetInstance<Program_CreateProgram_Internal>().Add_Committee_Memeber(
                Comm0_CommitteeMember, Comm0_CommitteeMemberFirstName, Comm0_CommitteeMemberLasttName, Comm0_EffectiveDate, Comm0_RepOf, EtryNumber, Comm0_Roles);
            GetInstance<Program_CreateProgram_Internal>().Add_Committee_Memeber(
                Comm1_CommitteeMember, Comm1_CommitteeMemberFirstName, Comm1_CommitteeMemberLasttName, Comm1_EffectiveDate, Comm1_RepOf, EtryNumber, Comm1_Roles);
            GetInstance<Program_CreateProgram_Internal>().SaveProgram_Btn();

            NewProgramID = GetInstance<Program_Information_Page>().ProgramID_Txt();
            ExtentReportInfo(NewProgramID, "New Program ID", Name);

            //UI Validation----------------------------------------------------------------------------------------------------------------------------------
            //Program Information
            ExtentReportLog(GetInstance<Program_Information_Page>().ProgramFullName_Txt(), ProgramName, "Validating Program Name", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().EmailData_Txt(), ContactEmail, "Validating Email", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().SiteURL_Txt(), Website, "Validating Site URL", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().TollFreePhone_Txt(), ContactTollFree, "Validating Toll Free Number", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().PhoneNumber_Txt(), ContactPhone, "Validating Phone", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().FaxNumber_Txt(), ContactFax, "Validating Fax Number", Name);

            switch (ShopType)
            {
                case "0":
                    ShopType = "Unknown";
                    break;
                case "1":
                    ShopType = "Non-Union";
                    break;
                case "2":
                    ShopType = "Union";
                    break;              
                default:
                    ShopType = "Unknown";
                    break;
            }
            ExtentReportLog(GetInstance<Program_Information_Page>().ShopType_txt(), ShopType, "Validating Shop Type", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().ProvisonalDate_Txt(), DateTime.Parse(ProvisionalDate).ToString("MM/d/yyyy"), "Validating Provisional Date", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().PermanentDate_Txt(), DateTime.Parse(PermanentDate).ToString("MM/d/yyyy"), "Validating Permanent Date", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().ContactName_Txt(), ContactName, "Validating Contact Namee", Name);

            switch (ProgramType)
            {
                case "0":
                    ProgramType = "Group Joint";
                    break;
                case "1":
                    ProgramType = "Group Non-Joint";
                    break;
                case "2":
                    ProgramType = "Individual Joint";
                    break;
                case "3":
                    ProgramType = "Individual Non-Joint";
                    break;
                case "4":
                    ProgramType = "Individual Waiver";
                    break;
                case "5":
                    ProgramType = "On the Job Training";
                    break;
                case "6":
                    ProgramType = "Plant Program";
                    break;
                case "7":
                    ProgramType = "Unknown";
                    break;
                default:
                    ProgramType = "Unknown";
                    break;
            }
            ExtentReportLog(GetInstance<Program_Information_Page>().ProgramType_Txt(), ProgramType, "Validating Program Type", Name);

            switch (ConsultantName)
            {
                case "0":
                    ConsultantName = "Patrick Martin";
                    break;
                case "1":
                    ConsultantName = "AhShalla Harris";
                    break;
                case "2":
                    ConsultantName = "Jim Kaltenbaugh";
                    break;
                case "3":
                    ConsultantName = "Brittany Craighead";
                    break;
                case "4":
                    ConsultantName = "Gary Peterson";
                    break;
                case "5":
                    ConsultantName = "Elmer Arter";
                    break;
                case "6":
                    ConsultantName = "Evie Lawry";
                    break;
                case "7":
                    ConsultantName = "Evan Hamilton";
                    break;
                case "8":
                    ConsultantName = "Rachel McAloon";
                    break;
                case "9":
                    ConsultantName = "Sandra Husband";
                    break;
                case "10":
                    ConsultantName = "Jake Steller";
                    break;
                case "11":
                    ConsultantName = "John Kabir";
                    break;
                case "12":
                    ConsultantName = "Nishanth Chintamani";
                    break;
                case "13":
                    ConsultantName = "Ken Konyeaso";
                    break;
                default:
                    ConsultantName = "Unknown";
                    break;
            }
            ExtentReportLog(GetInstance<Program_Information_Page>().LNIContactName_Txt(), ConsultantName, "Validating LNI Contact Name", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().ProgramOfficialStandardURL_Txt(), StandardURL, "Validating Site URL", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().MailingAddress_Txt(),
                MailingAddressL1 + " " + MailingAddressL2 + " " + MailingAddressCity + " " + MailingAddressState + " " + MailingAddresszip,
                "Validating Mailing Address", Name);

            ExtentReportLog(GetInstance<Program_Information_Page>().PhysicalAddress_Txt(),
                PhysicalAddressL1 + " " + PhysicalAddressL2 + " " + PhysicalAddressCity + " " + PhysicalAddressState + " " + PhysicalAddresszip,
                "Validating Physical Address", Name);

            //Counties Covered
            GetInstance<Program_Information_Page>().ExpandCounties_Btn();

            for (int i = 0; i < CountyCovered.Count; i++)
            {
               ExtentReportLog(GetInstance<Program_Information_Page>().CountiesList_Txt(i), CountyCovered[i], "Validating Counties", Name);
            }

            //Occupations
            //0
            GetInstance<Program_Information_Page>().SelectProgramOccupation_DrpDwn("0");

            ExtentReportLog(GetInstance<Program_Information_Page>().OccFullName_Txt(), Occ0_FullName, "Validating Occupation fullname", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().EffectiveDate_Txt(), DateTime.Parse(Occ0_ActiveDate).ToString("MM/d/yyyy"), "Validating Occupation Active Date", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().SocCode_Txt(), Occ0_SOCCode, "Validating Occupation SOC Code", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().ProbationHours_Txt(), Occ0_ProbationHours, "Validating Occupation Probation hours", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().SupplimentHours_Txt(), Occ0_RSIHours, "Validating Occupation Supliment RSI Hours", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().TermHours_Txt(), Occ0_TermHours, "Validating Occupation Total Term Hours", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().MinTermHours_Txt(), Occ0_MinTermHours, "Validating Occupation Min Hours", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().StepHoursDecileTable_Txt(), Occ0_WageLevelFromTo, "Validating Occupation decile hours vale for each step", Name);     

            List<string> Occ0_steps = new List<string>();
            for(int i = 1; i<= int.Parse(Occ0_NumberOfSteps); i++)
            {
                Occ0_steps.Add("Step "+ i.ToString());
            }
            ExtentReportLog(GetInstance<Program_Information_Page>().StepCountTable_Txt(), Occ0_steps, "Validating Occupation Steps table", Name);

            //1
            GetInstance<Program_Information_Page>().SelectProgramOccupation_DrpDwn("1");

            ExtentReportLog(GetInstance<Program_Information_Page>().OccFullName_Txt(), Occ1_FullName, "Validating Occupation fullname", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().EffectiveDate_Txt(), DateTime.Parse(Occ1_ActiveDate).ToString("MM/d/yyyy"), "Validating Occupation Effective date", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().SocCode_Txt(), Occ1_SOCCode, "Validating Occupation SOC Code", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().ProbationHours_Txt(), Occ1_ProbationHours, "Validating Occupation Probation hours", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().SupplimentHours_Txt(), Occ1_RSIHours, "Validating Occupation Supliment RSI Hours", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().TermHours_Txt(), Occ1_TermHours, "Validating Occupation Total Term Hours", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().MinTermHours_Txt(), Occ1_MinTermHours, "Validating Occupation Min Hours", Name);
            ExtentReportLog(GetInstance<Program_Information_Page>().StepHoursDecileTable_Txt(), Occ1_WageLevelFromTo, "Validating Occupation decile hours vale for each step", Name);
            List<string> Occ1_steps = new List<string>();
            for (int i = 1; i <= int.Parse(Occ1_NumberOfSteps); i++)
            {
                Occ1_steps.Add("Step " + i.ToString());
            }
            ExtentReportLog(GetInstance<Program_Information_Page>().StepCountTable_Txt(), Occ1_steps, "Validating Occupation Steps table", Name);

            //Committee Members
        }
    }
}