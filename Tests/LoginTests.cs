using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using SauceDemoAutomation.Pages;
using SauceDemoAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SauceDemoAutomation.Utilities.UserEnum;

namespace SauceDemoAutomation.Tests
{
    [TestFixture]
    public class LoginTests
    {
        protected IWebDriver driver;
        protected User user;

        LoginPage loginPage;
        Utils utils;

        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.CreateDriver();
            utils = new Utils(this.driver, 30);
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            loginPage = new LoginPage(this.driver, User.StandardUser);
        }

        [Test]
        public void ValidLoginTest()
        {
            loginPage.typeUserName();
            loginPage.typePassword();
            loginPage.clickOnLoginButton();
            loginPage.checkIfTheUserIsRedirected();
        }

        [Test]
        public void BlankLoginTest()
        {
            loginPage.clickOnLoginButton();
            loginPage.errorMessageBlankFields();
        }

        [Test]
        public void invalidUsernameAndPasswordLoginTest()
        {
            loginPage.clickOnLoginButton();
            loginPage.errorMessageUserAndPwdFields();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
