using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowProject.Base;
using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.WebElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.PageObject.Pages
{
    public class DataDrivenExample
    {
        public static void Select_Data(string Serverity, string Hardware, string summary, string description)
        {
            DropDownHelper.SelectByValue(EnterBugDetailElements.SeverityDropDown, Serverity);
            DropDownHelper.SelectByValue(EnterBugDetailElements.HardwareDropDown, Hardware);
            TextBoxHelper.TypeInTextBox(EnterBugDetailElements.shortDescription, summary);
            TextBoxHelper.TypeInTextBox(EnterBugDetailElements.Description, description);
            ButtonHelper.ClickButton(EnterBugDetailElements.SubmitButton);

        }
    }
}
