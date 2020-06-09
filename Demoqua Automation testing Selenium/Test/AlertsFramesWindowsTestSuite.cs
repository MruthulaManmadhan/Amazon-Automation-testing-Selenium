using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class AlertsFramesWindowsTestSuite
    {
        IWebDriver driver;
        PageHelper.HomePage homePage;
        PageHelper.AlertsFramesWindowsPage alertsFramesWindows;
        public AlertsFramesWindowsTestSuite()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            homePage = new PageHelper.HomePage();
            alertsFramesWindows = new PageHelper.AlertsFramesWindowsPage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }


        [Test]
        public void VerifyBrowserWindows()
        {
            alertsFramesWindows.BrowserWindows(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Browser Windows", actualOutput);
        }

        [Test]
        public void VerifyAlerts()
        {
            alertsFramesWindows.Alerts(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Alerts", actualOutput);
        }

        [Test]
        public void VerifyFrames()
        {
            alertsFramesWindows.Frames(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Frames", actualOutput);
        }

        [Test]
        public void VerifyModalDialogs()
        {
            alertsFramesWindows.ModalDialogs(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Modal Dialogs", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
