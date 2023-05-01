using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class NavigationHelper
    {
        public static void LoadWebSite()
        {
            ObjectRepository.driver.Navigate().GoToUrl(ObjectRepository.config.GetURL());
        }

        public static void Refresh()
        {
            ObjectRepository.driver.Navigate().Refresh();
        }

        public static void GoBack()
        {
            ObjectRepository.driver.Navigate().Back();
        }

        public static void GoForward()
        {
            ObjectRepository.driver.Navigate().Forward();
        }
    }
}
