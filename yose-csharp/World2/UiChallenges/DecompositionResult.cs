using System;

namespace Yose.World2.UiChallenges
{
    public class DecompositionResult : IPrimeFactorsResult
    {
        public bool Matches(string number)
        {
            return true;
        }

        public object Response(string number)
        {
            var decomposition = PrimeFactors.Of(Convert.ToInt32(number));
            return number + " = " + String.Join(" x ", decomposition.ToArray());
        }
    }
}