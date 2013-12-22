using System.Net;
using NUnit.Framework;
using RestSharp;
using Yose.TestHelpers;
using Yose.Web;

namespace Yose.World1
{
    [TestFixture]
    class PingChallengeApiTest : ServerTest
    {
        private IRestResponse<AliveResponse> response;

        [TestFixtureSetUp]
        public void PingServer()
        {
            var restClient = new RestClient(Server.Uri);
            var request = new RestRequest("/ping", Method.GET) { RequestFormat = DataFormat.Json };
            response = restClient.Execute<AliveResponse>(request);
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
    }
}