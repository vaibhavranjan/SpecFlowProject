using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SpecFlowProject.Settings
{
    public class TakeScrrenShots
    {
        public static void Take_ScreenShot()
        {
            //string dateTime= DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss");
            string imagename = "screenshot";

            //Screenshot image = ObjectRepository.driver.TakeScreenshot();
            //image.SaveAsFile(imagename);


            ((ITakesScreenshot)ObjectRepository.driver).GetScreenshot().SaveAsFile(imagename + ".png", ScreenshotImageFormat.Png);
        }
    }
}
