using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.UIHelper
{
    public class SearchPage
    {
        public string FirstProductNameInResultXpath = "//*[@id=\"search\"]/div[1]/div[1]/div/span[4]/div[2]/div[2]/div/span/div/div/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/h2/a/span";
        public string FeatureButtonXpath = "//*[@id=\"a-autoid-0-announce\"]";
        public string FilterSelectedXpath = "//*[@id=\"a-autoid-0-announce\"]/span[2]";
        public string ProductNameXpath = "//*[@id=\"search\"]/span/div/span/h1/div/div[1]/div/div/span[3]";
    }
}
