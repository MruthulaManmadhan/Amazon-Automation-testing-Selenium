using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.PageHelper
{
    public class FormsPage
    {
        UIHelper.FormsPage formsPage;
        Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod method;

        public FormsPage()
        {
            formsPage = new UIHelper.FormsPage();
            method = new Amazon_Automation_testing_Selenium.GenericHelper.SeleniumSetMethod();
        }
        public void PracticeForm(IWebDriver driver)
        {
            new HomePage().Forms(driver);
            method.Click(driver, formsPage.PracticeFormsXpath, "Xpath");
        }
    }
}
