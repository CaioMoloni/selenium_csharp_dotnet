using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Utilities
{
    public static class DriverFactory
    {
        private static IWebDriver _driver;

        public static IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            _driver = new ChromeDriver(options);

            return _driver;
        }
    }
}
