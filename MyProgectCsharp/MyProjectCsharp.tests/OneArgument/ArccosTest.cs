using System;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    public class ArccosTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Arccos();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0, result, 0.01);
        }
        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgumentCalculator calculator = new Arccos();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}
