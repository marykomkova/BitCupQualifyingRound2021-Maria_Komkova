using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Testing
{
    class Test
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://cloud.google.com/";
            IWebElement search = driver.FindElement(By.Name("q"));
            search.Click();
            search.Clear();
            search.SendKeys("Google Cloud Platform Pricing Calculator");
            search.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Google Cloud Platform Pricing Calculator")).Click();
            
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
