using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SauceDemoAutomation.Utilities;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using static SauceDemoAutomation.Utilities.UserEnum;
using SauceDemoAutomation.Locators;

namespace SauceDemoAutomation.Pages
{
    public class LoginPage
    {
        Utils utils;
        LoginLocators loginLocators;

        public IWebDriver driver;

        public string username;
        public string password;

        public string userEmail;
        public string userPassword;
        public string loginButton;
        public string productsText;
        public string errorUserAndPwdText;
        public string errorUsernameText;

        public LoginPage(IWebDriver driver, User user)
        {
            //initial setup
            this.driver = driver;
            (username, password) = UserCredentials.GetCredentials(user);
            utils = new Utils(this.driver, 30);
            loginLocators = new LoginLocators();

            //registering the elements
            userEmail = loginLocators.userEmailElement();
            userPassword = loginLocators.passwordElement();
            loginButton = loginLocators.loginButtonElement();
            productsText = loginLocators.productsText();
            errorUserAndPwdText = loginLocators.loginErrorUserAndPwdText();
            errorUsernameText = loginLocators.loginUserNameErrorText();
        }

        public void typeUserName()
        {
            utils.waitUntilElementIsVisible(userEmail);
            utils.sendText(userEmail, username);
        }

        public void typePassword()
        {
            utils.sendText(userPassword, password);
        }

        public void clickOnLoginButton()
        {
            utils.clickElement(loginButton);
        }

        public void checkIfTheUserIsRedirected()
        {
            utils.pageContainsText(productsText);
        }

        public void errorMessageBlankFields()
        {
            utils.pageContainsText(errorUserAndPwdText);
        }

        public void errorMessageUserAndPwdFields()
        {
            utils.pageContainsText(errorUserAndPwdText);
        }
    }
}
