using Amazon_Automation_testing_Selenium.GenericHelper;
using Amazon_Automation_testing_Selenium.Test;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.PageHelper
{
    public class LogoutPage
    {
        UIHelper.LogoutPage logoutPage;
        UIHelper.HomePage homePage;
        SeleniumSetMethod seleniumSetMethod;
        LoginPage loginPage;
        //LoginTestSuit loginTestSuit;
        public LogoutPage()
        {
            loginPage = new LoginPage();
            logoutPage = new UIHelper.LogoutPage();
            homePage = new UIHelper.HomePage();
            seleniumSetMethod = new SeleniumSetMethod();
            //loginTestSuit = new LoginTestSuit();
        }

        static readonly string loginCredentialFile = @"C:\Users\Mruthula.Manmadhan\Documents\Automation Testing\Amazon\Login Credentials.txt";
        static string[] lines = File.ReadAllLines(loginCredentialFile);

        public string Logout(IWebDriver driver)
        {
            Login(driver);
            seleniumSetMethod.Mousehover(driver, homePage.AccountsAndListsXpath, "Xpath");
            seleniumSetMethod.Click(driver, homePage.SignOutXpath, "Xpath");
            return driver.FindElement(By.XPath(logoutPage.LogInText)).Text;
        }

        public void Login(IWebDriver driver)
        {
            char[] seperator = { ';' };
            string[] credential = lines[0].Split(seperator);
            loginPage.Email(driver, credential[0]);
            loginPage.Password(driver, credential[1]);
        }
    }
}
