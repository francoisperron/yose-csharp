using NUnit.Framework;
using SimpleBrowser;
using Yose.TestHelpers;

namespace Yose.World2
{
    class DisplayResultsChallengeWebTest : ServerTest
    {
        private Browser browser;

        [TestFixtureSetUp]
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
            Assert.That(browser.Find("result").Value, Is.EqualTo("3, 5"));
        }
    }
}