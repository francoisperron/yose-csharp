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
            Get["/primeFactors/result"] = Answer;
        }

        private object Answer(dynamic parameters)
        {
            int number;
            if (IsNotANumber(Request.Query.number, out number))
            {
                return View["primeFactorsResult.html",  Request.Query.number + " is not a number"];
            }

            if (IsTooBig(number))
            {
                return View["primeFactorsResult.html", "too big number (>1e6)"];
            }

            if (IsNegative(number))
            {
                return View["primeFactorsResult.html", Request.Query.number + " is not an integer > 1"];
            }
            
            var decomposition = PrimeFactors.Of(number);
            return View["primeFactorsResult.html", Request.Query.number + " = " + String.Join(" x ", decomposition.ToArray())];
        }

        private static bool IsNotANumber(string request, out int number)
        {
            return !int.TryParse(request, out number);
        }

        private static bool IsTooBig(int number)
        {
            return number > 1000000;
        }

        private static bool IsNegative(int number)
        {
            return number < 0;
        }
    }
}