using AutProjectMojix.src.code.factoryBrowser;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.session
{
    public class Session
    {
        private static Session instance = null;
        private IWebDriver browser;

        private Session() {
            browser = FactoryBrowser.Make("chrome").Create();
        }
        public static Session Instance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            else
            {
                instance = null;
                browser.Quit();
            }
        }
        public void CloseBrowser()
        {
            instance = null;
            browser.Quit();
        }

        public IWebDriver GetBrowser()
        {
            return browser;
        }

    }
}
