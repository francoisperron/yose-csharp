using System.Linq;
using Nancy;

namespace Yose.World2
{
    public class PrimeFactorsNancyEndpoint : NancyModule
    {
        private PrimeFactorsEndpoint primeFactorsEndpoint = new PrimeFactorsEndpoint();

        public PrimeFactorsNancyEndpoint()
        {
            Get["/primeFactors"] = _ =>
            {
                var numbers = ((string)Request.Query.number).Split(',').ToList();
                var results = numbers.Select(n => primeFactorsEndpoint.Get(n)).ToList();
                return Response.AsJson(results.Count == 1 ? results[0] : results);
            };
        }
    }
}
