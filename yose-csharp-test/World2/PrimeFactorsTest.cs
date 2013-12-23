using System.Collections.Generic;
using NUnit.Framework;

namespace Yose.World2
{
    class PrimeFactorsTest
    {
        [Test]
        public void ZeroHasNoPrimeFactor()
        {
            Assert.That(PrimeFactors.Of(0), Is.Empty);
        }

        [Test]
        public void TwoHasTwoAsPrimeFactor()
        {
            Assert.That(PrimeFactors.Of(2), Is.EqualTo(new List<int> { 2 }));
        }

        [Test]
        public void SixHasTwoThreeAsPrimeFactors()
        {
            Assert.That(PrimeFactors.Of(6), Is.EqualTo(new List<int> { 2, 3 }));
        }

        [Test]
        public void ThrityHasTwoThreeFiveAsPrimeFactors()
        {
            Assert.That(PrimeFactors.Of(30), Is.EqualTo(new List<int> { 2, 3, 5 }));
        }
    }
}
