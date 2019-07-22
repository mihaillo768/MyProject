using System;
using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture]
    class RemainderTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Remainder();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void CalculateTestExceptionTest()
        {
            ITwoArgumentsCalculator calculator = new Remainder();
            Assert.Throws<Exception>(() => calculator.Calculate(3, 0));
        }
    }
}
