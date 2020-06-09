using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class HomePage
    {
        UIHelper.HomePage homePage;
        Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod method;
        public HomePage()
        {
            homePage = new UIHelper.HomePage();
            method = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod();
        }
        public string GetHeader(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(homePage.TitleXpath)).Text;
        }


        public void Elements(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.Elemets, "Xpath");
        }
        public void Forms(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.Forms, "Xpath");
        }
        public void AlertFrameAndWindows(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.AlertFrameAndWindows, "Xpath");
        }
        public void Widgets(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.Widgets, "Xpath");
        }
        public void Interactions(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.Interactions, "Xpath");
        }


        private void HeaderSelect(IWebDriver driver, string header, string headerType)
        {
            method.Click(driver, header, headerType);

        }


        public void HomeHeaderSelect(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.HomebuttonText, "Text");
        }

        public void InteractionHeaderSelect(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.InteractionButtonText, "Text");
        }

        public void WidgetHeaderSelect(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.WidgetButtonText, "Text");
        }

        public void ToolTipAndDoubleClickHeaderSelect(IWebDriver driver)
        {
            HeaderSelect(driver, homePage.InteractionButtonText, "Text");
        }


        public void SortableSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.SortableXpath);
        }
        public void SelectableSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.SelectableXpath);
        }
        public void ResizableSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.ResizableXpath);
        }
        public void DroppableSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.DroppableXpath);
        }
        public void DraggableSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.DraggableXpath);
        }
        public void AutomationPracticeSwitchWindowsSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.AutomationPracticeSwitchWindowsXpath);
        }
        public void AutomationPracticeTableSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.AutomationPracticeTableXpath);
        }
        public void IFramePracticePageSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.IFramePracticePageXpath);
        }
        public void AutomationPracticeFormSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.AutomationPracticeFormXpath);
        }
        public void HTMLContactFormSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.HTMLContactFormXpath);
        }
        public void KeyBoardEventsSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.KeyBoardEventsXpath);
        }
        public void AutomationPracticeSwitchWindows2SideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.AutomationPracticeSwitchWindows2Xpath);
        }
        public void KeyBoardEventsSampleFormSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.KeyBoardEventsSampleFormXpath);
        }
        public void TooltipAndDoubleClickSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.TooltipAndDoubleClickXpath);
        }
        public void TooltipSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.TooltipXpath);
        }
        public void TabsSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.TabsXpath);
        }
        public void SpinnerSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.SpinnerXpath);
        }
        public void SliderSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.SliderXpath);
        }
        public void SelectMenuSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.SelectMenuXpath);
        }
        public void ProgressBarSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.ProgressBarXpath);
        }
        public void MenuSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.MenuXpath);
        }
        public void DialogSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.DialogXpath);
        }
        public void DatePickerSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.DatePickerXpath);
        }
        public void ControlGroupSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.ControlGroupXpath);
        }
        public void CheckBoxRadioSideBarButton(IWebDriver driver)
        {
            SideBarButton(driver, homePage.CheckBoxRadioXpath);
        }

        private void SideBarButton(IWebDriver driver, string sideBarButton)
        {
            method.Click(driver, sideBarButton, "Xpath");
        }
    }
}
