using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository;
using System.Threading;
using WA.LNI.Apprentice.UIAutomation.Utilities;
using System.Reflection;
using WA.LNI.Apprentice.TestFramework;
using RelevantCodes.ExtentReports;
using System.Configuration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Registration;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.MENU_On_Left_Navigation_Bar;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Requests;
using WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Dashboard_Overview.Quick_Links.RSI_OJT_Reporting;
using System.Collections.Generic;
using System.Data;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace WA.LNI.Apprentice.UIAutomation.TestCases
{
    [TestClass]
    public class DummyTest : TestBase
    {
        string Name;

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TC001_Verify_Login()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            string Apprentice_ID = "29685";
            string Apprentic_FirstName = "A";
            string Apprentic_LastName = "SWANSON";

            string ApprenticAffidavitInfo_Current_Query_1 =
              "EXEC [aprnt].[p_apprentice_details_for_affidavit] @apprentice_rid = " + Apprentice_ID + ", @first_name = " + Apprentic_FirstName + ", @last_name = " + Apprentic_LastName;

            string FirstName_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "FirstName");
            string LastName_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "LastName");
            string ProgramName_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "Program");
            string Occupation_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "OccupationName");
            string Status_DB = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "StatusDesc");

            string[] RegistrationDate_DB_temp = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "BeginDate").Split(' ');
            string RegistrationDate_DB = DateTime.Parse(RegistrationDate_DB_temp[0]).ToString("MM-dd-yyyy");

//            string[] CancelDate_DB_temp = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "CancelDate").Split(' ');
//            string CancelDate_DB = DateTime.Parse(CancelDate_DB_temp[0]).ToString("MM-dd-yyyy");

            string[] CompletionDate_DB_Temp = DBConnection.GetDBData(ApprenticAffidavitInfo_Current_Query_1, "CompletionDate").Split(' ');
            string CompletionDate_DB = DateTime.Parse(CompletionDate_DB_Temp[0]).ToString("MM-dd-yyyy");

            Console.Write(RegistrationDate_DB + " " + CompletionDate_DB);
            

            /* GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
             ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
             GetInstance<LandingPage>().Tasks("128");
             Thread.Sleep(3000);*/

            /*string query = "select YearNumber,Q1,Q2,Q3,Q4, (ISNULL(Q1,0)+ISNULL(Q2,0)+ISNULL(Q3,0)+ISNULL(Q4,0)) AS Total from \n" +
                            "( \n"+
                            "select[year_num] as YearNumber, 'Q' + cast([quarter_num] as varchar) as QuarterNum, sum(isnull([hrs_qty], 0))  RISHours \n"+
                            "from[aprnt].[apprentice_pgm_occpn_hour] \n"+
                            "where[apprentice_pgm_occpn_rid]=24992 and work_hour_type_code in ('RSI_Paid','RSI_Unpaid') \n"+
                            "group by[year_num],[quarter_num] \n"+
	                        ") as q \n"+
                            "PIVOT \n"+
                            "( \n"+
                            "sum(RISHours) \n"+
                            "FOR QuarterNum in (Q1,Q2,Q3,Q4) \n"+
	                        ") as pvt \n"+
                            "order by YearNumber \n";

            List<string> data = DBConnection.GetDBData_List_String(query, "Total");

            for (int i=0; i< data.Count; i++)
            {
               
                Console.WriteLine(data[i]);
            }*/


            /*using (var writer = new StringWriter())
            {
                (DBConnection.GetDBData_0(query)).WriteXml(writer);
                Console.WriteLine(writer.ToString());
            }*/

            ///Console.WriteLine("_"+list+"_");
            //string apprenticeID = "175157";
            //string CurrentAppHours = "SELECT SUM(b.hrs_qty) AS 'OJTHour' FROM [aprnt].[apprentice_pgm_occpn] a INNER JOIN [aprnt].[apprentice_pgm_occpn_hour] b ON a.rid=b.apprentice_pgm_occpn_rid WHERE a.apprentice_rid = " + apprenticeID + "AND b.work_hour_type_code ='OJT'";
            //string list1 = DBConnection.GetDBData(CurrentAppHours, "OJTHour");

            //string ReqTermHours = "SELECT * FROM [aprnt].[apprentice_pgm_occpn] WHERE apprentice_rid = " + apprenticeID;
            //string list2 = DBConnection.GetDBData(ReqTermHours, "rid", "term_qty","create_date");
            //Console.WriteLine(list2);
            /* GetInstance<DashBoard_Overview_Page>().QuickLnks_RSI_OJTReporting_ClickLnk();
             Thread.Sleep(3000);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().SelectProgram_DrpDwn("128");
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Search_Btn();
             Thread.Sleep(3000);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().FromDate_Input("08/01/2018");
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().ToDate_Input("11/01/2018");
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().AutoFill_btn();
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 0);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 1);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 2);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 3);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 4);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 5);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_RSIPaid_Input("10", 6);

             List <string> _msg_ = new List<string>();
             Thread.Sleep(3000);
             GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Submit_ClickBtn();
             Thread.Sleep(3000);
             _msg_ =GetInstance<ApprenticeReadyTo_Report_Hours_Page>().Table_ErrorMessageInfo_Status_Check_Txt();

             for (int i = 0; i < _msg_.Count; i++)
             { 
                 string[] txt_0 = _msg_[i].Split('(');
                 string temp = txt_0[0].Substring(txt_0[0].IndexOf(' '));
                 string txt_1 = temp.Substring(temp.IndexOf(' ') + 1);
                 ExtentReportLog(txt_1, "Date range should be with in the quarter of the year ", "CHECK", Name);
             }*/
        }
        //counties llist 
        //table[@class='wikitable sortable jquery-tablesorter']//tbody//tr/td[1]/a
