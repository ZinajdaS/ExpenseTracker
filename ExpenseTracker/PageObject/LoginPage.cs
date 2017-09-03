using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.PageObject
{
    class LoginPage
    {
        #region Initialize
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }
        #endregion

        #region Elements
        public IWebElement Username
        {
            get { return driver.FindElement(By.Id("login")); }
        }

        public IWebElement Password
        {
            get { return driver.FindElement(By.Id("password")); }
        }

        public IWebElement LoginButton
        {
            get { return driver.FindElement(By.Id("submit")); }
        }

        public IWebElement LoggedUser
        {
            get { return driver.FindElement(By.Id("editaccount")); }
        }
        #endregion

        #region Functions
        public void Login(string user, string password)
        {
            Helper helper = new Helper(this.driver);
            helper.Navigate(this.driver);
            Helper.Wait(this.driver);
            Username.SendKeys(user);
            Password.SendKeys(password);
            LoginButton.Click();
        }
        #endregion
    }
}
