using Nancy;

namespace Yose.World2
{
    public class PrimeFactorsEndpoint : NancyModule
    {
        public PrimeFactorsEndpoint()
        {
            Get["/primeFactors"] = parameters =>
            {
                var number = Request.Query.number;
                var decomposition = PrimeFactors.Of(number);
                return Response.AsJson(new PrimeFactorsDecomposition {number = number, decomposition = decomposition});
            };
        }
    }
}
