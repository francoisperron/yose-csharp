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
                var result = new PrimeFactorsEndpoint().Get(Request.Query.number);
                dynamic response;
                if (result is PrimeFactorsError)
                {
                    response = result.error;
                }
                else
                {
                    response = Request.Query.number + " = " + String.Join(" x ", result.decomposition.ToArray());    
                }                
                return View["primeFactorsResult.html", response];
            };
        }
    }
}