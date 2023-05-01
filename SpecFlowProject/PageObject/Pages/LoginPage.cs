using OpenQA.Selenium;
using SpecFlowProject.Base;
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
    public class LoginPage
    {       
       
        #region Actions

        public static void LoginToBugzilla()
        {
            //GetElement method requires a locator to be passed whereas PageFactory gives the element itself. Hence above changes ahs been made.
            GenericHelper.GetElement(LoginPageElements.username).SendKeys(ObjectRepository.config.GetUsername());
            GenericHelper.GetElement(LoginPageElements.password).SendKeys(ObjectRepository.config.GetPassword());
            ButtonHelper.ClickButton(LoginPageElements.LoginButton);
        }
        #endregion
    }
}
