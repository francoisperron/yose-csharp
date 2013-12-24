namespace Yose.World2.UiChallenges
{
    public class NotANumberResult : IPrimeFactorsResult
    {
        public bool Matches(string number)
        {
            int intNumber;
            return !int.TryParse(number, out intNumber);
        }

        public object Response(string number)
        {
            return number + " is not a number";
        }
    }
}