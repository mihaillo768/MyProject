using MyProjectCsharp.TwoArguements;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguements
{
    [TestFixture]
    public class AdderTestCase
    {
        [TestCase(3, 4, 7)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 0, 0)]
        public void CalculateTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new Adder();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
