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
    public class InteractionPage
    {
        UIHelper.InteractionPage interaction;
        Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod method;
        public InteractionPage()
        {
            interaction = new UIHelper.InteractionPage();
            method = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod();
        }

        public void Sortable(IWebDriver driver)
        {
            new HomePage().Interactions(driver);
            Scroll(driver, interaction.SortableXpath);
            method.Click(driver, interaction.SortableXpath, "Xpath");
        }
        public void Selectable(IWebDriver driver)
        {
            new HomePage().Interactions(driver);
            Scroll(driver, interaction.SelectableXpath);
            method.Click(driver, interaction.SelectableXpath, "Xpath");
        }

        public void Resizable(IWebDriver driver)
        {
            new HomePage().Interactions(driver);
            Scroll(driver, interaction.ResizableXpath);
            method.Click(driver, interaction.ResizableXpath, "Xpath");
        }
        public void Droppable(IWebDriver driver)
        {
            new HomePage().Interactions(driver);
            Scroll(driver, interaction.DroppableXpath);
            method.Click(driver, interaction.DroppableXpath, "Xpath");
        }
        public void Dragabble(IWebDriver driver)
        {
            new HomePage().Interactions(driver);
            Scroll(driver, interaction.DragabbleXpath);
            method.Click(driver, interaction.DragabbleXpath, "Xpath");
        }
        private void Scroll(IWebDriver driver, string elementXpath)
        {
            //scroll until view the element
            var element = driver.FindElement(By.XPath(elementXpath));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
        }



        //public void Selectable(IWebDriver driver)
        //{
        //    new HomePage().InteractionHeaderSelect(driver);
        //    method.Click(driver,interaction.SelectableXpath, "Xpath");
        //}

        //public void Resizable(IWebDriver driver)
        //{
        //    new HomePage().InteractionHeaderSelect(driver);
        //    method.Click(driver,interaction.ResizableXpath, "Xpath");
        //}
        //public void Droppable(IWebDriver driver)
        //{
        //    new HomePage().InteractionHeaderSelect(driver);
        //    method.Click(driver,interaction.DroppableXpath, "Xpath");
        //}
        //public void Draggable(IWebDriver driver)
        //{
        //    new HomePage().InteractionHeaderSelect(driver);
        //    method.Click(driver,interaction.DraggableXpath, "Xpath");
        //}
    }
}
