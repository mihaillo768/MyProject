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
    public class TangentTests
    {
        [TestCase(3, 4, 7)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 0, 0)]
        public void CalculateTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new Tangent();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
