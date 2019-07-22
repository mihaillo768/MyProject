using System;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    public class SinusTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Sinus();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.84, result, 0.01);
        }
        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgumentCalculator calculator = new Sinus();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}

