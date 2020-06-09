using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_Automation_testing_Selenium.UIHelper
{
    public class LoginPage
    {
        public string EmailTextBoxXpath = "//*[@id=\"ap_email\"]";
        public string EmailContinueId = "continue";
        public string PasswordTextBoxId = "ap_password";
        public string PasswordSubmitId = "signInSubmit";
        public string PasswordTextXpath = "//*[@id=\"authportal-main-section\"]/div[2]/div[1]/div/div/form/div/div[1]/div[1]/div[1]/label";

    }
}
