using NUnit.Framework;
using System;

namespace Sixflags.Tests
{
    [TestFixture]
    public class EntranceTests
    {
        private EntranceCalculator _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new EntranceCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }

        [Test]
        public void AgeShouldNotBeNegative()
        {
            Assert.That(() => _sut.AddPerson("sam", -10), Throws.Exception);
        }

        [Test]
        public void ChildrenUpToSixShouldEnterFreely()
        {
            _sut.AddPerson("Kutkopje", 4);
            Assert.That(_sut.CalculateEntrance(), Is.EqualTo(0));
        }

        [Test]
        public void ChildrenFrom6To18ShouldPayMinorFee()
        {
            _sut.AddPerson("Kutkop", 10);
            Assert.That(_sut.CalculateEntrance(), Is.EqualTo(7.5));
        }

        [Test]
        public void AdultsShouldPayAdultFee()
        {
            _sut.AddPerson("Kuthoofd", 120);
            Assert.That(_sut.CalculateEntrance(), Is.EqualTo(15));
        }

        [Test]
        public void VisitorsShouldHaveName()
        {
            Assert.That(() => _sut.AddPerson(null, -10), Throws.Exception);
        }

        
    }
}
