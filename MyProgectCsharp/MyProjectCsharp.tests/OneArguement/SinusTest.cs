using System;
using MyProjectCsharp.OneArguement;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArguement
{
    [TestFixture]
    public class SinusTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgrumentCalculator calculator = new Sinus();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.84, result, 0.01);
        }
        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgrumentCalculator calculator = new Sinus();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}

