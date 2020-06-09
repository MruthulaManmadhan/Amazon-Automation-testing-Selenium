using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.GenericHelper
{
    public class SeleniumSetMethod
    {        //enter text

        public IWebDriver GetDriver()
        {
            return new ChromeDriver();
            //return new EdgeDriver();
            //return new InternetExplorerDriver();
            //return new FirefoxDriver();
        }
        public void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            //var driver = driver()
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == "Xpath")
                driver.FindElement(By.XPath(element)).SendKeys(value);
            if (elementType == "Text")
                driver.FindElement(By.LinkText(element)).SendKeys(value);
        }
        //click in button
        public void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (elementType == "Xpath")
                driver.FindElement(By.XPath(element)).Click();
            if(elementType=="Text")
                driver.FindElement(By.LinkText(element)).Click();
        }
        //Select dropdown
        public void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementType == "Xpath")
                new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);
            if (elementType == "Text")
                new SelectElement(driver.FindElement(By.LinkText(element))).SelectByText(value);
        }

        //Mouse hover
        public void Mousehover(IWebDriver driver, string element, string elementType)
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //var elementTo = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
            IWebElement elementTo=null;
            if (elementType == "Id")
            {
                elementTo = driver.FindElement(By.Id(element));
            }
            if (elementType == "Name")
            {
                elementTo = driver.FindElement(By.Name(element));
            }
            if (elementType == "Xpath")
            {
                elementTo = driver.FindElement(By.XPath(element));
            }
            if (elementType == "Text")
            {
                elementTo = driver.FindElement(By.LinkText(element));
            }
            Actions action = new Actions(driver);
            action.MoveToElement(elementTo).Perform();

        }
    }
}