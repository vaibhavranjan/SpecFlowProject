using OpenQA.Selenium;
using SpecFlowProject.ComponentHelper;
using SpecFlowProject.PageObject.WebElement;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProject.PageObject.Pages
{
    public class FileUpload
    {
        public static void UploadFiles()
        {
            NavigationHelper.LoadWebSite();
            MainPage.FileABug();
            LoginPage.LoginToBugzilla();
            EnterBugDetails.EnterABug();
            GenericHelper.GetElement(EnterBugDetailElements.AddAttachment).Click();
            GenericHelper.GetElement(EnterBugDetailElements.chooseFile).SendKeys(@"D:\Work\Training\Selenium\FilesToUpload\Xpath.docx");
            Thread.Sleep(5000);
            GenericHelper.GetElement(EnterBugDetailElements.Description).SendKeys("Description 1");
            ButtonHelper.ClickButton(EnterBugDetailElements.SubmitButton);
            
            
            #region AutoIt
            //Install AutoIt exe on your machine and write the script to upload the file
            // file path - "D:\Work\Training\Selenium\AutoIt\FileUpload.au3"
            // Build the script in order to generate the executable file
            //Create a process object and set the filename and argumnet properties/field
            //ProcessStartInfo processInfo = new ProcessStartInfo();
            //processInfo.FileName = @"D:\Work\Training\Selenium\AutoIt\FileUpload.exe";
            //processInfo.Arguments = @"D:\Work\Training\Selenium\FilesToUpload\Xpath.docx";
            //Below lines 35- 39 does the same job as 30-32, here Using object initializer, properties are initialized
            //var processInfo = new ProcessStartInfo()
            //{
            //    FileName = @"D:\Work\Training\Selenium\AutoIt\FileUpload.exe",
            //    Arguments = @"D:\Work\Training\Selenium\FilesToUpload\Xpath.docx"
            //};
            //This will start the execution of exe file and wait until it completes.
            //var process = Process.Start(processInfo);
            //process.WaitForExit();
            //process.Close();
            //If we are using - using clause we dont need to explicitly close the process.
            //using (var process = Process.Start(processInfo))
            //{
            //    process.WaitForExit();
            //}
            #endregion





        }
    }
}
