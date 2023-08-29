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
    public class CartTests
    {
        protected IWebDriver driver;
        protected User user;
        LoginPage loginPage;
        CartPage cartPage;
        Utils utils;

        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.CreateDriver();
            utils = new Utils(this.driver, 30);
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            loginPage = new LoginPage(this.driver, User.StandardUser);
            cartPage = new CartPage(this.driver);
        }

        [Test]
        public void AddProductToCart()
        {
            loginPage.typeUserName();
            loginPage.typePassword();
            loginPage.clickOnLoginButton();
            loginPage.checkIfTheUserIsRedirected();
            cartPage.addProductToCart();
            cartPage.validateCartPage();
        }

        [Test]
        public void GoToCheckOut()
        {
            loginPage.typeUserName();
            loginPage.typePassword();
            loginPage.clickOnLoginButton();
            loginPage.checkIfTheUserIsRedirected();
            cartPage.addProductToCart();
            cartPage.validateCartPage();
            cartPage.goToCheckout();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
