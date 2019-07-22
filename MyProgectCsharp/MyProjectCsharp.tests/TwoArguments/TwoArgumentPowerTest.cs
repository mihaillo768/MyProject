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
    public class TwoArgumentPowerTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new TwoArgumentsPower();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(16, result);
        }
    }
}
