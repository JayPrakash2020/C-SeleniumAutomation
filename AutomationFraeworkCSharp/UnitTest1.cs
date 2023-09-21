using AutomationFraeworkCSharp.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFraeworkCSharp
{
    [TestFixture]
    public class Tests:BaseTesting
    {
      
        [Test,Category("Regression Testing")]
        public void Method1()
        {        
            driver.Navigate().GoToUrl("https://www.google.com");
            IWebElement serachvalue = driver.FindElement(By.XPath("//textarea[@name='q']"));
            serachvalue.SendKeys("Jay PRakash Pathak");
            Thread.Sleep(5000);
            serachvalue.SendKeys(Keys.Enter);
            Thread.Sleep(5000);        
        }
        [Test, Category("Smoke Testing")]

        public void Method2() { 
                 
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            IWebElement loginbtn = driver.FindElement(By.XPath("//button[@name='login']"));
            Thread.Sleep(5000);
            loginbtn.Click();
        }
    }
}