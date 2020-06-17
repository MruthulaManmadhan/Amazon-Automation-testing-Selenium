using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class TooltipAndDoubleClickTestSit
    {
        IWebDriver driver;
        PageHelper.TooltipAndDoubleClickPage TooltipAndDoubleClickPage;

        public TooltipAndDoubleClickTestSit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            TooltipAndDoubleClickPage = new PageHelper.TooltipAndDoubleClickPage();
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
            TooltipAndDoubleClickPage.DoubleClickFromHeader(driver);
            string expectedAlertText = "Double Click Alert\r\n\r\nHi,You are seeing this message as you have double cliked on the button";
            var alert_win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_win.Text);

            alert_win.Accept();
        }

        [Test]
        public void VerifySideBarDoubleClick()
        {
            TooltipAndDoubleClickPage.DoubleClickThroughSideBar(driver);
            string expectedAlertText = "Double Click Alert\r\n\r\nHi,You are seeing this message as you have double cliked on the button";
            var alert_win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_win.Text);

            alert_win.Accept();
        }

        [Test]
        public void VerifyRighClickFromHeader()
        {
            TooltipAndDoubleClickPage.RightClickFromHeader(driver);
            string expectedAlertText = "You have selected Favourites";
            var alert_win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_win.Text);

            alert_win.Accept();
        }
        [Test]
        public void VerifySideBarRighClick()
        {
            TooltipAndDoubleClickPage.RightClickThroughSideBar(driver);
            string expectedAlertText = "You have selected Favourites";
            var alert_win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_win.Text);

            alert_win.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
