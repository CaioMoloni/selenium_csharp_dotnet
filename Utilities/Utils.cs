using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Utilities
{
    public class Utils
    {
        public IWebDriver driver;

        public string id;

        public WebDriverWait wait;

        string pageSource;

        public Utils(IWebDriver driver, int time)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(time));
            pageSource = this.driver.PageSource;
        }

        public void waitUntilElementIsVisible(string id)
        {
            wait.Until(ExpectedConditions.ElementExists(By.Id(id)));
        }

        public void waitTime(int milisecs)
        {
            Thread.Sleep(milisecs);
        }

        public bool pageContainsText(string text)
        {
            return this.pageSource.Contains(text);
        }

        public void clickElement(string id)
        {
            waitUntilElementIsVisible(id);
            driver.FindElement(By.Id(id)).Click();
        }

        public void sendText(string id, string text)
        {
            waitUntilElementIsVisible(id);
            driver.FindElement(By.Id(id)).SendKeys(text);
        }
    }
}
