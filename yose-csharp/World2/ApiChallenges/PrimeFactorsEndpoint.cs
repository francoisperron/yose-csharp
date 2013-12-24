namespace Yose.World2.ApiChallenges
{
    public class PrimeFactorsEndpoint
    {
        public object Get(string request)
        {
            int number;
            if (IsNotANumber(request, out number))
            {
                return new PrimeFactorsError{number = request, error = "not a number"};
            }
            if (IsTooBig(number))
            {
                return new PrimeFactorsError { number = request, error = "too big number (>1e6)" };
            }
            
            var decomposition = PrimeFactors.Of(number);
            return new PrimeFactorsDecomposition { number = number, decomposition = decomposition };
        }

        private static bool IsNotANumber(string request, out int number)
        {
            return !int.TryParse(request, out number);
        }

        private static bool IsTooBig(int number)
        {
            return number > 1000000;
        }
    }
}