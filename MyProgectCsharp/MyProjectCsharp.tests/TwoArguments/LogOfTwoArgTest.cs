using System;
using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture()]
    class LogOfTwoArgTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new LogOfTwoArguments();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(0.5, result);
        }
        [Test]
        public void CalculateTestExceptionTest()
        {
            ITwoArgumentsCalculator calculator = new LogOfTwoArguments();
            Assert.Throws<Exception>(() => calculator.Calculate(3, 0));
        }
    }
}
