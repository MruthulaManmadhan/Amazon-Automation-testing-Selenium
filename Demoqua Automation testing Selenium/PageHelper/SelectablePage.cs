using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class SelectablePage
    {
        Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod method;
        UIHelper.SelectablePage selectablePage;
        public SelectablePage()
        {
            method = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod();
            selectablePage = new UIHelper.SelectablePage();
        }

        
        public void Selectable(IWebDriver driver, string item)
        {
            method.Click(driver,item, "Xpath");
        }
        public void SelectableFromHeader(IWebDriver driver)
        {
            new InteractionPage().Selectable(driver);
            method.Click(driver,selectablePage.FifthElement,"Xpath");
        }
        public void SelectableFromSideBar(IWebDriver driver)
        {
            new HomePage().SelectableSideBarButton(driver);
            method.Click(driver,selectablePage.FifthElement, "Xpath");
        }
        public string GetColour(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(selectablePage.FifthElement)).GetCssValue("background-color");
        }
    }
}
