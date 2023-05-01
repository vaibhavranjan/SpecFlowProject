using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class RadioButton
    {
        public static void Select(By locator)
        {
            GenericHelper.GetElement(locator).Click();
        }
        public static bool IsSelected(By locator)
        {
            return GenericHelper.GetElement(locator).Selected;
        }
    }
}
