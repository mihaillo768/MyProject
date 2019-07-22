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
    public class ArctanTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = new Arctan();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.79, result, 0.01);
        }
    }
}
