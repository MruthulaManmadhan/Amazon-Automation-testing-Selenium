using Amazon_Automation_testing_Selenium.UIHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.Test
{
    public class LogoutTestSuit
    {
        IWebDriver driver;
        PageHelper.LogoutPage logoutPage;
        public LogoutTestSuit()
        {
            driver = new GenericHelper.SeleniumSetMethod().GetDriver();
            logoutPage = new PageHelper.LogoutPage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("https://www.amazon.in/");
        }

        [Test]
        public void VerifyLogout()
        {
            
            var actualOutput = logoutPage.Logout(driver);
            Assert.AreEqual( "LogIn", actualOutput);

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