/*
        [TestMethod]
        public void Verify_Profile()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);

            IList<IWebElement> WikiTable = Selenium.ObjDriver.FindElements(By.XPath("table[@class='wikitable sortable jquery-tablesorter']//tbody//tr/td[1]/a"));

            List<string> s = Selenium.Driver.GetText(WikiTable, "" );
            //AutomationReport.Capture(Selenium.ObjDriver);           
        }
        */
        

        [TestMethod]
        public void Verify_Profile()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<ProgramProfile>().Profile();
            Thread.Sleep(10000);
            //AutomationReport.Capture(Selenium.ObjDriver);           
        }
        
        [TestMethod]
        public void Verify_LandingPage()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name); 
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks();
         //  ExtentReportLog("Program Overview", Base.GetInstance<LandingPage>().LandingPageHeading(), "verification of heading", Name);
        }

        [TestMethod]
        public void Verify_StepUpdate()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            GetInstance<LoginPage>().Login(ExcelReader.GetTestData_Integration(Name, DataConstants.LOGINID),
            ExcelReader.GetTestData_Integration(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().Tasks("152");
            Thread.Sleep(1000);
            GetInstance<DashBoard_Overview_Page>().Request_ClickTab();
            Thread.Sleep(1000);
            ExtentReportLog("Murray ,Corey (179041)", GetInstance<Requests_Page>().Table_IncomingTransfer_Name_Txt(0), "Test", Name);
            Console.WriteLine(GetInstance<Requests_Page>().Table_IncomingTransfer_Name_Txt(2));
            GetInstance<Requests_Page>().Click_TakeAction_Matching_ID("188103");
            Thread.Sleep(5000);
            GetInstance<Requests_Page>().Accept_Btn();
        }
        
        [TestMethod]
        public void ArtsInternalLogin()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            //  Base.GetInstance<LoginPage>().Login(ExcelReader.GetTestData(Name, DataConstants.LOGINID),
            //  ExcelReader.GetTestData(Name, DataConstants.PASSWORD));
            GetInstance<LandingPage>().ToLandingPage("128");
            Thread.Sleep(1000);
        }

        [TestMethod]
        public void ARTSInternalRef()
        {
            Name = MethodBase.GetCurrentMethod().Name;
            Selenium.Log = Selenium.Extent.StartTest(Name);
            Selenium.Log.Log(LogStatus.Info, "Started test " + Name);
            ExcelReader.SetSheet(ConfigurationManager.AppSettings.Get("TestApprenticeRegInfoSheet"));
            GetInstance<Left_Menu_Nav_Bar>().Main_Apprentice_Tab();
            GetInstance<Left_Menu_Nav_Bar>().Apprentice_AppReg_Lnk();
            GetInstance<AppReg_EnterSSN_Page_Internal>().ProgramId_InputNum("128");
            
            GetInstance<AppReg_EnterSSN_Page_Internal>().EnterSSN_InputNum(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.SSN));
            GetInstance<AppReg_EnterSSN_Page_Internal>().FindApprentice_ClickBtn();
            GetInstance<AppReg_Form_Page_Internal>().FirstName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.FIRSTNAME));
            GetInstance<AppReg_Form_Page_Internal>().LastName_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.LASTNAME));
            GetInstance<AppReg_Form_Page_Internal>().AddressLine1_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ADDRESS1));
            GetInstance<AppReg_Form_Page_Internal>().City_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.CITY));
            GetInstance<AppReg_Form_Page_Internal>().State_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));
            GetInstance<AppReg_Form_Page_Internal>().ZipCode_Input(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.ZIPCODE));
            GetInstance<AppReg_Form_Page_Internal>().Phone_InputTxt(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.APPLICANTPHONE));
            GetInstance<AppReg_Form_Page_Internal>().Gender_DrpDwn(ExcelReader.GetAppRegInfo(Name, AppRegInfoConstants.STATE));
        }
    }
}
