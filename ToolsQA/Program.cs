using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();

            IWebElement FirstName = driver.FindElement(By.Id("firstName"));
            FirstName.SendKeys("Vedrana");

            IWebElement LastName = driver.FindElement(By.Id("lastName"));
            LastName.SendKeys("Mitrovic");

            IWebElement Email = driver.FindElement(By.Id("userEmail"));
            Email.SendKeys("vedrana.mitrovic@outlook.com");

            IWebElement Mobile = driver.FindElement(By.Id("userNumber"));
            Mobile.SendKeys("0638641853");

            IWebElement CurrentAddress = driver.FindElement(By.Id("currentAddress"));
            CurrentAddress.SendKeys("Savski nasip 7, Belgrade");

            driver.Quit();



        }
    
    }
}
