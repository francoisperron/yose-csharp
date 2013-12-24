using System.Collections.Generic;
using NUnit.Framework;
using RestSharp;
using Yose.TestHelpers;
using Yose.Web;

namespace Yose.World2.ApiChallenges
{
    class GuardChallengesTest : ServerTest
    {
        private RestClient restClient;

        [TestFixtureSetUp]
        public void RequestingTwoPrimeFactors()
        {
            restClient = new RestClient(Server.Uri);
        }

        [Test]
        public void ReturnsAnErrorWhenNumberIsNotANumber()
        {
            var request = new RestRequest("/primeFactors?number=hello", Method.GET) { RequestFormat = DataFormat.Json };
            dynamic result = restClient.Execute<List<PrimeFactorsDecomposition>>(request);

            Assert.That(result.Data.error, Is.EqualTo("not a number"));
        }

        [Test]
        public void ReturnsAnErrorWhenNumberIsBiggerThanAMillion()
        {
            var request = new RestRequest("/primeFactors?number=1000001", Method.GET) { RequestFormat = DataFormat.Json };
            dynamic result = restClient.Execute<List<PrimeFactorsDecomposition>>(request);

            Assert.That(result.error, Is.EqualTo("too big number (>1e6)"));
        }
    }
}
