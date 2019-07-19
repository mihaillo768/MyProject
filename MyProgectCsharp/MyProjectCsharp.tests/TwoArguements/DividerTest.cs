using MyProgectCsharp.TwoArguements;

namespace MyProjectCsharp.tests.TwoArguements
{
    [TestFixture]
    public class DividerTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgrumentsCalculator calculator = new Divider();
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }

    }
}