using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProjectCsharp.TwoArguements;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguements
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
