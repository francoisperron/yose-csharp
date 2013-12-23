using System;
using Nancy;

namespace Yose.World2
{
    public class PrimeFactorsFormNancyEndpoint : NancyModule
    {
        public PrimeFactorsFormNancyEndpoint()
        {
            Get["/primeFactors/ui"] = _ => View["primeFactorsForm.html"];
        } 
    }

    public class PrimeFactorsResultNancyEndpoint : NancyModule
    {
        public PrimeFactorsResultNancyEndpoint()
        {
            Get["/primeFactors/result"] = _ =>
            {
                PrimeFactorsDecomposition decomposition = new PrimeFactorsEndpoint().Get(Request.Query.number);
                var result = String.Join(", ", decomposition.decomposition.ToArray());
                return View["primeFactorsResult.html", result];
            };
        }
    }
}