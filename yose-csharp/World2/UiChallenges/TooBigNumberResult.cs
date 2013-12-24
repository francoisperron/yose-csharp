using System;

namespace Yose.World2.UiChallenges
{
    public class TooBigNumberResult : IPrimeFactorsResult
    {
        public bool Matches(string number)
        {
            return Convert.ToInt32(number) > 1000000;
        }

        public object Response(string number)
        {
            return "too big number (>1e6)";
        }
    }
}