using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectCsharp.OneArguement;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MyProjectCsharp.tests.OneArguement
{
    [TestFixture()]
    class ArcsinusExceptionTest
    {
        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgrumentCalculator calculator = new Arcsin();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}
