using NUnit.Framework;
using RestSharp;
using Yose.TestHelpers;
using Yose.Web;

namespace Yose.Nancy
{
    class LearningNancyQueryParameters : ServerTest
    {
        [Test]
        [Explicit]
        public void UrlParameters()
        {
            var bob = "bob";
            var restClient = new RestClient(Server.Uri);
            var request = new RestRequest(string.Format("/learning/{0}", bob), Method.GET) { RequestFormat = DataFormat.Json };
            restClient.Execute(request);

            Assert.That(LearningUrlParametersEndpoint.Name, Is.EqualTo(bob));
        }

        [Test]
        [Explicit]
        public void QueryParameters()
        {
            var bob = "bob";
            var restClient = new RestClient(Server.Uri);
            var request = new RestRequest(string.Format("/learningQuery?name={0}", bob), Method.GET) { RequestFormat = DataFormat.Json };
            restClient.Execute(request);

            Assert.That(LearningQueryParametersEndpoint.Name, Is.EqualTo(bob));
        }

        [Test]
        [Explicit]
        public void MultipleQueryParameters()
        {
            var bob = "bob";
            var bill = "bill";
            var restClient = new RestClient(Server.Uri);
            var request = new RestRequest(string.Format("/learningMultipleQuery?name={0}&name={1}", bob, bill), Method.GET) { RequestFormat = DataFormat.Json };
            restClient.Execute(request);

            Assert.That(LearningMultipleQueryParametersEndpoint.Names, Is.EqualTo("bob,bill"));
        }
    }
}
