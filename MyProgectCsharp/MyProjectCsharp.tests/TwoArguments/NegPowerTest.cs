using System;
using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture]
    class NegPowerTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new NegPower();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void CalculateTestExceptionTest()
        {
            ITwoArgumentsCalculator calculator = new NegPower();
            Assert.Throws<Exception>(() => calculator.Calculate(2, 0));
        }
    }
}
