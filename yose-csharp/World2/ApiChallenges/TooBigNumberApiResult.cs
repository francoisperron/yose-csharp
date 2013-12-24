using System;

namespace Yose.World2.ApiChallenges
{
    public class TooBigNumberApiResult : IPrimeFactorsApiResult
    {
        public bool Matches(string number)
        {
            return Convert.ToInt32(number) > 1000000;
        }

        public object Response(string number)
        {
            return new PrimeFactorsError { number = number, error = "too big number (>1e6)" };
        }
    }
}