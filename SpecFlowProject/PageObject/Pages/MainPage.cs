using OpenQA.Selenium;
using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.WebElement;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.PageObject.Pages
{
    public class MainPage
    {
        #region Actions
        public static void FileABug()
        {
            ButtonHelper.ClickButton(MainPageElements.FileABug);
        }

        #endregion

    }
}
