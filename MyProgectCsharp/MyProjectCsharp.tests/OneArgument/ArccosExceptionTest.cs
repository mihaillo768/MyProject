using System;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    public class ArccosExceptionTest
    {
        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgumentCalculator calculator = new Arccos();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}
