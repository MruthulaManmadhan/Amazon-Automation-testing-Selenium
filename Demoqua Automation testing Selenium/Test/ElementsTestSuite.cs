using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class ElementsTestSuite
    {
        IWebDriver driver;
        PageHelper.HomePage homePage;
        PageHelper.ElementsPage elementsPage;
        public ElementsTestSuite()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            homePage = new PageHelper.HomePage();
            elementsPage = new PageHelper.ElementsPage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }


        [Test]
        public void VerifyTextBox()
        {
            elementsPage.TextBox(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Text Box", actualOutput);

        }

        [Test]
        public void VerifyCheckBox()
        {
            elementsPage.CheckBox(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Check Box", actualOutput);

        }
        [Test]
        public void VerifyRadioButton()
        {
            elementsPage.RadioButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Radio Button", actualOutput);
        }


        [Test]
        public void VerifyWebTables()
        {
            elementsPage.WebTables(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Web Tables", actualOutput);

        }

        [Test]
        public void VerifyButtons()
        {
            elementsPage.Buttons(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Buttons", actualOutput);
        }

        [Test]
        public void VerifyLinks()
        {
            elementsPage.Links(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Links", actualOutput);
        }

        [Test]
        public void VerifyUploadAndDownload()
        {
            elementsPage.UploadAndDownload(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Upload and Download", actualOutput);
        }

        [Test]
        public void VerifyDynamicProperties()
        {
            elementsPage.DynamicProperties(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Dynamic Properties", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}