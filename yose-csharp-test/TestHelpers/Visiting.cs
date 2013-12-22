using NUnit.Framework;
using SimpleBrowser;
using Yose.Web;

namespace Yose.TestHelpers
{
    public static class Visiting
    {
        public static void Visit(this Browser browser, string url)
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
