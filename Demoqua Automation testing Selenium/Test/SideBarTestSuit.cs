using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.Test
{
    public class SideBarTestSuit
    {
        IWebDriver driver;
        PageHelper.HomePage homePage;
        public SideBarTestSuit()
        {
            driver = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod().GetDriver();
            homePage = new PageHelper.HomePage();
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Amazon page
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }


        [Test]
        public void VerifySideBarSortable()
        {
            homePage.SortableSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Sortable", actualOutput);
        }

        [Test]
        public void VerifySideBarSelectable()
        {
            homePage.SelectableSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Selectable", actualOutput);
        }

        [Test]
        public void VerifySideBarResizable()
        {
            homePage.ResizableSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Resizable", actualOutput);
        }

        [Test]
        public void VerifySideBarDroppable()
        {
            homePage.DroppableSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Droppable", actualOutput);
        }

        [Test]
        public void VerifySideBarDraggabble()
        {
            homePage.DraggableSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Draggable", actualOutput);
        }


        [Test]
        public void VerifySideBarAutomationPracticeSwitchWindows()
        {
            homePage.AutomationPracticeSwitchWindowsSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Automation Practice Switch Windows", actualOutput);
        }

        [Test]
        public void VerifySideBarAutomationPracticeTable()
        {
            homePage.AutomationPracticeTableSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Automation Practice Table", actualOutput);
        }

        [Test]
        public void VerifySideBarIFramePracticePage()
        {
            homePage.IFramePracticePageSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("IFrame Practice Page", actualOutput);
        }

        [Test]
        public void VerifySideBarAutomationPracticeForm()
        {
            homePage.AutomationPracticeFormSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Automation Practice Form", actualOutput);
        }

        [Test]
        public void VerifySideBarHTMLContactForm()
        {
            homePage.HTMLContactFormSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("HTML Contact Form", actualOutput);
        }

        [Test]
        public void VerifySideBarKeyBoardEvents()
        {
            homePage.KeyBoardEventsSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("KeyBoard Events", actualOutput);
        }

        [Test]
        public void VerifySideBarAutomationPracticeSwitchWindows2()
        {
            homePage.AutomationPracticeSwitchWindows2SideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Automation Practice Switch Windows", actualOutput);
        }

        [Test]
        public void VerifySideBarKeyBoardEventsSampleForm()
        {
            homePage.KeyBoardEventsSampleFormSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("KeyBoard Events Sample Form", actualOutput);
        }

        [Test]
        public void VerifySideBarTooltipAndDoubleClick()
        {
            homePage.TooltipAndDoubleClickSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Tooltip And Double Click", actualOutput);
        }

        [Test]
        public void VerifySideBarTooltip()
        {
            homePage.TooltipSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Tooltip", actualOutput);
        }

        [Test]
        public void VerifySideBarTabs()
        {
            homePage.TabsSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Tabs", actualOutput);
        }

        [Test]
        public void VerifySideBarSpinner()
        {
            homePage.SpinnerSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Spinner", actualOutput);
        }

        [Test]
        public void VerifySideBarSlider()
        {
            homePage.SliderSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Slider", actualOutput);
        }

        [Test]
        public void VerifySideBarSelectMenu()
        {
            homePage.SelectMenuSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("SelectMenu", actualOutput);
        }

        [Test]
        public void VerifySideBarProgressBar()
        {
            homePage.ProgressBarSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("ProgressBar", actualOutput);
        }

        [Test]
        public void VerifySideBarMenu()
        {
            homePage.MenuSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Menu", actualOutput);
        }

        [Test]
        public void VerifySideBarDialog()
        {
            homePage.DialogSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("Dialog", actualOutput);
        }

        [Test]
        public void VerifySideBarDatePicker()
        {
            homePage.DatePickerSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("DatePicker", actualOutput);
        }


        [Test]
        public void VerifySideBarControlGroup()
        {
            homePage.ControlGroupSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("ControlGroup", actualOutput);
        }
        [Test]
        public void VerifySideBarCheckBoxRadio()
        {
            homePage.CheckBoxRadioSideBarButton(driver);
            var actualOutput = homePage.GetHeader(driver);
            Assert.AreEqual("CheckBoxRadio", actualOutput);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
