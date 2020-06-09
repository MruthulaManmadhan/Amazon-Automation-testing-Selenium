using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class ResizableTestSuit
    {
        IWebDriver driver;
        PageHelper.ResizablePage resizablePage;
        public ResizableTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            resizablePage = new PageHelper.ResizablePage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }
        [Test]
        public void VerifyResizable()
        {
            string oldPosition = resizablePage.Position(driver);
            resizablePage.ResizableFromHeader(driver);
            string newPosition = resizablePage.Position(driver);
            Assert.AreNotEqual(oldPosition, newPosition);
        }
        [Test]
        public void VerifySideBarResizable()
        {
            string oldPosition = resizablePage.Position(driver);
            resizablePage.ResizableFromSideBar(driver);
            string newPosition = resizablePage.Position(driver);
            Assert.AreNotEqual(oldPosition, newPosition);
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
