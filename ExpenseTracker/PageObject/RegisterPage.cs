using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.PageObject
{
    class RegisterPage
    {
        #region Initialize

        private readonly IWebDriver driver;

        public RegisterPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

        #endregion

        #region Elements

        public IWebElement RegisterLink
        {
            get { return this.driver.FindElement(By.XPath("//*[contains(text(),'Register new user')]")); }
        }

        public IWebElement Username
        {
            get { return driver.FindElement(By.Id("login")); }
        }


        public IWebElement Password
        {
            get { return driver.FindElement(By.Id("password1")); }

        }

        public IWebElement RepeatPassword
        {
            get { return driver.FindElement(By.Id("password2")); }

        }

        public IWebElement RegisterButton
        {
            get { return driver.FindElement(By.Id("submit")); }

        }

        public IWebElement LoggedUser
        {
            get { return driver.FindElement(By.Id("editaccount")); }
        }

        #endregion

        #region Functions

        public void Register(string user, string password, string repeatPassword)
        {
            Helper helper = new Helper(this.driver);
            helper.Navigate(this.driver);
            Helper.Wait(this.driver);
            RegisterLink.Click();
            Username.SendKeys(user);
            Password.SendKeys(password);
            RepeatPassword.SendKeys(repeatPassword);
            RegisterButton.Click();
        }

        #endregion
    }
}
