using AutProjectMojix.src.code.page;
using AutProjectMojix.src.code.page.Todoist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.test
{
    [TestClass]
    public class Project : TestBase
    {
        MainPageTodoist mainPage = new MainPageTodoist();
        LoginPage loginPage = new LoginPage();
        LeftMenu leftMenu = new LeftMenu();

        [TestMethod]

        public void TodoistTest() {

            //LOGIN
            mainPage.loginButton.Click();
            loginPage.emailTxtBox.SetText("vladimircvcf98@outlook.com");
            loginPage.pwdTxtBox.SetText("759153ferd123");
            loginPage.loginBtn.Click();

            //CREATE PROJECT
            Thread.Sleep(1000);
            leftMenu.addProjectBtn.Click();
            leftMenu.projectName.SetText("new");
            leftMenu.dropDownColorBtn.Click();
            leftMenu.projectColorBlue.Click();
            leftMenu.confirmAddition.Click();



        }
    }
}
