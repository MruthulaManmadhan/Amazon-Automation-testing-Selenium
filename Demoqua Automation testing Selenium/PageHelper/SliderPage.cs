using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class SliderPage
    {
        UIHelper.SliderPage sliderPage;
        //public string sliderHandle = new UIHelper.SliderPage().SliderHandle;
        public SliderPage()
        {
            sliderPage = new UIHelper.SliderPage();
        }

        public void Slider(IWebDriver driver)
        {
            new HomePage().Widgets(driver);
            Slide(driver);
        }


        public void SliderFromHeader(IWebDriver driver)
        {
            new WidgetPage().Slider(driver);
            Slide(driver);
        }
        public void SliderFromSideBar(IWebDriver driver)
        {
            new HomePage().SliderSideBarButton(driver);
            Slide(driver);
        }
        private void Slide(IWebDriver driver)
        {
            var position = driver.FindElement(By.XPath(sliderPage.SliderHandle));
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(position, 250, 150).Build().Perform();
        }
        public string Position(IWebDriver driver)
        {
            var element = driver.FindElement(By.XPath(sliderPage.SliderHandle));
            return (element.Location.ToString());
        }
    }
}
