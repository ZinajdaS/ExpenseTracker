using ExpenseTracker.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Test
{
    class AddExpenseTest
    {
        #region Initialize

        public IWebDriver Driver { get; set; }
        ChromeOptions options = new ChromeOptions();

        [SetUp]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Driver.Manage().Window.Maximize();
        }

        public AddExpenseTest(IWebDriver browser)
        {
            this.Driver = browser;
            PageFactory.InitElements(browser, this);
        }

        public AddExpenseTest()
        {

        }
        #endregion

        #region Tests
        [Test]
        public void AddExpense()
        {
            //Arange
            var application = new AddExpensePage(this.Driver);
            var appCategory = new AddCategoryPage(this.Driver);
            var appLogin = new LoginPage(this.Driver);

            //Act
            appLogin
                .Login(ConfigurationManager.AppSettings["user"],
                ConfigurationManager.AppSettings["password"]);

            appCategory
                .AddCategory();

            application
                .AddExpense();


            //Assert
            // application.CategoryListItem.Text.Should().Be("Food");
        }
        #endregion

        #region TearDown
        #endregion
    }
}
