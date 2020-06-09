using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class ElementsPage
    {
        UIHelper.ElementsPage elementsPage;
        Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod method;

        public ElementsPage()
        {
            elementsPage = new UIHelper.ElementsPage();
            method = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod();
        }
        public void TextBox(IWebDriver driver)
        {
            new HomePage().Elements(driver);
            method.Click(driver, elementsPage.TextBoxXpath, "Xpath");
        }
        public void CheckBox(IWebDriver driver)
        {
            new HomePage().Elements(driver);
            method.Click(driver, elementsPage.CheckBoxXpath, "Xpath");
        }
        public void RadioButton(IWebDriver driver)
        {
            new HomePage().Elements(driver);
            method.Click(driver, elementsPage.RadioButtonXpath, "Xpath");
        }
        public void WebTables(IWebDriver driver)
        {
            new HomePage().Elements(driver);
            method.Click(driver, elementsPage.WebTablesXpath, "Xpath");
        }
        public void Buttons(IWebDriver driver)
        {
            new HomePage().Elements(driver);
            method.Click(driver, elementsPage.ButtonsXpath, "Xpath");
        }
        public void Links(IWebDriver driver)
        {
            new HomePage().Elements(driver);
            method.Click(driver, elementsPage.LinksXpath, "Xpath");
        }
        public void UploadAndDownload(IWebDriver driver)
        {
            new HomePage().Elements(driver);
            Scroll(driver, elementsPage.UploadAndDownloadXpath);
            method.Click(driver, elementsPage.UploadAndDownloadXpath, "Xpath");
        }
        public void DynamicProperties(IWebDriver driver)
        {
            new HomePage().Elements(driver);
            Scroll(driver, elementsPage.DynamicPropertiesXpath);
            method.Click(driver, elementsPage.DynamicPropertiesXpath, "Xpath");
        }


        private void Scroll(IWebDriver driver,string elementXpath)
        {
            //scroll until view the element
            var element = driver.FindElement(By.XPath(elementXpath));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
        }
    }
}
