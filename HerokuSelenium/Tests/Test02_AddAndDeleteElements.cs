using HerokuSelenium.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuSelenium.Tests
{
    public class Test02_AddAndDeleteElements : BaseTest
    {
        [Fact]
        public void VerifyAddAndDeleteElements()
        {
            var page00_Home = new Page00_Home(driver);
            var page02_AddRemoveElements = new Page02_AddRemoveElements(driver);

            page00_Home.ClickOnElement("Add/Remove Elements");

            page02_AddRemoveElements.AddElement();
            page02_AddRemoveElements.DeleteElement();

            var numberOfDeleteButtons = page02_AddRemoveElements.CountDeleteButtons();

            Assert.Equal(0, numberOfDeleteButtons);
        }
    }
}
