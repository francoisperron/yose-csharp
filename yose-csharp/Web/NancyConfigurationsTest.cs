using System;
using NUnit.Framework;

namespace Yose.Web
{
    class NancyConfigurationsTest
    {
        [Test]
        public void ReturnsViewsPath()
        {
            Assert.That(new CustomRootPathProvider().GetRootPath(), Is.EqualTo(AppDomain.CurrentDomain.BaseDirectory + "\\views"));
        }
    }
}