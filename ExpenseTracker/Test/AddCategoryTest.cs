using ExpenseTracker.PageObject;
using FluentAssertions;
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
    class AddCategoryTest
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

        public AddCategoryTest(IWebDriver browser)
        {
            this.Driver = browser;
            PageFactory.InitElements(browser, this);
        }

        public AddCategoryTest()
        {

        }

        #endregion

        #region Tests
        [Test]
        public void AddCategory()
        {
            //Arange
            var application = new AddCategoryPage(this.Driver);
            var appLogin = new LoginPage(this.Driver);

            //Act
            appLogin
                .Login(ConfigurationManager.AppSettings["user"],
                ConfigurationManager.AppSettings["password"]);

            application
                .AddCategory();


            //Assert
            application.CategoryListItem.Text.Should().Be("Food");
        }
        #endregion

        #region TearDown
        #endregion
    }
}
