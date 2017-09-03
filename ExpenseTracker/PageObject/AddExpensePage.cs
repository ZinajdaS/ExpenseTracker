using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace ExpenseTracker.PageObject
{
    class AddExpensePage
    {
        #region Initialize
        private readonly IWebDriver driver;

        public AddExpensePage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }
        #endregion

        #region Elements
        public IWebElement AddExpenseLink
        {
            get { return driver.FindElement(By.Id("go_add_expense")); }
        }

        public IWebElement Day
        {
            get { return driver.FindElement(By.Id("day")); }
        }

        public IWebElement Month
        {
            get { return driver.FindElement(By.Id("month")); }
        }

        public IWebElement Year
        {
            get { return driver.FindElement(By.Id("year")); }
        }

        public IWebElement DropDownElements
        {
            get { return driver.FindElement(By.Id("category")); }
        }

        public IWebElement Amount
        {
            get { return driver.FindElement(By.Id("amount")); }
        }

        public IWebElement Reason
        {
            get { return driver.FindElement(By.Id("reason")); }
        }

        public IWebElement CreateExpenseBtn
        {
            get { return driver.FindElement(By.Id("submit")); }
        }

        public IWebElement CategoryListItem
        {
            get { return this.driver.FindElement(By.XPath("//*[contains(text(),'Food')]")); }
        }
        #endregion

        #region Functions
        public void AddExpense()
        {
            AddExpenseLink.Click();
            Day.SendKeys("10");
            Month.Clear();
            Month.SendKeys("12");
            Year.Clear();
            Year.SendKeys("2015");
            SelectElement selector = new SelectElement(DropDownElements);
            selector.SelectByIndex(0);
            Amount.SendKeys("22");
            Reason.SendKeys("Test test test");
            CreateExpenseBtn.Click();
        }
        #endregion
    }
}
