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
    public class CheckoutPage
    {
        protected IWebDriver driver;

        public string checkoutElement;
        public string finishElement;
        public string qtyText;
        public string backHomeElement;
        public string cancelElement;
        public string continueElement;
        public string checkoutSubtitleText;
        public string firstNameElement;
        public string lastNameElement;
        public string postalCodeElement;
        public string paymentInformationText;
        public string paymentDescriptionText;
        public string shippingInformationText;
        public string shippingDescriptionText;
        public string priceTotalText;
        public string itemTotalText;
        public string taxText;
        public string totalText;
        public string thankYouForYourOrderText;
        public string orderCompleteText;
        public string continueShoppingElement;
        public string descriptionText;
        public string priceText;

        CheckoutLocators checkoutLocators;
        CartLocators cartLocators;
        Utils utils;
        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
            utils = new Utils(this.driver, 30);
            checkoutLocators = new CheckoutLocators();
            cartLocators = new CartLocators();
            qtyText = checkoutLocators.qtyText();
            checkoutElement = checkoutLocators.checkoutElement();
            finishElement= checkoutLocators.finishElement();
            backHomeElement= checkoutLocators.backHomeElement();
            cancelElement= checkoutLocators.cancelElement();
            continueElement= checkoutLocators.continueElement();
            checkoutSubtitleText= checkoutLocators.checkoutSubtitleText();
            firstNameElement= checkoutLocators.firstNameElement();
            lastNameElement= checkoutLocators.lastNameElement();
            postalCodeElement= checkoutLocators.postalCodeElement();
            paymentInformationText = checkoutLocators.paymentInformationText(); 
            paymentDescriptionText = checkoutLocators.paymentDescriptionText();
            shippingInformationText = checkoutLocators.shippingInformationText();
            shippingDescriptionText = checkoutLocators.shippingDescriptionText();
            priceTotalText= checkoutLocators.priceTotalText();
            itemTotalText= checkoutLocators.itemTotalText();
            taxText= checkoutLocators.taxText();
            totalText = checkoutLocators.totalText();
            thankYouForYourOrderText = checkoutLocators.thankYouForYourOrderText();
            orderCompleteText = checkoutLocators.orderCompleteText();
            descriptionText= cartLocators.descriptionText();
            priceText = cartLocators.priceText();
        }
        public void inputFirstName()
        {
            utils.sendText(firstNameElement, "test");
        }
        public void inputLastName()
        {
            utils.sendText(lastNameElement, "test");
        }
        public void inputPostalCode()
        {
            utils.sendText(postalCodeElement, "test");
        }
        public void clickOnContinue()
        {
            utils.clickElement(continueElement);
        }

        public void cancelCheckoutValidateNavigation()
        {
            utils.clickElement(cancelElement);
            utils.pageContainsText("Your Cart");
        }
        public void validateCheckoutOverview()
        {
            utils.pageContainsText(qtyText);
            utils.pageContainsText(descriptionText);
            utils.pageContainsText(priceText);
            utils.pageContainsText(paymentDescriptionText);
            utils.pageContainsText(shippingDescriptionText);
            utils.pageContainsText(priceTotalText);
            utils.pageContainsText(itemTotalText);
            utils.pageContainsText(taxText);
            utils.pageContainsText(totalText);
            utils.waitUntilElementIsVisible(finishElement);
        }
        public void finishOrderAndCheckElements()
        {
            utils.clickElement(finishElement);
            utils.pageContainsText(thankYouForYourOrderText);
            utils.pageContainsText(orderCompleteText);
            utils.pageContainsText(backHomeElement);
        }

    }
}
