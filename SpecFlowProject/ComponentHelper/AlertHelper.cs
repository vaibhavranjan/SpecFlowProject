using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class AlertHelper
    {
        public static void SwitchToAlert()
        {
            ObjectRepository.driver.SwitchTo().Alert();
        }

        public static void Accept()
        {
            ObjectRepository.driver.SwitchTo().Alert().Accept();
        }

        public static void Dismiss()
        {
            ObjectRepository.driver.SwitchTo().Alert().Dismiss();
        }

        public static void EnterText(string text)
        {
            ObjectRepository.driver.SwitchTo().Alert().SendKeys(text);
        }

        public static string GetText(string text)
        {
            return ObjectRepository.driver.SwitchTo().Alert().Text;
        }
    }
}
