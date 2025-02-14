using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuSelenium
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver driver;

        public BaseTest()
        {
            SetUp();
        }

    public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}

