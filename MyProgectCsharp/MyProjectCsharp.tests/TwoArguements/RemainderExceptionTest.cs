using System;
using MyProjectCsharp.TwoArguements;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguements
{
    [TestFixture]
    class RemainderExceptionTest
    {
        [Test]
        public void CalculateTestExceptionTest()
        {
            ITwoArgumentsCalculator calculator = new Remainder();
            Assert.Throws<Exception>(() => calculator.Calculate(3, 0));
        }
    }
}
