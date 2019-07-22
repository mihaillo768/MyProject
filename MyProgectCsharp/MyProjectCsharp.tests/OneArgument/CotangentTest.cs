using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    public class CotangentTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Cotangent();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.64, result, 0.01);
        }
    }
}
