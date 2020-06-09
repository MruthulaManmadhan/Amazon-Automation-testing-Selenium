using Amazon_Automation_testing_Selenium.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.PageHelper
{
    public class HomePage
    {
        UIHelper.HomePage homePage;
        SeleniumSetMethod seleniumSetMethod;
        public HomePage()
        {
            homePage = new UIHelper.HomePage();
            seleniumSetMethod = new SeleniumSetMethod();
        }
        public void Search(IWebDriver driver, string product)
        {
            seleniumSetMethod.EnterText(driver,homePage.SearchTextBox, product, "Xpath");
            seleniumSetMethod.Click(driver,homePage.SearchButton, "Xpath");
        }
    }
}
