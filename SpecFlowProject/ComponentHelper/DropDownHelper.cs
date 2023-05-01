using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject.Settings;

namespace SpecFlowProject.ComponentHelper
{
    public class DropDownHelper
    {
        public static void SelectByIndex(By locator, int index)
        {
            SelectElement selectElement = new SelectElement(GenericHelper.GetElement(locator));
            selectElement.SelectByIndex(index);
        }

        public static void SelectByValue(By locator, string value)
        {
            SelectElement selectElement = new SelectElement(GenericHelper.GetElement(locator));
            selectElement.SelectByValue(value);
        }

        public static void SelectByText(By locator, string text)
        {
            SelectElement selectElement = new SelectElement(GenericHelper.GetElement(locator));
            selectElement.SelectByText(text);
        }
    }
}
