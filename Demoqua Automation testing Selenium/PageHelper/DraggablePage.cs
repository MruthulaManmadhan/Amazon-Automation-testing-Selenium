using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class DraggablePage
    {
        UIHelper.DraggablePage draggablePage;
        public DraggablePage()
        {
            draggablePage = new UIHelper.DraggablePage();
        }

        public string DragabbleFromHeader(IWebDriver driver)
        {
            new InteractionPage().Dragabble(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string position = Position(driver);
            Draggable(driver);
            return position;
        }
        public string DraggableFromSideBar(IWebDriver driver)
        {
            new HomePage().DraggableSideBarButton(driver);
            string position = Position(driver);
            Draggable(driver);
            return position;
        }
        public void Draggable(IWebDriver driver)
        {
            // find element which we need to drag
            var position = driver.FindElement(By.XPath(draggablePage.DragElement));

            // calling the method and x,y cordinates are random
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(position, 250, 150).Build().Perform();
        }
        public string Position(IWebDriver driver)
        {
            var element = driver.FindElement(By.XPath(draggablePage.DragElement));
            return (element.Location.ToString());
        }
    }
}
