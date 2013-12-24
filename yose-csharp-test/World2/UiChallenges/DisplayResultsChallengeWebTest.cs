using NUnit.Framework;
using SimpleBrowser;
using Yose.TestHelpers;

namespace Yose.World2.UiChallenges
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
        public void DisplaysTooBigErrorMessage()
        {
            browser.Find("number").Value = "1000001";
            browser.Find("go").Click();
            Assert.That(browser.Find("result").Value, Is.EqualTo("too big number (>1e6)"));
        }

        [Test]
        public void DisplaysNotANumberErrorMessage()
        {
            browser.Find("number").Value = "hello";
            browser.Find("go").Click();
            Assert.That(browser.Find("result").Value, Is.EqualTo("hello is not a number"));
        }

        [Test]
        public void DisplaysSmallerThanZeroErrorMessage()
        {
            browser.Find("number").Value = "-42";
            browser.Find("go").Click();
            Assert.That(browser.Find("result").Value, Is.EqualTo("-42 is not an integer > 1"));
        }
    }
}