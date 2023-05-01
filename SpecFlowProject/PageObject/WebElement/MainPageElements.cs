using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.PageObject.WebElement
{
    public class MainPageElements
    {
        #region WebElements
        //[FindsBy(How = How.XPath, Using = "//input[@value='Quick Search']")]
        //public static IWebElement QuickSearchButton;

        //[FindsBy(How = How.Id, Using = "quicksearch_main")]
        //public static IWebElement QuickSearchTextBox;

        //[FindsBy(How = How.LinkText, Using = "File a Bug")]
        //public static IWebElement FileABug;

        public By QuickSearchButton = By.XPath("//input[@value='Quick Search']");
        public By QuickSearchTextBox = By.Id("quicksearch_main");
        public static By FileABug = By.LinkText("File a Bug");
        #endregion

        //public MainPageElements()
        //{
        //    //this keyword refers to current class object
        //    PageFactory.InitElements(ObjectRepository.driver, this);
        //}


    }
}
