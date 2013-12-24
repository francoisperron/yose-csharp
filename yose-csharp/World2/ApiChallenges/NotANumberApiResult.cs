namespace Yose.World2.ApiChallenges
{
    public class NotANumberApiResult : IPrimeFactorsApiResult
    {
        public bool Matches(string number)
        {
            int intNumber;
            return !int.TryParse(number, out intNumber);
        }

        public object Response(string number)
        {
            return new PrimeFactorsApiResult { number = number, error = "not a number" };
        }
    }
}