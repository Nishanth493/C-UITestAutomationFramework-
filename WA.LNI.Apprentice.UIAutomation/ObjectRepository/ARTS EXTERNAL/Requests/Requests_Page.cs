using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_EXTERNAL.Requests
{
    public class Requests_Page : Base
    {
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/section[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td/td/a")]
        public IList<IWebElement> Table_IncomingTransfer_Namelnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/section[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]//child::span")]
        public IList<IWebElement> Table_IncomingTransfer_RequestDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[1]/div[3]/div[1]/section[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr/td//button")]
        public IList<IWebElement> Table_IncomingTransfer_TakeActionBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/section[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/table[1]/tbody[1]//child::div[2]/span")]
        public IList<IWebElement> Table_IncomingTransfer_ActionStatusTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/section[3]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]//child::a")]
        public IList<IWebElement> Table_OutgoingTransfer_Namelnk { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/section[3]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]::span")]
        public IList<IWebElement> Table_OutgoingTransfer_RequestDateTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/section[3]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]::button")]
        public IList<IWebElement> Table_OutgoingTransfer_TakeActionBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[3]/div[3]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/section[3]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]//child::div[2]/span")]
        public IList<IWebElement> Table_OutgoingTransfer_ActionStatusTxt { get; set; }

        [FindsBy(How = How.Id, Using = "acceptAction")]
        public IWebElement AcceptBtn { get; set; }

        [FindsBy(How = How.Id, Using = "denyAction")]
        public IWebElement DenyBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Next')]")]
        public IWebElement NextBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//ul[@class='pagination']//child::button")]
        public IList<IWebElement> PageNavigationBarBtn { get; set; }

        [FindsBy(How = How.Id, Using = "requestActionSuccess")]
        public IWebElement RequestActionSucessMessageTxt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string Table_IncomingTransfer_Name_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_IncomingTransfer_Namelnk[n], "Table_IncomingTransfer_Namelnk"+n+"]");
        }

        public void Table_IncomingTransfer_Name_Lnk(int n)
        {
            Selenium.Driver.Click(Table_IncomingTransfer_Namelnk[n], "Table_IncomingTransfer_Namelnk" + n + "]");
        }

        public string Table_IncomingTransfer_RequestDate_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_IncomingTransfer_RequestDateTxt[n], "Table_IncomingTransfer_RequestDateTxt" + n + "]");
        }

        public void Table_IncomingTransfer_TakeAction_Btn(int n)
        {
            Selenium.Driver.Click(Table_IncomingTransfer_TakeActionBtn[n], "Table_IncomingTransfer_TakeActionBtn" + n + "]");
        }

        public string Table_IncomingTransfer_ActionStatus_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_IncomingTransfer_ActionStatusTxt[n], "Table_IncomingTransfer_ActionStatusTxt" + n + "]");
        }

        public string Table_OutgoingTransfer_Name_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_OutgoingTransfer_Namelnk[n], "Table_OutgoingTransfer_Namelnk" + n + "]");
        }

        public void Table_OutgoingTransfer_Name_lnk(int n)
        {
            Selenium.Driver.Click(Table_OutgoingTransfer_Namelnk[n], "Table_OutgoingTransfer_Namelnk" + n + "]");
        }

        public string Table_OutgoingTransfer_RequestDate_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_OutgoingTransfer_RequestDateTxt[n], "Table_OutgoingTransfer_RequestDateTxt" + n + "]");
        }

        public void Table_OutgoingTransfer_TakeAction_Btn(int n)
        {
            Selenium.Driver.Click(Table_OutgoingTransfer_TakeActionBtn[n], "Table_OutgoingTransfer_TakeActionBtn" + n + "]");
        }

        public string Table_OutgoingTransfer_ActionStatus_Txt(int n)
        {
            return Selenium.Driver.GetText(Table_OutgoingTransfer_ActionStatusTxt[n], "Table_OutgoingTransfer_ActionStatusTxt" + n + "]");
        }

        public void Click_TakeAction_Matching_ID(string Id)
        {
            int List_Length = Table_IncomingTransfer_Namelnk.Count;

            if (PageNavigationBarBtn.Count == 0)
            {
                for (int i = 0; i < List_Length; i++)
                {
                    string Extract_String_ID = Table_IncomingTransfer_Name_Txt(i);
                    string SubString_ID = Extract_String_ID.Substring(Extract_String_ID.Length - 7);
                    string temp_ID = Id + ")";
                    if (SubString_ID == temp_ID)
                    {
                        Console.WriteLine(Extract_String_ID);
                        Selenium.Driver.Click(Table_IncomingTransfer_TakeActionBtn[i], "Table_IncomingTransfer_TakeActionBtn[" + i + "]");
                        return;
                    }
                }
            }

            else
            {

                for (int j = 0; j < PageNavigationBarBtn.Count - 2; j++)
                {
                    for (int i = 0; i < List_Length; i++)
                    {
                        string Extract_String_ID = Table_IncomingTransfer_Name_Txt(i);
                        string SubString_ID = Extract_String_ID.Substring(Extract_String_ID.Length - 7);
                        string temp_ID = Id + ")";
                        if (SubString_ID == temp_ID)
                        {
                            Console.WriteLine(Extract_String_ID);
                            Selenium.Driver.Click(Table_IncomingTransfer_TakeActionBtn[i], "Table_IncomingTransfer_TakeActionBtn[" + i + "]");
                            return;
                        }
                    }
                    Selenium.Driver.Click(NextBtn, "NextBtn");
                }           
            }
        }

        public void Accept_Btn()
        {
             Selenium.Driver.Click(AcceptBtn, "AcceptBtn");
             Thread.Sleep(3000);
        }

        public void Deny_Btn()
        {
            Selenium.Driver.Click(DenyBtn, "DenyBtn");
            Thread.Sleep(3000);
        }

        public string RequestActionSucessMessage_Txt()
        {
            return Selenium.Driver.GetText(RequestActionSucessMessageTxt, "RequestActionSucessMessageTxt");
        } 
    }
}
