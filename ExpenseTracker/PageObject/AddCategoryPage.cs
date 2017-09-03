using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.PageObject
{
    class AddCategoryPage
    {
        #region Initialize
        private readonly IWebDriver driver;

        public AddCategoryPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }
        #endregion

        #region Elements

        public IWebElement ListCategoryLink
        {
            get { return driver.FindElement(By.Id("go_list_categories")); }
        }

        public IWebElement AddCategoryLink
        {
            get { return driver.FindElement(By.Id("go_add_category")); }
        }

        public IWebElement CategoryName
        {
            get { return driver.FindElement(By.Id("name")); }
        }

        public IWebElement CreateCategoryBtn
        {
            get { return driver.FindElement(By.Id("submit")); }
        }

        public IWebElement CategoryListItem
        {
            get { return this.driver.FindElement(By.XPath("//*[contains(text(),'Food')]")); }
        }
        #endregion

        #region Functions
        public void AddCategory()
        {
            Helper helper = new Helper(this.driver);
            ListCategoryLink.Click();
            AddCategoryLink.Click();
            CategoryName.SendKeys("Food");
            CreateCategoryBtn.Click();
        }
        #endregion
    }
}
