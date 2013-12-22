using NUnit.Framework;
using SimpleBrowser;
using Yose.TestHelpers;

namespace Yose.World1
{
    class ContactInformationChallengeWebTest : ServerTest
    {
        private Browser browser;

        [TestFixtureSetUp]
        public void LandingPage()
        {
            browser = new Browser();
            browser.Visit("/");
        }

        [Test]
        public void ContainsALinkToContactInformation()
        {
            Assert.That(browser.Find("a", FindBy.Id, "contact-me-link").Exists);
        }
    }
}