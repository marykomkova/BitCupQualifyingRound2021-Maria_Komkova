using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Testing
{
    class Test
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://cloud.google.com/";
        }
    }
}
