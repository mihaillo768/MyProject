using System;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture()]
    class ArcsinusExceptionTest
    {
        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgumentCalculator calculator = new Arcsin();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}
