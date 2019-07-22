using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    public class LogarithmOfTwoTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new LogarithmOfTwo();
            double result = calculator.Calculate(1);
            Assert.AreEqual(2, result, 0.01);
        }
    }
}
