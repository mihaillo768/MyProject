using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProgectCsharp.OneArguement;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArguement
{
    [TestFixture]
    public class SinusTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgrumentCalculator calculator = new Sinus();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.84, result, 0.01);
        }
    }
}

