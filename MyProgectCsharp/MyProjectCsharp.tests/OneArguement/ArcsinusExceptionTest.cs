using System;
using MyProjectCsharp.OneArguement;
using NUnit.Framework;

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
