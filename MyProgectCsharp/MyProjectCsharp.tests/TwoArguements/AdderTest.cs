using MyProgectCsharp.TwoArguements;
using NUnit.Framework;

namespace MyProjectCsharp.tests.TwoArguements
{
    [TestFixture]
    public class AdderTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgrumentsCalculator calculator = new Adder();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(6, result);
        }

    }
}
