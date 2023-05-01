using OpenQA.Selenium;
using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.WebElement;

namespace SpecFlowProject.PageObject.Pages
{
    public class EnterBugDetails
    {       

        private static string detiledDescription = "Description is the pattern of narrative development that aims to make vivid a place, object, character, or group. Description is one of four rhetorical modes, along with exposition, argumentation, and narration. In practice it would be difficult to write literature that drew on just one of the four basic modes";

        public static void EnterABug()
        {
            DropDownHelper.SelectByText(EnterBugDetailElements.SeverityDropDown, "trivial");
            DropDownHelper.SelectByValue(EnterBugDetailElements.HardwareDropDown, "Macintosh");
            TextBoxHelper.TypeInTextBox(EnterBugDetailElements.shortDescription, "Summary");
            TextBoxHelper.TypeInTextBox(EnterBugDetailElements.Description, detiledDescription);
        }
    }
}