namespace Yose.World2.UiChallenges
{
    public interface IPrimeFactorsResult
    {
        bool Matches(string number);
        object Response(string number);
    }
}