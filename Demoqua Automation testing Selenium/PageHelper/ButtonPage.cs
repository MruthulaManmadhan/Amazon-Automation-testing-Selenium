using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class ButtonPage
    {
        UIHelper.ButtonsPage buttonsPage;
        public ButtonPage()
        {
            buttonsPage = new UIHelper.ButtonsPage();
        }
        public string DoubleClick(IWebDriver driver)
        {
            new ElementsPage().Buttons(driver);
            var button = driver.FindElement(By.XPath(buttonsPage.DoubleClickButtonXpath));
            Actions action = new Actions(driver);
            action.DoubleClick(button).Perform();
            return driver.FindElement(By.Id(buttonsPage.DoubleClickMessageId)).Text;

        }
        public string RightClick(IWebDriver driver)
        {
            new ElementsPage().Buttons(driver);
            var button = driver.FindElement(By.XPath(buttonsPage.RightClickButtonXpath));
            Actions action = new Actions(driver);
            action.ContextClick(button).Perform(); 
            return driver.FindElement(By.Id(buttonsPage.RightClickMessageId)).Text;

        }
        public string Click(IWebDriver driver)
        {
            new ElementsPage().Buttons(driver);
            var button = driver.FindElement(By.XPath(buttonsPage.ClickButtonXpath));
            Actions action = new Actions(driver);
            action.Click(button).Perform();
            return driver.FindElement(By.Id(buttonsPage.ClickMessageId)).Text;
        }
    }
}
