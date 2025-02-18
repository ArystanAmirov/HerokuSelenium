using HerokuSelenium.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuSelenium.Tests
{
    public class Test01_AbTesting : BaseTest
    {
        [Fact]
        public void VeryfyABTestText()
        {
            var page00_Home = new Page00_Home(driver);
            var page01_ABTesting = new Page01_ABTesting(driver);

            page00_Home.ClickOnElement("A/B Testing");

            var ABTestHeader = page01_ABTesting.GetABTestHeader();
            var ABTestText = page01_ABTesting.GetABTestText();

            Assert.Equal("A/B Test Variation 1", ABTestHeader.Text);
            Assert.Equal("Also known as split testing. This is a way in which businesses are able to simultaneously test and learn different versions of a page to see which text and/or functionality works best towards a desired outcome (e.g. a user action such as a click-through).", ABTestText.Text);
        }
    }
}


