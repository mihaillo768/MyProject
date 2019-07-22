using System;
using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
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
