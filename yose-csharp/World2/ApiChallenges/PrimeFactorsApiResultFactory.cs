using System.Collections.Generic;
using System.Linq;

namespace Yose.World2.ApiChallenges
{
    public static class PrimeFactorsApiResultFactory
    {
        private static List<IPrimeFactorsApiResult> results = new List<IPrimeFactorsApiResult>
        {
            new NotANumberApiResult(),
            new TooBigNumberApiResult(),
            new DecompositionApiResult(),
        };

        public static IPrimeFactorsApiResult Build(string number)
        {
            return results.First(r => r.Matches(number));    
        }
    }
}