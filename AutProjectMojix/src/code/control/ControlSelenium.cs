using AutProjectMojix.src.code.session;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.Debugger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.control
{
    public class ControlSelenium
    {
        protected By Locator;
        protected IWebElement Control;

        public ControlSelenium(By Locator)
        {
            this.Locator = Locator;
        }

        protected void FindControl()
        {
            Control = Session.Instance().GetBrowser().FindElement(Locator);

        }
        public void Click()
        {
            FindControl();
            Control.Click();
        }

        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return Control.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
