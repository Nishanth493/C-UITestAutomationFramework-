using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.LNI.Apprentice.TestFramework
{
    public class Base 
    {
        /// <summary>
        /// This code will maintain common page instance for all the page objects 
        /// </summary>
        /// <typeparam name="Page"></typeparam>
        /// <returns></returns>
        public static Page GetInstance<Page>() where Page : new()
        {
           var value =new Page();
           PageFactory.InitElements(Selenium.ObjDriver,value);
           return value;
        }   
    }
}

