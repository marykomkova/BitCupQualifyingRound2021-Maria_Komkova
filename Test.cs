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
            driver.Navigate().GoToUrl("https://yopmail.com/");
            IWebElement search = driver.FindElement(By.Name("q"));
            search.Click();
            search.Clear();
            search.SendKeys("Google Cloud Platform Pricing Calculator");
            search.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Google Cloud Platform Pricing Calculator")).Click();
            Thread.Sleep(5000);
            driver.Navigate().Refresh();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='mainForm']/md-tabs/md-tabs-wrapper/md-tabs-canvas/md-pagination-wrapper/md-tab-item[1]/div/div/div[1]/div/div")).Click();
            driver.FindElement(By.Id("input_74")).Click();
            driver.FindElement(By.Id("input_74")).SendKeys("4");
            driver.FindElement(By.XPath("//*[@id='select_value_label_66']/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='select_option_76']/div[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='select_value_label_67']/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='select_option_89']/div")).Click();
            driver.FindElement(By.XPath("//*[@id='select_value_label_70']/span[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='select_option_271']/div[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='mainForm']/div[2]/div/md-card/md-card-content/div/div[1]/form/div[16]/button")).Click();
            driver.FindElement(By.Id("input_120")).Click();
            driver.FindElement(By.Id("input_120")).SendKeys("1");////*[@id="select_value_label_439"]/span[2]
            driver.FindElement(By.XPath("//*[@id='mainForm']/div[2]/div/md-card/md-card-content/div/div[2]/form/div[4]/div[1]/md-input-container/md-checkbox/div[1]/div")).Click();
            driver.FindElement(By.XPath("//*[@id='select_value_label_440']/span[2]")).Click();
            driver.FindElement(By.Id("select_option_464'")).Click();
            driver.FindElement(By.XPath("//*[@id='select_value_label_439']/span[2]")).Click();
            driver.FindElement(By.Id("select_option_428")).Click();
            driver.FindElement(By.XPath("//*[@id='mainForm']/div[2]/div/md-card/md-card-content/div/div[2]/form/div[6]/div/md-input-container/md-checkbox/div[1]/div[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='select_value_label_117']/span[2]")).Click();
            driver.FindElement(By.Id("select_option_132")).Click();
            driver.FindElement(By.XPath("//*[@id='select_value_label_118']/span[2]")).Click();
            driver.FindElement(By.Id("select_option_287")).Click();
            driver.FindElement(By.XPath("//*[@id='select_value_label_119']/span[2]")).Click();
            driver.FindElement(By.Id("select_option_139")).Click();
            driver.FindElement(By.XPath("//*[@id='mainForm']/div[2]/div/md-card/md-card-content/div/div[2]/form/div[13]/button")).Click();
            String totalResult = driver.FindElement(By.XPath("//*[@id='resultBlock']/md-card/md-card-content/div/div/div/h2/b")).Text;


            
            //Thread.Sleep(5000);
            //driver.Quit();
        }
    }
}
