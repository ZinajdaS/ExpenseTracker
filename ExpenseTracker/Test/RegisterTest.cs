using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ExpenseTracker.PageObject;
using System.Configuration;
using FluentAssertions;

namespace ExpenseTracker.Test
{
    class RegisterTest
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

        public RegisterTest(IWebDriver browser)
        {
            this.Driver = browser;
            PageFactory.InitElements(browser, this);
        }

        public RegisterTest()
        {

        }
        #endregion

        #region Tests
        [Test]
        public void Register()
        {
            //Arange
            var application = new RegisterPage(this.Driver);

            //Act
            application
                .Register(ConfigurationManager.AppSettings["user"],
                ConfigurationManager.AppSettings["password"],
                ConfigurationManager.AppSettings["password"]);

            //Assert
            application.LoggedUser.Text.Should().Be("Tarik");
        }
        #endregion

        #region Teardown
        [TearDown]
        public void TearDownTest()
        {
            //this.Driver.Quit();
        }
        #endregion
    }
}
