using System.Net;
using NUnit.Framework;
using RestSharp;

namespace Yose.World1
{
    [TestFixture]
    class PingChallengeApiTest
    {
        private IRestResponse<AliveResponse> response;

        [TestFixtureSetUp]
        public void Setup()
        {
            StartServer();
            response = PingServer();
        }

        [Test]
        public void ReturnsOK()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void ReturnsAliveTrue()
        {
            Assert.That(response.Data.alive, Is.True);
        }

        private void StartServer()
        {
            new Server().Start();
        }

        private static IRestResponse<AliveResponse> PingServer()
        {
            var restClient = new RestClient(string.Format("http://{0}:{1}", Server.Host, Server.Port));
            var request = new RestRequest("/ping", Method.GET) {RequestFormat = DataFormat.Json};
            return restClient.Execute<AliveResponse>(request);
        }
    }
}