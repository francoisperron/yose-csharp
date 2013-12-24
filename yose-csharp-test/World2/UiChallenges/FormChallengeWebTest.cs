using NUnit.Framework;
using SimpleBrowser;
using Yose.TestHelpers;

namespace Yose.World2.UiChallenges
{
    class FormChallengeWebTest : ServerTest
    {
        private Browser browser;

        [TestFixtureSetUp]
        public void PrimefactorsFormPage()
        {
            browser = new Browser();
            browser.Visit("/primeFactors/ui");
        }

        [Test]
        public void ContainsATitle()
        {
            Assert.That(browser.Find("title").Exists);
        }

        [Test]
        public void ContainsAnInvitation()
        {
            Assert.That(browser.Find("invitation").Exists);
        }

        [Test]
        public void ContainsTheNumberInput()
        {
            Assert.That(browser.Find("input", FindBy.Id, "number").Exists);
        }

        [Test]
        public void ContainsAButton()
        {
            Assert.That(browser.Find("button", FindBy.Id, "go").Exists);
        }
    }
}