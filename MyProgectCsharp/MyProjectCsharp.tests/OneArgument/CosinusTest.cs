using System;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    public class CosinusTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Cosinus();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.54, result, 0.01);
        }

        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgumentCalculator calculator = new Cosinus();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}
