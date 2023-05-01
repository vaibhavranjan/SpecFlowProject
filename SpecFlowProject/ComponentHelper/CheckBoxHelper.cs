using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class CheckBoxHelper
    {
        public static void SelectCheckBox(By locator)
        {
            if(IsCheckBoxSelected(locator) == false)
            {
                GenericHelper.GetElement(locator).Click();
            }
            
        }

        //This method checks if element is selected or not and returns boolean value

        public static bool IsCheckBoxSelected(By locator)
        {
            return GenericHelper.GetElement(locator).Selected;
        }


        //This method return the value of "checked" attribute in string format for a checkbox element
        public static string GetCheckedAttributeValue(By locator)
        {
           return GenericHelper.GetElement(locator).GetAttribute("checked");
        }
    }
}
