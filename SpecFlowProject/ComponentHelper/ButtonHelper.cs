using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class ButtonHelper
    {
        public static void ClickButton(By locator)
        {
            if (IsButtonEnabled(locator))
                GenericHelper.GetElement(locator).Click();
        }

        public static bool IsButtonEnabled(By locator)
        {
            return GenericHelper.GetElement(locator).Enabled;
        }
    }
}
