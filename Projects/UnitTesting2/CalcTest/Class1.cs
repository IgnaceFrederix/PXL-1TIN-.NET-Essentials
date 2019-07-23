using MyCalculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalcTest
{
    public class CaclTest
    {

        [TestFixture]
        public class CalcTests
        {
            [Test]
            public void ShouldAddTwoNumbers()
            {
                //ARRANGE
                var sut = new Calculator();
                //ACT
                var result = sut.Add(1, 2);
                //ASSERT
                Assert.That(result, Is.EqualTo(3));
            }

            [Test]
            public void ShouldMulitplyTwoNumbers()
            {
                var sut = new Calculator();
                Assert.That(sut.Multiply(5, 10), Is.EqualTo(50));
            }
        }
    }
}
