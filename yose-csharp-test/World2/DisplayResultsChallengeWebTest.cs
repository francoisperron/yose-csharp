using NUnit.Framework;
using SimpleBrowser;
using Yose.TestHelpers;

namespace Yose.World2
{
    class DisplayResultsChallengeWebTest : ServerTest
    {
        private Browser browser;

        [SetUp]
        public void PrimefactorsFormPage()
        {
            browser = new Browser();
            browser.Visit("/primeFactors/ui");
        }

        [Test]
        public void DisplaysResult()
        {
            browser.Find("number").Value = "15";
            browser.Find("go").Click();
            Assert.That(browser.Find("result").Value, Is.EqualTo("15 = 3 x 5"));
        }

        [Test]
        public void DisplaysErrorMessage()
        {
            browser.Find("number").Value = "1000001";
            browser.Find("go").Click();
            Assert.That(browser.Find("result").Value, Is.EqualTo("too big number (>1e6)"));
        }
    }
}