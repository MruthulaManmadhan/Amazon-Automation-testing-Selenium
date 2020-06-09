using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class CheckBoxPage
    {
        UIHelper.CheckBoxPage checkBoxPage;
        public CheckBoxPage()
        {
            checkBoxPage = new UIHelper.CheckBoxPage();
        }
        public void Checkbox(IWebDriver driver)
        {
            Actions action = new Actions(driver);
            new ElementsPage().CheckBox(driver);
            var checkBox = driver.FindElement(By.XPath(checkBoxPage.CheckBoxXpath));
            action.Click(checkBox).Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        public string GetMessage(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(checkBoxPage.CheckBoxMessageXpath)).Text;
        }
    }
}
