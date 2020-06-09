using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class TooltipPage
    {
        UIHelper.ToolTipPage toolTipPage;
        public TooltipPage()
        {
            toolTipPage = new UIHelper.ToolTipPage();
        }
        public string TooltipFromHeader(IWebDriver driver)
        {
            //new WidgetPage().Tooltip(driver);
            return Tooltip(driver);
        }
        public string TooltipFromSideBar(IWebDriver driver)
        {
            new HomePage().TooltipSideBarButton(driver);
            return Tooltip(driver);
        }
        private string Tooltip(IWebDriver driver)
        {
            var textBox = driver.FindElement(By.XPath(toolTipPage.TextBoxXpath));
            Actions action = new Actions(driver);
            action.MoveToElement(textBox).Build().Perform();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //string tooltipText = driver.FindElement(By.Id("age")).GetAttribute("title");
            String tooltipText = driver.FindElement(By.CssSelector(".ui-tooltip")).GetAttribute("title");
            return tooltipText;
        }
    }
}
