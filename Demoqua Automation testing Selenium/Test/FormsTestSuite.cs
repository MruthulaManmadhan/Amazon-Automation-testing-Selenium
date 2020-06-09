using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class FormsTestSuite
    {
        IWebDriver driver;
        PageHelper.HomePage homePage;
        PageHelper.FormsPage formsPage;
        public FormsTestSuite()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            homePage = new PageHelper.HomePage();
            formsPage = new PageHelper.FormsPage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        [Test]
        public void VerifyPracticeForm()
        {
            formsPage.PracticeForm(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Practice Form", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
