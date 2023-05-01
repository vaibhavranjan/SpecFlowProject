using OpenQA.Selenium;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class TextBoxHelper
    {
        public static void TypeInTextBox(By locator, string textToEnter)
        {
            ClearTextBox(locator);
            GenericHelper.GetElement(locator).SendKeys(textToEnter);
        }

        public static void ClearTextBox(By locator)
        {
            GenericHelper.GetElement(locator).Clear();
        }
    }
}
