using Nancy;

namespace Yose.World2
{
    public class PrimeFactorsNancyEndpoint : NancyModule
    {
        private PrimeFactorsEndpoint primeFactorsEndpoint = new PrimeFactorsEndpoint();

        public PrimeFactorsNancyEndpoint()
        {
            Get["/primeFactors"] = _ => FormatterExtensions.AsJson(Response, primeFactorsEndpoint.Get(Request.Query.number));
        }
    }
}
