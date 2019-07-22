using System;
using MyProjectCsharp.TwoArguments;
using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture]
    public class TwoArgumentsFactoryTests
    {
        [TestCase("MinValue", typeof(MinNumber))]
        [TestCase("NegPower", typeof(NegPower))]
        [TestCase("LogOfTwoArg", typeof(LogOfTwoArguments))]
        [TestCase("PowerTwoArguments", typeof(TwoArgumentsPower))]
        [TestCase("MaxValue", typeof(MaxNumber))]
        [TestCase("Remainder", typeof(Remainder))]
        [TestCase("Plus", typeof(Adder))]
        [TestCase("Minus", typeof(Minus))]
        [TestCase("Multiplier", typeof(Multiplier))]
        [TestCase("Divider", typeof(Divider))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
