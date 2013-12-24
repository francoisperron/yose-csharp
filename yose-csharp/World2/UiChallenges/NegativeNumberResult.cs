using System;

namespace Yose.World2.UiChallenges
{
    public class NegativeNumberResult : IPrimeFactorsResult
    {
        public bool Matches(string number)
        {
            return Convert.ToInt32(number) < 0;
        }

        public object Response(string number)
        {
            return number + " is not an integer > 1";
        }
    }
}