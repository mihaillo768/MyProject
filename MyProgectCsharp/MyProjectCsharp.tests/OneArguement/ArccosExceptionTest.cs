using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectCsharp.OneArguement;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArguement
{
    [TestFixture]
    public class ArccosExceptionTest
    {
        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgrumentCalculator calculator = new Arccos();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}
