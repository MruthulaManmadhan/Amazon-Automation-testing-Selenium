using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class TooltipTestSuit
    {
        IWebDriver driver;
        PageHelper.TooltipPage TooltipPage;
        public TooltipTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            TooltipPage = new PageHelper.TooltipPage();
        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }
        public void VerifyTooltipFromHeader()
        {
            string expectedOutPut = "We ask for your age only for statistical purposes.";
            string actualOutPut = TooltipPage.TooltipFromHeader(driver);
            Assert.AreEqual(expectedOutPut, actualOutPut);

        }
        public void VerifyTooltipFromSidebar()
        {
            string expectedOutPut = "We ask for your age only for statistical purposes.";
            string actualOutPut = TooltipPage.TooltipFromSideBar(driver);
            Assert.AreEqual(expectedOutPut, actualOutPut);
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
