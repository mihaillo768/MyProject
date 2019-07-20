using MyProjectCsharp.TwoArguements;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguements
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
              //  calculator.Calculate());

        }

    }
}