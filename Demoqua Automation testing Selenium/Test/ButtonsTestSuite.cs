using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class ButtonsTestSuite
    {
        IWebDriver driver;
        PageHelper.ButtonPage buttonPage;
        public ButtonsTestSuite()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            buttonPage = new PageHelper.ButtonPage();
        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }


        [Test]
        public void VerifyDoubleClick()
        {
            var actualOutput = buttonPage.DoubleClick(driver);
            Assert.AreEqual("You have done a double click", actualOutput);

        }

        [Test]
        public void VerifyRightClick()
        {
            var actualOutput = buttonPage.RightClick(driver);
            Assert.AreEqual("You have done a right click", actualOutput);

        }
        [Test]
        public void VerifyClick()
        {
            var actualOutput = buttonPage.Click(driver);
            Assert.AreEqual("You have done a dynamic click", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}