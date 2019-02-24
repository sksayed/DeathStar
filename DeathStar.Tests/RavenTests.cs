using NUnit.Framework;
using Autofac.Extras.Moq;
using System.Diagnostics.CodeAnalysis;
using DeathStar;

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
            using (var mock = AutoMock.GetLoose())
            {
                var weapon = mock.Mock<IWeapon>();
                weapon.Setup(x => x.Damage).Returns(500);

                var ship = mock.Create<Raven>();
                ship.Weapons = new System.Collections.Generic.List<IWeapon>() { weapon.Object , weapon.Object };

                var damage = ship.FireWeapon();

                weapon.VerifyAll();
                Assert.AreEqual(1000, damage);

            }

            //Assert.Pass();
        }
    }
}