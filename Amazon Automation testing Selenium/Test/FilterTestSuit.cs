using Amazon_Automation_testing_Selenium.UIHelper;
using Amazon_Automation_testing_Selenium.PageHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.IO;

namespace Amazon_Automation_testing_Selenium.Test
{
    public class FilterTestSuit
    {
        IWebDriver driver;
        PageHelper.SearchPage searchPage;
        public FilterTestSuit()
        {
            driver = new GenericHelper.SeleniumSetMethod().GetDriver();
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
        public void VerifyLowToHighFilter()
        {
            searchPage.Filter(driver,lines[0], "Price: Low to High");

            var actualOutput = searchPage.GetSelectedFilter(driver);
            Assert.AreEqual("Price: Low to High", actualOutput);
        }

        [Test]

        public void VerifyHighToLowFilter()
        {
            searchPage.Filter(driver, lines[0], "Price: High to Low");

            var actualOutput = searchPage.GetSelectedFilter(driver);
            Assert.AreEqual("Price: High to Low", actualOutput);
        }

        [Test]
        public void VerifyAvgCustomerReviewFilter()
        {
            searchPage.Filter(driver, lines[0], "Avg. Customer Review");

            var actualOutput = searchPage.GetSelectedFilter(driver);
            Assert.AreEqual("Avg. Customer Review", actualOutput);
        }

        [Test]
        public void VerifyNewestArrivalFilter()
        {
            searchPage.Filter(driver, lines[0], "Newest Arrivals");

            var actualOutput = searchPage.GetSelectedFilter(driver);
            Assert.AreEqual("Newest Arrivals", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
