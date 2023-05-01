using OpenQA.Selenium;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class FrameHelper
    {
        public static void SwitchToFrame(IWebElement element)
        {
            ObjectRepository.driver.SwitchTo().Frame(element);
        }

        public static void SwitchToFrame(int index)
        {
            ObjectRepository.driver.SwitchTo().Frame(index);
        }

        public static void SwitchToFrame(string FrameName)
        {
            ObjectRepository.driver.SwitchTo().Frame(FrameName);
        }

        public static void SwitchToDefaultContent()
        {
            ObjectRepository.driver.SwitchTo().DefaultContent();
        }
    }
}
