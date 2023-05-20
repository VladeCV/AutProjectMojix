using AutProjectMojix.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutProjectMojix.src.code.page.Todoist
{
    public class LeftMenu
    {
        //Create Project 
        public Label todayLabel = new Label(By.XPath("//div[@id=\"agenda_view\"]//header//span[text()=\"Today\"]"));
        public Button addProjectBtn = new Button(By.XPath("//div[@id=\"left_menu\"]//button[@aria-label=\"Add project\"]"));
        public TextBox projectName = new TextBox(By.XPath("//input[@name='name']"));
        public Button dropDownColorBtn = new Button(By.XPath("//form//button[@aria-haspopup='listbox']"));
        public Button projectColorRed = new Button(By.XPath("//ul//li//span[text()='Red']"));
        public Button confirmAddition = new Button(By.XPath("//form//footer//button[2]"));

        //Update Project
        public Button actionsBtn = new Button(By.XPath("//*[@id=\"projects_list\"]//li//span[text()='dasd']//following::button[@aria-label='More project actions']"));
        public Button editProjectBtn = new Button(By.XPath("//div[@class=' popper']//ul//li[4]"));
        public Button projectColorBlue = new Button(By.XPath("//ul//li//span[text()='Blue']"));
        public Button confirmProjectUpdate = new Button(By.XPath("//footer//span[text()='Save']"));

        //Delete Project
        public Button deleteProjectBtn = new Button(By.XPath("//div[@class=' popper']//ul//li[13]"));
        public Button deleteConfirmationBtn = new Button(By.XPath("//footer//span[text()='Delete']\r\n"));

        public Boolean ProjectNameIsDisplayed(String projectName)
        {
            Label labelProjectName = new Label(By.XPath("//ul[@id=\"projects_list\"]//li[last()]//span[text()='"+projectName+"']"));
            return labelProjectName.IsControlDisplayed();
        } 
    }
}
