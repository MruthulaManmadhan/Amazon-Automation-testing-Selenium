using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demoqua_Automation_testing_Selenium.PageHelper;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class DroppableTestSuit
    {
        IWebDriver driver;
        DroppablePage droppablePage;
        public DroppableTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            droppablePage = new DroppablePage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }
        [Test]
        public void VerifyDroppable()
        {
            var actualOutput = droppablePage.DroppableFromHeader(driver);
            Assert.AreEqual("Dropped!", actualOutput);
        }

        [Test]
        public void VerifySideBarDroppable()
        {
            var actualOutput = droppablePage.DroppableFromSideBar(driver);
            Assert.AreEqual("Dropped!", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
