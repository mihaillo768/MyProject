using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture]
    public class MinNumberTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new MinNumber();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}
