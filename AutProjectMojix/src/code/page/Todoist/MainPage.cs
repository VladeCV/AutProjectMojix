using AutProjectMojix.src.code.control;
using OpenQA.Selenium;

namespace AutProjectMojix.src.code.page
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//nav//a[text()='Log in']"));
    }
}
