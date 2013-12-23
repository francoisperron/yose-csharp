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
}