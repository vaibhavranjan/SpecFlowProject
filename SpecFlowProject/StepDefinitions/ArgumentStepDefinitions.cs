using OpenQA.Selenium;
using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.Pages;
using SpecFlowProject.PageObject.WebElement;
using SpecFlowProject.Settings;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class ArgumentStepDefinitions
    {

        #region Given
        [Given(@"I am on main page of google with ""([^""]*)""")]
        public void GivenIAmOnMainPageOfGoogleWith(string url)
        {
            //ObjectRepository.driver.Navigate().GoToUrl(url);
            ObjectRepository.driver.Navigate().GoToUrl(url);
        }

        #endregion

        #region When
        [When(@"I click on file a bug")]
        public void WhenIClickOnFileABug()
        {
            MainPage.FileABug();
        }

        [When(@"User click submit")]
        public void WhenUserClickSubmit()
        {
            ButtonHelper.ClickButton(EnterBugDetailElements.SubmitButton);
        }


        [When(@"user Provide ""([^""]*)"", ""([^""]*)"",  ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserProvideAnd(string severity, string hardware, string summary, string description)
        {
            throw new PendingStepException();
        }

        [When(@"User click on ""([^""]*)"" link")]
        public void WhenUserClickOnLink(string fileabug)
        {
            NavigationHelper.LoadWebSite();

            //Finding element using given link text and clicking on it
            //ObjectRepository.driver.FindElement(By.LinkText("File a Bug")).Click();

            //finding element using helper method LinkHelper.Click_LinkText and passing the linktext as string
           // LinkHelper.Click_LinkText("File a Bug");

            //finding element using helper method LinkHelper.Click_LinkText and passing the linktext as reference variable, which is coming from specflow feature file
            LinkHelper.Click_LinkText(fileabug);
        }

        [When(@"user supply ""([^""]*)"" , ""([^""]*)"" and click on login")]
        public void WhenUserSupplyAndClickOnLogin(string username, string password)
        {
            TextBoxHelper.TypeInTextBox(LoginPageElements.username, username);
            TextBoxHelper.TypeInTextBox(LoginPageElements.password, password);
            ButtonHelper.ClickButton(LoginPageElements.LoginButton);
        }

        [When(@"user Provide severity, hardware,  summary and description")]
        public void WhenUserProvideSeverityHardwareSummaryAndDescription(Table table)
        {
            foreach (var row in table.Rows)
            {
                DropDownHelper.SelectByText(EnterBugDetailElements.SeverityDropDown, row["Severity"]);
                DropDownHelper.SelectByText(EnterBugDetailElements.HardwareDropDown, row["Hardware"]);
                TextBoxHelper.TypeInTextBox(EnterBugDetailElements.shortDescription, row["Summary"]);
                TextBoxHelper.TypeInTextBox(EnterBugDetailElements.Description, row["Description"]);
            }
        }

        //[When(@"user Provides ""([^""]*)"", ""([^""]*)"",  ""([^""]*)"" and ""([^""]*)""")]
        //public void WhenUserProvidesAnd(string severity, string hardware, string summary, string description)
        //{
        //    DropDownHelper.SelectByText(EnterBugDetailElements.SeverityDropDown, severity);
        //    DropDownHelper.SelectByText(EnterBugDetailElements.HardwareDropDown, hardware);
        //    TextBoxHelper.TypeInTextBox(EnterBugDetailElements.shortDescription, summary);
        //    TextBoxHelper.TypeInTextBox(EnterBugDetailElements.Description, description);
        //}


        [When(@"you click ""([^""]*)""")]
        public void WhenYouClick(string flink)
        {
            NavigationHelper.LoadWebSite();
            LinkHelper.Click_LinkText(flink);
        }

        [When(@"you enter ""([^""]*)"", ""([^""]*)"" and click login")]
        public void WhenYouEnterAndClickLogin(string username, string password)
        {
            TextBoxHelper.TypeInTextBox(LoginPageElements.username, username);
            TextBoxHelper.TypeInTextBox(LoginPageElements.password, password);
            ButtonHelper.ClickButton(LoginPageElements.LoginButton);
        }

        [Then(@"you should be on enter a bug page")]
        public void ThenYouShouldBeOnEnterABugPage()
        {
            string expected_Title = "Enter Bug: TestProduct";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title);
        }

        [When(@"you enter details ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)""")]
        public void WhenYouEnterDetails(string severity, string hardware, string summary, string description)
        {
            DropDownHelper.SelectByText(EnterBugDetailElements.SeverityDropDown, severity);
            DropDownHelper.SelectByText(EnterBugDetailElements.HardwareDropDown, hardware);
            TextBoxHelper.TypeInTextBox(EnterBugDetailElements.shortDescription, summary);
            TextBoxHelper.TypeInTextBox(EnterBugDetailElements.Description, description);
        }


        [When(@"Click on submit bug")]
        public void WhenClickOnSubmitBug()
        {
            ButtonHelper.ClickButton(EnterBugDetailElements.SubmitButton);
        }


        #endregion

        #region Then
        [Then(@"I should be navigated to login page")]
        public void ThenIShouldBeNavigatedToLoginPage()
        {
            string expected_Title = "Log in to Bugzilla";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title);
        }


        [Then(@"User should be navigated to login page")]
        public void ThenUserShouldBeNavigatedToLoginPage()
        {
            string expected_Title = "Log in to Bugzilla";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title);
        }

        [Then(@"user should be logged in")]
        public void ThenUserShouldBeLoggedIn()
        {
            string expected_Title = "Enter Bug: TestProduct";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title);
        }
        #endregion

        #region And
        #endregion

    }
}
