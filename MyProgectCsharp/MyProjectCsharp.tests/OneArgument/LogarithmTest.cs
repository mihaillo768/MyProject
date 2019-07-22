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
    public class LogarithmTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Logarithm();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0, result, 0.01);
        }
    }
}
