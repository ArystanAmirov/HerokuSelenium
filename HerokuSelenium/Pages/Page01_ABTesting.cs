using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuSelenium.Pages
{
    class Page01_ABTesting
    {
        IWebDriver driver;

        public Page01_ABTesting(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetABTestHeader()
        {
            return driver.FindElement(By.CssSelector(".example h3"));
        }

        public IWebElement GetABTestText()
        {
            return driver.FindElement(By.CssSelector(".example p"));
        }
    }
}