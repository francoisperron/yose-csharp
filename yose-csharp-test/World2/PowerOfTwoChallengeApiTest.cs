using System.Collections.Generic;
using System.Net;
using NUnit.Framework;
using RestSharp;
using Yose.TestHelpers;
using Yose.Web;

namespace Yose.World2
{
    class PowerOfTwoChallengeApiTest : ServerTest
    {
        private IRestResponse<PrimeFactorsDecomposition> response;
        private const int Number = 16;

        [TestFixtureSetUp]
        public void RequestingPrimeFactors()
        {
            var restClient = new RestClient(Server.Uri);
            var request = new RestRequest(string.Format("/primeFactors?number={0}", Number), Method.GET) { RequestFormat = DataFormat.Json };
            response = restClient.Execute<PrimeFactorsDecomposition>(request);
        }

        [Test]
        public void ReturnsOK()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void ReturnsNumber()
        {
            Assert.That(response.Data.number, Is.EqualTo(Number));
        }

        [Test]
        public void ReturnsDecomposition()
        {
            Assert.That(response.Data.decomposition, Is.EqualTo(new List<int>{2,2,2,2}));
        }
    }
}
