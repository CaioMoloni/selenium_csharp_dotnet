using OpenQA.Selenium;
using SauceDemoAutomation.Locators;
using SauceDemoAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Pages
{
    public class CartPage
    {
        protected IWebDriver driver;

        public string openCartElement;
        public string yourCartSubtitleText;
        public string qtyText;
        public string descriptionText;
        public string sauceLabsBackpackText;
        public string removeBackPackElement;
        public string productDescriptionText;
        public string priceText;
        public string continueShoppingElement;
        public string addToCartBackpackElement;
        public string checkoutElement;

        CartLocators cartLocators;
        HomeLocators homeLocators;
        Utils utils;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            utils = new Utils(this.driver, 30);
            cartLocators = new CartLocators();
            homeLocators = new HomeLocators();
            addToCartBackpackElement = homeLocators.addToCartBackpackElement();
            openCartElement = cartLocators.openCartElement();
            yourCartSubtitleText= cartLocators.yourCartSubtitleText();
            qtyText= cartLocators.qtyText();
            descriptionText= cartLocators.descriptionText();
            sauceLabsBackpackText= cartLocators.sauceLabsBackpackText();
            removeBackPackElement= cartLocators.removeBackPackElement();
            productDescriptionText= cartLocators.productDescriptionText();
            priceText= cartLocators.priceText();
            continueShoppingElement= cartLocators.continueShoppingElement();
            checkoutElement= cartLocators.checkoutElement();
        }

        public void addProductToCart()
        {
            utils.clickElement(addToCartBackpackElement);
            utils.clickElement(openCartElement);
        }

        public void validateCartPage()
        {
            utils.pageContainsText(yourCartSubtitleText);
            utils.pageContainsText(qtyText);
            utils.pageContainsText(descriptionText);
            utils.pageContainsText(sauceLabsBackpackText);
            utils.waitUntilElementIsVisible(removeBackPackElement);
            utils.pageContainsText(productDescriptionText);
            utils.pageContainsText(priceText);
            utils.waitUntilElementIsVisible(continueShoppingElement);
        }

        public void goToCheckout()
        {
            utils.clickElement(checkoutElement);
            utils.pageContainsText("Checkout:Your Information");
        }

    }
}
