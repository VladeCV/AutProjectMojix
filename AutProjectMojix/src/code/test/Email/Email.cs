using AutProjectMojix.src.code.page.Yopmail;
using AutProjectMojix.src.code.session;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.test.Email
{
    [TestClass]
    public class Email : TestBase2
    {
        MainPage mainPage = new MainPage();
        Inbox inboxPage = new Inbox();

        [TestMethod]

        public void enterEmail()
        {
            mainPage.emailInput.SetText("paemaslls");
            mainPage.checkInboxBtn.Click();

            Assert.IsTrue(inboxPage.emailIsDisplayed("paemaslls@yopmail.com"), "Login was not successful");

            inboxPage.newMessageBtn.Click();
            Session.Instance().ChangeFrame("ifmail"); 

            inboxPage.recipientInput.SetText("paemaslls");
            inboxPage.subjectInput.SetText("test");
            inboxPage.messageBody.SetText("sometihgnaasd");
            inboxPage.sendMessageBtn.Click();

            

            Session.Instance().BackToPrincipal();

            Assert.IsTrue(inboxPage.messageSentAlert.IsControlDisplayed());

            inboxPage.refresInboxBtn.Click();
        }

    }
}
