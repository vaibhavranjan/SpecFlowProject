using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SpecFlowProject.Helpers
{

    //Generic method is written to get the data from xmlnode
    public class XmlDataReader
    {
        public static string XmlData;
        public static string xmlPath = "D:\\Work\\Training\\Selenium\\SpecFlowProject\\SpecFlowProject\\config.xml";

        public static string GetXmlData(string xmlNodeName)
        {
            XmlTextReader xmlText  = new XmlTextReader(xmlPath);

            while(xmlText.Read())
            {
                if(xmlText.NodeType == XmlNodeType.Element && xmlText.Name == xmlNodeName)
                {
                    XmlData = xmlText.ReadString();
                    break;
                }
            }

            return XmlData;
        }
    }
}
