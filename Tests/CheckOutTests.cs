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
    public class CheckOutTests
    {
        protected IWebDriver driver;
        protected User user;
        LoginPage loginPage;
        CartPage cartPage;
        CheckoutPage checkoutPage;
        Utils utils;

        [SetUp]
        public void Setup()
        {
            driver = DriverFactory.CreateDriver();
            utils = new Utils(this.driver, 30);
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            loginPage = new LoginPage(this.driver, User.StandardUser);
            cartPage = new CartPage(this.driver);
            checkoutPage= new CheckoutPage(this.driver);
            loginPage.typeUserName();
            loginPage.typePassword();
            loginPage.clickOnLoginButton();
            loginPage.checkIfTheUserIsRedirected();
            cartPage.addProductToCart();
            cartPage.validateCartPage();
            cartPage.goToCheckout();
        }

        [Test]
        public void inputCustomerDataAndContinue()
        {
            checkoutPage.inputFirstName();
            checkoutPage.inputLastName();
            checkoutPage.inputPostalCode();
            checkoutPage.clickOnContinue();
        }

        [Test]
        public void cancelCheckout() 
        {
            checkoutPage.cancelCheckoutValidateNavigation();
        }

        [Test]
        public void goToCheckOutOverview()
        {
            checkoutPage.inputFirstName();
            checkoutPage.inputLastName();
            checkoutPage.inputPostalCode();
            checkoutPage.clickOnContinue();
            checkoutPage.validateCheckoutOverview();
        }

        [Test]
        public void finishCheckout()
        {
            checkoutPage.inputFirstName();
            checkoutPage.inputLastName();
            checkoutPage.inputPostalCode();
            checkoutPage.clickOnContinue();
            checkoutPage.validateCheckoutOverview();
            checkoutPage.finishOrderAndCheckElements();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
