using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class SelectHeaderTestSuit
    {
        PageHelper.HomePage homePage;
        IWebDriver driver;
        public SelectHeaderTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            homePage = new PageHelper.HomePage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        [Test]
        public void VerifyElemetsButton()
        {
            homePage.Elements(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Elements", actualOutput);
        }
        [Test]
        public void VerifyFormsButton()
        {
            homePage.Forms(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Forms", actualOutput);
        }
        [Test]
        public void VerifyAlertFrameAndWindowsButton()
        {
            homePage.AlertFrameAndWindows(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Alerts, Frame & Windows", actualOutput);
        }
        [Test]
        public void VerifyWidgetsButton()
        {
            homePage.Widgets(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Widgets", actualOutput);
        }
        [Test]
        public void VerifyInteractionsButton()
        {
            homePage.Interactions(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Interactions", actualOutput);
        }




        //[Test]
        //public  void VerifyHomeButton()
        //{
        //    homePage.HomeHeaderSelect(driver);
        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Home", actualOutput);
        //}

        //[Test]
        //public void VerifyInteractionButton()
        //{
        //    homePage.InteractionHeaderSelect(driver);
        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Interactions", actualOutput);
        //}

        //[Test]
        //public void VerifyWidgetButton()
        //{
        //    homePage.WidgetHeaderSelect(driver);
        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Widgets", actualOutput);
        //}

        //[Test]
        //public void VerifyToolTipAndDoubleClickButton()
        //{
        //    homePage.ToolTipAndDoubleClickHeaderSelect(driver);
        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Tooltip and Double click", actualOutput);
        //}

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
