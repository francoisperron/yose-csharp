namespace Yose.World2.ApiChallenges
{
    public interface IPrimeFactorsApiResult
    {
        bool Matches(string number);
        object Response(string number);        
    }
}