using OpenQA.Selenium;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class LinkHelper
    {
        public static void ClickOnLink(By locator)
        {
            ObjectRepository.driver.FindElement(locator).Click();
        }

        public static void Click_LinkText(string linkText)
        {
            ObjectRepository.driver.FindElement(By.LinkText(linkText)).Click();
        }

        public static void Click_PartialLinkText(string partiallinkText)
        {
            ObjectRepository.driver.FindElement(By.LinkText(partiallinkText)).Click();
        }
    }
}
