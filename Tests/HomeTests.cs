using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemoAutomation.Pages;
using SauceDemoAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SauceDemoAutomation.Utilities.UserEnum;

namespace SauceDemoAutomation.Tests
{
    [TestFixture]
    public class HomeTests
    {
        protected IWebDriver driver;
        protected User user;
        LoginPage loginPage;
        CartPage cartPage;
        HomePage homePage;
        Utils utils;

        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.CreateDriver();
            utils = new Utils(this.driver, 30);
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            loginPage = new LoginPage(this.driver, User.StandardUser);
            cartPage = new CartPage(this.driver);
            homePage = new HomePage(this.driver);
        }

        [Test]
        public void ValidateHomeScreenTitles()
        {
            loginPage.typeUserName();
            loginPage.typePassword();
            loginPage.clickOnLoginButton();
            loginPage.checkIfTheUserIsRedirected();
            homePage.validatePageTitles();
        }

        [Test]
        public void ValidateHamburguerMenu()
        {
            loginPage.typeUserName();
            loginPage.typePassword();
            loginPage.clickOnLoginButton();
            homePage.openHamburguerMenu();
            homePage.validateHamburguerMenuItens();
        }

        [Test]
        public void validateAddingProductToCart()
        {
            loginPage.typeUserName();
            loginPage.typePassword();
            loginPage.clickOnLoginButton();
            homePage.addProductToCartAndExpectRemoveBtn();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
