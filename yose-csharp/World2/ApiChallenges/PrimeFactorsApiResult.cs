using System.Collections.Generic;

namespace Yose.World2.ApiChallenges
{
    public class PrimeFactorsApiResult
    {
        public object number { get; set; }
        public List<int> decomposition { get; set; }
        public string error { get; set; }
    }
}
