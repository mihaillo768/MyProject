using System;
using MyProjectCsharp.TwoArguements;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguements
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
