using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Automation.Practice.WebDriver
{
    public class WebDriverInteractionBase
    {
        protected IWebDriver _driver;
        private TimeSpan _wait;
        public string Url { get => _driver.Url; }

        public WebDriverInteractionBase(int wait = 10)
        {
            /*
             * Driver Creation should be extended
             * to handle additional settings and browser bindings
             */
            _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            _wait = TimeSpan.FromSeconds(wait);
        }

        protected IWebElement GetVisableElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, _wait);
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected IWebElement GetClickableElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, _wait);
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected SelectElement GetSelectElement(By by)
        {
            return new SelectElement(_driver.FindElement(by));
        }

        public void Navigate(string url)
        {
            _driver.Url = url;
            _driver.Navigate();
        }
    }
}
