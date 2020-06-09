using Amazon_Automation_testing_Selenium.GenericHelper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.PageHelper
{
    public class LoginPage
    {
        UIHelper.HomePage homePage;
        UIHelper.LoginPage loginPage;
        SeleniumSetMethod seleniumSetMethod;
        public LoginPage()
        {
            homePage = new UIHelper.HomePage();
            loginPage = new UIHelper.LoginPage();
            seleniumSetMethod = new SeleniumSetMethod();
        }
        public string Email(IWebDriver driver, string mailId)
        {
            seleniumSetMethod.Click(driver,homePage.AccountsAndListsXpath, "Xpath");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            seleniumSetMethod.EnterText(driver,loginPage.EmailTextBoxXpath, mailId, "Xpath");
            seleniumSetMethod.Click(driver,loginPage.EmailContinueId, "Id");
            return driver.FindElement(By.XPath(loginPage.PasswordTextXpath)).Text;
        }
        public string Password(IWebDriver driver, string password)
        {

            seleniumSetMethod.EnterText(driver,loginPage.PasswordTextBoxId, password, "Id");
            seleniumSetMethod.Click(driver,loginPage.PasswordSubmitId, "Id");
            return driver.FindElement(By.XPath(homePage.HelloName)).Text;
        }
    }
}
