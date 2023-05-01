using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.Pages;
using SpecFlowProject.PageObject.WebElement;
using SpecFlowProject.Settings;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions
    {
        [Given(@"I am on HP")]
        public void GivenIAmOnHP()
        {
            NavigationHelper.LoadWebSite();
        }

        [When(@"I click file bug")]
        public void WhenIClickFileBug()
        {
            MainPage.FileABug();
        }

        [Then(@"I am at LP")]
        public void ThenIAmAtLP()
        {
            string expected_Title = "Log in to Bugzilla";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title);
        }

        [When(@"I enter username, pass and click on login")]
        public void WhenIEnterUsernamePassAndClickOnLogin()
        {
            TextBoxHelper.TypeInTextBox(LoginPageElements.username,ObjectRepository.config.GetUsername());
            TextBoxHelper.TypeInTextBox(LoginPageElements.password, ObjectRepository.config.GetPassword());
            ButtonHelper.ClickButton(LoginPageElements.LoginButton);
        }

        [Then(@"login should be successful")]
        public void ThenLoginShouldBeSuccessful()
        {
            string expected_Title = "Enter Bug: TestProduct";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title);
        }

        [When(@"I click Home page link")]
        public void WhenIClickHomePageLink()
        {
            LinkHelper.ClickOnLink(EnterBugDetailElements.HomePageLink);
        }

        [Then(@"I should be navigated to HP")]
        public void ThenIShouldBeNavigatedToHP()
        {
            string expected_Title = "Welcome to Bugzilla";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title );
        }

        [When(@"I enter summary and click submit button")]
        public void WhenIEnterSummaryAndClickSubmitButton()
        {
            TextBoxHelper.TypeInTextBox(EnterBugDetailElements.shortDescription, "summary 1");
            ButtonHelper.ClickButton(EnterBugDetailElements.SubmitButton);
        }

        [Then(@"Bug should be created")]
        public void ThenBugShouldBeCreated()
        {
            Assert.IsTrue(GenericHelper.isElementDisplayed(EnterBugDetailElements.isBugSubmitted));
        }

        [When(@"I Click logout")]
        public void WhenIClickLogout()
        {
            Logout.LogoutBugzilla();
        }

        [Then(@"Logout happens")]
        public void ThenLogoutHappens()
        {
            string expected_Title = "Logged Out";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title);
        }

    }
}
