using Amazon_Automation_testing_Selenium.UIHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.Test
{

    public class LoginTestSuit
    {
        IWebDriver driver;
        PageHelper.LoginPage loginPage;
        public LoginTestSuit()
        {
            driver = new GenericHelper.SeleniumSetMethod().GetDriver();
            loginPage = new PageHelper.LoginPage();
        }
        static readonly string loginCredentialFile = @"C:\Users\Mruthula.Manmadhan\Documents\Automation Testing\Amazon\Login Credentials.txt";
        static string[] lines = File.ReadAllLines(loginCredentialFile);

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("https://www.amazon.in/");
        }

        [Test]
        public void VerifyLogin()
        {
            char[] seperator = { ';' };
            string[] credential = lines[0].Split(seperator);

            var actualOutput = loginPage.Email(driver, credential[0]);
            Assert.AreEqual("Password", actualOutput);

            actualOutput = loginPage.Password(driver, credential[1]);
            Assert.AreEqual("Hello, " + credential[2], actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {

            driver.Close();
        }
    }

}
