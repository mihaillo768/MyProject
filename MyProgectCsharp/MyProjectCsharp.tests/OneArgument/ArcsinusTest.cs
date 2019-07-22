using System;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    class ArcsinusTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Arcsin();
            double result = calculator.Calculate(1);
            Assert.AreEqual(1.57, result, 0.01);
        }

        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgumentCalculator calculator = new Arcsin();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}
