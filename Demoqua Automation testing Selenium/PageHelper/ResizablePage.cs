using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class ResizablePage
    {
        UIHelper.ResizablePage resizablePage;
        public ResizablePage()
        {
            resizablePage = new UIHelper.ResizablePage();
        }

        public void ResizableFromHeader(IWebDriver driver)
        {
            new InteractionPage().Resizable(driver);
            Resizable(driver,resizablePage.ResizePointXpath);
        }
        public void ResizableFromSideBar(IWebDriver driver)
        {
            new HomePage().ResizableSideBarButton(driver);
            Resizable(driver,resizablePage.ResizePointXpath);
        }
        private void Resizable(IWebDriver driver, string resizeObjectXpath)
        {
            var resizeObject = driver.FindElement(By.XPath(resizeObjectXpath));
            Actions action = new Actions(driver);
            action.ClickAndHold(resizeObject).MoveByOffset(250, 150).Release(resizeObject).Build().Perform();
        }
        public string Position(IWebDriver driver)
        {
            var element = driver.FindElement(By.XPath(resizablePage.ResizePointXpath));
            return (element.Location.ToString());
        }

    }
}
