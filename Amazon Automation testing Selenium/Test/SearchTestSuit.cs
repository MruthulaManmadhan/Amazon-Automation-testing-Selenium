using Amazon_Automation_testing_Selenium.UIHelper;
using Amazon_Automation_testing_Selenium.PageHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Amazon_Automation_testing_Selenium.Test
{
    public class SearchTestSuit
    {
        IWebDriver driver;
        PageHelper.HomePage homePage;
        PageHelper.SearchPage searchPage;
        public SearchTestSuit()
        {
            driver = new GenericHelper.SeleniumSetMethod().GetDriver();
            homePage = new PageHelper.HomePage();
            searchPage = new PageHelper.SearchPage();
        }

        static readonly string productFile = @"C:\Users\Mruthula.Manmadhan\Documents\Automation Testing\Amazon\Searching.txt";
        static string[] lines = File.ReadAllLines(productFile);

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("https://www.amazon.in/");
        }
        [Test]
        public void VerifySearchProduct()
        {
            homePage.Search(driver, lines[0]);

            var actualOutput = searchPage.GetProductNameHeader(driver);
            Assert.AreEqual("\""+lines[0]+ "\"", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
