namespace Yose.World2
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
            
            var decomposition = PrimeFactors.Of(number);
            return new PrimeFactorsDecomposition { number = number, decomposition = decomposition };
        }

        private static bool IsNotANumber(string request, out int number)
        {
            return !int.TryParse(request, out number);
        }
    }
}