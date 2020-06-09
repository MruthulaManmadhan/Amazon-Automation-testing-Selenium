using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class WidgetsTestSuit
    {
        IWebDriver driver;
        PageHelper.HomePage homePage;
        PageHelper.WidgetPage widgetPage;
        public WidgetsTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            homePage = new PageHelper.HomePage();
            widgetPage = new PageHelper.WidgetPage();
        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        [Test]
        public void VerifyAccordian()
        {
            widgetPage.Accordian(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Accordian", actualOutput);
        }
        [Test]
        public void VerifyAutoComplete()
        {
            widgetPage.AutoComplete(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Auto Complete", actualOutput);
        }
        [Test]
        public void VerifyDatePicker()
        {
            widgetPage.DatePicker(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Date Picker", actualOutput);
        }
        [Test]
        public void VerifySlider()
        {
            widgetPage.Slider(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Slider", actualOutput);
        }
        [Test]
        public void VerifyProgressBar()
        {
            widgetPage.ProgressBar(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Progress Bar", actualOutput);
        }
        [Test]
        public void VerifyTabs()
        {
            widgetPage.Tabs(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Tabs", actualOutput);
        }
        [Test]
        public void VerifyToolTips()
        {
            widgetPage.ToolTips(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Tool Tips", actualOutput);
        }
        [Test]
        public void VerifyMenu()
        {
            widgetPage.Menu(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Menu", actualOutput);
        }

        [Test]
        public void VerifySelectMenu()
        {
            widgetPage.SelectMenu(driver);

            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Select Menu", actualOutput);
        }


        //[Test]
        //public void VerifyAutomationPracticeSwitchWindows()
        //{
        //    WidgetPage.AutomationPracticeSwitchWindows(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Automation Practice Switch Windows", actualOutput);
        //}

        //[Test]
        //public void VerifyAutomationPracticeTable()
        //{
        //    WidgetPage.AutomationPracticeTable(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Automation Practice Table", actualOutput);
        //}

        //[Test]
        //public void VerifyIFramePracticePage()
        //{
        //    WidgetPage.IFramePracticePage(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("IFrame Practice Page", actualOutput);
        //}

        //[Test]
        //public void VerifyAutomationPracticeForm()
        //{
        //    WidgetPage.AutomationPracticeForm(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Automation Practice Form", actualOutput);
        //}

        //[Test]
        //public void VerifyHTMLContactForm()
        //{
        //    WidgetPage.HTMLContactForm(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("HTML Contact Form", actualOutput);
        //}

        //[Test]
        //public void VerifyKeyBoardEvents()
        //{
        //    WidgetPage.KeyBoardEvents(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("KeyBoard Events", actualOutput);
        //}

        //[Test]
        //public void VerifyAutomationPracticeSwitchWindows2()
        //{
        //    WidgetPage.AutomationPracticeSwitchWindows2(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Automation Practice Switch Windows", actualOutput);
        //}

        //[Test]
        //public void VerifyKeyBoardEventsSampleForm()
        //{
        //    WidgetPage.KeyBoardEventsSampleForm(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("KeyBoard Events Sample Form", actualOutput);
        //}

        //[Test]
        //public void VerifyTooltipAndDoubleClick()
        //{
        //    WidgetPage.TooltipAndDoubleClick(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Tooltip And Double Click", actualOutput);
        //}

        //[Test]
        //public void VerifyTooltip()
        //{
        //    WidgetPage.Tooltip(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Tooltip", actualOutput);
        //}

        //[Test]
        //public void VerifyTabs()
        //{
        //    WidgetPage.Tabs(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Tabs", actualOutput);
        //}

        //[Test]
        //public void VerifySpinner()
        //{
        //    WidgetPage.Spinner(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Spinner", actualOutput);
        //}

        ////[Test]
        ////public void VerifySlider()
        ////{
        ////    WidgetPage.Slider(driver);

        ////    var actualOutput = homePage.GetHeader(driver);
        ////    Assert.AreEqual("Slider", actualOutput);
        ////}

        //[Test]
        //public void VerifySelectMenu()
        //{
        //    WidgetPage.SelectMenu(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("SelectMenu", actualOutput);
        //}

        //[Test]
        //public void VerifyProgressBar()
        //{
        //    WidgetPage.ProgressBar(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("ProgressBar", actualOutput);
        //}

        //[Test]
        //public void VerifyMenu()
        //{
        //    WidgetPage.Menu(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Menu", actualOutput);
        //}

        //[Test]
        //public void VerifyDialog()
        //{
        //    WidgetPage.Dialog(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("Dialog", actualOutput);
        //}

        //[Test]
        //public void VerifyDatePicker()
        //{
        //    WidgetPage.DatePicker(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("DatePicker", actualOutput);
        //}


        //[Test]
        //public void VerifyControlGroup()
        //{
        //    WidgetPage.ControlGroup(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("ControlGroup", actualOutput);
        //}
        //[Test]
        //public void VerifyCheckBoxRadio()
        //{
        //    WidgetPage.CheckBoxRadio(driver);

        //    var actualOutput = homePage.GetHeader(driver);
        //    Assert.AreEqual("CheckBoxRadio", actualOutput);
        //}


        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
