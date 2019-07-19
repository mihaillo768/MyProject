using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProgectCsharp.TwoArguements;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MyProjectCsharp.tests.TwoArguements
{
    [TestFixture]
    public class AdderTestCase
    {
        [TestCase(3,4,7)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 0, 0)]
        public void CalculateTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new Adder();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
