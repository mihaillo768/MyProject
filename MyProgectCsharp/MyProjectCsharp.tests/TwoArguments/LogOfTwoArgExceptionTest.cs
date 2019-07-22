using System;
using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture()]
    class LogOfTwoArgExceptionTest
    {
        [Test]
        public void CalculateTestExceptionTest()
        {
            ITwoArgumentsCalculator calculator = new LogOfTwoArguments();
            Assert.Throws<Exception>(() => calculator.Calculate(3, 0));
        }
    }
}
