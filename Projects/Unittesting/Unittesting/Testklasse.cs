using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unittesting
{
    [TestFixture]
    class Testklasse
    {
        [Test]
        public void MathTest()
        {
            var resultaat = 2 + 2;
            Assert.AreEqual(4, resultaat);

        }


        [SetUp]
       public void SetUpTest()
        {
            Debug.WriteLine("dit voeren we uit voor een test start");
            Debug.WriteLine("momenteel bereiden we deze test voor" + TestContext.CurrentContext.Test.Name );

        }

        public void TearDownTest()
        {
            Debug.WriteLine("dit voeren we uit na de test");
        }
    }
}
