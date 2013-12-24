using System;

namespace Yose.World2.ApiChallenges
{
    public class DecompositionApiResult : IPrimeFactorsApiResult
    {
        public bool Matches(string number)
        {
            return true;
        }

        public object Response(string number)
        {
            var intNumber = Convert.ToInt32(number);
            var decomposition = PrimeFactors.Of(intNumber);
            return new PrimeFactorsApiResult { number = intNumber, decomposition = decomposition };
        }
    }
}