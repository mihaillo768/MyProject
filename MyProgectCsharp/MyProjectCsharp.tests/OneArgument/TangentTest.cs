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
    public class TangentTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Tangent();
            double result = calculator.Calculate(1);
            Assert.AreEqual(1.56, result, 0.01);
        }
    }
}
