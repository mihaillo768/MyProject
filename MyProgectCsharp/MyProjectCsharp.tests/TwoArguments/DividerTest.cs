﻿using System;
using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture]
    public class DividerTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Divider();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
        public void CalculateTestByZero()
        {
            ITwoArgumentsCalculator calculator = new Divider();
            double result = calculator.Calculate(4, 2);
            //Assert.Throws<>(() =>
            //calculator.Calculate());

        }
        [Test]
        public void CalculateTestExceptionTest()
        {
            ITwoArgumentsCalculator calculator = new Divider();
            Assert.Throws<Exception>(() => calculator.Calculate(2, 0));
        }

    }
}