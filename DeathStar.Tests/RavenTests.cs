using NUnit.Framework;
using Autofac.Extras.Moq;
using System.Diagnostics.CodeAnalysis;

namespace Tests
{
    [TestFixture , ExcludeFromCodeCoverage]
    public class RavenTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using ( var mock = AutoMock.GetLoose())
            {
                

            }

            //Assert.Pass();
        }
    }
}