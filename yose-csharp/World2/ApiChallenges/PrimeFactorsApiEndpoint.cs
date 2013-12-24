using System.Collections.Generic;
using System.Linq;
using Nancy;

namespace Yose.World2.ApiChallenges
{
    public class PrimeFactorsApiEndpoint : NancyModule
    {
        public PrimeFactorsApiEndpoint()
        {
            Get["/primeFactors"] = GetPrimeFactorsApiResult;            
        }

        private object GetPrimeFactorsApiResult(dynamic parameters)
        {            
            var numbers = ExtractNumbersFromQuery();
            var results = numbers.Select(GetResult).ToList();
            return Response.AsJson(Render(results));   
        }

        private List<string> ExtractNumbersFromQuery()
        {
            return ((string)Request.Query.number).Split(',').ToList();
        }

        private static object GetResult(string number)
        {
            return PrimeFactorsApiResultFactory.Build(number).Response(number);
        }

        private static object Render(List<object> results)
        {
            return results.Count == 1 ? results[0] : results;
        }
    }
}
