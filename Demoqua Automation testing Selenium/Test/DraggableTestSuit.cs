using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class DraggableTestSuit
    {
        PageHelper.DraggablePage draggable;
        IWebDriver driver;
        public DraggableTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            draggable = new PageHelper.DraggablePage();
        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }

        [Test]
        public void VerifyDraggable()
        {
            string oldPosition = draggable.Position(driver);
            string newPosition = draggable.DragabbleFromHeader(driver);
            Assert.AreNotEqual(oldPosition, newPosition);

        }

        [Test]
        public void VerifySideBarDraggable()
        {
            string oldPosition = draggable.Position(driver);
            string newPosition = draggable.DraggableFromSideBar(driver);
            Assert.AreNotEqual(oldPosition, newPosition);
        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
