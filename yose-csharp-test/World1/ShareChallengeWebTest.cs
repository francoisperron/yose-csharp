using NUnit.Framework;
using SimpleBrowser;
using Yose.TestHelpers;

namespace Yose.World1
{
    class ShareChallengeWebTest : ServerTest
    {
        private Browser browser;

        [TestFixtureSetUp]
        public void LandingPage()
        {
            browser = new Browser();
            browser.Visit("/");
        }

        [Test]
        public void ContainsALinkToGitHubRepo()
        {
            Assert.That(browser.Find("a", FindBy.Id, "repository-link").GetAttribute("href"), Is.EqualTo("https://github.com/francoisperron/yose-csharp"));
        }
    }
}