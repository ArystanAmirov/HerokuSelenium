using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuSelenium.Pages
{
    class Page02_AddRemoveElements
    {
        IWebDriver driver;

        public Page02_AddRemoveElements(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddElement()
        {
            driver.FindElement(By.XPath("//button[text()='Add Element']")).Click();
        }

        public void DeleteElement()
        {
            driver.FindElement(By.XPath("//button[text()='Delete']")).Click();
        }

        public int CountDeleteButtons()
        {
            return driver.FindElements(By.XPath("//button[text()='Delete']")).Count;
        }
    }
}
