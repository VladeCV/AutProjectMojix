using AutProjectMojix.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.page
{
    public class MainPageTodoist
    {
        public Button loginButton = new Button(By.XPath("//nav//a[text()=\"Log in\"]\r\n"));
    }
}
