using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFraeworkCSharp.BaseClass
{
    public class BaseTesting
    {
        public IWebDriver driver;
       [OneTimeSetUp] 
        public void SetUp() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           
        }
        [OneTimeTearDown]
        public void Flush()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
