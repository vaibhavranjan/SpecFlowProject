using SpecFlowProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using SpecFlowProject.Settings;
using SpecFlowProject.Helpers;

namespace SpecFlowProject.Configuration
{
    public class ConfigReader : IConfig
    {

        public static string XmlData;

        //In C# \ has special meaning (escape sequence character) To treat single backslash (\) as normal string, use double backslash (\\) or use verbatim literal symbol infront of string which is @.
        public static string xmlPath = @"D:\Work\Training\Selenium\SpecFlowProject\SpecFlowProject\config.xml";

        //public static string xmlPath = "D:\\Work\\Training\\Selenium\\SpecFlowProject\\SpecFlowProject";
        public BrowserType GetBrowser()
        {
            //string xmldata = XmlDataReader.GetXmlData(ConfigKeys.Browser);
            //Object obj = Enum.Parse(typeof(BrowserType), xmldata);
            //return (BrowserType)obj;

            return (BrowserType)Enum.Parse(typeof(BrowserType), XmlDataReader.GetXmlData(ConfigKeys.Browser));
        }

        public int GetPageLoadTimeOut()
        {
            return Convert.ToInt32(XmlDataReader.GetXmlData(ConfigKeys.pageLoadTimeOut));
        }

        public string GetPassword()
        {
           return XmlDataReader.GetXmlData(ConfigKeys.password);
        }

        public string GetURL()
        {
            return XmlDataReader.GetXmlData(ConfigKeys.URL);
        }

        public string GetUsername()
        {
            return XmlDataReader.GetXmlData(ConfigKeys.userName);
        }
    }
}
