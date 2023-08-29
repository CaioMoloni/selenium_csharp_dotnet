using OpenQA.Selenium;
using SauceDemoAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Locators
{
    public class LoginLocators
    {
        public string pageTitleText() 
        {
            return "Swag Labs";
        }
        public string productsText()
        {
            return "Products";
        }
        public string userEmailElement()
        {
            return "user-name";
        }
        public string passwordElement()
        {
            return "password";
        }
        public string loginButtonElement()
        {
            return "login-button";
        }
        public string loginUserNameErrorText()
        {
            return "Epic sadface: Username is required";
        }
        public string loginErrorUserAndPwdText() 
        {
            return "Epic sadface: Username and password do not match any user in this service";
        }
    }
}
