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
    class LoginTest
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

        public LoginTest(IWebDriver browser)
        {
            this.Driver = browser;
            PageFactory.InitElements(browser, this);
        }

        public LoginTest()
        {

        }

        #endregion

        #region Tests
        [Test]
        public void Login()
        {
            //Arange
            var application = new LoginPage(this.Driver);

            //Act
            application
                .Login(ConfigurationManager.AppSettings["user"],
                ConfigurationManager.AppSettings["password"]);

            //Assert
            application.LoggedUser.Text.Should().Be("Tarik");
        }
        #endregion

        #region TearDown
        [TearDown]
        public void TearDownTest()
        {
            this.Driver.Quit();
        }

        #endregion
    }
}
