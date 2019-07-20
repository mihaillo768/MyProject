using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectCsharp.OneArguement;
using MyProjectCsharp.TwoArguements;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MyProjectCsharp.tests.OneArguement
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Cosinus", typeof(Cosinus))]
        [TestCase("Tangens", typeof(Tangens))]
        [TestCase("Catangens", typeof(Catangens))]
        [TestCase("ArcSinus", typeof(Arcsin))]
        [TestCase("ArcCosinus", typeof(Arccos))]
        [TestCase("ArcTangens", typeof(Arctan))]
        [TestCase("Power", typeof(Power))]
        [TestCase("Logarifm", typeof(Logarifm))]
        [TestCase("LogarifmOfTwo", typeof(LogarifmOfTwo))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
