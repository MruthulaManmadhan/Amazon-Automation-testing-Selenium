using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.Test
{
    public class SelectProductTestSuit
    {
        IWebDriver driver;
        PageHelper.SelectProductPage selectProductPage;
        public SelectProductTestSuit()
        {
            driver = new GenericHelper.SeleniumSetMethod().GetDriver();
            selectProductPage = new PageHelper.SelectProductPage();
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
        public void SelectProduct()
        {
            string productName = selectProductPage.SelectProduct(driver,lines[1]);
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            var actualOutput = selectProductPage.GetProductName(driver);
            Assert.AreEqual(productName, actualOutput);

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
