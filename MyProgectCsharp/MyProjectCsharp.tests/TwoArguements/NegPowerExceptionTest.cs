using System;
using MyProjectCsharp.TwoArguements;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguements
{
    [TestFixture]
    class NegPowerExceptionTest
    {
        [Test]
        public void CalculateTestExceptionTest()
        {
            ITwoArgumentsCalculator calculator = new NegPower();
            Assert.Throws<Exception>(() => calculator.Calculate(2, 0));
        }
    }
}
