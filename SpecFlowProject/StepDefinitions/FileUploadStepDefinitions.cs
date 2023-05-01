using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.WebElement;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class FileUploadStepDefinitions
    {
        [When(@"clicked on Add attachment")]
        public void WhenClickedOnAddAttachment()
        {
            GenericHelper.GetElement(EnterBugDetailElements.AddAttachment).Click();
        }

        [When(@"upload a file")]
        public void WhenUploadAFile()
        {
            GenericHelper.GetElement(EnterBugDetailElements.chooseFile).SendKeys(@"D:\Work\Training\Selenium\FilesToUpload\Xpath.docx");
        }
    }
}
