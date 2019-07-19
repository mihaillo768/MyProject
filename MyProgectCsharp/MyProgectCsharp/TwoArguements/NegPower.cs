using System;

namespace MyProgectCsharp.TwoArguements
{
    public class NegPower:ITwoArgrumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1/second);
        }
    }
}
