using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.UIHelper
{
    public class HomePage
    {
        public string AccountsAndListsXpath = "//*[@id=\"nav-link-accountList\"]";
        public string SignOutXpath = "//*[@id=\"nav-item-signout\"]";
        public string HelloName = "//*[@id=\"nav-link-accountList\"]/span[1]";
        public string SearchTextBox = "//*[@id=\"twotabsearchtextbox\"]";
        public string SearchButton = "//span[@id='nav-search-submit-text']/../input";
    }
}
