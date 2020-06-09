using Amazon_Automation_testing_Selenium.PageHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class InteractionTestSuit
    {
        IWebDriver driver;
        PageHelper.HomePage homePage;
        PageHelper.InteractionPage interaction;
        public InteractionTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            homePage = new PageHelper.HomePage();
            interaction = new PageHelper.InteractionPage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }


        [Test]
        public void VerifySortableFromInteraction()
        {
            interaction.Sortable(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Sortable", actualOutput);

        }

        [Test]
        public void VerifySelectableFromInteraction()
        {
            interaction.Selectable(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Selectable", actualOutput);
            
        }
        [Test]
        public void VerifyResizableFromInteraction()
        {
            interaction.Resizable(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Resizable", actualOutput);
        }


        [Test]
        public void VerifyDragableFromInteraction()
        {
            interaction.Dragabble(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Dragabble", actualOutput);

        }

        [Test]
        public void VerifyDroppableFromInteraction()
        {
            interaction.Droppable(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Droppable", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
