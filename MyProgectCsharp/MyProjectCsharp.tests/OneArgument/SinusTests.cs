using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(0, 1, 0)]
        [TestCase(0.5, 0, 0.48)]
        [TestCase(1, 0, 0.84)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Sinus();
            var actualresult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualresult, 0.01);
        }

    }
}
