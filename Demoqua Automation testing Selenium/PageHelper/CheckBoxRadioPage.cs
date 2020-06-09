using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class CheckBoxRadioPage
    {
        UIHelper.CheckBoxRadioPage checkBoxRadioPage;
        public CheckBoxRadioPage()
        {
            checkBoxRadioPage = new UIHelper.CheckBoxRadioPage();
        }
        public void CheckBoxRadioFromHeader(IWebDriver driver)
        {
            //new WidgetPage().CheckBoxRadio(driver);
        }
        public void CheckBoxRadioFromSideBar(IWebDriver driver)
        {
            new HomePage().CheckBoxRadioSideBarButton(driver);
        }
        public void RadioButton(IWebDriver driver, string button)
        {
            IWebElement checkBox=null;
            if (button == "Button 1")
                checkBox = driver.FindElement(By.XPath(checkBoxRadioPage.RadioButton1));
            if (button == "Button 2")
                checkBox = driver.FindElement(By.XPath(checkBoxRadioPage.RadioButton2));
            if (button == "Button 3")
                checkBox = driver.FindElement(By.XPath(checkBoxRadioPage.RadioButton3));
            Actions action = new Actions(driver);
            action.Click(checkBox).Perform();
        }
        public void Checkbox(IWebDriver driver, string button)
        {
            IWebElement checkBox = null;
            if (button == "Button 1")
                checkBox = driver.FindElement(By.XPath(checkBoxRadioPage.CheckBox1));
            if (button == "Button 2")
                checkBox = driver.FindElement(By.XPath(checkBoxRadioPage.CheckBox2));
            if (button == "Button 3")
                checkBox = driver.FindElement(By.XPath(checkBoxRadioPage.CheckBox3));
            if (button == "Button 4")
                checkBox = driver.FindElement(By.XPath(checkBoxRadioPage.CheckBox4));
            Actions action = new Actions(driver);
            action.Click(checkBox).Perform();
        }
        public string GetRadioButtonColour(IWebDriver driver, string button)
        {
            if(button=="Button 1")
                return GetButtonColour(driver, checkBoxRadioPage.RadioButton1);
            if(button=="Button 2")
                return GetButtonColour(driver, checkBoxRadioPage.RadioButton2);
            if (button == "Button 3")
                return GetButtonColour(driver, checkBoxRadioPage.RadioButton3);
            else
                return null;
        }
        public string GetCheckboxColour(IWebDriver driver, string button)
        {
            if (button == "Button 1")
                return GetButtonColour(driver, checkBoxRadioPage.CheckBox1);
            if (button == "Button 2")
                return GetButtonColour(driver, checkBoxRadioPage.CheckBox2);
            if (button == "Button 3")
                return GetButtonColour(driver, checkBoxRadioPage.CheckBox3);
            if (button == "Button 4")
                return GetButtonColour(driver, checkBoxRadioPage.CheckBox4);
            else
                return null;
        }
        private string GetButtonColour(IWebDriver driver, string button)
        {
            return driver.FindElement(By.XPath(button)).GetCssValue("background-color");
        }
    }
}
