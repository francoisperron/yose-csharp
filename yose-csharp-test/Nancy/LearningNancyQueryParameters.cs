using NUnit.Framework;
using RestSharp;
using Yose.TestHelpers;
using Yose.Web;

namespace Yose.Nancy
{
    class LearningNancyQueryParameters : ServerTest
    {
        [Test]
        [Ignore]
        public void UrlParameters()
        {
            var param = "bob";
            var restClient = new RestClient(Server.Uri);
            var request = new RestRequest(string.Format("/learning/{0}", param), Method.GET) { RequestFormat = DataFormat.Json };
            restClient.Execute(request);

            Assert.That(LearningUrlParametersEndpoint.Name, Is.EqualTo(param));
        }

        [Test]
        [Ignore]
        public void QueryParameters()
        {
            var param = "bob";
            var restClient = new RestClient(Server.Uri);
            var request = new RestRequest(string.Format("/learningQuery?name={0}", param), Method.GET) { RequestFormat = DataFormat.Json };
            restClient.Execute(request);

            Assert.That(LearningQueryParametersEndpoint.Name, Is.EqualTo(param));
        }
    }
}
