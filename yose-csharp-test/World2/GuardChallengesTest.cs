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
    }
}
