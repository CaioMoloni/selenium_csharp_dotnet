using OpenQA.Selenium;
using SauceDemoAutomation.Locators;
using SauceDemoAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SauceDemoAutomation.Utilities.UserEnum;

namespace SauceDemoAutomation.Pages
{
    public class HomePage
    {
        protected IWebDriver driver;

        public string pageTitleText;
        public string hamburguerMenuElement;
        public string productsSubtitleText;
        public string hamburguerMenuAllItensText;
        public string hamburguerMenuAboutText;
        public string hamburguerMenuLogoutText;
        public string hamburguerMenuResetAppStateText;
        public string addToCartBackpackElement;
        public string removeFromCartElement;

        HomeLocators homeLocators;
        Utils utils;

        public HomePage(IWebDriver driver)
        {
            this.driver= driver;
            utils= new Utils(this.driver, 30);
            homeLocators= new HomeLocators();
            pageTitleText= homeLocators.pageTitleText();
            hamburguerMenuElement= homeLocators.hamburguerMenuElement();
            productsSubtitleText= homeLocators.productsSubtitleText();
            hamburguerMenuAllItensText= homeLocators.harmburguerMenuAllItensText();
            hamburguerMenuAboutText= homeLocators.harmburguerMenuAboutText();
            hamburguerMenuLogoutText= homeLocators.harmburguerMenuLogoutText();
            hamburguerMenuResetAppStateText= homeLocators.harmburguerMenuResetAppStateText();
            addToCartBackpackElement= homeLocators.addToCartBackpackElement();
            removeFromCartElement= homeLocators.removeFromCartElement();
        }

        public void validatePageTitles()
        {
            utils.pageContainsText(pageTitleText);
            utils.pageContainsText(productsSubtitleText);
        }
        public void openHamburguerMenu()
        {
            utils.clickElement(hamburguerMenuElement);
        }
        public void validateHamburguerMenuItens()
        {
            utils.pageContainsText(hamburguerMenuAllItensText);
            utils.pageContainsText(hamburguerMenuAboutText);
            utils.pageContainsText(hamburguerMenuLogoutText);
            utils.pageContainsText(hamburguerMenuResetAppStateText);
        }

        public void addProductToCartAndExpectRemoveBtn()
        {
            utils.clickElement(addToCartBackpackElement);
            utils.waitUntilElementIsVisible(removeFromCartElement);
        }

    }
}
