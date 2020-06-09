using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class DroppablePage
    {
        UIHelper.DroppablePage droppablePage;
        public DroppablePage()
        {
            droppablePage = new UIHelper.DroppablePage();
        }

        public string DroppableFromSideBar(IWebDriver driver)
        {
            new HomePage().DroppableSideBarButton(driver);
            Droppable(driver,droppablePage.PositionXpath, droppablePage.TargetXpath);
            return driver.FindElement(By.XPath(droppablePage.DroppedText)).Text;
        }
        public string DroppableFromHeader(IWebDriver driver)
        {
            Droppable(driver,droppablePage.PositionXpath, droppablePage.TargetXpath);
            return driver.FindElement(By.XPath(droppablePage.DroppedText)).Text;
        }
        public void Droppable(IWebDriver driver, string item, string target)
        {

            // find element which we need to drag
            var position = driver.FindElement(By.XPath(item));
            var targetPosition = driver.FindElement(By.XPath(target));
            // calling the method and x,y cordinates are random
            Actions action = new Actions(driver);
            action.DragAndDrop(position, targetPosition).Build().Perform();
        }


    }
}
