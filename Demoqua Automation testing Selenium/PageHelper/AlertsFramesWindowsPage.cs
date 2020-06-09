using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class AlertsFramesWindowsPage
    {

        UIHelper.AlertsFramesWindowsPage alertsFramesWindows;
        Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod method;

        public AlertsFramesWindowsPage()
        {
            alertsFramesWindows = new UIHelper.AlertsFramesWindowsPage();
            method = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod();
        }
        public void BrowserWindows(IWebDriver driver)
        {
            new HomePage().AlertFrameAndWindows(driver);
            method.Click(driver, alertsFramesWindows.BrowserWindowsXpath, "Xpath");
        }
        public void Alerts(IWebDriver driver)
        {
            new HomePage().AlertFrameAndWindows(driver);
            method.Click(driver, alertsFramesWindows.AlertsXpath, "Xpath");
        }
        public void Frames(IWebDriver driver)
        {
            new HomePage().AlertFrameAndWindows(driver);
            method.Click(driver, alertsFramesWindows.FramesXpath, "Xpath");
        }
        public void ModalDialogs(IWebDriver driver)
        {
            new HomePage().AlertFrameAndWindows(driver);
            Scroll(driver, alertsFramesWindows.ModalDialogsXpath);
            method.Click(driver, alertsFramesWindows.ModalDialogsXpath, "Xpath");
        }

        private void Scroll(IWebDriver driver, string elementXpath)
        {
            //scroll until view the element
            var element = driver.FindElement(By.XPath(elementXpath));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
        }
    }
}
