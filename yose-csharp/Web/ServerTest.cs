using NUnit.Framework;

namespace Yose.Web
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