using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CalcaTest
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public ShouldAddTwoNumbers()
        {
            var sut = new Calculator();

            var result = sut.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldMulitplyTwoNumbers()
        {
            var sut = new Calculater();
            Assert.That(sut.Multiply(5, 10), Is.EqualTo(50));
        }
    }
}
