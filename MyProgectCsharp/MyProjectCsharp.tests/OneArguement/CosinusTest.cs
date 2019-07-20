using MyProgectCsharp.OneArguement;
using NUnit.Framework;

namespace MyProjectCsharp.tests.OneArguement
{
    [TestFixture]
    public class CosinusTest
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgrumentCalculator calculator = new Cosinus();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.54, result,0.01);
        }
    }
}
