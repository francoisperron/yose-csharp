using NUnit.Framework;

namespace Yose.World2
{
    class GuardChallengesTest
    {
        [Test]
        public void ReturnsAnErrorWhenNumberIsNotANumber()
        {
            dynamic result = new PrimeFactorsEndpoint().Get("hello");

            Assert.That(result.error, Is.EqualTo("not a number"));
        }

        [Test]
        public void ReturnsAnErrorWhenNumberIsBiggerThanAMillion()
        {
            dynamic result = new PrimeFactorsEndpoint().Get("1000001");

            Assert.That(result.error, Is.EqualTo("too big number (>1e6)"));
        }
    }
}
