using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class SliderTestSuit
    {
        IWebDriver driver;
        PageHelper.SliderPage sliderPage;
        public SliderTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            sliderPage = new PageHelper.SliderPage();
        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        [Test]
        public void VerifySlider()
        {
            string oldPosition = sliderPage.Position(driver);
            sliderPage.Slider(driver);
            string newPosition = sliderPage.Position(driver);
            Assert.AreNotEqual(newPosition, oldPosition);
        }

        //[Test]
        //public void VerifySliderThroughHeaderButton()
        //{
        //    string oldPosition = sliderPage.Position(driver);
        //    sliderPage.SliderFromHeader(driver);
        //    string newPosition = sliderPage.Position(driver);
        //    Assert.AreNotEqual(newPosition, oldPosition);
        //}

        //[Test]
        //public void VerifySideBarSlider()
        //{
        //    string oldPosition = sliderPage.Position(driver);
        //    sliderPage.SliderFromSideBar(driver);
        //    string newPosition = sliderPage.Position(driver);
        //    Assert.AreNotEqual(newPosition, oldPosition);
        //}
        //[TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
