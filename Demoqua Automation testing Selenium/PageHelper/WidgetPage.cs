using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class WidgetPage
    {
        //public string Wiget = new UIHelper.HomePage().WidgetButtonText;
        UIHelper.WidgetPage widget;
        Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod method;
        public WidgetPage()
        {
            widget = new UIHelper.WidgetPage();
            method = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod();

        }

        public void Accordian(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.Accordian);
            method.Click(driver, widget.Accordian, "Xpath");
        }
        public void AutoComplete(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.AutoComplete);
            method.Click(driver, widget.AutoComplete, "Xpath");
        }
        public void DatePicker(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.DatePicker);
            method.Click(driver, widget.DatePicker, "Xpath");
        }
        public void Slider(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.Slider);
            method.Click(driver, widget.Slider, "Xpath");
        }
        public void ProgressBar(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.ProgressBar);
            method.Click(driver, widget.ProgressBar, "Xpath");
        }
        public void Tabs(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.Tabs);
            method.Click(driver, widget.Tabs, "Xpath");
        }
        public void ToolTips(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.ToolTips);
            method.Click(driver, widget.ToolTips, "Xpath");
        }
        public void Menu(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.Menu);
            method.Click(driver, widget.Menu, "Xpath");
        }
        public void SelectMenu(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Scroll(driver, widget.SelectMenu);
            method.Click(driver, widget.SelectMenu, "Xpath");
        }




        private void Scroll(IWebDriver driver, string elementXpath)
        {
            //scroll until view the element
            var element = driver.FindElement(By.XPath(elementXpath));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
        }

        //public void Slider(IWebDriver driver)
        //{
        //    new HomePage().Widgets(driver);
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    method.Click(driver, widget.SliderXpath, "Xpath");
        //}

        //public void AutomationPracticeForm(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.AutomationPracticeFormXpath, "Xpath");
        //}
        //public void AutomationPracticeSwitchWindows2(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.AutomationPracticeSwitchWindows2Xpath, "Xpath");
        //}
        //public void AutomationPracticeSwitchWindows(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.AutomationPracticeSwitchWindowsXpath, "Xpath");
        //}
        //public void AutomationPracticeTable(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.AutomationPracticeTableXpath, "Xpath");
        //}
        //public void CheckBoxRadio(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.CheckBoxRadioXpath, "Xpath");
        //}
        //public void ControlGroup(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.ControlGroupXpath, "Xpath");
        //}
        //public void DatePicker(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.DatePickerXpath, "Xpath");
        //}
        //public void Dialog(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver, widget.DialogXpath, "Xpath");
        //}
        //public void HTMLContactForm(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.HTMLContactFormXpath, "Xpath");
        //}
        //public void IFramePracticePage(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.IFramePracticePageXpath, "Xpath");
        //}
        //public void KeyBoardEventsSampleForm(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.KeyBoardEventsSampleFormXpath, "Xpath");
        //}
        //public void KeyBoardEvents(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.KeyBoardEventsXpath, "Xpath");
        //}
        //public void Menu(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.MenuXpath, "Xpath");
        //}
        //public void ProgressBar(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.ProgressBarXpath, "Xpath");
        //}
        //public void SelectMenu(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.SelectMenuXpath, "Xpath");
        //}
        ////public void Slider(IWebDriver driver)
        ////{
        ////    new HomePage().WidgetHeaderSelect(driver);
        ////    method.Click(driver,widget.SliderXpath, "Xpath");
        ////}
        //public void Spinner(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.SpinnerXpath, "Xpath");
        //}
        //public void Tabs(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.TabsXpath, "Xpath");
        //}
        //public void TooltipAndDoubleClick(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.TooltipAndDoubleClickXpath, "Xpath");
        //}
        //public void Tooltip(IWebDriver driver)
        //{
        //    new HomePage().WidgetHeaderSelect(driver);
        //    method.Click(driver,widget.TooltipXpath, "Xpath");
        //}

    }
}
