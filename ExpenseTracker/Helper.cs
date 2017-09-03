using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Threading;


namespace ExpenseTracker
{
    public class Helper
    {
        public static int timeout = 20;

        private readonly IWebDriver driver;


        public static void Wait(IWebDriver driver)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            Thread.Sleep(2000);
        }

        public void Navigate(IWebDriver driver)
        {

            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);
            Thread.Sleep(2000);
        }
        public Helper(IWebDriver browser)
        {
            this.driver = browser;
        }

      

    }
}
