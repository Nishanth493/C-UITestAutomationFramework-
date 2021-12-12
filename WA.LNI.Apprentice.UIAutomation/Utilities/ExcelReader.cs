using OfficeOpenXml;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.IO;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.Utilities
{
    public class ExcelReader
    {
        public static ExcelWorksheet ExcelSheet;
        public static ExcelPackage ExcelPackage;
        public static void Create(string file) {
            ExcelPackage = new ExcelPackage(new FileInfo(@file));
        }
        public static void SetSheet(string sheet)
        {
            ExcelSheet = (ExcelWorksheet)ExcelPackage.Workbook.Worksheets[sheet];
        }

        public static string GetTestData_Integration(string testcase, DataConstants Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Unable to get test case date from Excel || " + e);
                throw (e);
            }
        }

        public static string GetTestData_PreProd(string testcase, DataConstants Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Unable to get test case date from Excel || " + e);
                throw (e);
            }
        }

        public static  ArrayList GetEnvData(int application, int url1, int url2, int browser, int connection)
        {
            Thread.Sleep(2000);
            string Application = "";
            string Url1 = "";
            string Url2 = "";
            string Browser = "";
            string Connection = "";
            Application = ExcelSheet.GetValue(2, application).ToString();
            Url1 = ExcelSheet.GetValue(2, url1).ToString();
            Url2 = ExcelSheet.GetValue(2, url2).ToString();
            Browser = ExcelSheet.GetValue(2, browser).ToString();
            Connection = ExcelSheet.GetValue(2, connection).ToString();
            //Console.WriteLine(Url);
            var List = new ArrayList(new string[] {Application, Url1, Url2, Browser, Connection });
            return List;
        }

        public static string GetAppRegInfo(string testcase, AppRegInfoConstants Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static string GetApprenticeTrasData(string testcase, AppTransInfoConstants Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static string Get_AI_ApproachingStepUpdate(string testcase, AI_ReadyToStepUpdate Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static string Get_AI_ProbationNearingCompletion(string testcase, AI_ProbationNearingCompletion Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static string Get_QL_OJT_RSI_Hours(string testcase, QL_OJT_RSI_Hours Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static string Get_QL_Activate_Occupation_TA(string testcase, QL_Activate_Occupation_TA Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static string Get_QL_Update_Journey_Level_Wages(string testcase, QL_Update_Journey_Level_Wages Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static string Get_QL_Step_Update(string testcase, QL_Step_Update Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static string Get_TS_Apprentice_Information(string testcase, TS_Apprentice_Information Constants)
        {
            try
            {
                int column = (int)Constants;
                string Value = "";
                int count = ExcelSheet.Dimension.End.Row;
                for (int index = 1; index <= count; index++)
                {
                    if (ExcelSheet.GetValue(index, 1).ToString().Equals(testcase))
                    {
                        Value = ExcelSheet.GetValue(index, column).ToString();
                        break;
                    }
                }
                return Value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, "ExcelReaderError" + DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Excel reader error || " + e);
                throw (e);
            }
        }

        public static void Close()
        {

        }

    }
}
