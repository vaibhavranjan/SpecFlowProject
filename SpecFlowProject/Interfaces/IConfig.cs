using SpecFlowProject.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetURL();
        string GetUsername();
        string GetPassword();
        int GetPageLoadTimeOut();
    }
}
