using OpenQA.Selenium;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class GenericHelper
    {
        public static IWebElement GetElement(By locator)
        {
            try
            {
                if (isElementPresent(locator) == true)
                {
                    return ObjectRepository.driver.FindElement(locator);
                }
                else
                {
                    throw new NoSuchElementException("Element is not present" + locator);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            
        }

        public static bool isElementDisplayed(By locator)
        {
            return ObjectRepository.driver.FindElement(locator).Displayed;
        }

        private static bool isElementPresent(By locator)
        {
            return ObjectRepository.driver.FindElements(locator).Count == 1;
        }

        public static string GetPageTitle()
        {
            return ObjectRepository.driver.Title;
        }
    }
}
