using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Locators
{
    public class CheckoutLocators
    {
        public string checkoutElement()
        {
            return "checkout";
        }
        public string firstNameElement()
        {
            return "first-name";
        }
        public string lastNameElement()
        {
            return "last-name";
        }
        public string postalCodeElement()
        {
            return "postal-code";
        }
        public string cancelElement()
        {
            return "cancel";
        }
        public string continueElement()
        {
            return "continue";
        }
        public string qtyText()
        {
            return "QTY";
        }
        public string checkoutSubtitleText()
        {
            return "Checkout: Overview";
        }
        public string paymentInformationText()
        {
            return "Payment Information";
        }
        public string paymentDescriptionText()
        {
            return "SauceCard #31337";
        }
        public string shippingInformationText()
        {
            return "Shipping Information";
        }
        public string shippingDescriptionText()
        {
            return "Free Pony Express Delivery!";
        }
        public string priceTotalText()
        {
            return "Price Total";
        }
        public string itemTotalText()
        {
            return "Item total: $29.99";
        }
        public string taxText()
        {
            return "Tax: $2.40";
        }
        public string totalText()
        {
            return "Total: $32.39";
        }
        public string finishElement()
        {
            return "finish";
        }
        public string thankYouForYourOrderText()
        {
            return "Thank you for your order!";
        }
        public string orderCompleteText()
        {
            return "Your order has been dispatched, and will arrive just as fast as the pony can get there!";
        }
        public string backHomeElement()
        {
            return "back-to-products";
        }
    }
}
