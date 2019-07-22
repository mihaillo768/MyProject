using MyProjectCsharp.TwoArguments;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguments
{
    [TestFixture]
    public class MultiplierTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Multiplier();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(8, result);
        }

    }
}