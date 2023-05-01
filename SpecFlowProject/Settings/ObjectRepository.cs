using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Settings
{
    public static class ObjectRepository
    {
        public static IConfig config { get; set; }
        public static IWebDriver driver { get; set; }


        
    }
}
