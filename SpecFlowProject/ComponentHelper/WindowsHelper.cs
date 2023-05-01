using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class WindowsHelper
    {
        public static int GetWindowsCount()
        {
            return ObjectRepository.driver.WindowHandles.Count();
        }

        public static string GetCurrentWindowsHandle()
        {
            return ObjectRepository.driver.CurrentWindowHandle.ToString();
        }

        public static void SwitchToWindow(int index) 
        {
            ObjectRepository.driver.SwitchTo().Window(ObjectRepository.driver.WindowHandles[index]);
        }
        public static void SwitchToWindow(string  Name)
        {
            ObjectRepository.driver.SwitchTo().Window(Name);
        }
    }
}
