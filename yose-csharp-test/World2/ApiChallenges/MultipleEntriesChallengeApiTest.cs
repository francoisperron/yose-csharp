using System.Collections.Generic;
using NUnit.Framework;
using RestSharp;
using Yose.TestHelpers;
using Yose.Web;

namespace Yose.World2.ApiChallenges
{
    class MultipleEntriesChallengeApiTest : ServerTest
    {
        private IRestResponse<List<PrimeFactorsApiResult>> response;

        [TestFixtureSetUp]
        public void RequestingTwoPrimeFactors()
        {
            var restClient = new RestClient(Server.Uri);
            var request = new RestRequest("/primeFactors?number=4&number=15", Method.GET) { RequestFormat = DataFormat.Json };
            response = restClient.Execute<List<PrimeFactorsApiResult>>(request);  
        }

        [Test]
        public void ReturnsTwoDecomposition()
        {
            Assert.That(response.Data, Has.Count.EqualTo(2));
        }

        [Test]
        public void ReturnsTheFirstDecompositionForTheFirstNumber()
        {
            Assert.That(response.Data[0].decomposition, Is.EqualTo(new List<int>{2,2}));
        }

        [Test]
        public void ReturnsTheSecondDecompositionForTheSecondNumber()
        {
            Assert.That(response.Data[1].decomposition, Is.EqualTo(new List<int> { 3, 5 }));
        }
    }
}