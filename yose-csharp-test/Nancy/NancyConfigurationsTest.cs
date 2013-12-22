using System;
using System.IO;
using NUnit.Framework;
using Yose.Web;

namespace Yose.Nancy
{
    class NancyConfigurationsTest
    {
        [Test]
        public void ReturnsViewsPath()
        {
            Assert.That(new CustomRootPathProvider().GetRootPath(), Is.EqualTo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "views")));
        }
    }
}