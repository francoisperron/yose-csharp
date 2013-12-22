using NUnit.Framework;
using Yose.Web;

namespace Yose.TestHelpers
{
    public abstract class ServerTest
    {
        private static Server server;

        [TestFixtureSetUp]
        public void StartServer()
        {
            if (server != null) return;

            server = new Server();
            server.Start();
        }
    }
}