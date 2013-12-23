using System.Collections.Generic;

namespace Yose.World2
{
    public static class PrimeFactors
    {
        public static List<int> Of(int number)
        {
            var primes = new List<int>();
            for (var candidat = 2; candidat < number + 1; candidat++)
            {
                while (number % candidat == 0)
                {
                    primes.Add(candidat);
                    number /= candidat;
                }
            }
            return primes;
        }
    }
}