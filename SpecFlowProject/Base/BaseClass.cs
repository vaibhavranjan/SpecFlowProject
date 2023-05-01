using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using SpecFlowProject.Configuration;
using SpecFlowProject.CustomException;
using SpecFlowProject.Interfaces;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Base
{
    [Binding]
    public class BaseClass
    {
        public BaseClass()
        {
            //IntiWebDriver();
        }
        
        public static void IntiWebDriver()
        {
            //ObjectRepository.config = new ConfigReader();
            //switch(ObjectRepository.config.GetBrowser())
            //{
            //    case BrowserType.Chrome:
            //        ObjectRepository.driver = GetChromeDriver();
            //        break;
            //    case BrowserType.Firefox:
            //        ObjectRepository.driver = GetFireFoxDriver();
            //        break;
            //    case BrowserType.Safari:
            //        ObjectRepository.driver = GetSafariDriver();
            //        break;
            //    default:
            //        throw new NoSuchDriverFound("Driver not found - " + ObjectRepository.config.GetBrowser().ToString());
            //}
            //ObjectRepository.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.config.GetPageLoadTimeOut());
        }

        [BeforeTestRun]
        public static void InitTest()
        {
           ObjectRepository.config = new ConfigReader();
            switch (ObjectRepository.config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.driver = GetChromeDriver();
                    break;
                case BrowserType.Firefox:
                    ObjectRepository.driver = GetFireFoxDriver();
                    break;
                case BrowserType.Safari:
                    ObjectRepository.driver = GetSafariDriver();
                    break;
                default:
                    throw new NoSuchDriverFound("Driver not found - " + ObjectRepository.config.GetBrowser().ToString());
            }
            ObjectRepository.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.config.GetPageLoadTimeOut());
        }

        [AfterTestRun]
        public static void CleanUp()
        {
            ObjectRepository.driver.Quit();

        }
        private static IWebDriver GetChromeDriver()
        {
            //var options = GetChromeOptions();
            //IWebDriver driver = new ChromeDriver();

            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        private static IWebDriver GetFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetSafariDriver()
        {
            IWebDriver driver = new SafariDriver();
            return driver;
        }

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            //Commenting because path was wrong for postman xtension and tests was failing
            //options.AddExtension("D:\\Work\\Training\\Selenium\\SpecFlowProject\\extension_5_5_6_0.crx");
            return options;
        }

       


    }
}
