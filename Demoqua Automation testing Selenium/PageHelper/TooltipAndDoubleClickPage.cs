using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class TooltipAndDoubleClickPage
    {
        UIHelper.TooltipAndDoubleClickPage tooltipAndDoubleClickPage;
        public TooltipAndDoubleClickPage()
        {
            tooltipAndDoubleClickPage = new UIHelper.TooltipAndDoubleClickPage();
        }

        public void DoubleClickFromHeader(IWebDriver driver)
        {
            //new WidgetPage().TooltipAndDoubleClick(driver);
            DoubleClick(driver);
        }
        public void DoubleClickThroughSideBar(IWebDriver driver)
        {
            new HomePage().TooltipAndDoubleClickSideBarButton(driver);
            DoubleClick(driver);
        }
        private void DoubleClick(IWebDriver driver)
        {
            var button = driver.FindElement(By.XPath(tooltipAndDoubleClickPage.DoubliClickButtonXpath));
            Actions action = new Actions(driver);
            action.DoubleClick(button).Perform();
        }
        public void RightClickFromHeader(IWebDriver driver)
        {
            //new WidgetPage().TooltipAndDoubleClick(driver);
            RightClick(driver);
        }

        public void RightClickThroughSideBar(IWebDriver driver)
        {
            new HomePage().TooltipAndDoubleClickSideBarButton(driver);
            RightClick(driver);
        }
        public void RightClick(IWebDriver driver)
        {
            var button = driver.FindElement(By.XPath(tooltipAndDoubleClickPage.RightClickXpath));
            Actions action = new Actions(driver);
            action.ContextClick(button).Perform();
            driver.FindElement(By.XPath(tooltipAndDoubleClickPage.FavouritesXpath)).Click();
        }
    }
}
