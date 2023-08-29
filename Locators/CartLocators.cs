using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Locators
{
    public class CartLocators
    {
        public string openCartElement()
        {
            return "shopping_cart_container";
        }
        public string yourCartSubtitleText()
        {
            return "Your Cart";
        }
        public string qtyText()
        {
            return "QTY";
        }
        public string descriptionText()
        {
            return "Description";
        }
        public string sauceLabsBackpackText()
        {
            return "Sauce Labs Backpack";
        }
        public string removeBackPackElement()
        {
            return "remove-sauce-labs-backpack";
        }
        public string productDescriptionText()
        {
            return "carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.";
        }
        public string priceText()
        {
            return "$29.99";
        }
        public string continueShoppingElement()
        {
            return "continue-shopping";
        }
        public string checkoutElement()
        {
            return "checkout";
        }
    }
}
