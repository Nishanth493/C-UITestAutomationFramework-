 using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.ObjectModel;

namespace WA.LNI.Apprentice.TestFramework
{
    public class DriverFunctions
    {

        public IWebDriver Driver;
        
        public DriverFunctions(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public void WaitFluent(IWebElement element,double time)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(3);

            wait.PollingInterval = TimeSpan.FromSeconds(time);
            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                if (element.Displayed)
                {
                    return true;
                }
                return false;
            });
            wait.Until(waiter);
        }

        public void WaitFluent(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(2);
            wait.PollingInterval = TimeSpan.FromSeconds(10);

            try
            {
                Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
                {
                    if (element.Displayed)
                    {
                        return true;
                    }
                    return false;
                });
                wait.Until(waiter);
            }

            catch (ElementClickInterceptedException e)
            {
                if ((Selenium.ObjDriver.FindElement(By.CssSelector(
                   "div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.lni-o-layout--simple div:nth-child(1) div:nth-child(3) div.lni-c-collapse:nth-child(1) div.lni-c-spinner__overlay > div.lni-c-spinner__wrapper"))).Displayed)
                {
                    Func<IWebElement, bool> Waiter = new Func<IWebElement, bool>((IWebElement ele) =>
                    {
                        if ((Selenium.ObjDriver.FindElement(By.CssSelector(
                   "div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.lni-o-layout--simple div:nth-child(1) div:nth-child(3) div.lni-c-collapse:nth-child(1) div.lni-c-spinner__overlay > div.lni-c-spinner__wrapper"))).Displayed)
                        {
                            return true;
                        }
                        return false;
                    });
                    wait.Until(Waiter);
                }
            }

            catch (System.Reflection.TargetInvocationException e)
            {
                if ((Selenium.ObjDriver.FindElement(By.CssSelector(
                   "div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.lni-o-layout--simple div:nth-child(1) div:nth-child(3) div.lni-c-collapse:nth-child(1) div.lni-c-spinner__overlay > div.lni-c-spinner__wrapper"))).Displayed)
                {
                    Func<IWebElement, bool> Waiter = new Func<IWebElement, bool>((IWebElement ele) =>
                {
                    if ((Selenium.ObjDriver.FindElement(By.CssSelector(
               "div.centerWidth:nth-child(3) div.ewn3body:nth-child(4) div.lni-o-layout--simple div:nth-child(1) div:nth-child(3) div.lni-c-collapse:nth-child(1) div.lni-c-spinner__overlay > div.lni-c-spinner__wrapper"))).Displayed)
                    {
                        return true;
                    }
                    return false;
                });
                    wait.Until(Waiter);
                }
            }
        }

        /// <summary>
        /// This code is to perform selenium function, click  
        /// </summary>Click
        /// <param name="element"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void Click(IWebElement element, string selement)
        {
            try
            {
                WaitFluent(element);
                element.Click();
                Selenium.Log.Log(LogStatus.Pass, "Clicked Element: " + selement);  
            }
            catch (Exception e)
            { 
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver, selement+DateTime.Today.ToString("MM-dd-yyyy_hh_mm_ss"));
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to click the Element -> " + selement + " || " + " Build Error Message: " + e );
                throw(e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, send keys eg: input text 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="text"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void SendKeys(IWebElement element, string text, string selement)
        {
            try
            {
                WaitFluent(element);
                element.SendKeys(text);
                Selenium.Log.Log(LogStatus.Pass, "Entered Text in: " + selement);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to enter into Element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, select an element from the dropdown with 'text' as reference
        /// </summary>
        /// <param name="element"></param>
        /// <param name="text"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void SelectDropDownByText(IWebElement element, string text, string selement)
        {
            try
            {
                WaitFluent(element);
                SelectElement DrpDown = new SelectElement(element);
                DrpDown.SelectByText(text);

                Selenium.Log.Log(LogStatus.Pass, "Selected dropdown option: " + selement);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to select drop down text -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        ///This code is to perform selenium function, select an element from the dropdown with 'Value' as reference
        /// </summary>
        /// <param name="element"></param>
        /// <param name="text"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void SelectDropDownByValue(IWebElement element, string text, string selement)
        {
            try
            {
                WaitFluent(element);
                SelectElement DrpDown = new SelectElement(element);
                DrpDown.SelectByValue(text);
                Selenium.Log.Log(LogStatus.Pass, "Selected dropdown option: " + selement);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to select drop down value -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, select an element from the dropdown with 'Index' as reference
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void SelectDropDownByIndex(IWebElement element, int index, string selement)
        {
            try
            {
                WaitFluent(element);
                SelectElement DrpDown = new SelectElement(element);
                DrpDown.SelectByIndex(index);
                Selenium.Log.Log(LogStatus.Pass, "Selected dropdown option: " + selement);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to select drop down index -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, click functionality using action class
        /// </summary>
        /// <param name="element"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void ActionClick(IWebElement element, string selement)
        {
            try
            {
                WaitFluent(element);
                Actions Act = new Actions(Driver);
                Act.MoveToElement(element).Click().Build();
                Selenium.Log.Log(LogStatus.Pass, "Selected element: " + selement);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to click the element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, checks the visibility of an element 
        /// </summary>
        /// <param name="element"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public bool IsVisible(IWebElement element, string selement)
        {   
            try
            {
                WaitFluent(element);
                bool value = element.Enabled;
                Selenium.Log.Log(LogStatus.Pass, "Visibility checked for: " + selement);
                return value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "element not found -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, sendKeys functionality using action class
        /// </summary>
        /// <param name="element"></param>
        /// <param name="text"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void ActionSendKeys(IWebElement element, string text, string selement)
        {
            try
            {
                WaitFluent(element);
                Actions Act = new Actions(Driver);
                Act.MoveToElement(element).SendKeys(text).Build();
                Selenium.Log.Log(LogStatus.Pass, "entered text to: " + selement);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to enter into the element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, Context click (Right Click) functionality using action class
        /// </summary>
        /// <param name="element"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void ActionContexClick(IWebElement element, string selement)
        {
            try
            {
                Actions Act = new Actions(Driver);
                Act.MoveToElement(element).ContextClick().Build().Perform();
                Selenium.Log.Log(LogStatus.Pass, "Right Clicked/Context Clicked on: " + selement);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to click the element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, gets the text of the element 
        /// </summary>
        /// <param name="element"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public string GetText(IWebElement element, string selement)
        {
            
            try
            {
                WaitFluent(element);
                return element.Text;
                Selenium.Log.Log(LogStatus.Pass, "Retrived Text of: " + selement);         
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able get the text -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }    
        }

        /// <summary>
        /// This code is to perform selenium function, Gets text using javaScriptExecutor
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public string GetTextJS(IWebElement element, string selement)
        {
            try
            {
                WaitFluent(element);
                IJavaScriptExecutor JSExecutor = (IJavaScriptExecutor)Driver;
                string text = (string)JSExecutor.ExecuteScript("return arguments[0].value;", element);
                Selenium.Log.Log(LogStatus.Pass, "Retrived text from: " + selement);
                return text;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to enter into element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        ///This code is to perform selenium function, move to a pirticular element using action class
        /// </summary>
        /// <param name="element"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void ActionMoveToElemenet(IWebElement element, string selement)
        {
            try
            {
                WaitFluent(element);
                Actions Act = new Actions(Driver);
                Act.MoveToElement(element).Build().Perform();
                Selenium.Log.Log(LogStatus.Pass, "Moved to: " + selement);

            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to move to the element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        ///This code is to perform selenium function, move to a pirticular element using action class
        /// </summary>
        /// <param name="element"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void Clear(IWebElement element, string selement)
        {
            try
            {
                WaitFluent(element); 
                element.Clear();
                Selenium.Log.Log(LogStatus.Pass, "Cleared " + selement);

            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to move to the element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        public void DeleteTxt(IWebElement element, string selement)
        {
            try
            {
                WaitFluent(element);
                element.SendKeys(Keys.Control + "a");
                element.SendKeys(Keys.Delete);
                Selenium.Log.Log(LogStatus.Pass, "Cleared " + selement);

            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to move to the element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }


        /// <summary>
        ///This code is to perform selenium function, returns attribute of element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="attributename"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public string GetAttribute(IWebElement element, string attributename, string selement)
        {
            string value;
            try
            {
                WaitFluent(element);        
                value = element.GetAttribute(attributename);
                Selenium.Log.Log(LogStatus.Pass, "Retrived attributes for: " + selement);
                return value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to get attributes of the element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
            
        }

        /// <summary>
        ///This code is to perform selenium function, gets the present webpage title
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public string GetTitle()
        {
            string Title;
            try
            {
                Title = Driver.Title;
                Selenium.Log.Log(LogStatus.Pass, "Retrived Title for : " + Driver);
                return Title;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to get the title of the page -> " + Driver + " || " + " Build Error Message: " + e);
                throw (e);
            }
            
        }

        /// <summary>
        ///returns the selected drop down value text
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public string GetSelectedTxt(IWebElement DrpDwn, string selement)
        {
            try
            {
                WaitFluent(DrpDwn);
                SelectElement select = new SelectElement(DrpDwn);
                IWebElement option = select.SelectedOption;
                string Item = option.Text;
                return Item;
                
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to get the title of the page -> " + Driver + " || " + " Build Error Message: " + e);
                throw (e);
            }

        }
        /// <summary>
        /// This code is to perform selenium function, returns the CSSValue of a webelement
        /// </summary>
        /// <param name="cssvalue"></param>
        /// <param name="element"></param>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public string GetCSSValue(IWebElement element, string valueType, string selement)
        {
            string value;
            try
            {
                WaitFluent(element);  
                value = element.GetCssValue(valueType);
                Selenium.Log.Log(LogStatus.Pass, "Retrived CSS Value for : " + selement);
                return value;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to get the CSS value -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }          
        }

        /// <summary>
        /// This code is to perform selenium function, Gets text using javaScriptExecutor
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public void ScrollToElement(IWebElement element, string selement)
        {
            try
            {
                IJavaScriptExecutor JSExecutor = (IJavaScriptExecutor)Driver;
                JSExecutor.ExecuteScript("arguments[0].scrollIntoView();", element);
                Selenium.Log.Log(LogStatus.Info, "Scrolled down to " + element);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Warning, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Warning, "Unable to scroll to -> " + element + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        ///This code is to perform selenium function, accept alerts/ pop-ups 
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public void AlertAccept()
        {
            try
            {
                var Alert = Driver.SwitchTo().Alert();
                Alert.Accept();
                Selenium.Log.Log(LogStatus.Pass, "Alert Accepted: " + Alert);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to move to accept alert " + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, dismiss alerts/ pop-ups 
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public void AlertDismiss()
        {
            try
            {
                var Alert = Driver.SwitchTo().Alert();
                Alert.Dismiss();
                Selenium.Log.Log(LogStatus.Pass, "Alert Accepted: " + Alert);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to move to dismiss alert " + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, switch the handle to the alert 
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public void SwithchToAlert()
        {
            try
            {
                Driver.SwitchTo().Alert();
                Selenium.Log.Log(LogStatus.Pass, "Switched to: " + (Driver.SwitchTo().Alert()).GetType());
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to move to switch to alert " + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, switch to a particular window 
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public void SwitchWindow(string windowname)
        {
            try
            {
                Driver.SwitchTo().Window(windowname);
                Selenium.Log.Log(LogStatus.Pass, "Switched to window: " + windowname);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to switch to window " + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }

        /// <summary>
        /// This code is to perform selenium function, switch to the default window 
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public void SwitchDefaultContent()
        {
            try
            {
                Driver.SwitchTo().DefaultContent();
                Selenium.Log.Log(LogStatus.Pass, "Switched to window: " + (Driver.SwitchTo().DefaultContent()).Title);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to switch to default content " + " || " + " Build Error Message: " + e);
                throw (e);
            }
        }


        /// <summary>
        /// This code is to perform selenium function, send keys/text using javaScriptExecutor
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public void SendKeysJS(IWebElement element, string text, string selement)
        {
            try
            {
                WaitFluent(element);
                IJavaScriptExecutor JSExecutor = (IJavaScriptExecutor)Driver;
                JSExecutor.ExecuteScript("arguments[0].setAttribute('value', '" + text + "')", element);
                Selenium.Log.Log(LogStatus.Pass, "Entered text into: " + selement);
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to enter into element -> " + selement + " || " + " Build Error Message: " + e);
                throw  (e);
            }
        }


        /// <summary>
        /// This code is to perform selenium function, send keys/text using javaScriptExecutor
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public bool IsDisplayed(IWebElement element, string selement)
        {
            bool val;
            try
            {
                WaitFluent(element);         
                val = element.Displayed;
                Selenium.Log.Log(LogStatus.Pass, "Checked if displayed for: " + selement);
                return val;
            }
            catch (Exception e)
            {
                string screenShotPath = AutomationReport.Capture(Selenium.ObjDriver);
                Selenium.Log.Log(LogStatus.Fail, "Snapshot below: " + Selenium.Log.AddScreenCapture(screenShotPath));
                Selenium.Log.Log(LogStatus.Fail, "Not able to find the element -> " + selement + " || " + " Build Error Message: " + e);
                throw (e);
            }
            
        }

        /// <summary>
        /// method for the wait function to wait for an element to be clickable
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author> 
        public void WaitForElementClickable(IWebElement element, double value)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(value));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        /// <summary>
        /// method for the wait function to wait for an element to be clickable
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void WaitForAlertIsPresent(double value)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(value));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        /// <summary>
        /// method for the wait function to wait for an element to be clickable
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void WaitForElementToBeSelected(IWebElement element, double value)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(value));
            wait.Until(ExpectedConditions.ElementToBeSelected(element));
        }

        /// <summary>
        /// method for the wait function to wait for an element to be Visible
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author>
        public void WatiForVisibilityOfAllElementsLocatedBy(ReadOnlyCollection<IWebElement> elements, double value)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(value));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elements));
        }

        /// <summary>
        /// method for the wait function to wait for an element to be present
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author
        public void WatiForTextToBePresentInElementBy(IWebElement element, string text, double value)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(value));
            wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));

        }

        /// <summary>
        /// method to generate timestamp
        /// </summary>
        /// <author>Nishanth; Chintamani(CHNG235)</author
        public void GetTimeStamp()
        {
            try
            {
                DateTime DT = DateTime.Now;

            }
            catch (Exception)
            {

                throw new TestException("Error in generating Time Stamp");  // custom exception
            }
        }

    }
}