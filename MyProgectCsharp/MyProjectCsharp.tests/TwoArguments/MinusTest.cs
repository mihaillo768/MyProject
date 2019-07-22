using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture]
    public class MinusTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Minus();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }

    }
}