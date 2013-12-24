using Nancy;

namespace Yose.World2.UiChallenges
{
    public class PrimeFactorsFormEndpoint : NancyModule
    {
        public PrimeFactorsFormEndpoint()
        {
            Get["/primeFactors/ui"] = _ => View["primeFactorsForm.html"];
        } 
    }

    public class PrimeFactorsFormResultEndpoint : NancyModule
    {
        public PrimeFactorsFormResultEndpoint()
        {
            Get["/primeFactors/result"] = GetPrimeFactorsFormResult;
        }

        private object GetPrimeFactorsFormResult(dynamic parameters)
        {
            var number = Request.Query.number;
            var result = PrimeFactorsResultFactory.Build(number).Response(number);
            return View["primeFactorsResult.html", result];
        }
    }
}