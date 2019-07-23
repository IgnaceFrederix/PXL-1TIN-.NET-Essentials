using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnittetingFile;

namespace CalcTest
{
    public class Class1
    {

        [TestFixture]

        public class CalcTest
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
        }
    }

}