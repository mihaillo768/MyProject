using System;
using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Cosinus", typeof(Cosinus))]
        [TestCase("Tangens", typeof(TangentTest))]
        [TestCase("Catangens", typeof(Cotangent))]
        [TestCase("ArcSinus", typeof(Arcsin))]
        [TestCase("ArcCosinus", typeof(Arccos))]
        [TestCase("ArcTangens", typeof(Arctan))]
        [TestCase("Power", typeof(Power))]
        [TestCase("Logarifm", typeof(Logarithm))]
        [TestCase("LogarifmOfTwo", typeof(LogarithmOfTwoTests))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
