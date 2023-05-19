using AutProjectMojix.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.page.Todoist
{
    public class LoginPage
    {
        public TextBox emailTxtBox = new TextBox(By.XPath("//input[@id=\"element-0\"]"));
        public TextBox pwdTxtBox = new TextBox(By.XPath("//input[@id=\"element-3\"]"));
        public Button loginBtn = new Button(By.XPath("//div[2]//div/form/button"));

      
    }
    
    
}
