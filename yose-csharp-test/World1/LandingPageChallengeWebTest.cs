using NUnit.Framework;
using SimpleBrowser;
using Yose.TestHelpers;
using Yose.Web;

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
            Visit("/");  
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

        private void Visit(string url)
        {
            browser.ClearException();
            browser.Navigate(Server.Uri + url);
            if (browser.LastWebException != null)
            {
                Assert.Fail("Page non trouvée : " + url + "\n" + browser.LastWebException);   
            }                
        }
    }
}
