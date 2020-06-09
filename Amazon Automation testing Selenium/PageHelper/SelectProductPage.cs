using Amazon_Automation_testing_Selenium.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.PageHelper
{
    public class SelectProductPage
    {
        UIHelper.SearchPage searchPage;
        HomePage homePage;
        SeleniumSetMethod seleniumSetMethod;
        UIHelper.SelectProductPage selectProductPage;
        public SelectProductPage()
        {
            searchPage = new UIHelper.SearchPage();
            homePage = new HomePage();
            seleniumSetMethod = new SeleniumSetMethod();
            selectProductPage = new UIHelper.SelectProductPage();
        }
        public string SelectProduct(IWebDriver driver, string product)
        {
            homePage.Search(driver,product);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string productName = driver.FindElement(By.XPath(searchPage.FirstProductNameInResultXpath)).Text;
            seleniumSetMethod.Click(driver,searchPage.FirstProductNameInResultXpath, "Xpath");
            return productName;
        }
        public string GetProductName(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(selectProductPage.ProductNameXpath)).Text;
        }
    }
}
