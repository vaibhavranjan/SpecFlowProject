using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.PageObject.WebElement
{
    public class LogoutElement
    {
        public static By logOut = By.XPath("//a[@href='index.cgi?logout=1']");
    }
}
