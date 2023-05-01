using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class MainPageStepDefinitions
    {
        [Given(@"I am at MainPage")]
        public void GivenIAmAtMainPage()
        {
            NavigationHelper.LoadWebSite();
        }


        [When(@"I click file a bug link")]
        public void WhenIClickFileABugLink()
        {
            MainPage.FileABug();
        }

        [Then(@"Login page should display")]
        public void ThenLoginPageShouldDisplay()
        {
            string expected_Title = "Log in to Bugzilla";
            string actual_Title = GenericHelper.GetPageTitle();
            Assert.AreEqual(expected_Title, actual_Title);
        }
    }
}
