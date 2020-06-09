using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class CheckboxAndRadioButtonTestSuit
    {
        PageHelper.CheckBoxRadioPage checkBoxAndRadio;
        IWebDriver driver;
        public CheckboxAndRadioButtonTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            checkBoxAndRadio = new PageHelper.CheckBoxRadioPage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }

        [Test]
        public void VerifyCheckBox()
        {
            checkBoxAndRadio.CheckBoxRadioFromHeader(driver);
            var oldColourCheckBox1 = checkBoxAndRadio.GetCheckboxColour(driver,"Button 1");
            var oldColourCheckBox2 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 2");
            var oldColourCheckBox3 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 3");
            var oldColourCheckBox4 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 4");
            checkBoxAndRadio.Checkbox(driver,"Button 3");
            var newColourCheckBox1 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 1");
            var newColourCheckBox2 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 2");
            var newColourCheckBox3 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 3");
            var newColourCheckBox4 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 4");
            Assert.AreEqual(oldColourCheckBox1, newColourCheckBox1);
            Assert.AreEqual(oldColourCheckBox2, newColourCheckBox2);
            Assert.AreNotEqual(oldColourCheckBox3, newColourCheckBox3);
            Assert.AreEqual(oldColourCheckBox4, newColourCheckBox4);

        }
        [Test]
        public void VerifySideBarCheckBox()
        {
            checkBoxAndRadio.CheckBoxRadioFromSideBar(driver);
            var oldColourCheckBox1 = checkBoxAndRadio.GetCheckboxColour(driver,"Button 1");
            var oldColourCheckBox2 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 2");
            var oldColourCheckBox3 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 3");
            var oldColourCheckBox4 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 4");
            checkBoxAndRadio.Checkbox(driver,"Button 3");
            var newColourCheckBox1 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 1");
            var newColourCheckBox2 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 2");
            var newColourCheckBox3 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 3");
            var newColourCheckBox4 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 4");
            Assert.AreEqual(oldColourCheckBox1, newColourCheckBox1);
            Assert.AreEqual(oldColourCheckBox2, newColourCheckBox2);
            Assert.AreNotEqual(oldColourCheckBox3, newColourCheckBox3);
            Assert.AreEqual(oldColourCheckBox4, newColourCheckBox4);

        }
        [Test]
        public void VerifyRadio()
        {
            checkBoxAndRadio.CheckBoxRadioFromHeader(driver);

            var oldColourCheckBox3 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 3");
            checkBoxAndRadio.RadioButton(driver,"Button 3");
            var newColourCheckBox1 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 1");
            var newColourCheckBox2 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 2");
            var newColourCheckBox3 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 3");
            Assert.AreEqual(newColourCheckBox1, newColourCheckBox2);
            Assert.AreNotEqual(newColourCheckBox1, newColourCheckBox3);
            Assert.AreNotEqual(oldColourCheckBox3, newColourCheckBox3);

        }
        [Test]
        public void VerifySideBarRadio()
        {
            checkBoxAndRadio.CheckBoxRadioFromSideBar(driver);
            var oldColourCheckBox3 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 3");
            checkBoxAndRadio.RadioButton(driver,"Button 3");
            var newColourCheckBox1 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 1");
            var newColourCheckBox2 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 2");
            var newColourCheckBox3 = checkBoxAndRadio.GetRadioButtonColour(driver,"Button 3");
            Assert.AreEqual(newColourCheckBox1, newColourCheckBox2);
            Assert.AreNotEqual(newColourCheckBox1, newColourCheckBox3);
            Assert.AreNotEqual(oldColourCheckBox3, newColourCheckBox3);

        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
