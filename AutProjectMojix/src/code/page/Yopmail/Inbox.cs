using AutProjectMojix.src.code.control;
using AutProjectMojix.src.code.session;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.page.Yopmail
{
    public class Inbox
    {
        public Button newMessageBtn = new Button(By.XPath("//button[@id='newmail']"));

        public IFrame messageSection = new IFrame(By.XPath("//iframe[@id='fmail']"));

        public TextBox recipientInput = new TextBox(By.XPath("//input[@id='msgto']"));
        public TextBox subjectInput = new TextBox(By.XPath("//input[@id='msgsubject']"));
        public TextBox messageBody = new TextBox(By.XPath("//div[@id='msgbody']"));
        public Button sendMessageBtn = new Button(By.XPath("//button[@id='msgsend']"));
        public Button refresInboxBtn = new Button(By.XPath("//button[@id='refresh']"));

        public Label messageSentAlert = new Label(By.XPath("//div[@id='msgpop']/div"));

        public Boolean emailIsDisplayed(String email)
        {
            Label userEmail = new Label(By.XPath("//*[@id='webmail']//div[text()='"+email+"']"));
            return userEmail.IsControlDisplayed();
        }


    }
}
