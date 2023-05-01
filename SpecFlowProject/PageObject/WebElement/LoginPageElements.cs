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
    public class LoginPageElements
    {
        #region WebElement


        //PageFactory is not working with selenium driver 4.8.2 throwing Could not load type 'OpenQA.Selenium.Internal.IWrapsElement' from assembly 'WebDriver, Version=4.0.0.0
        //Either use findelement method of driver or use DotNetSeleniumExtras.PageObjects.Core Nuget package

        //[FindsBy(How = How.Id, Using = "Bugzilla_login")]
        //public static IWebElement username;

        //[FindsBy(How = How.Id, Using = "Bugzilla_password")]
        //public static IWebElement password;

        //[FindsBy(How = How.Id, Using = "log_in")]
        //public static IWebElement LoginButton;

        public static By username = By.Id("Bugzilla_login");
        public static By password = By.Id("Bugzilla_password");
        public static By LoginButton = By.Id("log_in");        

        #endregion

        //public LoginPageElements()
        //{
        //    PageFactory.InitElements(ObjectRepository.driver, this);
        //}
    }
}
