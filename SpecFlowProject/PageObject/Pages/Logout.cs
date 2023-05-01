using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.WebElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.PageObject.Pages
{
    public class Logout
    {
        public static void LogoutBugzilla()
        {
            LinkHelper.ClickOnLink(LogoutElement.logOut);
        }
    }
}
