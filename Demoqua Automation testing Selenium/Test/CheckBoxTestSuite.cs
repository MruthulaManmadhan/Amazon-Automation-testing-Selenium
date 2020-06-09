using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class CheckBoxTestSuite
    {
        PageHelper.CheckBoxPage checkBoxPage;
        IWebDriver driver;
        public CheckBoxTestSuite()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            checkBoxPage = new PageHelper.CheckBoxPage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        [Test]
        public void VerifyCheckBox()
        {
            checkBoxPage.Checkbox(driver);
            var actualOutput = checkBoxPage.GetMessage(driver);
          var expectedOutput = "You have selected :\r\nhome\r\ndesktop\r\nnotes\r\ncommands\r\ndocuments\r\nworkspace\r\nreact\r\nangular\r\nveu\r\noffice\r\npublic\r\nprivate\r\nclassified\r\ngeneral\r\ndownloads\r\nwordFile\r\nexcelFile";

            Assert.AreEqual(expectedOutput, actualOutput);

        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
