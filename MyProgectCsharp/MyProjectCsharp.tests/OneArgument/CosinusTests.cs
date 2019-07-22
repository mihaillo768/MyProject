using MyProjectCsharp.OneArgument;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArgument
{
    [TestFixture]
    class CosinusTests
    {
        [TestCase(0, 1, 1)]
        [TestCase(0.5, 0, 0.88)]
        [TestCase(1, 0, 0.54)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Cosinus();
            var actualresult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualresult, 0.01);
        }

    }
}
