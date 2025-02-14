using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuSelenium.Pages
{
    class Page00_Home
    {
        private IWebDriver driver;

        public Page00_Home(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnElement(string linkText)
        {
            driver.FindElement(By.LinkText(linkText)).Click();
        }
    }
}
