using NUnit.Framework;
using SimpleBrowser;
using Yose.TestHelpers;

namespace Yose.World1
{
    [TestFixture]
    class LandingPageChallengeWebTest : ServerTest
    {
        private Browser browser;

        [TestFixtureSetUp]
        public void LandingPage()
        {
            browser = new Browser();
            browser.Visit("/");  
        }

        [Test]
        public void ContainsAWelcomeElement()
        {
            Assert.That(browser.Find("welcome").Exists);
        }

        [Test]
        public void ContainsALinkToThePingChallenge()
        {
            Assert.That(browser.Find("a", FindBy.Id, "ping-challenge-link").Exists);
        }
    }
}
