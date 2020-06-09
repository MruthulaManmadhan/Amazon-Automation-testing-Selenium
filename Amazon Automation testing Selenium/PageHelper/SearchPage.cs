using Amazon_Automation_testing_Selenium.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.PageHelper
{
    public class SearchPage
    {
        UIHelper.SearchPage searchPage;
        SeleniumSetMethod seleniumSetMethod;
        HomePage homePage;
        public SearchPage()
        {
            searchPage = new UIHelper.SearchPage();
            seleniumSetMethod = new SeleniumSetMethod();
            homePage = new HomePage();
        }
        public void Filter(IWebDriver driver, string product, string condition)
        {
            homePage.Search(driver, product);
            seleniumSetMethod.Click(driver,searchPage.FeatureButtonXpath, "Xpath");
            seleniumSetMethod.Click(driver,condition, "Text");
        }
        public string GetProductNameHeader(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(searchPage.ProductNameXpath)).Text;
        }
        public string GetSelectedFilter(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(searchPage.FilterSelectedXpath)).Text;
        }

    }
}
