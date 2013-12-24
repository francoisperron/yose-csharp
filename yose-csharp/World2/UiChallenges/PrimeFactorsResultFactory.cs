using System.Collections.Generic;
using System.Linq;

namespace Yose.World2.UiChallenges
{
    public static class PrimeFactorsResultFactory
    {
        private static List<IPrimeFactorsResult> results = new List<IPrimeFactorsResult>
        {
            new NotANumberResult(),
            new TooBigNumberResult(),
            new NegativeNumberResult(),
            new DecompositionResult(),
        };

        public static IPrimeFactorsResult Build(string number)
        {
            return results.First(r => r.Matches(number));
        }
    }
}