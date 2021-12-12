using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.Utilities
{
    public class DBConnection
    {
        public static SqlConnection Connection;
        public static SqlCommand Command;
        public static SqlDataReader Reader;
        public static void ConnectDB(string connectionString)
        { 
            Connection = new SqlConnection(connectionString);
            Connection.ConnectionString = connectionString;
        }

        public static string GetDBData(string query,params string[] columns)
        {
            try
            { 
            string Output = "";
            //string outputClmn = "";

            Command = new SqlCommand(query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            var List = new ArrayList(columns);
            while (Reader.Read())
            {
                foreach(string column in List) {
                    Output = Output + Reader[column].ToString();
                    if (List.IndexOf(column) == List.Count-1)
                    {
                        break;
                    } 
                    Output = Output + " || ";    
                }
            }
            Connection.Close();
            return Output  ;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Unable to run query " + e);
                throw (e);
            }
        }

        public static List<string> GetDBData_List_String(string query, params string[] columns)
        {
            try
            {
                List<string> Output = new List<string>();
                Command = new SqlCommand(query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                var List = new ArrayList(columns);
                while (Reader.Read())
                {
                    foreach (string column in List)
                    {
                        Output.Add(Reader[column].ToString());
                        if (List.IndexOf(column) == List.Count - 1)
                        {
                            break;
                        }
                    }
                }
                Connection.Close();
                return Output;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Unable to run query " + e);
                throw (e);
            }
        }


        public static List<float> GetDBData_List_Float(string query, params string[] columns)
        {
            try
            {
                List<float> Output = new List<float>();
                Command = new SqlCommand(query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                var List = new ArrayList(columns);
                while (Reader.Read())
                {
                    foreach (string column in List)
                    {
                        Output.Add(float.Parse(Reader[column].ToString()));
                        if (List.IndexOf(column) == List.Count - 1)
                        {
                            break;
                        }
                    }
                }
                Connection.Close();
                return Output;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Unable to run query " + e);
                throw (e);
            }
        }

        public static List<string> GetDBData_List_String(string query)
        {
            try
            {
                List<string> res = new List<string>();
                Connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataSet result = new DataSet();
                    adapter.Fill(result);

                    foreach (DataTable table in result.Tables)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            foreach (DataColumn column in table.Columns)
                            {
                                for (int i = 0; i < table.Columns.Count; i++)
                                {
                                    res.Add(row[column].ToString());
                                }
                            }
                        }
                    }
                }
                return res;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Unable to run query " + e);
                throw (e);
            }
        }

        public static List<float> GetDBData_List_Float(string query)
        {
            try
            {
                List<float> res = new List<float>();
                Connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
                {
                    DataSet result = new DataSet();
                    adapter.Fill(result);
                    
                    foreach (DataTable table in result.Tables)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            foreach (DataColumn column in table.Columns)
                            {
                                for (int i = 0; i < table.Columns.Count; i++)
                                {
                                    res.Add(float.Parse(row[column].ToString()));
                                }
                            }
                        }
                    }
                }
                return res;
            }

            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Unable to run query " + e);
                throw (e);
            }
        }

        public static void CloseDB()
        {
            Connection.Close();
        }
    }
}
