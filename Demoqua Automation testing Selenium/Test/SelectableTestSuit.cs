using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class SelectableTestSuit
    {
        IWebDriver driver;
        PageHelper.SelectablePage selectablePage;
        public SelectableTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            selectablePage = new PageHelper.SelectablePage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }
  
        public void VerifySelectable()
        {
            var oldColour = selectablePage.GetColour(driver);
            selectablePage.SelectableFromHeader(driver);

            var newColour = selectablePage.GetColour(driver);
            Assert.AreNotEqual(newColour, oldColour);

        }

        [Test]
        public void VerifySideBarSelectable()
        {
            var oldColour = selectablePage.GetColour(driver);
            selectablePage.SelectableFromSideBar(driver);

            var newColour = selectablePage.GetColour(driver);
            Assert.AreNotEqual(newColour, oldColour);

        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
