using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.PageObject.WebElement
{
    public class EnterBugDetailElements
    {
        public static By SeverityDropDown = By.Id("bug_severity");
        public static By HardwareDropDown = By.Id("rep_platform");
        public static By shortDescription = By.Id("short_desc");
        public static By Description = By.Id("comment");
        public static By SubmitButton = By.Id("commit");
        public static By AddAttachment = By.XPath("//input[contains(@value,'Add an attachment')]");
        public static By chooseFile = By.XPath("//input[@id='data']");
        public static By fileDescription = By.XPath("//input[@id='description']");
        public static By HomePageLink = By.XPath("(//div[@id='header']//a)[1]");
        public static By isBugSubmitted = By.XPath("//*[@id=\"title\"]/p[contains(text(),'Submitted')]");
        //
    }
}
