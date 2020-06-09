using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqua_Automation_testing_Selenium.UIHelper
{
    public class DroppablePage
    {
        public string PositionXpath = "//*[@id=\"draggable\"]/p";
        public string TargetXpath = "//*[@id=\"droppable\"]";
        public string DroppedText = "//*[@id=\"droppable\"]/p";
    }
}
