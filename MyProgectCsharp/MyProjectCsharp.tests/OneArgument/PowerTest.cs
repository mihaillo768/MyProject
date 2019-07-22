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
    public class PowerTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Power();
            double result = calculator.Calculate(1);
            Assert.AreEqual(2.71, result, 0.01);
        }
    }
}
