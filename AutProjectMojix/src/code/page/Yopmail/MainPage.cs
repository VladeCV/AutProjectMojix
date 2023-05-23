using AutProjectMojix.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.page.Yopmail
{
    public class MainPage
    {
        public TextBox emailInput = new TextBox(By.XPath("//input[@id='login']"));
        public Button checkInboxBtn = new Button(By.XPath("//div[@id='refreshbut']/button"));
    }
}
